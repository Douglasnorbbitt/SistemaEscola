using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Alunos
{
    public class ConsultaAluno
    {
        private readonly IAlunoRepository _alunoRepository;

        public ConsultaAluno(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<Aluno> BuscarPorId(int id)
        {
            return await _alunoRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Aluno>> ListarTodosAlunos()
        {
            return await _alunoRepository.ListarTodosAlunos();
        }
    }
}