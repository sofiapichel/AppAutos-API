using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAutos.DataAccess.Migrations
{
    public partial class ver6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "max_velocidad",
                table: "vehiculos",
                newName: "potencia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "potencia",
                table: "vehiculos",
                newName: "max_velocidad");
        }
    }
}
