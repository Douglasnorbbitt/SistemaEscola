using Dominio.Entidades;
using Infra.Contexto;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class AlunoRepositoy : IAlunoRepository
    {
        private readonly DataContext _dataContext;

        public AlunoRepositoy(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Aluno aluno)
        {
            _dataContext.Alunos.Add(aluno);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Alterar(Aluno aluno)
        {
            _dataContext.Update(aluno);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Aluno aluno)
        {
            _dataContext.Remove(aluno);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Aluno> BuscarPorId(int id)
        {
            return await _dataContext.Alunos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Aluno>> ListarTodosAlunos()
        {
            return await _dataContext.Alunos.AsNoTracking().ToListAsync();
        }
    }
}
