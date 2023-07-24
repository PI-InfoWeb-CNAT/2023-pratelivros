﻿using System;
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
        [StringLength(13, ErrorMessage = "ISBN deve ter 13 caracteres")]
        public string ISBN { get; set; }
        [Required]
        public string Editora { get; set; }
        [Required]
        public int Edicao { get; set; }
        [Required]
        public string Idioma { get; set; }
        [Required]
        public int NPaginas { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string DataPub { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 30, ErrorMessage = "Deve estar entre 30 e 1000 caracteres")]
        public string Descricao { get; set; }
        public System.Guid Id { get; set; }
        public byte[] Pic { get; set; }
    }
}