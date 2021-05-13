using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Cursos
{
    public class ConsultaCurso
    {
        private readonly ICursoRepository _cursoRepository;

        public ConsultaCurso(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task<Curso> BuscarPorId(int id)
        {
            return await _cursoRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Curso>> ListarTodosCursos()
        {
            return await _cursoRepository.ListarTodosCursos();
        }
    }
}
