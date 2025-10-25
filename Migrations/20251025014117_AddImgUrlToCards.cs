using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorcanaCardCollector.Migrations
{
    /// <inheritdoc />
    public partial class AddImgUrlToCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Collection",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "ID",
                keyValue: "AIR-003",
                column: "ImgUrl",
                value: "https://lorcana-api.com/images/king_stefan/new_father/king_stefan-new_father-large.png");

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "ID",
                keyValue: "ARI-001",
                column: "ImgUrl",
                value: "https://lorcana-api.com/images/rhino/motivational_speaker/rhino-motivational_speaker-large.png");

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "ID",
                keyValue: "ARI-002",
                column: "ImgUrl",
                value: "https://lorcana-api.com/images/perdita/playful_mother/perdita-playful_mother-large.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Collection");
        }
    }
}
