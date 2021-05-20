using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Cursos
{
    public class ExcluirCurso
    {
        private readonly ICursoRepository _cursoRepository;

        public ExcluirCurso(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task Executar(int id)
        {
            await _cursoRepository.Excluir(id);
        }
    }
}
