using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "113bf5bc-8ed5-419d-9c74-e28f2b6034b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1f45e7-ec77-45be-80e5-79a471225f50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50a73d96-c390-4d48-b4ae-b07f26af0c65", null, "Admin", "ADMIN" },
                    { "58e42e9d-2b7c-4299-a001-ce317deb9430", null, "Employee", "EMPLOYEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a73d96-c390-4d48-b4ae-b07f26af0c65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58e42e9d-2b7c-4299-a001-ce317deb9430");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "113bf5bc-8ed5-419d-9c74-e28f2b6034b3", null, "Employee", "EMPLOYEE" },
                    { "cf1f45e7-ec77-45be-80e5-79a471225f50", null, "Admin", "ADMIN" }
                });
        }
    }
}
