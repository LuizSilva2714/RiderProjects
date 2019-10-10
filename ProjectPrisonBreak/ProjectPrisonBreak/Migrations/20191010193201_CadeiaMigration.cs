using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPrisonBreak.Migrations
{
    public partial class CadeiaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadeias",
                columns: table => new
                {
                    CadeiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Nivel = table.Column<int>(nullable: false),
                    Capacidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadeias", x => x.CadeiaId);
                });

            migrationBuilder.CreateTable(
                name: "Bandidos",
                columns: table => new
                {
                    BandidoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Capivara = table.Column<string>(nullable: true),
                    Vulgo = table.Column<string>(nullable: true),
                    ReuPrimario = table.Column<bool>(nullable: false),
                    CadeiaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandidos", x => x.BandidoId);
                    table.ForeignKey(
                        name: "FK_Bandidos_Cadeias_CadeiaId",
                        column: x => x.CadeiaId,
                        principalTable: "Cadeias",
                        principalColumn: "CadeiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bandidos_CadeiaId",
                table: "Bandidos",
                column: "CadeiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bandidos");

            migrationBuilder.DropTable(
                name: "Cadeias");
        }
    }
}
