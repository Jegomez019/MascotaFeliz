using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriaClinica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Apertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Mascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_Mascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Estado_Salud = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motivo_Visita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Frecuencia_Respiratoria = table.Column<int>(type: "int", nullable: false),
                    Frecuencia_Cardiaca = table.Column<int>(type: "int", nullable: false),
                    Estado_Animo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visita", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriaClinica");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Propietario");

            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DropTable(
                name: "Visita");
        }
    }
}
