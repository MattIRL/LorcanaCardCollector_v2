using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LorcanaCardCollector.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collection",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GemColor = table.Column<int>(type: "int", nullable: false),
                    SetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    InADeck = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collection", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Collection",
                columns: new[] { "ID", "CardName", "GemColor", "InADeck", "Quantity", "SetName" },
                values: new object[,]
                {
                    { 1, "Rhino - Motivational Speaker", 10, true, 1, "Archazia's Island" },
                    { 2, "Perdita - Playful Mother", 9, false, 1, "Archazia's Island" },
                    { 3, "King Stefan - New Father", 0, true, 2, "Archazilia's Island" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collection");
        }
    }
}
