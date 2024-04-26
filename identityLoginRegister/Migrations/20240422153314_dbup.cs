using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityLoginRegister.Migrations
{
    /// <inheritdoc />
    public partial class dbup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba2801e2-d7cb-484d-8815-de6539179092");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f615ee58-9491-4348-a527-99e10ddc43d0");

            migrationBuilder.CreateTable(
                name: "ExportedReferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tech = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uploadedById = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportedReferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExportedReferences_AspNetUsers_uploadedById",
                        column: x => x.uploadedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReferenceDocuments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uploadedById = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferenceDocuments_AspNetUsers_uploadedById",
                        column: x => x.uploadedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70e69c80-1832-4f81-8337-8a69db4bdedc", null, "Employee", "EMPLOYEE" },
                    { "aa450912-97ef-4118-9a59-41f48cd6e4ae", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportedReferences_uploadedById",
                table: "ExportedReferences",
                column: "uploadedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceDocuments_uploadedById",
                table: "ReferenceDocuments",
                column: "uploadedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportedReferences");

            migrationBuilder.DropTable(
                name: "ReferenceDocuments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70e69c80-1832-4f81-8337-8a69db4bdedc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa450912-97ef-4118-9a59-41f48cd6e4ae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ba2801e2-d7cb-484d-8815-de6539179092", null, "Employee", "EMPLOYEE" },
                    { "f615ee58-9491-4348-a527-99e10ddc43d0", null, "Admin", "ADMIN" }
                });
        }
    }
}
