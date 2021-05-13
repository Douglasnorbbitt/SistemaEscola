using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Factories
{
    public static class CursoFactory
    {
        public static Curso MapearCurso(CursoViewModel cursoViewModel)
        {
            return new Curso(cursoViewModel.Nome, cursoViewModel.Turno);
        }
    }
}
