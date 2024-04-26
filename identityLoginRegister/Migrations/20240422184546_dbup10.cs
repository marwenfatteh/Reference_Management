using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_originalId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17b17c91-f601-46b2-a60e-65443a217866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d69e23d-677c-424f-8b53-4fb20e25524d");

            migrationBuilder.RenameColumn(
                name: "originalId",
                table: "ExportedReferences",
                newName: "referenceDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_ExportedReferences_originalId",
                table: "ExportedReferences",
                newName: "IX_ExportedReferences_referenceDocumentId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "988a6f34-822f-40ca-97ed-cd882b94498c", null, "Admin", "ADMIN" },
                    { "ba865584-a0d9-4f49-ab49-9f1e0832f53d", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_referenceDocumentId",
                table: "ExportedReferences",
                column: "referenceDocumentId",
                principalTable: "ReferenceDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_referenceDocumentId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "988a6f34-822f-40ca-97ed-cd882b94498c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba865584-a0d9-4f49-ab49-9f1e0832f53d");

            migrationBuilder.RenameColumn(
                name: "referenceDocumentId",
                table: "ExportedReferences",
                newName: "originalId");

            migrationBuilder.RenameIndex(
                name: "IX_ExportedReferences_referenceDocumentId",
                table: "ExportedReferences",
                newName: "IX_ExportedReferences_originalId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17b17c91-f601-46b2-a60e-65443a217866", null, "Admin", "ADMIN" },
                    { "7d69e23d-677c-424f-8b53-4fb20e25524d", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_originalId",
                table: "ExportedReferences",
                column: "originalId",
                principalTable: "ReferenceDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
