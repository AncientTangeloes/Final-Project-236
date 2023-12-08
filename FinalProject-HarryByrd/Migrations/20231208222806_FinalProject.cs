using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject_HarryByrd.Migrations
{
    /// <inheritdoc />
    public partial class FinalProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    InstrumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.InstrumentId);
                    table.ForeignKey(
                        name: "FK_Instruments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "B", "Brass" },
                    { "H", "Hybrid" },
                    { "K", "Keyboard" },
                    { "M", "Misc" },
                    { "N", "Psudeoinstrument" },
                    { "P", "Percussion" },
                    { "S", "String" },
                    { "W", "Woodwind" }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "CategoryId", "Description", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "N", "Organ Pipe Mud Dauber nests look like pan flutes. Woah.", "Organ Pipe Mud Dauber's Nest", "45,000,000 BC" },
                    { 2, "H", "Product of string and brass copulation.", "Stroviol", "1899" },
                    { 3, "S", "Banjo, but big.", "Cello Banjo", "1889" },
                    { 4, "B", "Saxy figure, trumpet mechanics, two horns, one with built-in wah wah.", "Jazzophone", "1920" },
                    { 5, "B", "Trombone-like mouthpiece, woodwind-like tone holes, long curvy body. Snake? Snake?! SNAAAAAAAAAAKE!", "Serpent", "1590" },
                    { 6, "S", "Violin, but three-player.", "Triolin", "1991" },
                    { 7, "H", "Half euphonium, half lyre, half toilet.", "Loophonium", "1960" },
                    { 8, "M", "It's a theremin inside a badger.", "Badgermin", "2011" },
                    { 9, "W", "Flute, but REALLY big 4.", "Hyperbass Flute", "2001" },
                    { 10, "S", "42-stringed multi-necked guitar.", "Pikasso Guitar", "1984" },
                    { 11, "P", "Stiff bent wire, one end wooden ball, the other end hollow wooden box with loose metal \"teeth\". Smack ball to rattle.", "Vibraslap", "1967" },
                    { 12, "P", "Ancestor to the vibraslap, just a fuckin jawbone of a beast of burden or related species. Still smack to rattle.", "Quijada", "55,000,000 BC" },
                    { 13, "K", "A 3.5-acre electrically acutated lithophone in Luray Caverns, Virginia. Tap keys at the console, stalactites get tapped.", "The Great Stalacpipe Organ", "1956" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_CategoryId",
                table: "Instruments",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
