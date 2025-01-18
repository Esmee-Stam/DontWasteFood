using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class AddProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "Id", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"), "LA", 0, true },
                    { new Guid("97db6a1b-01e3-46be-8e8b-5834ed54d9b4"), "DB", 1, true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "Id", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("0724fef2-a426-41d8-bdcc-eccf371010ac"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("2a954dd2-59fb-4733-a713-1ddc26536d0f"), false, "Fanta", "/images/fanta.png" },
                    { new Guid("2e1ad063-4c6c-49f7-8d6b-c818f7187bfe"), false, "Panini Salami", "/images/panini-salami.jpg" },
                    { new Guid("32fbec29-9bca-4b13-a748-3fc7f8a4f5cf"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("4f0a4465-a671-4b68-a371-1b68fba6aa2a"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("578c6970-e138-4a74-8787-3dcf34018125"), true, "Amstel", "/images/amstel.jpg" },
                    { new Guid("5ce5bcd8-c300-4977-ada7-0574c523d7dd"), false, "Broodje gezond", "/images/broodje-gezond.jpg" },
                    { new Guid("68d43d4c-4c0b-4d87-a3e7-0558f7dfaabd"), false, "Cola", "/images/cola.jpg" },
                    { new Guid("9980a9a4-c855-4c67-a59b-d0e162f93851"), false, "Stroopwafel", "/images/stroopwafel.jpg" },
                    { new Guid("b0e93fe7-e894-435d-8c6f-40de51bc3549"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "Id", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[] { new Guid("bda4d532-0dc9-4a75-b48c-1d0d433d5813"), 1, new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "Id", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[] { new Guid("61a15bab-54da-42a8-80d1-25af7daad9da"), new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"), "7654321", null, "Jan Jansen" });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "Id", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("a0520f9f-1be8-4df6-99e8-50e30c9960d4"), new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Amstel & Stroopwafel", 10.00m, null, new DateTime(2024, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("addc7fb3-f48c-4823-b1ca-06baa1e852fa"), new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Gevulde Koek met Fristi", 5.00m, new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0d61041-95a3-4337-bd8d-05ec850e4f46"), new Guid("97db6a1b-01e3-46be-8e8b-5834ed54d9b4"), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Panini Salami", 4.00m, null, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df3816dc-b90f-47d9-a27d-acfc17131fee"), new Guid("97db6a1b-01e3-46be-8e8b-5834ed54d9b4"), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Broodje Gezond", 3.00m, null, new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesId", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("a0520f9f-1be8-4df6-99e8-50e30c9960d4"), new Guid("578c6970-e138-4a74-8787-3dcf34018125") },
                    { new Guid("a0520f9f-1be8-4df6-99e8-50e30c9960d4"), new Guid("9980a9a4-c855-4c67-a59b-d0e162f93851") },
                    { new Guid("addc7fb3-f48c-4823-b1ca-06baa1e852fa"), new Guid("0724fef2-a426-41d8-bdcc-eccf371010ac") },
                    { new Guid("addc7fb3-f48c-4823-b1ca-06baa1e852fa"), new Guid("4f0a4465-a671-4b68-a371-1b68fba6aa2a") },
                    { new Guid("c0d61041-95a3-4337-bd8d-05ec850e4f46"), new Guid("2e1ad063-4c6c-49f7-8d6b-c818f7187bfe") },
                    { new Guid("df3816dc-b90f-47d9-a27d-acfc17131fee"), new Guid("5ce5bcd8-c300-4977-ada7-0574c523d7dd") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("61a15bab-54da-42a8-80d1-25af7daad9da"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("a0520f9f-1be8-4df6-99e8-50e30c9960d4"), new Guid("578c6970-e138-4a74-8787-3dcf34018125") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("a0520f9f-1be8-4df6-99e8-50e30c9960d4"), new Guid("9980a9a4-c855-4c67-a59b-d0e162f93851") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("addc7fb3-f48c-4823-b1ca-06baa1e852fa"), new Guid("0724fef2-a426-41d8-bdcc-eccf371010ac") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("addc7fb3-f48c-4823-b1ca-06baa1e852fa"), new Guid("4f0a4465-a671-4b68-a371-1b68fba6aa2a") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("c0d61041-95a3-4337-bd8d-05ec850e4f46"), new Guid("2e1ad063-4c6c-49f7-8d6b-c818f7187bfe") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("df3816dc-b90f-47d9-a27d-acfc17131fee"), new Guid("5ce5bcd8-c300-4977-ada7-0574c523d7dd") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a954dd2-59fb-4733-a713-1ddc26536d0f"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32fbec29-9bca-4b13-a748-3fc7f8a4f5cf"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68d43d4c-4c0b-4d87-a3e7-0558f7dfaabd"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0e93fe7-e894-435d-8c6f-40de51bc3549"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bda4d532-0dc9-4a75-b48c-1d0d433d5813"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("a0520f9f-1be8-4df6-99e8-50e30c9960d4"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("addc7fb3-f48c-4823-b1ca-06baa1e852fa"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("c0d61041-95a3-4337-bd8d-05ec850e4f46"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("df3816dc-b90f-47d9-a27d-acfc17131fee"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0724fef2-a426-41d8-bdcc-eccf371010ac"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e1ad063-4c6c-49f7-8d6b-c818f7187bfe"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0a4465-a671-4b68-a371-1b68fba6aa2a"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("578c6970-e138-4a74-8787-3dcf34018125"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ce5bcd8-c300-4977-ada7-0574c523d7dd"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9980a9a4-c855-4c67-a59b-d0e162f93851"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("97db6a1b-01e3-46be-8e8b-5834ed54d9b4"));

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
    }
}
