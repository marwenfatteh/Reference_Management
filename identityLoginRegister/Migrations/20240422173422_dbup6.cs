using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29184cd1-34a9-4d4b-b21f-c7bc74a6ead3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60d09a45-13cf-4eab-99f0-022715991c93");

            migrationBuilder.AddColumn<string>(
                name: "exportedReferenceId",
                table: "ReferenceDocuments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e66d045-1b25-4fcc-805e-e19fedd8190d", null, "Employee", "EMPLOYEE" },
                    { "e5092a07-cec4-43f4-bcbe-8c3569ec6d3e", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e66d045-1b25-4fcc-805e-e19fedd8190d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5092a07-cec4-43f4-bcbe-8c3569ec6d3e");

            migrationBuilder.DropColumn(
                name: "exportedReferenceId",
                table: "ReferenceDocuments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29184cd1-34a9-4d4b-b21f-c7bc74a6ead3", null, "Admin", "ADMIN" },
                    { "60d09a45-13cf-4eab-99f0-022715991c93", null, "Employee", "EMPLOYEE" }
                });
        }
    }
}
