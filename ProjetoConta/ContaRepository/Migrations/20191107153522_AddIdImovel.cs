using Microsoft.EntityFrameworkCore.Migrations;

namespace ContaRepository.Migrations
{
    public partial class AddIdImovel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idImovel",
                table: "ContasLuz",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idImovel",
                table: "ContasLuz");
        }
    }
}
