using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSoundDB.Migrations
{
    /// <inheritdoc />
    public partial class NewDataTableMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Teste", 1989 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}
