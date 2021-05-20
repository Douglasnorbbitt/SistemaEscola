using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AlunoViewModel
    {
        public int Id { get;  set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public int CursoId { get;  set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Nome { get;  set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Matricula { get;  set; }
        public string Sexo { get;  set; }
        public string Telefone { get;  set; }
    }
}
