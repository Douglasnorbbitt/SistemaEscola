using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class CursoRepository : ICursoRepository
    {
        private readonly DataContext _dataContext;

        public CursoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Curso curso)
        {
            _dataContext.Cursos.Add(curso);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Alterar(Curso curso)
        {
            _dataContext.Update(curso);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Curso curso)
        {
            _dataContext.Remove(curso);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Curso> BuscarPorId(int id)
        {
            return await _dataContext.Cursos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Curso>> ListarTodosCursos()
        {
            return await _dataContext.Cursos.AsNoTracking().ToListAsync();
        }
    }
}
