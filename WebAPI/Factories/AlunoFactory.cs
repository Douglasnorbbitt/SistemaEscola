using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Factories
{
    public static class AlunoFactory
    {
        public static Aluno MapearAluno(AlunoViewModel alunoViewModel)
        {
            return new Aluno(alunoViewModel.Id, alunoViewModel.Nome, alunoViewModel.CursoId, alunoViewModel.Matricula, alunoViewModel.Sexo, alunoViewModel.Telefone);
        }
        public static AlunoViewModel MapearAlunoViewModel(Aluno aluno)
        {
            return new AlunoViewModel() { Id = aluno.Id, Nome = aluno.Nome, CursoId = aluno.CursoId, Matricula = aluno.Matricula, Sexo = aluno.Sexo, Telefone = aluno.Telefone };
        }
        public static IEnumerable<AlunoViewModel> MapearListaAlunoViewModel(IEnumerable<Aluno> lista)
        {
            var listaAlunoViewModel = new List<AlunoViewModel>();
            AlunoViewModel alunoVm;

            foreach (var item in lista)
            {
                alunoVm = new AlunoViewModel
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    CursoId = item.CursoId,
                    Matricula = item.Matricula,
                    Sexo = item.Sexo,
                    Telefone = item.Telefone
                };

                listaAlunoViewModel.Add(alunoVm);
            }

            return listaAlunoViewModel;
        }

    }
}
