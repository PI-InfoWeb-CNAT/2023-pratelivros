using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPratelivros.Models
{
    public class LivroDenuncia
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'Nome' deve ser composto por, no máximo, 30 caracteres")]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Tipo' é obrigatório.")]
        public Denuncia Tipo { get; set; }
        [MaxLength(30, ErrorMessage = "O campo 'E-mail' deve ser composto por, no máximo, 30 caracteres")]
        public string Email { get; set; }
    }
}