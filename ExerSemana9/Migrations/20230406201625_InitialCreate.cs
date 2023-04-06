using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerSemana9.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Semana",
                columns: table => new
                {
                    CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CONTEÚDO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    APLICCONTEÚDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semana", x => x.CODIGO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Semana");
        }
    }
}
