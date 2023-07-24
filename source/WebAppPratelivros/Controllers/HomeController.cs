using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPratelivros.Models;

namespace WebAppPratelivros.Controllers
{
    public class HomeController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}