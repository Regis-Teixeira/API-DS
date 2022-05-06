using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Jogador");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 245, 4, 25, 189, 0, 122, 104, 223, 71, 176, 162, 145, 39, 143, 166, 132, 104, 99, 137, 98, 115, 124, 230, 174, 16, 10, 93, 239, 192, 230, 37, 204, 212, 171, 211, 142, 214, 87, 44, 2, 238, 172, 218, 6, 140, 108, 33, 224, 173, 103, 241, 115, 159, 181, 130, 63, 228, 18, 206, 197, 11, 119, 200 }, new byte[] { 167, 128, 105, 136, 112, 187, 148, 238, 119, 18, 45, 26, 66, 234, 180, 163, 39, 60, 185, 49, 124, 96, 155, 249, 97, 252, 240, 28, 30, 104, 66, 53, 19, 184, 157, 200, 72, 124, 33, 158, 0, 163, 243, 189, 236, 5, 137, 110, 134, 144, 245, 221, 62, 188, 48, 125, 127, 178, 18, 127, 66, 245, 242, 178, 47, 65, 165, 44, 123, 232, 30, 189, 29, 176, 252, 56, 167, 239, 78, 232, 186, 214, 227, 132, 125, 75, 87, 234, 104, 146, 106, 246, 229, 208, 62, 113, 215, 153, 67, 98, 242, 6, 223, 137, 46, 124, 220, 79, 239, 172, 122, 230, 21, 159, 48, 220, 92, 51, 243, 233, 137, 8, 4, 80, 21, 62, 50, 113 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 186, 138, 202, 30, 218, 174, 212, 23, 39, 49, 137, 121, 219, 184, 48, 244, 85, 124, 211, 247, 232, 1, 32, 32, 12, 133, 178, 69, 142, 104, 172, 136, 235, 74, 36, 140, 80, 238, 211, 195, 255, 95, 213, 179, 3, 101, 178, 66, 77, 88, 45, 235, 27, 245, 219, 141, 252, 105, 128, 198, 249, 8, 172, 2 }, new byte[] { 201, 113, 157, 254, 21, 198, 37, 196, 110, 225, 87, 134, 194, 147, 181, 86, 124, 161, 240, 68, 119, 174, 223, 249, 142, 148, 87, 75, 17, 3, 87, 21, 196, 252, 169, 98, 161, 57, 14, 223, 62, 86, 252, 192, 102, 14, 163, 107, 205, 139, 181, 178, 10, 55, 239, 167, 123, 97, 74, 253, 30, 66, 134, 106, 27, 64, 54, 65, 22, 89, 5, 66, 242, 91, 254, 202, 67, 28, 155, 77, 108, 74, 52, 180, 146, 40, 221, 196, 65, 14, 242, 44, 214, 241, 236, 194, 230, 142, 98, 125, 146, 154, 94, 60, 15, 58, 249, 21, 226, 141, 90, 235, 140, 43, 84, 238, 72, 102, 0, 108, 230, 21, 113, 97, 141, 93, 254, 41 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId");
        }
    }
}
