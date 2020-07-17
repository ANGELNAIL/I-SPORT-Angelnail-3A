using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace I_SPORT.SERVICES.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "equipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: true),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: true),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: true),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Fechanac = table.Column<DateTime>(nullable: false),
                    Estatura = table.Column<double>(nullable: false),
                    Pais = table.Column<string>(nullable: true),
                    posicion = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true),
                    EquipoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jugadores_equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "partidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: true),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Fechapartido = table.Column<DateTime>(nullable: false),
                    Equipolocal = table.Column<int>(nullable: false),
                    Equipovisitante = table.Column<int>(nullable: false),
                    equipoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_partidos_equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "estadisticas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: true),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Goles = table.Column<int>(nullable: false),
                    Autogoles = table.Column<int>(nullable: false),
                    TRojas = table.Column<int>(nullable: false),
                    TAmarillas = table.Column<int>(nullable: false),
                    TNaranas = table.Column<int>(nullable: false),
                    Tjugado = table.Column<int>(nullable: false),
                    idjugador = table.Column<int>(nullable: false),
                    jugadorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadisticas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estadisticas_jugadores_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_estadisticas_jugadorId",
                table: "estadisticas",
                column: "jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_jugadores_EquipoId",
                table: "jugadores",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_partidos_equipoId",
                table: "partidos",
                column: "equipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "estadisticas");

            migrationBuilder.DropTable(
                name: "partidos");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "jugadores");

            migrationBuilder.DropTable(
                name: "equipos");
        }
    }
}
