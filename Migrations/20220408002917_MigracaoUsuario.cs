using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "Personagens",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Personagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Armas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataAcesso", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, null, null, null, new byte[] { 19, 9, 202, 135, 7, 96, 169, 116, 96, 216, 10, 128, 47, 84, 235, 165, 106, 99, 255, 224, 176, 32, 196, 56, 101, 203, 66, 248, 220, 13, 58, 155, 151, 177, 43, 62, 69, 20, 130, 155, 58, 41, 39, 36, 239, 52, 78, 25, 249, 121, 28, 117, 87, 1, 128, 232, 222, 220, 24, 73, 9, 251, 236, 70 }, new byte[] { 236, 208, 58, 205, 126, 111, 102, 82, 30, 219, 23, 51, 142, 2, 114, 100, 111, 229, 173, 180, 102, 21, 213, 11, 201, 110, 35, 82, 216, 48, 19, 186, 85, 13, 53, 210, 123, 52, 189, 94, 10, 158, 210, 4, 162, 43, 104, 182, 174, 215, 35, 254, 134, 192, 22, 210, 152, 112, 188, 37, 165, 151, 26, 28, 21, 37, 68, 234, 145, 64, 244, 131, 123, 166, 205, 151, 26, 77, 202, 236, 157, 223, 142, 54, 197, 135, 106, 67, 76, 74, 1, 228, 32, 62, 242, 86, 134, 234, 161, 190, 232, 34, 68, 172, 200, 72, 32, 105, 223, 65, 99, 127, 4, 214, 11, 60, 91, 160, 232, 173, 150, 196, 186, 30, 150, 193, 50, 58 }, "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropTable(
                name: "Armas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Personagens");
        }
    }
}
