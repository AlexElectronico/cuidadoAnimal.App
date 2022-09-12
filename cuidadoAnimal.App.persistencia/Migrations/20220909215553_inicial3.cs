using Microsoft.EntityFrameworkCore.Migrations;

namespace cuidadoAnimal.App.persistencia.Migrations
{
    public partial class inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreHacienda = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarjetaProfecional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veterinario_Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Animales",
                columns: table => new
                {
                    IdCerdos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropietarioIdPersona = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animales", x => x.IdCerdos);
                    table.ForeignKey(
                        name: "FK_Animales_Personas_PropietarioIdPersona",
                        column: x => x.PropietarioIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    IdVisita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaVisita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalIdCerdos = table.Column<int>(type: "int", nullable: true),
                    VeterinarioIdPersona = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.IdVisita);
                    table.ForeignKey(
                        name: "FK_Visitas_Animales_AnimalIdCerdos",
                        column: x => x.AnimalIdCerdos,
                        principalTable: "Animales",
                        principalColumn: "IdCerdos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visitas_Personas_VeterinarioIdPersona",
                        column: x => x.VeterinarioIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animales_PropietarioIdPersona",
                table: "Animales",
                column: "PropietarioIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_AnimalIdCerdos",
                table: "Visitas",
                column: "AnimalIdCerdos");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_VeterinarioIdPersona",
                table: "Visitas",
                column: "VeterinarioIdPersona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropTable(
                name: "Animales");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
