using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Matricula).IsRequired().HasMaxLength(4).HasColumnType("varchar(4)");
            builder.Property(x => x.Sexo).HasMaxLength(20).HasColumnType("varchar(20)");

            //builder.HasOne(x => x.Curso).WithMany(x => x.Alunos);
        }
    }
}
