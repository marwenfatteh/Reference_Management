using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "988a6f34-822f-40ca-97ed-cd882b94498c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba865584-a0d9-4f49-ab49-9f1e0832f53d");

            migrationBuilder.DropColumn(
                name: "exportedReferenceId",
                table: "ReferenceDocuments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1472c3e6-63a0-4a7f-9038-77aa7e96fb1d", null, "Admin", "ADMIN" },
                    { "f6378428-a299-409b-82b9-b689ed3ffebd", null, "Employee", "EMPLOYEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1472c3e6-63a0-4a7f-9038-77aa7e96fb1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6378428-a299-409b-82b9-b689ed3ffebd");

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
                    { "988a6f34-822f-40ca-97ed-cd882b94498c", null, "Admin", "ADMIN" },
                    { "ba865584-a0d9-4f49-ab49-9f1e0832f53d", null, "Employee", "EMPLOYEE" }
                });
        }
    }
}
