using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Cards",
                type: "longtext",
                nullable: true,
                defaultValue: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR5QnnpQTGXTJUmRbOcpI3mV8QR9sP8OhH4BQ&s",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "ImgUrl",
                keyValue: null,
                column: "ImgUrl",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Cards",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true,
                oldDefaultValue: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR5QnnpQTGXTJUmRbOcpI3mV8QR9sP8OhH4BQ&s")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
