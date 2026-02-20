using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class finaly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Colors_ColorId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ColroId",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ColorId",
                value: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Colors_ColorId",
                table: "Cards",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Colors_ColorId",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ColroId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "ColroId" },
                values: new object[] { null, 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Colors_ColorId",
                table: "Cards",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id");
        }
    }
}
