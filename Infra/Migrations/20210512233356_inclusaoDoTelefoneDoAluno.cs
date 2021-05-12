using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class inclusaoDoTelefoneDoAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Alunos",
                type: "varchar(14)",
                maxLength: 14,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Alunos");
        }
    }
}
