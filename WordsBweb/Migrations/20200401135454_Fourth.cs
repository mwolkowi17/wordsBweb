using Microsoft.EntityFrameworkCore.Migrations;

namespace WordsBweb.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Przyklady",
                columns: table => new
                {
                    PrzykladID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NrPrzyklad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przyklady", x => x.PrzykladID);
                });

            migrationBuilder.CreateTable(
                name: "PunktyBaza",
                columns: table => new
                {
                    PunktyID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NrPunkty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PunktyBaza", x => x.PunktyID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Przyklady");

            migrationBuilder.DropTable(
                name: "PunktyBaza");
        }
    }
}
