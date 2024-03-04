using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuracion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PaddingTop = table.Column<int>(type: "integer", nullable: false),
                    PaddingLeft = table.Column<int>(type: "integer", nullable: false),
                    Border = table.Column<bool>(type: "boolean", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    MensajeAlert = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracion", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracion");
        }
    }
}
