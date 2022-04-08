using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoUmParaUm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "Id", "Dano", "Nome", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 35, "Arco e Flecha", 1 },
                    { 2, 33, "Espada", 2 },
                    { 3, 31, "Machado", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 148, 32, 136, 146, 140, 45, 210, 219, 202, 213, 182, 187, 148, 195, 124, 205, 199, 73, 118, 186, 69, 21, 92, 127, 202, 208, 249, 197, 183, 32, 74, 15, 114, 133, 1, 60, 10, 134, 129, 37, 191, 225, 67, 161, 234, 193, 118, 43, 250, 212, 43, 44, 139, 16, 195, 63, 252, 197, 53, 34, 33, 97, 173, 235 }, new byte[] { 91, 128, 245, 144, 239, 230, 250, 73, 227, 125, 53, 56, 79, 133, 164, 26, 251, 182, 21, 217, 81, 74, 196, 132, 224, 206, 22, 248, 9, 237, 0, 228, 136, 16, 253, 198, 202, 43, 137, 223, 251, 11, 137, 2, 79, 8, 129, 105, 115, 249, 146, 98, 162, 9, 24, 121, 189, 157, 241, 72, 121, 42, 200, 138, 153, 94, 171, 100, 144, 227, 203, 212, 240, 130, 171, 71, 235, 161, 220, 22, 60, 136, 63, 213, 70, 167, 52, 164, 79, 112, 200, 143, 114, 179, 95, 246, 48, 56, 160, 36, 249, 254, 80, 220, 229, 239, 175, 113, 58, 191, 76, 40, 58, 11, 153, 47, 211, 124, 0, 74, 120, 120, 210, 199, 101, 74, 38, 54 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DeleteData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 9, 202, 135, 7, 96, 169, 116, 96, 216, 10, 128, 47, 84, 235, 165, 106, 99, 255, 224, 176, 32, 196, 56, 101, 203, 66, 248, 220, 13, 58, 155, 151, 177, 43, 62, 69, 20, 130, 155, 58, 41, 39, 36, 239, 52, 78, 25, 249, 121, 28, 117, 87, 1, 128, 232, 222, 220, 24, 73, 9, 251, 236, 70 }, new byte[] { 236, 208, 58, 205, 126, 111, 102, 82, 30, 219, 23, 51, 142, 2, 114, 100, 111, 229, 173, 180, 102, 21, 213, 11, 201, 110, 35, 82, 216, 48, 19, 186, 85, 13, 53, 210, 123, 52, 189, 94, 10, 158, 210, 4, 162, 43, 104, 182, 174, 215, 35, 254, 134, 192, 22, 210, 152, 112, 188, 37, 165, 151, 26, 28, 21, 37, 68, 234, 145, 64, 244, 131, 123, 166, 205, 151, 26, 77, 202, 236, 157, 223, 142, 54, 197, 135, 106, 67, 76, 74, 1, 228, 32, 62, 242, 86, 134, 234, 161, 190, 232, 34, 68, 172, 200, 72, 32, 105, 223, 65, 99, 127, 4, 214, 11, 60, 91, 160, 232, 173, 150, 196, 186, 30, 150, 193, 50, 58 } });
        }
    }
}
