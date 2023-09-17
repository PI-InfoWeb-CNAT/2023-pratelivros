using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebAppPratelivros.Models
{
    public class Home
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'Nome' deve ser composto por, no máximo, 30 caracteres")]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'E-mail' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'E-mail' deve ser composto por, no máximo, 30 caracteres")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Tipo' é obrigatório.")]
        public Denuncia Tipo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Mensagem' é obrigatório.")]
        public string Mensagem { get; set; }
    }

    public enum Denuncia
    {
        Outro
    }
}