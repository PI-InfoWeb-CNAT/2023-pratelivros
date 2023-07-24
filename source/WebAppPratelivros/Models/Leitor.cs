using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPratelivros.Models
{
    public class Leitor
    {
        public string nome { get; set; }
        public string username { get; set; }
        [Key]
        public string email { get; set; }
        public string senha { get; set; }
        public string celular { get; set; }
        public string idade { get; set; }
        public string genero { get; set; }
        public float avaliacao { get; set; }
    }
}