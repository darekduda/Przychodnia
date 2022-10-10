using Microsoft.EntityFrameworkCore.Migrations;

namespace Przychodnia.Intranet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktualnosc",
                columns: table => new
                {
                    IdAktualnosci = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTytul = table.Column<string>(nullable: false),
                    Tytul = table.Column<string>(nullable: false),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Pozycja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktualnosc", x => x.IdAktualnosci);
                });

            migrationBuilder.CreateTable(
                name: "Parametr",
                columns: table => new
                {
                    IdAktualnosci = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(nullable: false),
                    Nazwa = table.Column<string>(nullable: false),
                    Wartosc = table.Column<string>(nullable: false),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametr", x => x.IdAktualnosci);
                });

            migrationBuilder.CreateTable(
                name: "Strona",
                columns: table => new
                {
                    IdStrony = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTytul = table.Column<string>(nullable: false),
                    Tytul = table.Column<string>(nullable: false),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Pozycja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strona", x => x.IdStrony);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktualnosc");

            migrationBuilder.DropTable(
                name: "Parametr");

            migrationBuilder.DropTable(
                name: "Strona");
        }
    }
}
