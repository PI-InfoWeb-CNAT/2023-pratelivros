using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPratelivros.Controllers
{
    public class LeitorController : Controller
    {
        // GET: Leitor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}