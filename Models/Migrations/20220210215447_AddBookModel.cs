using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class AddBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    autorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.autorId);
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    noticiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    Contenido = table.Column<string>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    autorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.noticiaId);
                    table.ForeignKey(
                        name: "FK_Noticia_Autor_autorId",
                        column: x => x.autorId,
                        principalTable: "Autor",
                        principalColumn: "autorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_Nombre_Apellido",
                table: "Autor",
                columns: new[] { "Nombre", "Apellido" });

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_autorId",
                table: "Noticia",
                column: "autorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "Autor");
        }
    }
}
