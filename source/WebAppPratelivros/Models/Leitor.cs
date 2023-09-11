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
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'Nome' deve ser composto por, no máximo, 30 caracteres")]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Username' é obrigatório.")]
        [MaxLength(15, ErrorMessage = "O campo 'Username' deve ser composto por, no máximo, 15 caracteres")]
        public string Username { get; set; }
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'E-mail' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'E-mail' deve ser composto por, no máximo, 30 caracteres")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Senha' é obrigatório.")]
        [MaxLength(20, ErrorMessage = "O campo 'Senha' deve ser composto por, no máximo, 20 caracteres")]
        public string Senha { get; set; }
        public string Celular { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Idade' é obrigatório.")]
        public string Idade { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Gênero' é obrigatório.")]
        public string Genero { get; set; }
        public float Avaliacao { get; set; }
    }
}