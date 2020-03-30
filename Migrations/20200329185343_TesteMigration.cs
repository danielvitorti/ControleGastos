using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleGastos.Migrations
{
    public partial class TesteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<int>(
                name: "LancamentoId",
                table: "FormaPagamento",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LancamentoId",
                table: "Contas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContaId",
                table: "Competencia",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LancamentoId",
                table: "Competencia",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormaPagamento_LancamentoId",
                table: "FormaPagamento",
                column: "LancamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_LancamentoId",
                table: "Contas",
                column: "LancamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Competencia_ContaId",
                table: "Competencia",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Competencia_LancamentoId",
                table: "Competencia",
                column: "LancamentoId");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropIndex(
                name: "IX_FormaPagamento_LancamentoId",
                table: "FormaPagamento");

            migrationBuilder.DropIndex(
                name: "IX_Contas_LancamentoId",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Competencia_ContaId",
                table: "Competencia");

            migrationBuilder.DropIndex(
                name: "IX_Competencia_LancamentoId",
                table: "Competencia");

            migrationBuilder.AddColumn<int>(
                name: "IdCompetencia",
                table: "Lancamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdConta",
                table: "Lancamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFormaPagamento",
                table: "Lancamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCompetencia",
                table: "Contas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
