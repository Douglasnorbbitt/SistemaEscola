using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Cursos
{
    public class AlterarCurso
    {
        private readonly ICursoRepository _cursoRepository;

        public AlterarCurso(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task Executar(int id, Curso curso)
        {
            var dadosDoCurso = await _cursoRepository.BuscarPorId(id);

            dadosDoCurso.AtualizarDados(curso.Nome, curso.Turno);

            await _cursoRepository.Alterar(dadosDoCurso);
        }
    }
}
