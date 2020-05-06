using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGames.Dados.Migrations
{
    public partial class AdicionandoPlataforma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plataforma",
                columns: table => new
                {
                    IdPlataforma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma", x => x.IdPlataforma);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plataforma");
        }
    }
}
