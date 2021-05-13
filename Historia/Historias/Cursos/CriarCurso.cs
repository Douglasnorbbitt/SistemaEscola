using Dominio.IRepositories;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Cursos
{
    public class CriarCurso
    {
        private readonly ICursoRepository _cursoRepository;

        public CriarCurso(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task Executar(Curso curso)
        {
            await _cursoRepository.Criar(curso);
        }
    }
}
