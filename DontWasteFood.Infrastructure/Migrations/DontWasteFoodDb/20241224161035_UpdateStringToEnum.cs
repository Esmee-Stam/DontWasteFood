using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class UpdateStringToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "CanteenWorkerId",
                keyValue: new Guid("dde44693-b0aa-414b-a105-d631e9158887"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("13e6fa87-f2a0-41ee-8b82-c22380a438f8"), new Guid("0b3ec876-7240-4f40-9f0e-937148207b79") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("13e6fa87-f2a0-41ee-8b82-c22380a438f8"), new Guid("135bb552-e394-422b-b848-6a29d6c52083") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("49901b45-ab3a-47ae-9835-d37fe6be9586"), new Guid("275df27f-c998-4870-bf08-9598d64cd766") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("49901b45-ab3a-47ae-9835-d37fe6be9586"), new Guid("ff977bf2-f1e8-4855-ab91-6dae52e940dc") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("a0cff8f0-7981-4219-a0b6-ce500019e5b0"), new Guid("4a7eb8c7-887b-48d0-ad07-d1c0f1072c54") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("b9e2eb0b-c9ba-4247-8168-82b6184eba9f"), new Guid("e16463ba-b001-42ae-a667-03cfaf42c2b9") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cb9eaa6-ad70-4c08-8fa1-32efb6c9e316"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("26ce3003-177e-4479-812a-3140d88bdc0f"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6744b650-1663-49a8-be2a-713f58d23aaf"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8ebceb33-1069-408b-99b4-70a85a441cfd"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("84ec1d54-3271-43cd-a710-b7bde131b404"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("13e6fa87-f2a0-41ee-8b82-c22380a438f8"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("49901b45-ab3a-47ae-9835-d37fe6be9586"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("a0cff8f0-7981-4219-a0b6-ce500019e5b0"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("b9e2eb0b-c9ba-4247-8168-82b6184eba9f"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0b3ec876-7240-4f40-9f0e-937148207b79"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("135bb552-e394-422b-b848-6a29d6c52083"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("275df27f-c998-4870-bf08-9598d64cd766"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4a7eb8c7-887b-48d0-ad07-d1c0f1072c54"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e16463ba-b001-42ae-a667-03cfaf42c2b9"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ff977bf2-f1e8-4855-ab91-6dae52e940dc"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("8436378f-7334-408e-901c-c0d69e1a9cbb"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"));

            migrationBuilder.AlterColumn<int>(
                name: "MealType",
                schema: "DontWasteFood",
                table: "Packages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "CanteenWorkerId",
                keyValue: new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"),
                column: "CanteenId",
                value: new Guid("80b47e9e-7398-411b-bb44-ae0052aeec36"));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "CanteenId", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("2f3b01e4-b715-4d5a-90fc-e9217f23b2d0"), "DB", "Den_Bosch", true },
                    { new Guid("80b47e9e-7398-411b-bb44-ae0052aeec36"), "LA", "Breda", true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "ProductId", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("09c3891f-207e-498e-b3d8-2358e814d301"), true, "Cola", "/images/cola.jpg" },
                    { new Guid("3f8863ee-49c0-45e2-b5e9-c4c94ed52eb8"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" },
                    { new Guid("529e6978-5c79-43a9-b721-d3f4e6bc5565"), false, "Panini Salami", "/images/panini-salami.jpg" },
                    { new Guid("56885c02-efb8-4b19-85ea-a772b779e8bd"), true, "Amstel", "/images/amstel.jpg" },
                    { new Guid("9c611891-a285-4760-a969-280b1c0d33d8"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("a04f585b-c189-4917-9ddf-a622580b4291"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("aa775ff2-e551-420e-840f-b432f1f37e91"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("ad867539-1fd1-403e-91e7-7ae26539a8c9"), false, "Stroopwafel", "/images/stroopwafel.jpg" },
                    { new Guid("d2a1b26e-dcb6-414d-9f7f-f892c6c03748"), false, "Fanta", "/images/fanta.png" },
                    { new Guid("df80ea80-7b4a-4bad-a5e8-719344d0496c"), false, "Broodje gezond", "/images/broodje-gezond.jpg" }
                });

            migrationBuilder.UpdateData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "StudentId", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[] { new Guid("a3c26886-31c7-4468-b6a2-4eca734eaa4d"), "Den_Bosch", new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "CanteenWorkerId", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[] { new Guid("92e85afc-396b-42df-a73f-56eb66532cc8"), new Guid("80b47e9e-7398-411b-bb44-ae0052aeec36"), "7654321", null, "Jan Jansen" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "PackageId", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("66c691cc-0286-4dc8-90cc-87817fa4839e"), new Guid("80b47e9e-7398-411b-bb44-ae0052aeec36"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Gevulde Koek met Fristi", 5.00m, new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dae2b06-8627-46b2-81dd-5b27ed416a43"), new Guid("2f3b01e4-b715-4d5a-90fc-e9217f23b2d0"), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Panini Salami", 4.00m, null, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c177e27-13fb-4b58-96d7-6a3c8f4f1052"), new Guid("2f3b01e4-b715-4d5a-90fc-e9217f23b2d0"), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Broodje Gezond", 3.00m, null, new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e9d4fff-7dab-4cc2-bcf8-66ddc059d117"), new Guid("80b47e9e-7398-411b-bb44-ae0052aeec36"), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Amstel & Stroopwafel", 10.00m, null, new DateTime(2024, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesPackageId", "ProductsProductId", "PackageId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("66c691cc-0286-4dc8-90cc-87817fa4839e"), new Guid("9c611891-a285-4760-a969-280b1c0d33d8"), null, null },
                    { new Guid("66c691cc-0286-4dc8-90cc-87817fa4839e"), new Guid("aa775ff2-e551-420e-840f-b432f1f37e91"), null, null },
                    { new Guid("6dae2b06-8627-46b2-81dd-5b27ed416a43"), new Guid("529e6978-5c79-43a9-b721-d3f4e6bc5565"), null, null },
                    { new Guid("9c177e27-13fb-4b58-96d7-6a3c8f4f1052"), new Guid("df80ea80-7b4a-4bad-a5e8-719344d0496c"), null, null },
                    { new Guid("9e9d4fff-7dab-4cc2-bcf8-66ddc059d117"), new Guid("56885c02-efb8-4b19-85ea-a772b779e8bd"), null, null },
                    { new Guid("9e9d4fff-7dab-4cc2-bcf8-66ddc059d117"), new Guid("ad867539-1fd1-403e-91e7-7ae26539a8c9"), null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "CanteenWorkerId",
                keyValue: new Guid("92e85afc-396b-42df-a73f-56eb66532cc8"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("66c691cc-0286-4dc8-90cc-87817fa4839e"), new Guid("9c611891-a285-4760-a969-280b1c0d33d8") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("66c691cc-0286-4dc8-90cc-87817fa4839e"), new Guid("aa775ff2-e551-420e-840f-b432f1f37e91") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("6dae2b06-8627-46b2-81dd-5b27ed416a43"), new Guid("529e6978-5c79-43a9-b721-d3f4e6bc5565") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("9c177e27-13fb-4b58-96d7-6a3c8f4f1052"), new Guid("df80ea80-7b4a-4bad-a5e8-719344d0496c") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("9e9d4fff-7dab-4cc2-bcf8-66ddc059d117"), new Guid("56885c02-efb8-4b19-85ea-a772b779e8bd") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("9e9d4fff-7dab-4cc2-bcf8-66ddc059d117"), new Guid("ad867539-1fd1-403e-91e7-7ae26539a8c9") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("09c3891f-207e-498e-b3d8-2358e814d301"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3f8863ee-49c0-45e2-b5e9-c4c94ed52eb8"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a04f585b-c189-4917-9ddf-a622580b4291"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2a1b26e-dcb6-414d-9f7f-f892c6c03748"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a3c26886-31c7-4468-b6a2-4eca734eaa4d"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("66c691cc-0286-4dc8-90cc-87817fa4839e"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("6dae2b06-8627-46b2-81dd-5b27ed416a43"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("9c177e27-13fb-4b58-96d7-6a3c8f4f1052"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("9e9d4fff-7dab-4cc2-bcf8-66ddc059d117"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("529e6978-5c79-43a9-b721-d3f4e6bc5565"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("56885c02-efb8-4b19-85ea-a772b779e8bd"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9c611891-a285-4760-a969-280b1c0d33d8"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa775ff2-e551-420e-840f-b432f1f37e91"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ad867539-1fd1-403e-91e7-7ae26539a8c9"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("df80ea80-7b4a-4bad-a5e8-719344d0496c"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("2f3b01e4-b715-4d5a-90fc-e9217f23b2d0"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("80b47e9e-7398-411b-bb44-ae0052aeec36"));

            migrationBuilder.AlterColumn<string>(
                name: "MealType",
                schema: "DontWasteFood",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "CanteenWorkerId",
                keyValue: new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"),
                column: "CanteenId",
                value: new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"));

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

            migrationBuilder.UpdateData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"),
                column: "DateOfBirth",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "StudentId", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[] { new Guid("84ec1d54-3271-43cd-a710-b7bde131b404"), "Den_Bosch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "CanteenWorkerId", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[] { new Guid("dde44693-b0aa-414b-a105-d631e9158887"), new Guid("f2b032c4-6ae9-4d93-a113-39739aa7798f"), "7654321", null, "Jan Jansen" });

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
        }
    }
}
