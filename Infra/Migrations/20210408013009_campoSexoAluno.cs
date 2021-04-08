using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class campoSexoAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Alunos",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Alunos");
        }
    }
}
