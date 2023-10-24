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
            Leitor h = new Leitor();
            h.livro = context.Livros.OrderBy(c => c.Titulo);
            return View(h);
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
            TempData["Mensagem"] = "Obrigado por nos contatar! A sua denúncia será analisada em breve.";
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
        [HttpPost]
        public ActionResult Login(string email, string senha)
        {
            // Verifica se os campos de email e senha foram preenchidos
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                // Adicione uma mensagem de erro à ViewData
                ViewData["ErrorMessage"] = "Preencha todos os campos.";

                // Retorna para a View de login, exibindo a mensagem de erro
                return View("Login");
            }

            var data = context.Leitor.Where(s => s.Email.Equals(email) && s.Senha.Equals(senha)).ToList();
            if (data.Count() > 0)
            {
                return RedirectToAction("Index", "Leitor");
            }
            else
            {
                // Caso os dados de login estejam incorretos, adicione uma mensagem de erro à ViewData
                ViewData["ErrorMessage"] = "Email ou senha incorretos.";

                // Retorna para a View de login, exibindo a mensagem de erro
                return View("Login");
            }
        }
        public ActionResult redefinirSenha()
        {
            return View();
        }
        public ActionResult Verify()
        {
            return View();
        }
    }
}