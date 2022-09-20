using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAutos.DataAccess.Migrations
{
    public partial class ver4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_Seguros_id_seguro",
                table: "vehiculos");

            migrationBuilder.AlterColumn<byte>(
                name: "puertas",
                table: "vehiculos",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "max_velocidad",
                table: "vehiculos",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_seguro",
                table: "vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "id_modelo",
                table: "vehiculos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "anio",
                table: "vehiculos",
                type: "char(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_Seguros_id_seguro",
                table: "vehiculos",
                column: "id_seguro",
                principalTable: "Seguros",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_Seguros_id_seguro",
                table: "vehiculos");

            migrationBuilder.AlterColumn<int>(
                name: "puertas",
                table: "vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "max_velocidad",
                table: "vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "id_seguro",
                table: "vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_modelo",
                table: "vehiculos",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "anio",
                table: "vehiculos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldMaxLength: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_Seguros_id_seguro",
                table: "vehiculos",
                column: "id_seguro",
                principalTable: "Seguros",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
