using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotifei_Back.Migrations
{
    /// <inheritdoc />
    public partial class TPHestrategia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Usuario_UsuarioId",
                table: "Playlists");

            migrationBuilder.DropTable(
                name: "Albuns");

            migrationBuilder.DropTable(
                name: "Artistas");

            migrationBuilder.DropTable(
                name: "Ouvintes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Playlists",
                type: "varchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TipoUsuario",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataPublicacao",
                value: new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Foto", "NomeDoUsuario", "Senha", "Status", "TipoUsuario" },
                values: new object[] { 1, "CarlosAlbertoOficial@hootmail.com.br", null, "Carlos Alberto", "0123450", 2, 1 });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "DataCriacao", "Discriminator", "Nome", "NumeroMusicas", "UsuarioId" },
                values: new object[] { 1, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playlist", "Musicas do Carlos", 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Usuarios_UsuarioId",
                table: "Playlists",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Usuarios_UsuarioId",
                table: "Playlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "TipoUsuario",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Albuns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albuns_Playlists_Id",
                        column: x => x.Id,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artistas_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ouvintes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ouvintes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ouvintes_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Artistas",
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataPublicacao",
                value: new DateTime(2025, 11, 18, 19, 48, 50, 267, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 11, 18, 19, 48, 50, 267, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Usuario_UsuarioId",
                table: "Playlists",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
