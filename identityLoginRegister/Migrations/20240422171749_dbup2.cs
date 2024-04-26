using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_AspNetUsers_uploadedById",
                table: "ExportedReferences");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferenceDocuments_AspNetUsers_uploadedById",
                table: "ReferenceDocuments");

            migrationBuilder.DropIndex(
                name: "IX_ReferenceDocuments_uploadedById",
                table: "ReferenceDocuments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70e69c80-1832-4f81-8337-8a69db4bdedc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa450912-97ef-4118-9a59-41f48cd6e4ae");

            migrationBuilder.DropColumn(
                name: "uploadedById",
                table: "ReferenceDocuments");

            migrationBuilder.RenameColumn(
                name: "uploadedById",
                table: "ExportedReferences",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ExportedReferences_uploadedById",
                table: "ExportedReferences",
                newName: "IX_ExportedReferences_UserId");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "ReferenceDocuments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OriginalId",
                table: "ExportedReferences",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "113bf5bc-8ed5-419d-9c74-e28f2b6034b3", null, "Employee", "EMPLOYEE" },
                    { "cf1f45e7-ec77-45be-80e5-79a471225f50", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceDocuments_userId",
                table: "ReferenceDocuments",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportedReferences_OriginalId",
                table: "ExportedReferences",
                column: "OriginalId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_AspNetUsers_UserId",
                table: "ExportedReferences",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_OriginalId",
                table: "ExportedReferences",
                column: "OriginalId",
                principalTable: "ReferenceDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReferenceDocuments_AspNetUsers_userId",
                table: "ReferenceDocuments",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_AspNetUsers_UserId",
                table: "ExportedReferences");

            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_OriginalId",
                table: "ExportedReferences");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferenceDocuments_AspNetUsers_userId",
                table: "ReferenceDocuments");

            migrationBuilder.DropIndex(
                name: "IX_ReferenceDocuments_userId",
                table: "ReferenceDocuments");

            migrationBuilder.DropIndex(
                name: "IX_ExportedReferences_OriginalId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "113bf5bc-8ed5-419d-9c74-e28f2b6034b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1f45e7-ec77-45be-80e5-79a471225f50");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "ReferenceDocuments");

            migrationBuilder.DropColumn(
                name: "OriginalId",
                table: "ExportedReferences");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ExportedReferences",
                newName: "uploadedById");

            migrationBuilder.RenameIndex(
                name: "IX_ExportedReferences_UserId",
                table: "ExportedReferences",
                newName: "IX_ExportedReferences_uploadedById");

            migrationBuilder.AddColumn<string>(
                name: "uploadedById",
                table: "ReferenceDocuments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70e69c80-1832-4f81-8337-8a69db4bdedc", null, "Employee", "EMPLOYEE" },
                    { "aa450912-97ef-4118-9a59-41f48cd6e4ae", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceDocuments_uploadedById",
                table: "ReferenceDocuments",
                column: "uploadedById");

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_AspNetUsers_uploadedById",
                table: "ExportedReferences",
                column: "uploadedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReferenceDocuments_AspNetUsers_uploadedById",
                table: "ReferenceDocuments",
                column: "uploadedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
