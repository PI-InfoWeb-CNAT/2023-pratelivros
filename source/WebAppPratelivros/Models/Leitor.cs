using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPratelivros.Models
{
    public class Leitor
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Username { get; set; }
        [Key]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public string Celular { get; set; }
        [Required]
        public string Idade { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public float Avaliacao { get; set; }
    }
}