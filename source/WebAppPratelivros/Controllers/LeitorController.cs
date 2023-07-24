using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPratelivros.Models;

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
            leitor.avaliacao = 5;
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