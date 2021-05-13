using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AlunoViewModel
    {
        public int Id { get;  set; }
        public int CursoId { get;  set; }
        public string Nome { get;  set; }
        public string Matricula { get;  set; }
        public string Sexo { get;  set; }
        public string Telefone { get;  set; }
    }
}
