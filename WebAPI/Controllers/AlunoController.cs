using Dominio.IRepositories;
using Historias.Alunos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Factories;
using WebAPI.Models;

namespace WebAPI.Controllers
{
   
    [Route("api/alunos")]
    public class AlunoController : ControllerBase
    {
        private readonly CriarAluno _criarAluno;
        private readonly ConsultaAluno _consultaAluno;
        private readonly AlterarAluno _alterarAluno;
        private readonly ExcluirAluno _excluirAluno;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _criarAluno = new CriarAluno(alunoRepository);
            _consultaAluno = new ConsultaAluno(alunoRepository);
            _alterarAluno = new AlterarAluno(alunoRepository);
            _excluirAluno = new ExcluirAluno(alunoRepository);
        }

        [HttpPost("criar-aluno")]
        public async Task<IActionResult> Criar([FromBody] AlunoViewModel alunoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "O campo nome é obrigatório" });
            }

            var aluno = AlunoFactory.MapearAluno(alunoViewModel);

            await _criarAluno.Executar(aluno);

            return Ok(new { mensagem = "aluno Criado com sucesso!" });
        }

        [HttpPut("alterar-aluno")]
        public async Task<IActionResult> Alterar([FromBody] AlunoViewModel alunoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "O campo nome é obrigatório" });
            }

            try
            {
                var aluno = AlunoFactory.MapearAluno(alunoViewModel);

                await _alterarAluno.Executar(alunoViewModel.Id, aluno);

                return Ok(new { mensagem = "Aluno alterado com sucesso" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao alterar o aluno" });
            }

        }

        [HttpDelete("excluir-aluno/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            try
            {
                await _excluirAluno.Executar(id);
                return Ok(new { mensagem = "Aluno excluido com sucesso" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao excluir o Aluno" });
            }

        }

        [HttpGet("listar-alunos")]
        public async Task<IEnumerable<AlunoViewModel>> Listar()
        {
            var listaDeAlunos = await _consultaAluno.ListarTodosAlunos();

            if (listaDeAlunos == null)
            {
                return null;
            }

            var listaAlunoVm = AlunoFactory.MapearListaAlunoViewModel(listaDeAlunos);
            return listaAlunoVm;
        }

        [HttpGet("buscar-aluno/{id}")]
        public async Task<AlunoViewModel> Buscar(int id)
        {
            var aluno = await _consultaAluno.BuscarPorId(id);

            if (aluno == null)
            {
                return null;
            }

            var alunoViewModel = AlunoFactory.MapearAlunoViewModel(aluno);

            return alunoViewModel;
        }

    }
}
