using Dominio.IRepositories;
using Historias.Cursos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Factories;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/cursos")]
    public class CursoController : ControllerBase
    {
        private readonly CriarCurso _criarCurso;

        public CursoController(ICursoRepository cursoRepository)
        {
            _criarCurso = new CriarCurso(cursoRepository);
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
    }
}
