using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPratelivros.Models;
using MailKit.Net.Smtp;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using Org.BouncyCastle.Crypto.Macs;

namespace WebAppPratelivros.Controllers
{
    public class LivroDenunciaController : Controller
    {
        // GET: LivroDenuncia
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LivroDenuncia formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }
            using (var client = new SmtpClient())
            {

                client.Connect("smtp.gmail.com");
                client.Authenticate("pratelivrospi@gmail.com", "yelh untv amln vfpz");

                var bodyBuilder = new BodyBuilder()
                {
                    HtmlBody = $"<p><b>Titulo do livro: </b> \n {formData.Nome}</p> <p><b>E-mail do usuário: </b> \n {formData.Email}</p> <p><b>Tipo da denúncia: </b> \n {formData.Tipo}</p>",
                    TextBody = "{formData.Nome} \n {formData.Email} \n {formData.Tipo}"
                };
                var message = new MimeMessage
                {
                    Body = bodyBuilder.ToMessageBody()
                };
                message.From.Add(new MailboxAddress(formData.Nome, formData.Email));
                message.To.Add(new MailboxAddress("pratelivros", "pratelivrospi@gmail.com"));
                message.Subject = "Nova denúncia recebida";
                client.Send(message);

                client.Disconnect(true);
            }
            return RedirectToAction("Index", "Leitor");
        }
    }
}