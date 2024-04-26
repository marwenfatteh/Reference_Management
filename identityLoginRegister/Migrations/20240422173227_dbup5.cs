using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExportedReferences_originalId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29bc978d-6302-43bd-84b2-566326207708");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bd2f61c-f1a2-4ecb-98fb-498917054ed7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29184cd1-34a9-4d4b-b21f-c7bc74a6ead3", null, "Admin", "ADMIN" },
                    { "60d09a45-13cf-4eab-99f0-022715991c93", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportedReferences_originalId",
                table: "ExportedReferences",
                column: "originalId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExportedReferences_originalId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29184cd1-34a9-4d4b-b21f-c7bc74a6ead3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60d09a45-13cf-4eab-99f0-022715991c93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29bc978d-6302-43bd-84b2-566326207708", null, "Admin", "ADMIN" },
                    { "3bd2f61c-f1a2-4ecb-98fb-498917054ed7", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportedReferences_originalId",
                table: "ExportedReferences",
                column: "originalId");
        }
    }
}
