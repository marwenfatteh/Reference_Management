using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1315be19-e7f7-4114-88d0-01386cb54eaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ed917ad-1d75-4554-813d-bbc7247dfff3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81008219-52e5-44c6-b305-9a0f5f75088a", null, "Employee", "EMPLOYEE" },
                    { "ce40f84e-4efd-4934-ae42-a0065a0812e6", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81008219-52e5-44c6-b305-9a0f5f75088a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce40f84e-4efd-4934-ae42-a0065a0812e6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1315be19-e7f7-4114-88d0-01386cb54eaa", null, "Admin", "ADMIN" },
                    { "9ed917ad-1d75-4554-813d-bbc7247dfff3", null, "Employee", "EMPLOYEE" }
                });
        }
    }
}
