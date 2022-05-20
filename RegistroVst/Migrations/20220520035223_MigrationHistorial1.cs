using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroVst.Migrations
{
    public partial class MigrationHistorial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVisitante = table.Column<int>(type: "int", nullable: false),
                    IdEvento = table.Column<int>(type: "int", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historial", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historial");
        }
    }
}
