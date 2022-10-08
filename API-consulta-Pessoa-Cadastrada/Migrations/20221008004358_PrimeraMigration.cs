using Microsoft.EntityFrameworkCore.Migrations;

namespace API_consulta_Pessoa_Cadastrada.Migrations
{
    public partial class PrimeraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Telefones",
                newName: "Telefone");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Pessoa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "Pessoa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TelefoneId",
                table: "Pessoa",
                column: "TelefoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Endereco_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Telefone_TelefoneId",
                table: "Pessoa",
                column: "TelefoneId",
                principalTable: "Telefone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Endereco_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Telefone_TelefoneId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_TelefoneId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Telefone",
                newName: "Telefones");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");
        }
    }
}
