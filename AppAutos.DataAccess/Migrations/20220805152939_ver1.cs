using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAutos.DataAccess.Migrations
{
    public partial class ver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Combustibles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustibles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "paises",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paises", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_modelo = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    precio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anio = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    puertas = table.Column<int>(type: "int", nullable: false),
                    max_velocidad = table.Column<int>(type: "int", nullable: false),
                    kilometros = table.Column<int>(type: "int", nullable: false),
                    id_marca = table.Column<int>(type: "int", nullable: false),
                    id_tipo = table.Column<int>(type: "int", nullable: false),
                    id_color = table.Column<int>(type: "int", nullable: false),
                    id_combustible = table.Column<int>(type: "int", nullable: false),
                    id_pais = table.Column<int>(type: "int", nullable: false),
                    id_seguro = table.Column<int>(type: "int", nullable: false),
                    id_estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.id);
                    table.ForeignKey(
                        name: "FK_vehiculos_Colores_id_color",
                        column: x => x.id_color,
                        principalTable: "Colores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_Combustibles_id_combustible",
                        column: x => x.id_combustible,
                        principalTable: "Combustibles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_Estados_id_estado",
                        column: x => x.id_estado,
                        principalTable: "Estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_marcas_id_marca",
                        column: x => x.id_marca,
                        principalTable: "marcas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_paises_id_pais",
                        column: x => x.id_pais,
                        principalTable: "paises",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_Seguros_id_seguro",
                        column: x => x.id_seguro,
                        principalTable: "Seguros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_tipos_id_tipo",
                        column: x => x.id_tipo,
                        principalTable: "tipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_id_color",
                table: "vehiculos",
                column: "id_color");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_id_combustible",
                table: "vehiculos",
                column: "id_combustible");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_id_estado",
                table: "vehiculos",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_id_marca",
                table: "vehiculos",
                column: "id_marca");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_id_pais",
                table: "vehiculos",
                column: "id_pais");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_id_seguro",
                table: "vehiculos",
                column: "id_seguro");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_id_tipo",
                table: "vehiculos",
                column: "id_tipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "Colores");

            migrationBuilder.DropTable(
                name: "Combustibles");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "paises");

            migrationBuilder.DropTable(
                name: "Seguros");

            migrationBuilder.DropTable(
                name: "tipos");
        }
    }
}
