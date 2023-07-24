using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPratelivros.Models
{
    public class Livro
    {
        [Key] 
        public string ISBN { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public string Idioma { get; set; }
        public int NPaginas { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string DataPub { get; set; }
        [StringLength(1000, MinimumLength = 30, ErrorMessage = "Deve estar entre 30 e 1000 caracteres")]
        public string Descricao { get; set; }
        public System.Guid Id { get; set; }
        public byte[] Pic { get; set; }
    }
}