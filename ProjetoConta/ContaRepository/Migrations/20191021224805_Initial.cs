using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ContaRepository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Identificacao = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ContasLuz",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DataLeitura = table.Column<DateTime>(nullable: false),
                    NumLeitura = table.Column<double>(nullable: false),
                    KwGasto = table.Column<double>(nullable: false),
                    ValorAPagar = table.Column<double>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: false),
                    MediaConsumo = table.Column<double>(nullable: false),
                    imovelid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasLuz", x => x.id);
                    table.ForeignKey(
                        name: "FK_ContasLuz_Imoveis_imovelid",
                        column: x => x.imovelid,
                        principalTable: "Imoveis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade,
                        onUpdate: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasLuz_imovelid",
                table: "ContasLuz",
                column: "imovelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasLuz");

            migrationBuilder.DropTable(
                name: "Imoveis");
        }
    }
}
