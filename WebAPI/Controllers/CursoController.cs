using Dominio.IRepositories;
using Historias.Cursos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Factories;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/cursos")]
    public class CursoController : ControllerBase
    {
        private readonly CriarCurso _criarCurso;
        private readonly ConsultaCurso _consultaCurso;

        public CursoController(ICursoRepository cursoRepository)
        {
            _criarCurso = new CriarCurso(cursoRepository);
            _consultaCurso = new ConsultaCurso(cursoRepository);
        }

        [HttpPost("criar-curso")]
        public async Task<IActionResult> Criar([FromBody] CursoViewModel cursoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "O campo nome é obrigatório"});
            }

            var curso = CursoFactory.MapearCurso(cursoViewModel);

            await _criarCurso.Executar(curso);

            return Ok(new { mensagem = "Curso Criado com sucesso!" });
        }

        [HttpGet("listar-cursos")]
        public async Task<IEnumerable<CursoViewModel>> Listar()
        {
            var listaDeCursos = await _consultaCurso.ListarTodosCursos();

            if (listaDeCursos == null)
            {
                return null;
            }

            var listaCursoVm = CursoFactory.MapearListaCursoViewModel(listaDeCursos);
            return listaCursoVm;
        }

        [HttpGet("buscar-curso/{id}")]
        public async Task<CursoViewModel> Buscar(int id)
        {
            var curso = await _consultaCurso.BuscarPorId(id);

            if (curso == null)
            {
                return null;
            }

            var cursoViewModel = CursoFactory.MapearCursoViewModel(curso);

            return cursoViewModel;
        }

    }
}
