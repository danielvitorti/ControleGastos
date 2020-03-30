using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ControleGastos.Migrations
{
    public partial class _0002Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Competencia",
                table: "Lancamentos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Lancamentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
