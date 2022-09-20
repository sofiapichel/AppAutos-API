using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAutos.DataAccess.Migrations
{
    public partial class ver8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_modelo",
                table: "vehiculos",
                newName: "modelo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "vehiculos",
                newName: "id_modelo");
        }
    }
}
