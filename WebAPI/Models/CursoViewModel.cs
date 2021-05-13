using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CursoViewModel
    {
        public int Id { get;  set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Nome { get;  set; }

        public string Turno { get;  set; }
    }
}
