﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPratelivros.Models;

namespace WebAppPratelivros.Controllers
{
    public class LivroController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Livro
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
        public ActionResult Cadastro(Livro livro, HttpPostedFileBase capa)
        {
            if (ModelState.IsValid)
            {
                if (capa.ContentLength > 0)
                {
                    var imgByte = new byte[capa.ContentLength];
                    capa.InputStream.Read(imgByte, 0, capa.ContentLength);
                    livro.Id = Guid.NewGuid();
                    livro.Pic = imgByte;
                    context.Livros.Add(livro);
                    context.SaveChanges();
                }
                return RedirectToAction("Index", "Leitor");
            }
            return View(livro);
        }
        //Details
        public ActionResult Detalhes()
        {
            return View();
        }

    }
}