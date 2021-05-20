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

        public static CursoViewModel MapearCursoViewModel(Curso curso)
        {
            return new CursoViewModel() { Id = curso.Id, Nome = curso.Nome, Turno = curso.Turno };
        }

        public static IEnumerable<CursoViewModel> MapearListaCursoViewModel(IEnumerable<Curso> lista)
        {
            var listaCursoViewModel = new List<CursoViewModel>();
            CursoViewModel cursoVm;

            foreach (var item in lista)
            {
                cursoVm = new CursoViewModel { 
                    Id = item.Id,
                    Nome = item.Nome,
                    Turno = item.Turno
                };

                listaCursoViewModel.Add(cursoVm);
            }

            return listaCursoViewModel;
        }
    }
}
