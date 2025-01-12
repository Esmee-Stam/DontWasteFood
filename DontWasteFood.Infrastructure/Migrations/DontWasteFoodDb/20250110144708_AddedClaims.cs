using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class AddedClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("13e30a51-4f97-456b-9697-b0e9cc0818f2"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("6c487ef0-d53b-4ce0-9587-5253646eb4d4"), new Guid("1678cba3-1c99-4f15-8583-56b197b54693") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("6c487ef0-d53b-4ce0-9587-5253646eb4d4"), new Guid("8296acc7-5300-406f-b00d-e017ea5d2de6") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("a8f6cf81-fbff-40a7-80f2-e2f0f0491f67"), new Guid("2a8e51a3-7c1d-4cde-aad9-f5e633522cd3") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("a8f6cf81-fbff-40a7-80f2-e2f0f0491f67"), new Guid("70614a29-79cc-4281-8234-6b24a84d9a4b") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("e4f925ce-107f-4b27-b666-ed7644e48dec"), new Guid("3d7d5038-343d-45f2-a2b8-b9bd4e47e954") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("f0f36860-035a-4a22-b94f-dd8972ac36c1"), new Guid("5d5ccd73-c672-4cf3-b400-e7c149527a71") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65a67986-2a3c-4d78-bf5f-d8d67e53cc53"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fd05664-8451-4923-9f93-6746a1d801f9"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f561d211-0029-4ced-bf80-55f14c2a33a5"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fccbf2e2-ce94-4301-8ec5-367ca2f3916d"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cf43c7ca-7546-4645-ba45-6ed790ca486a"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("6c487ef0-d53b-4ce0-9587-5253646eb4d4"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("a8f6cf81-fbff-40a7-80f2-e2f0f0491f67"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e4f925ce-107f-4b27-b666-ed7644e48dec"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("f0f36860-035a-4a22-b94f-dd8972ac36c1"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1678cba3-1c99-4f15-8583-56b197b54693"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a8e51a3-7c1d-4cde-aad9-f5e633522cd3"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d7d5038-343d-45f2-a2b8-b9bd4e47e954"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d5ccd73-c672-4cf3-b400-e7c149527a71"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70614a29-79cc-4281-8234-6b24a84d9a4b"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8296acc7-5300-406f-b00d-e017ea5d2de6"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("df310e40-acd3-49b0-911a-94ae12c53b32"));

            migrationBuilder.UpdateData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"),
                column: "CanteenId",
                value: new Guid("2977227e-fc29-4c85-b47b-f9149e276106"));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "Id", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("2977227e-fc29-4c85-b47b-f9149e276106"), "LA", 0, true },
                    { new Guid("6dc1904c-4aa3-4967-852e-a97dee252d4f"), "DB", 1, true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "Id", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("01ee85d2-6a88-426d-9b0f-8f325b2d6b70"), false, "Broodje gezond", "/images/broodje-gezond.jpg" },
                    { new Guid("30ffa4a0-b826-4acf-b712-703722cc7fe5"), true, "Amstel", "/images/amstel.jpg" },
                    { new Guid("4e37a893-d204-4585-b387-d60d54719d27"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("6be992e3-511a-4c2e-9bd3-18a710475bc9"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("8b1485f0-be0b-4f67-8e32-f077c50076bd"), false, "Cola", "/images/cola.jpg" },
                    { new Guid("96a98c5a-01f8-4a84-b49b-adc3e4c9dba7"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("d3e34475-b352-40db-9124-0d7df352fb34"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" },
                    { new Guid("d6813c93-f9d1-49e9-b1bb-8a64e02e80ac"), false, "Fanta", "/images/fanta.png" },
                    { new Guid("fca1f141-9743-44ac-8a93-1c5aaa51b8c4"), false, "Stroopwafel", "/images/stroopwafel.jpg" },
                    { new Guid("feca07bd-9f2f-42d7-be80-ee5a68dcb3a8"), false, "Panini Salami", "/images/panini-salami.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "Id", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[] { new Guid("e871695d-924c-4f81-bae3-d81b0a3e9362"), 1, new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "Id", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[] { new Guid("3f6c83f1-608a-4e64-a458-80751865d4e3"), new Guid("2977227e-fc29-4c85-b47b-f9149e276106"), "7654321", null, "Jan Jansen" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "Id", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("57749a10-0541-4454-8daa-437fa6a96f0e"), new Guid("2977227e-fc29-4c85-b47b-f9149e276106"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Gevulde Koek met Fristi", 5.00m, new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("598dae15-fe43-4762-980b-4715ab5d0232"), new Guid("2977227e-fc29-4c85-b47b-f9149e276106"), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Amstel & Stroopwafel", 10.00m, null, new DateTime(2024, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72ddfbb8-8dbc-4c45-a27e-ab4d62528535"), new Guid("6dc1904c-4aa3-4967-852e-a97dee252d4f"), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Broodje Gezond", 3.00m, null, new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbea0c4e-6ba4-4a51-a1ea-bf47692fe611"), new Guid("6dc1904c-4aa3-4967-852e-a97dee252d4f"), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Panini Salami", 4.00m, null, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesId", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("57749a10-0541-4454-8daa-437fa6a96f0e"), new Guid("6be992e3-511a-4c2e-9bd3-18a710475bc9") },
                    { new Guid("57749a10-0541-4454-8daa-437fa6a96f0e"), new Guid("96a98c5a-01f8-4a84-b49b-adc3e4c9dba7") },
                    { new Guid("598dae15-fe43-4762-980b-4715ab5d0232"), new Guid("30ffa4a0-b826-4acf-b712-703722cc7fe5") },
                    { new Guid("598dae15-fe43-4762-980b-4715ab5d0232"), new Guid("fca1f141-9743-44ac-8a93-1c5aaa51b8c4") },
                    { new Guid("72ddfbb8-8dbc-4c45-a27e-ab4d62528535"), new Guid("01ee85d2-6a88-426d-9b0f-8f325b2d6b70") },
                    { new Guid("bbea0c4e-6ba4-4a51-a1ea-bf47692fe611"), new Guid("feca07bd-9f2f-42d7-be80-ee5a68dcb3a8") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("3f6c83f1-608a-4e64-a458-80751865d4e3"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("57749a10-0541-4454-8daa-437fa6a96f0e"), new Guid("6be992e3-511a-4c2e-9bd3-18a710475bc9") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("57749a10-0541-4454-8daa-437fa6a96f0e"), new Guid("96a98c5a-01f8-4a84-b49b-adc3e4c9dba7") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("598dae15-fe43-4762-980b-4715ab5d0232"), new Guid("30ffa4a0-b826-4acf-b712-703722cc7fe5") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("598dae15-fe43-4762-980b-4715ab5d0232"), new Guid("fca1f141-9743-44ac-8a93-1c5aaa51b8c4") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("72ddfbb8-8dbc-4c45-a27e-ab4d62528535"), new Guid("01ee85d2-6a88-426d-9b0f-8f325b2d6b70") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("bbea0c4e-6ba4-4a51-a1ea-bf47692fe611"), new Guid("feca07bd-9f2f-42d7-be80-ee5a68dcb3a8") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e37a893-d204-4585-b387-d60d54719d27"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b1485f0-be0b-4f67-8e32-f077c50076bd"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3e34475-b352-40db-9124-0d7df352fb34"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6813c93-f9d1-49e9-b1bb-8a64e02e80ac"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e871695d-924c-4f81-bae3-d81b0a3e9362"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("57749a10-0541-4454-8daa-437fa6a96f0e"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("598dae15-fe43-4762-980b-4715ab5d0232"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("72ddfbb8-8dbc-4c45-a27e-ab4d62528535"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("bbea0c4e-6ba4-4a51-a1ea-bf47692fe611"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01ee85d2-6a88-426d-9b0f-8f325b2d6b70"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30ffa4a0-b826-4acf-b712-703722cc7fe5"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6be992e3-511a-4c2e-9bd3-18a710475bc9"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96a98c5a-01f8-4a84-b49b-adc3e4c9dba7"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fca1f141-9743-44ac-8a93-1c5aaa51b8c4"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("feca07bd-9f2f-42d7-be80-ee5a68dcb3a8"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("2977227e-fc29-4c85-b47b-f9149e276106"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("6dc1904c-4aa3-4967-852e-a97dee252d4f"));

            migrationBuilder.UpdateData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"),
                column: "CanteenId",
                value: new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"));

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
                values: new object[] { new Guid("cf43c7ca-7546-4645-ba45-6ed790ca486a"), 1, new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "Id", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[] { new Guid("13e30a51-4f97-456b-9697-b0e9cc0818f2"), new Guid("353c3168-f82f-4f15-a6a4-5d55f800ef72"), "7654321", null, "Jan Jansen" });

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
        }
    }
}
