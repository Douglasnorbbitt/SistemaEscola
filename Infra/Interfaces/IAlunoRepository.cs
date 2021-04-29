using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Interfaces
{
    public interface IAlunoRepository
    {
        Task Criar(Aluno aluno);

        Task Alterar(Aluno aluno);

        Task Excluir(Aluno aluno);

        Task<Aluno> BuscarPorId(int id);

        Task<IEnumerable<Aluno>> ListarTodosAlunos();
    }
}
