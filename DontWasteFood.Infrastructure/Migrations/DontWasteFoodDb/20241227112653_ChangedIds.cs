using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class ChangedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DontWasteFood");

            migrationBuilder.CreateTable(
                name: "Canteens",
                schema: "DontWasteFood",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    CanteenLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotMealsOffer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canteens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "DontWasteFood",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAlcoholic = table.Column<bool>(type: "bit", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "DontWasteFood",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentNumber = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CanteenWorkers",
                schema: "DontWasteFood",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanteenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanteenWorkers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CanteenWorkers_Canteens_CanteenId",
                        column: x => x.CanteenId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Canteens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                schema: "DontWasteFood",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfPickUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfPickUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Is18Plus = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CanteenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_Canteens_CanteenId",
                        column: x => x.CanteenId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Canteens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Students_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PackageProduct",
                schema: "DontWasteFood",
                columns: table => new
                {
                    PackagesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageProduct", x => new { x.PackagesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_PackageProduct_Packages_PackagesId",
                        column: x => x.PackagesId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "Id", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"), "LA", 0, true },
                    { new Guid("df310e40-acd3-49b0-911a-94ae12c53b32"), "DB", 1, true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "Id", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("1678cba3-1c99-4f15-8583-56b197b54693"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("2a8e51a3-7c1d-4cde-aad9-f5e633522cd3"), false, "Stroopwafel", "/images/stroopwafel.jpg" },
                    { new Guid("3d7d5038-343d-45f2-a2b8-b9bd4e47e954"), false, "Broodje gezond", "/images/broodje-gezond.jpg" },
                    { new Guid("5d5ccd73-c672-4cf3-b400-e7c149527a71"), false, "Panini Salami", "/images/panini-salami.jpg" },
                    { new Guid("65a67986-2a3c-4d78-bf5f-d8d67e53cc53"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" },
                    { new Guid("70614a29-79cc-4281-8234-6b24a84d9a4b"), true, "Amstel", "/images/amstel.jpg" },
                    { new Guid("7fd05664-8451-4923-9f93-6746a1d801f9"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("8296acc7-5300-406f-b00d-e017ea5d2de6"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("f561d211-0029-4ced-bf80-55f14c2a33a5"), true, "Cola", "/images/cola.jpg" },
                    { new Guid("fccbf2e2-ce94-4301-8ec5-367ca2f3916d"), false, "Fanta", "/images/fanta.png" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "Id", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[,]
                {
                    { new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), 0, new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "el.stam@student.avans.nl", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e", "Esmée Stam", null, "2196911" },
                    { new Guid("cf43c7ca-7546-4645-ba45-6ed790ca486a"), 1, new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "Id", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("13e30a51-4f97-456b-9697-b0e9cc0818f2"), new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"), "7654321", null, "Jan Jansen" },
                    { new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"), new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"), "1234567", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f", "John Doe" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "Id", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("6c487ef0-d53b-4ce0-9587-5253646eb4d4"), new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Gevulde Koek met Fristi", 5.00m, new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8f6cf81-fbff-40a7-80f2-e2f0f0491f67"), new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Amstel & Stroopwafel", 10.00m, null, new DateTime(2024, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4f925ce-107f-4b27-b666-ed7644e48dec"), new Guid("df310e40-acd3-49b0-911a-94ae12c53b32"), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Broodje Gezond", 3.00m, null, new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0f36860-035a-4a22-b94f-dd8972ac36c1"), new Guid("df310e40-acd3-49b0-911a-94ae12c53b32"), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Panini Salami", 4.00m, null, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesId", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("6c487ef0-d53b-4ce0-9587-5253646eb4d4"), new Guid("1678cba3-1c99-4f15-8583-56b197b54693") },
                    { new Guid("6c487ef0-d53b-4ce0-9587-5253646eb4d4"), new Guid("8296acc7-5300-406f-b00d-e017ea5d2de6") },
                    { new Guid("a8f6cf81-fbff-40a7-80f2-e2f0f0491f67"), new Guid("2a8e51a3-7c1d-4cde-aad9-f5e633522cd3") },
                    { new Guid("a8f6cf81-fbff-40a7-80f2-e2f0f0491f67"), new Guid("70614a29-79cc-4281-8234-6b24a84d9a4b") },
                    { new Guid("e4f925ce-107f-4b27-b666-ed7644e48dec"), new Guid("3d7d5038-343d-45f2-a2b8-b9bd4e47e954") },
                    { new Guid("f0f36860-035a-4a22-b94f-dd8972ac36c1"), new Guid("5d5ccd73-c672-4cf3-b400-e7c149527a71") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanteenWorkers_CanteenId",
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                column: "CanteenId");

            migrationBuilder.CreateIndex(
                name: "IX_CanteenWorkers_EmployeeNumber",
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                column: "EmployeeNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackageProduct_ProductsId",
                schema: "DontWasteFood",
                table: "PackageProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_CanteenId",
                schema: "DontWasteFood",
                table: "Packages",
                column: "CanteenId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_StudentId",
                schema: "DontWasteFood",
                table: "Packages",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_EmailAddress",
                schema: "DontWasteFood",
                table: "Students",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentNumber",
                schema: "DontWasteFood",
                table: "Students",
                column: "StudentNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanteenWorkers",
                schema: "DontWasteFood");

            migrationBuilder.DropTable(
                name: "PackageProduct",
                schema: "DontWasteFood");

            migrationBuilder.DropTable(
                name: "Packages",
                schema: "DontWasteFood");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "DontWasteFood");

            migrationBuilder.DropTable(
                name: "Canteens",
                schema: "DontWasteFood");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "DontWasteFood");
        }
    }
}
