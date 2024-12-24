using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class UpdateCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "CanteenWorkerId",
                keyValue: new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"),
                column: "CanteenId",
                value: new Guid("4be48778-d81a-4eb5-bd1c-553f546a5966"));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "CanteenId", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("01086a90-ff33-4d5b-9b49-9cbbb6291efa"), "DB", "Den Bosch", true },
                    { new Guid("4be48778-d81a-4eb5-bd1c-553f546a5966"), "LA", "Breda", true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "ProductId", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("1a3c84e8-ef8f-4070-b1e9-d8da5c51f4de"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("2b24029b-ca23-41e0-946c-c65751b83ba5"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("4d6fbfb7-f701-4a3a-96f5-2328d5ad3e9b"), false, "Fanta", "/images/fanta.png" },
                    { new Guid("6af0b603-68a1-429d-b614-8e50f3aa2231"), false, "Stroopwafel", "/images/stroopwafel.jpg" },
                    { new Guid("7dec6dc3-029a-41f3-89da-d535b213afd5"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("88288629-2bfe-46a2-973e-175ff977fb99"), true, "Amstel", "/images/amstel.jpg" },
                    { new Guid("af827f12-12ee-475b-95d4-f2bb164993b5"), true, "Cola", "/images/cola.jpg" },
                    { new Guid("d86c27f0-daa1-4546-9a98-3df8bdab4229"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" },
                    { new Guid("f3054f1f-f875-4e12-b891-7314711b0627"), false, "Broodje gezond", "/images/broodje-gezond.jpg" },
                    { new Guid("fdbe441a-2d9b-44ef-8d95-d087785d7c02"), false, "Panini Salami", "/images/panini-salami.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "StudentId", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[] { new Guid("10a8c01b-7df8-42ca-bc43-7473dd6d4df4"), "Den_Bosch", new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "CanteenWorkerId", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[] { new Guid("5f1e9cbc-9748-4e28-b7cc-b6d52ace34c7"), new Guid("4be48778-d81a-4eb5-bd1c-553f546a5966"), "7654321", null, "Jan Jansen" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "PackageId", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("09051bc9-81fb-438d-9ffa-e0dab29213d0"), new Guid("4be48778-d81a-4eb5-bd1c-553f546a5966"), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Amstel & Stroopwafel", 10.00m, null, new DateTime(2024, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20ee797e-8930-41d9-841e-acf3659640e1"), new Guid("01086a90-ff33-4d5b-9b49-9cbbb6291efa"), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Panini Salami", 4.00m, null, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8afc3f7f-0452-4db5-a0a3-6de0802419c1"), new Guid("01086a90-ff33-4d5b-9b49-9cbbb6291efa"), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Broodje Gezond", 3.00m, null, new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5305b5a-ec00-4626-925f-901f9b61bbf8"), new Guid("4be48778-d81a-4eb5-bd1c-553f546a5966"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Gevulde Koek met Fristi", 5.00m, new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesPackageId", "ProductsProductId", "PackageId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("09051bc9-81fb-438d-9ffa-e0dab29213d0"), new Guid("6af0b603-68a1-429d-b614-8e50f3aa2231"), null, null },
                    { new Guid("09051bc9-81fb-438d-9ffa-e0dab29213d0"), new Guid("88288629-2bfe-46a2-973e-175ff977fb99"), null, null },
                    { new Guid("20ee797e-8930-41d9-841e-acf3659640e1"), new Guid("fdbe441a-2d9b-44ef-8d95-d087785d7c02"), null, null },
                    { new Guid("8afc3f7f-0452-4db5-a0a3-6de0802419c1"), new Guid("f3054f1f-f875-4e12-b891-7314711b0627"), null, null },
                    { new Guid("a5305b5a-ec00-4626-925f-901f9b61bbf8"), new Guid("2b24029b-ca23-41e0-946c-c65751b83ba5"), null, null },
                    { new Guid("a5305b5a-ec00-4626-925f-901f9b61bbf8"), new Guid("7dec6dc3-029a-41f3-89da-d535b213afd5"), null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "CanteenWorkerId",
                keyValue: new Guid("5f1e9cbc-9748-4e28-b7cc-b6d52ace34c7"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("09051bc9-81fb-438d-9ffa-e0dab29213d0"), new Guid("6af0b603-68a1-429d-b614-8e50f3aa2231") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("09051bc9-81fb-438d-9ffa-e0dab29213d0"), new Guid("88288629-2bfe-46a2-973e-175ff977fb99") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("20ee797e-8930-41d9-841e-acf3659640e1"), new Guid("fdbe441a-2d9b-44ef-8d95-d087785d7c02") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("8afc3f7f-0452-4db5-a0a3-6de0802419c1"), new Guid("f3054f1f-f875-4e12-b891-7314711b0627") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("a5305b5a-ec00-4626-925f-901f9b61bbf8"), new Guid("2b24029b-ca23-41e0-946c-c65751b83ba5") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("a5305b5a-ec00-4626-925f-901f9b61bbf8"), new Guid("7dec6dc3-029a-41f3-89da-d535b213afd5") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1a3c84e8-ef8f-4070-b1e9-d8da5c51f4de"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4d6fbfb7-f701-4a3a-96f5-2328d5ad3e9b"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af827f12-12ee-475b-95d4-f2bb164993b5"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d86c27f0-daa1-4546-9a98-3df8bdab4229"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("10a8c01b-7df8-42ca-bc43-7473dd6d4df4"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("09051bc9-81fb-438d-9ffa-e0dab29213d0"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("20ee797e-8930-41d9-841e-acf3659640e1"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("8afc3f7f-0452-4db5-a0a3-6de0802419c1"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("a5305b5a-ec00-4626-925f-901f9b61bbf8"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2b24029b-ca23-41e0-946c-c65751b83ba5"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6af0b603-68a1-429d-b614-8e50f3aa2231"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7dec6dc3-029a-41f3-89da-d535b213afd5"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("88288629-2bfe-46a2-973e-175ff977fb99"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f3054f1f-f875-4e12-b891-7314711b0627"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fdbe441a-2d9b-44ef-8d95-d087785d7c02"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("01086a90-ff33-4d5b-9b49-9cbbb6291efa"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("4be48778-d81a-4eb5-bd1c-553f546a5966"));

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
    }
}
