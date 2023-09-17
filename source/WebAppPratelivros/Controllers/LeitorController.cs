using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPratelivros.Models;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using Org.BouncyCastle.Crypto.Macs;

namespace WebAppPratelivros.Controllers
{
    public class LeitorController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Leitor
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Leitor formData)
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
                    HtmlBody = $"<p><b>Nome do usuário: </b> \n {formData.Nome}</p> <p><b>E-mail do usuário: </b> \n {formData.Email}</p> <p><b>Tipo da denúncia: </b> \n {formData.Tipo}</p> <p><b>Mensagem: </b> \n {formData.Mensagem}</p>",
                    TextBody = "{formData.Nome} \n {formData.Email} \n {formData.Tipo} \n Mensagem:{formData.Mensagem}"
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
            TempData["Mensagem"] = "Valeu";
            return RedirectToAction("Index");
        }
        // GET: Cadastro
        public ActionResult Cadastro() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro(Leitor leitor)
        {
            context.Leitor.Add(leitor);
            leitor.Avaliacao = 5;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Verify()
        {
            return View();
        }
    }
}