using Microsoft.EntityFrameworkCore.Migrations;

namespace I_SPORT.SERVICES.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idpartido",
                table: "estadisticas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "partidoId",
                table: "estadisticas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_estadisticas_partidoId",
                table: "estadisticas",
                column: "partidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_estadisticas_partidos_partidoId",
                table: "estadisticas",
                column: "partidoId",
                principalTable: "partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_estadisticas_partidos_partidoId",
                table: "estadisticas");

            migrationBuilder.DropIndex(
                name: "IX_estadisticas_partidoId",
                table: "estadisticas");

            migrationBuilder.DropColumn(
                name: "Idpartido",
                table: "estadisticas");

            migrationBuilder.DropColumn(
                name: "partidoId",
                table: "estadisticas");
        }
    }
}
