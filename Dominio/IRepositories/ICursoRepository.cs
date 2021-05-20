using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface ICursoRepository
    {
        Task Criar(Curso curso);

        Task Alterar(Curso curso);

        Task Excluir(int id);

        Task<Curso> BuscarPorId(int id);

        Task<IEnumerable<Curso>> ListarTodosCursos();
    }
}
