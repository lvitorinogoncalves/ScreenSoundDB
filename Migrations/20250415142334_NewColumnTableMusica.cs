using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSoundDB.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnTableMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnoLancamento",
                table: "Musicas",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoLancamento",
                table: "Musicas");
        }
    }
}
