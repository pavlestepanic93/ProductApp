using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApp.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proizvodjac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dobavljac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProizvodId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProizvodId", "Cena", "Dobavljac", "Kategorija", "Naziv", "Opis", "Proizvodjac" },
                values: new object[,]
                {
                    { 1, 2500.0, "Tehnomanija", "Oprema", "Tastatura", "Bezicna", "Logitech" },
                    { 2, 2000.0, "Gigatron", "Oprema", "Mis", "Bezicni", "Logitech" },
                    { 3, 12500.0, "Winwin", "Oprema", "Monitor", "Zicani", "Hp" },
                    { 4, 5500.0, "MusicStudio", "Oprema", "Zvucnici", "Zicani", "Sony" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
