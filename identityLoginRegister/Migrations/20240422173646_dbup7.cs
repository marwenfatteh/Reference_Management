using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_AspNetUsers_UserId",
                table: "ExportedReferences");

            migrationBuilder.DropIndex(
                name: "IX_ExportedReferences_UserId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e66d045-1b25-4fcc-805e-e19fedd8190d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5092a07-cec4-43f4-bcbe-8c3569ec6d3e");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExportedReferences");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1315be19-e7f7-4114-88d0-01386cb54eaa", null, "Admin", "ADMIN" },
                    { "9ed917ad-1d75-4554-813d-bbc7247dfff3", null, "Employee", "EMPLOYEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1315be19-e7f7-4114-88d0-01386cb54eaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ed917ad-1d75-4554-813d-bbc7247dfff3");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ExportedReferences",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e66d045-1b25-4fcc-805e-e19fedd8190d", null, "Employee", "EMPLOYEE" },
                    { "e5092a07-cec4-43f4-bcbe-8c3569ec6d3e", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportedReferences_UserId",
                table: "ExportedReferences",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_AspNetUsers_UserId",
                table: "ExportedReferences",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
