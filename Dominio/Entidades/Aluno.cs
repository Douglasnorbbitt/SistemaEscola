using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Aluno
    {
        public Aluno(int id, int cursoId, string nome, string matricula, string sexo, string telefone)
        {
            Nome = nome;
            Id = id;
            CursoId = cursoId;
            Matricula = matricula;
            Sexo = sexo;
            Telefone = telefone;

        }

        public Aluno(int id, string nome, int cursoId, string matricula, string sexo, string telefone)
        {
            Id = id;
            Nome = nome;
            CursoId = cursoId;
            Matricula = matricula;
            Sexo = sexo;
            Telefone = telefone;
        }

        public void AtualizarDados(int id, string nome, object curso, string matricula, string sexo, string telefone)
        {
            throw new NotImplementedException();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int CursoId { get; private set; }
        public string Matricula { get; private set; }
        public string Sexo { get; private set; }
        public string Telefone { get; private set; }
        public IEnumerable<Aluno> Alunos { get; private set; }
        public object Curso { get; set; }

        public void AtualizarDados(int id, int cursoId, string nome, string matricula, string sexo, string telefone)
        {
            this.Nome = nome;
            this.CursoId = cursoId;
            this.Id = id;
            this.Matricula = matricula;
            this.Sexo = sexo;
            this.Telefone = telefone;



        }
    }
}