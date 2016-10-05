using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Editora
    {
        public int EditoraID { get ; set; }

        [Required(ErrorMessage = "O nome da editora é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail da editora é obrigatório ")]
        public string Email { get; set; }
    }
}