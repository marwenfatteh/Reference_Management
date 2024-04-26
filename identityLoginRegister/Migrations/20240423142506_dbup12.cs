using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1472c3e6-63a0-4a7f-9038-77aa7e96fb1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6378428-a299-409b-82b9-b689ed3ffebd");

            migrationBuilder.AddColumn<byte[]>(
                name: "referenceDocument",
                table: "ReferenceDocuments",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c3b8f73-3333-4e68-9c7f-365451c9f3fe", null, "Employee", "EMPLOYEE" },
                    { "a23dab33-4134-42ec-ad73-67dadebc24b7", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c3b8f73-3333-4e68-9c7f-365451c9f3fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a23dab33-4134-42ec-ad73-67dadebc24b7");

            migrationBuilder.DropColumn(
                name: "referenceDocument",
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
    }
}
