using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class UpdateCityStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new Guid("012fde28-9566-482c-ae9b-d5fc7d4ffe32"));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "CanteenId", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("012fde28-9566-482c-ae9b-d5fc7d4ffe32"), "LA", "Breda", true },
                    { new Guid("c155bce0-27ad-4e9d-b96c-79269b49dbd1"), "DB", "Den Bosch", true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "ProductId", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("33afbc2b-027b-4359-bcc3-13aebd0f92c3"), true, "Cola", "/images/cola.jpg" },
                    { new Guid("412640a7-4fc7-4f42-be43-bd6ddbce6390"), false, "Panini Salami", "/images/panini-salami.jpg" },
                    { new Guid("55fd481a-0a22-4495-8904-465e89304439"), true, "Amstel", "/images/amstel.jpg" },
                    { new Guid("706044eb-31ab-4a78-960b-490bb7a1bb14"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("87ba0997-4a1c-48a6-b799-9e89bdd054fa"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" },
                    { new Guid("950577a0-2b52-4550-94bf-e2a9e375b415"), false, "Broodje gezond", "/images/broodje-gezond.jpg" },
                    { new Guid("9f27fb92-d4ff-4992-a958-4896fb9ba4f9"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("f8c64b40-26b9-4f1b-88a7-50579f4ae4e9"), false, "Stroopwafel", "/images/stroopwafel.jpg" },
                    { new Guid("fb4c0a43-3bba-4169-8457-17a0cd8f5cd0"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("fc4ff700-6129-4f47-ace7-62022c7697fa"), false, "Fanta", "/images/fanta.png" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "StudentId", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[] { new Guid("79cc8327-56e7-474b-936f-11717168a98b"), "Den Bosch", new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "CanteenWorkerId", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[] { new Guid("64178fba-d17d-465a-990d-e5dfb9cf8b18"), new Guid("012fde28-9566-482c-ae9b-d5fc7d4ffe32"), "7654321", null, "Jan Jansen" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "PackageId", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("0ed5e837-e5c6-44e9-96fd-566076b95f9c"), new Guid("c155bce0-27ad-4e9d-b96c-79269b49dbd1"), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Broodje Gezond", 3.00m, null, new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30bbebe7-938e-4aa2-9b4a-cd3716bc593f"), new Guid("012fde28-9566-482c-ae9b-d5fc7d4ffe32"), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Amstel & Stroopwafel", 10.00m, null, new DateTime(2024, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3cb1b9ec-f3d0-4f53-bdcf-01d7804a7f80"), new Guid("012fde28-9566-482c-ae9b-d5fc7d4ffe32"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Gevulde Koek met Fristi", 5.00m, new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51bc1c46-b45e-4e3a-889a-f13de34eed1c"), new Guid("c155bce0-27ad-4e9d-b96c-79269b49dbd1"), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Panini Salami", 4.00m, null, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesPackageId", "ProductsProductId", "PackageId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("0ed5e837-e5c6-44e9-96fd-566076b95f9c"), new Guid("950577a0-2b52-4550-94bf-e2a9e375b415"), null, null },
                    { new Guid("30bbebe7-938e-4aa2-9b4a-cd3716bc593f"), new Guid("55fd481a-0a22-4495-8904-465e89304439"), null, null },
                    { new Guid("30bbebe7-938e-4aa2-9b4a-cd3716bc593f"), new Guid("f8c64b40-26b9-4f1b-88a7-50579f4ae4e9"), null, null },
                    { new Guid("3cb1b9ec-f3d0-4f53-bdcf-01d7804a7f80"), new Guid("9f27fb92-d4ff-4992-a958-4896fb9ba4f9"), null, null },
                    { new Guid("3cb1b9ec-f3d0-4f53-bdcf-01d7804a7f80"), new Guid("fb4c0a43-3bba-4169-8457-17a0cd8f5cd0"), null, null },
                    { new Guid("51bc1c46-b45e-4e3a-889a-f13de34eed1c"), new Guid("412640a7-4fc7-4f42-be43-bd6ddbce6390"), null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "CanteenWorkerId",
                keyValue: new Guid("64178fba-d17d-465a-990d-e5dfb9cf8b18"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("0ed5e837-e5c6-44e9-96fd-566076b95f9c"), new Guid("950577a0-2b52-4550-94bf-e2a9e375b415") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("30bbebe7-938e-4aa2-9b4a-cd3716bc593f"), new Guid("55fd481a-0a22-4495-8904-465e89304439") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("30bbebe7-938e-4aa2-9b4a-cd3716bc593f"), new Guid("f8c64b40-26b9-4f1b-88a7-50579f4ae4e9") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("3cb1b9ec-f3d0-4f53-bdcf-01d7804a7f80"), new Guid("9f27fb92-d4ff-4992-a958-4896fb9ba4f9") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("3cb1b9ec-f3d0-4f53-bdcf-01d7804a7f80"), new Guid("fb4c0a43-3bba-4169-8457-17a0cd8f5cd0") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesPackageId", "ProductsProductId" },
                keyValues: new object[] { new Guid("51bc1c46-b45e-4e3a-889a-f13de34eed1c"), new Guid("412640a7-4fc7-4f42-be43-bd6ddbce6390") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("33afbc2b-027b-4359-bcc3-13aebd0f92c3"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("706044eb-31ab-4a78-960b-490bb7a1bb14"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87ba0997-4a1c-48a6-b799-9e89bdd054fa"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc4ff700-6129-4f47-ace7-62022c7697fa"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("79cc8327-56e7-474b-936f-11717168a98b"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("0ed5e837-e5c6-44e9-96fd-566076b95f9c"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("30bbebe7-938e-4aa2-9b4a-cd3716bc593f"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("3cb1b9ec-f3d0-4f53-bdcf-01d7804a7f80"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: new Guid("51bc1c46-b45e-4e3a-889a-f13de34eed1c"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("412640a7-4fc7-4f42-be43-bd6ddbce6390"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("55fd481a-0a22-4495-8904-465e89304439"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("950577a0-2b52-4550-94bf-e2a9e375b415"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f27fb92-d4ff-4992-a958-4896fb9ba4f9"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f8c64b40-26b9-4f1b-88a7-50579f4ae4e9"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fb4c0a43-3bba-4169-8457-17a0cd8f5cd0"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("012fde28-9566-482c-ae9b-d5fc7d4ffe32"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "CanteenId",
                keyValue: new Guid("c155bce0-27ad-4e9d-b96c-79269b49dbd1"));

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
    }
}
