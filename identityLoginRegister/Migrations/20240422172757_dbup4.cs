using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_OriginalId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a73d96-c390-4d48-b4ae-b07f26af0c65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58e42e9d-2b7c-4299-a001-ce317deb9430");

            migrationBuilder.RenameColumn(
                name: "OriginalId",
                table: "ExportedReferences",
                newName: "originalId");

            migrationBuilder.RenameIndex(
                name: "IX_ExportedReferences_OriginalId",
                table: "ExportedReferences",
                newName: "IX_ExportedReferences_originalId");

            migrationBuilder.AlterColumn<string>(
                name: "originalId",
                table: "ExportedReferences",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29bc978d-6302-43bd-84b2-566326207708", null, "Admin", "ADMIN" },
                    { "3bd2f61c-f1a2-4ecb-98fb-498917054ed7", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_originalId",
                table: "ExportedReferences",
                column: "originalId",
                principalTable: "ReferenceDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_originalId",
                table: "ExportedReferences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29bc978d-6302-43bd-84b2-566326207708");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bd2f61c-f1a2-4ecb-98fb-498917054ed7");

            migrationBuilder.RenameColumn(
                name: "originalId",
                table: "ExportedReferences",
                newName: "OriginalId");

            migrationBuilder.RenameIndex(
                name: "IX_ExportedReferences_originalId",
                table: "ExportedReferences",
                newName: "IX_ExportedReferences_OriginalId");

            migrationBuilder.AlterColumn<string>(
                name: "OriginalId",
                table: "ExportedReferences",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50a73d96-c390-4d48-b4ae-b07f26af0c65", null, "Admin", "ADMIN" },
                    { "58e42e9d-2b7c-4299-a001-ce317deb9430", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExportedReferences_ReferenceDocuments_OriginalId",
                table: "ExportedReferences",
                column: "OriginalId",
                principalTable: "ReferenceDocuments",
                principalColumn: "Id");
        }
    }
}
