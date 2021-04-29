using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Interfaces
{
    public interface ICursoRepository
    {
        Task Criar(Curso curso);

        Task Alterar(Curso curso);

        Task Excluir(Curso curso);

        Task<Curso> BuscarPorId(int id);

        Task<IEnumerable<Curso>> ListarTodosCursos();
    }
}
