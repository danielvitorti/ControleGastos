using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ControleGastos.Migrations
{
    public partial class _0003Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<int>(
                name: "IdCompetencia",
                table: "Lancamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "competenciaId",
                table: "Lancamentos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCompetencia",
                table: "Contas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "competenciaId",
                table: "Contas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Competencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    PeriodoInicial = table.Column<DateTime>(nullable: false),
                    PeriodoFinal = table.Column<DateTime>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencia", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_competenciaId",
                table: "Lancamentos",
                column: "competenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_competenciaId",
                table: "Contas",
                column: "competenciaId");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Competencia");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_competenciaId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Contas_competenciaId",
                table: "Contas");



            migrationBuilder.AddColumn<string>(
                name: "Competencia",
                table: "Lancamentos",
                type: "TEXT",
                nullable: true);
        }
    }
}
