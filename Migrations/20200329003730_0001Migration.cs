using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ControleGastos.Migrations
{
    public partial class _0001Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<float>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<float>(nullable: false),
                    TipoLancamento = table.Column<string>(nullable: true),
                    IdConta = table.Column<int>(nullable: false),
                    contaId = table.Column<int>(nullable: true),
                    IdFormaPagamento = table.Column<int>(nullable: false),
                    formaPagamentoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lancamentos_Contas_contaId",
                        column: x => x.contaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lancamentos_FormaPagamento_formaPagamentoId",
                        column: x => x.formaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_contaId",
                table: "Lancamentos",
                column: "contaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_formaPagamentoId",
                table: "Lancamentos",
                column: "formaPagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "FormaPagamento");
        }
    }
}
