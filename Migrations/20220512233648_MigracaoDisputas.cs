using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoDisputas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Jogador");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Disputas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDisputa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtacanteId = table.Column<int>(type: "int", nullable: false),
                    OponenteId = table.Column<int>(type: "int", nullable: false),
                    Narracao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disputas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 146, 156, 181, 9, 35, 156, 133, 232, 89, 146, 87, 155, 41, 235, 211, 2, 9, 8, 66, 5, 47, 154, 120, 20, 32, 124, 113, 52, 138, 226, 36, 180, 142, 36, 37, 233, 120, 138, 198, 122, 111, 241, 131, 229, 250, 98, 158, 61, 98, 216, 59, 151, 184, 30, 166, 21, 180, 175, 45, 45, 231, 29, 38 }, new byte[] { 84, 184, 83, 121, 87, 179, 173, 81, 113, 16, 94, 55, 122, 179, 214, 129, 43, 130, 158, 137, 194, 229, 31, 2, 138, 93, 216, 42, 58, 233, 170, 35, 45, 227, 43, 172, 189, 155, 41, 154, 234, 237, 76, 157, 193, 174, 57, 74, 185, 191, 210, 40, 101, 48, 28, 139, 208, 67, 70, 73, 252, 123, 13, 237, 185, 109, 117, 96, 226, 53, 14, 188, 246, 51, 149, 192, 196, 73, 61, 131, 8, 186, 230, 159, 109, 70, 40, 74, 32, 133, 38, 237, 140, 99, 214, 191, 182, 80, 225, 156, 243, 123, 105, 45, 66, 94, 218, 244, 135, 86, 32, 201, 163, 69, 148, 103, 105, 110, 71, 91, 26, 114, 203, 126, 39, 78, 156, 46 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disputas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Jogador");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 245, 4, 25, 189, 0, 122, 104, 223, 71, 176, 162, 145, 39, 143, 166, 132, 104, 99, 137, 98, 115, 124, 230, 174, 16, 10, 93, 239, 192, 230, 37, 204, 212, 171, 211, 142, 214, 87, 44, 2, 238, 172, 218, 6, 140, 108, 33, 224, 173, 103, 241, 115, 159, 181, 130, 63, 228, 18, 206, 197, 11, 119, 200 }, new byte[] { 167, 128, 105, 136, 112, 187, 148, 238, 119, 18, 45, 26, 66, 234, 180, 163, 39, 60, 185, 49, 124, 96, 155, 249, 97, 252, 240, 28, 30, 104, 66, 53, 19, 184, 157, 200, 72, 124, 33, 158, 0, 163, 243, 189, 236, 5, 137, 110, 134, 144, 245, 221, 62, 188, 48, 125, 127, 178, 18, 127, 66, 245, 242, 178, 47, 65, 165, 44, 123, 232, 30, 189, 29, 176, 252, 56, 167, 239, 78, 232, 186, 214, 227, 132, 125, 75, 87, 234, 104, 146, 106, 246, 229, 208, 62, 113, 215, 153, 67, 98, 242, 6, 223, 137, 46, 124, 220, 79, 239, 172, 122, 230, 21, 159, 48, 220, 92, 51, 243, 233, 137, 8, 4, 80, 21, 62, 50, 113 } });
        }
    }
}
