using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Turno).HasMaxLength(20).HasColumnType("varchar(20)");

            //Relacionamento entre as tabelas um para muitos
            builder.HasMany(x => x.Alunos).WithOne(x => x.Curso);
        }
    }
}
