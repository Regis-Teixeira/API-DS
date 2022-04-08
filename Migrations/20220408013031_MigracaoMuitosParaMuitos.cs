using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 186, 138, 202, 30, 218, 174, 212, 23, 39, 49, 137, 121, 219, 184, 48, 244, 85, 124, 211, 247, 232, 1, 32, 32, 12, 133, 178, 69, 142, 104, 172, 136, 235, 74, 36, 140, 80, 238, 211, 195, 255, 95, 213, 179, 3, 101, 178, 66, 77, 88, 45, 235, 27, 245, 219, 141, 252, 105, 128, 198, 249, 8, 172, 2 }, new byte[] { 201, 113, 157, 254, 21, 198, 37, 196, 110, 225, 87, 134, 194, 147, 181, 86, 124, 161, 240, 68, 119, 174, 223, 249, 142, 148, 87, 75, 17, 3, 87, 21, 196, 252, 169, 98, 161, 57, 14, 223, 62, 86, 252, 192, 102, 14, 163, 107, 205, 139, 181, 178, 10, 55, 239, 167, 123, 97, 74, 253, 30, 66, 134, 106, 27, 64, 54, 65, 22, 89, 5, 66, 242, 91, 254, 202, 67, 28, 155, 77, 108, 74, 52, 180, 146, 40, 221, 196, 65, 14, 242, 44, 214, 241, 236, 194, 230, 142, 98, 125, 146, 154, 94, 60, 15, 58, 249, 21, 226, 141, 90, 235, 140, 43, 84, 238, 72, 102, 0, 108, 230, 21, 113, 97, 141, 93, 254, 41 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 6 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 148, 32, 136, 146, 140, 45, 210, 219, 202, 213, 182, 187, 148, 195, 124, 205, 199, 73, 118, 186, 69, 21, 92, 127, 202, 208, 249, 197, 183, 32, 74, 15, 114, 133, 1, 60, 10, 134, 129, 37, 191, 225, 67, 161, 234, 193, 118, 43, 250, 212, 43, 44, 139, 16, 195, 63, 252, 197, 53, 34, 33, 97, 173, 235 }, new byte[] { 91, 128, 245, 144, 239, 230, 250, 73, 227, 125, 53, 56, 79, 133, 164, 26, 251, 182, 21, 217, 81, 74, 196, 132, 224, 206, 22, 248, 9, 237, 0, 228, 136, 16, 253, 198, 202, 43, 137, 223, 251, 11, 137, 2, 79, 8, 129, 105, 115, 249, 146, 98, 162, 9, 24, 121, 189, 157, 241, 72, 121, 42, 200, 138, 153, 94, 171, 100, 144, 227, 203, 212, 240, 130, 171, 71, 235, 161, 220, 22, 60, 136, 63, 213, 70, 167, 52, 164, 79, 112, 200, 143, 114, 179, 95, 246, 48, 56, 160, 36, 249, 254, 80, 220, 229, 239, 175, 113, 58, 191, 76, 40, 58, 11, 153, 47, 211, 124, 0, 74, 120, 120, 210, 199, 101, 74, 38, 54 } });
        }
    }
}
