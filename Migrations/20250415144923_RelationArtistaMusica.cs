using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSoundDB.Migrations
{
    
    public partial class RelationArtistaMusica : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistaId",
                table: "Musicas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_ArtistaId",
                table: "Musicas",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id");
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas");

            migrationBuilder.DropIndex(
                name: "IX_Musicas_ArtistaId",
                table: "Musicas");

            migrationBuilder.DropColumn(
                name: "ArtistaId",
                table: "Musicas");
        }
    }
}
