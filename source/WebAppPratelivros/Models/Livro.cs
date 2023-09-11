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
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Título' é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo 'Título' deve ser composto por, no máximo, 50 caracteres")]
        public string Titulo { get; set; }
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'IBSN' é obrigatório.")]
        [MaxLength(13, ErrorMessage = "O campo 'ISBN' deve ser composto por 13 caracteres")]
        [MinLength(13, ErrorMessage = "O campo 'ISBN' deve ser composto por 13 caracteres")]
        public string ISBN { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Editora' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'Editora' deve ser composto por, no máximo, 30 caracteres")]
        public string Editora { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Edição' é obrigatório.")]
        public int Edicao { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Idioma' é obrigatório.")]
        [MaxLength(15, ErrorMessage = "O campo 'Idioma' deve ser composto por, no máximo, 15 caracteres")]
        public string Idioma { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'N° de Páginas' é obrigatório.")]
        public int NPaginas { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Autor' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'Autor' deve ser composto por, no máximo, 30 caracteres")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Gênero' é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O campo 'Gênero' deve ser composto por, no máximo, 30 caracteres")]
        public string Genero { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Data de Publicação' é obrigatório.")]
        public string DataPub { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Descrição' é obrigatório.")]
        [MinLength(30, ErrorMessage = "O campo 'Descrição' deve ser composto por, no mínimo, 30 caracteres")]
        [MaxLength(1000, ErrorMessage = "O campo 'Descrição' deve ser composto por, no máximo, 1000 caracteres")]
        public string Descricao { get; set; }
        public System.Guid Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Capa' é obrigatório.")]
        public byte[] Pic { get; set; }
    }
}