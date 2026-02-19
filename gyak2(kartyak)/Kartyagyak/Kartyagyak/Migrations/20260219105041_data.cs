using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartyagyak.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "Name" },
                values: new object[] { 4, "Yellow" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "ColorId", "Description", "ImgUrl", "Name" },
                values: new object[] { 1, 4, "Awakening of the New Era", "https://optcgapi.com/media/static/Card_Images/OP05-119.jpg", "Monkey.D.Luffy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 4);
        }
    }
}
