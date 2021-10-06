using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudTest.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Precio",
                table: "Libro",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Libro",
                type: "decimal(12,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
