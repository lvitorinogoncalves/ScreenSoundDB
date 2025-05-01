using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSoundDB.Migrations
{
    /// <inheritdoc />
    public partial class NewDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {"Teste", "Testes", "TT"});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Artistas");
        }
    }
}
