using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    CanteenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanteenLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotMealsOffer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canteens", x => x.CanteenId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "DontWasteFood",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAlcoholic = table.Column<bool>(type: "bit", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "DontWasteFood",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentNumber = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "CanteenWorkers",
                schema: "DontWasteFood",
                columns: table => new
                {
                    CanteenWorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanteenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanteenWorkers", x => x.CanteenWorkerId);
                    table.ForeignKey(
                        name: "FK_CanteenWorkers_Canteens_CanteenId",
                        column: x => x.CanteenId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Canteens",
                        principalColumn: "CanteenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                schema: "DontWasteFood",
                columns: table => new
                {
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfPickUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfPickUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Is18Plus = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CanteenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_Packages_Canteens_CanteenId",
                        column: x => x.CanteenId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Canteens",
                        principalColumn: "CanteenId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Students_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Students",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "PackageProduct",
                schema: "DontWasteFood",
                columns: table => new
                {
                    PackagesPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageProduct", x => new { x.PackagesPackageId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_PackageProduct_Packages_PackageId",
                        column: x => x.PackageId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageProduct_Packages_PackagesPackageId",
                        column: x => x.PackagesPackageId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalSchema: "DontWasteFood",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "CanteenId", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("8436378f-7334-408e-901c-c0d69e1a9cbb"), "DB", "Den_Bosch", true },
                    { new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"), "LA", "Breda", true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "ProductId", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("0b3ec876-7240-4f40-9f0e-937148207b79"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("135bb552-e394-422b-b848-6a29d6c52083"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("1cb9eaa6-ad70-4c08-8fa1-32efb6c9e316"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("26ce3003-177e-4479-812a-3140d88bdc0f"), false, "Fanta", "/images/fanta.png" },
                    { new Guid("275df27f-c998-4870-bf08-9598d64cd766"), true, "Amstel", "/images/amstel.jpg" },
                    { new Guid("4a7eb8c7-887b-48d0-ad07-d1c0f1072c54"), false, "Broodje gezond", "/images/broodje-gezond.jpg" },
                    { new Guid("6744b650-1663-49a8-be2a-713f58d23aaf"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" },
                    { new Guid("8ebceb33-1069-408b-99b4-70a85a441cfd"), true, "Cola", "/images/cola.jpg" },
                    { new Guid("e16463ba-b001-42ae-a667-03cfaf42c2b9"), false, "Panini Salami", "/images/panini-salami.jpg" },
                    { new Guid("ff977bf2-f1e8-4855-ab91-6dae52e940dc"), false, "Stroopwafel", "/images/stroopwafel.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "StudentId", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[,]
                {
                    { new Guid("84ec1d54-3271-43cd-a710-b7bde131b404"), "Den_Bosch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" },
                    { new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), "Breda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "el.stam@student.avans.nl", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e", "Esmée Stam", null, "2196911" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "CanteenWorkerId", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"), new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"), "1234567", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f", "John Doe" },
                    { new Guid("dde44693-b0aa-414b-a105-d631e9158887"), new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"), "7654321", null, "Jan Jansen" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "PackageId", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("13e6fa87-f2a0-41ee-8b82-c22380a438f8"), new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Anders", "Gevulde Koek met Fristi", 5.00m, new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49901b45-ab3a-47ae-9835-d37fe6be9586"), new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Drank", "Amstel & Stroopwafel", 10.00m, null, new DateTime(2024, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0cff8f0-7981-4219-a0b6-ce500019e5b0"), new Guid("8436378f-7334-408e-901c-c0d69e1a9cbb"), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Brood", "Broodje Gezond", 3.00m, null, new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9e2eb0b-c9ba-4247-8168-82b6184eba9f"), new Guid("8436378f-7334-408e-901c-c0d69e1a9cbb"), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Brood", "Panini Salami", 4.00m, null, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesPackageId", "ProductsProductId", "PackageId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("13e6fa87-f2a0-41ee-8b82-c22380a438f8"), new Guid("0b3ec876-7240-4f40-9f0e-937148207b79"), null, null },
                    { new Guid("13e6fa87-f2a0-41ee-8b82-c22380a438f8"), new Guid("135bb552-e394-422b-b848-6a29d6c52083"), null, null },
                    { new Guid("49901b45-ab3a-47ae-9835-d37fe6be9586"), new Guid("275df27f-c998-4870-bf08-9598d64cd766"), null, null },
                    { new Guid("49901b45-ab3a-47ae-9835-d37fe6be9586"), new Guid("ff977bf2-f1e8-4855-ab91-6dae52e940dc"), null, null },
                    { new Guid("a0cff8f0-7981-4219-a0b6-ce500019e5b0"), new Guid("4a7eb8c7-887b-48d0-ad07-d1c0f1072c54"), null, null },
                    { new Guid("b9e2eb0b-c9ba-4247-8168-82b6184eba9f"), new Guid("e16463ba-b001-42ae-a667-03cfaf42c2b9"), null, null }
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
                name: "IX_PackageProduct_PackageId",
                schema: "DontWasteFood",
                table: "PackageProduct",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageProduct_ProductId",
                schema: "DontWasteFood",
                table: "PackageProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageProduct_ProductsProductId",
                schema: "DontWasteFood",
                table: "PackageProduct",
                column: "ProductsProductId");

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
