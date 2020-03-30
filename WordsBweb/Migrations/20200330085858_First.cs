using Microsoft.EntityFrameworkCore.Migrations;

namespace WordsBweb.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WordsA",
                columns: table => new
                {
                    WordsID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WordEng = table.Column<string>(nullable: true),
                    WordPol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordsA", x => x.WordsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordsA");
        }
    }
}
