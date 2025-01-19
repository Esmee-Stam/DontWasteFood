using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations.DontWasteFoodDb
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"));

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

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"));

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Canteens",
                columns: new[] { "Id", "CanteenLocation", "City", "HotMealsOffer" },
                values: new object[,]
                {
                    { new Guid("ac2693c5-3aa3-4e77-95be-f624162f805a"), "DB", 1, true },
                    { new Guid("da3941aa-8ef8-4364-b210-304ac5a547d6"), "TI", 2, false },
                    { new Guid("ff009029-24b5-44f5-8026-3761bbb6271c"), "LA", 0, true }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Products",
                columns: new[] { "Id", "IsAlcoholic", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("157f4ced-fbed-403a-9efa-4e4a9b93257c"), false, "Panini Salami", "/images/panini-salami.jpg" },
                    { new Guid("3ae01902-607f-42d2-8748-7adbbc8b1b39"), false, "Fanta", "/images/fanta.png" },
                    { new Guid("44a61765-faa6-4112-9f27-31470b00e70c"), false, "Fristi", "/images/fristi.png" },
                    { new Guid("4c4c47ed-dce2-4b80-b912-698f57f85f54"), false, "Saucijzenbroodje", "/images/saucijzenbroodje.png" },
                    { new Guid("5d1c9a4e-7968-4f94-a81c-ecca866c73a1"), false, "Stroopwafel", "/images/stroopwafel.jpg" },
                    { new Guid("73209267-a1ed-45a3-8ea2-a97074f38232"), false, "Gevulde Koek", "/images/gevulde-koek.jpg" },
                    { new Guid("a0e1ffc4-39b9-4f3c-a242-a44172172229"), false, "Spa Blauw", "/images/spa-blauw.jpg" },
                    { new Guid("afbd7019-aba7-4d6f-adc5-3bc30960d161"), false, "Broodje gezond", "/images/broodje-gezond.jpg" },
                    { new Guid("bf69778b-9ed3-47f6-a432-8b989a10d42f"), false, "Cola", "/images/cola.jpg" },
                    { new Guid("db7b1a0e-6920-4bd2-b517-dc411635f85e"), true, "Amstel", "/images/amstel.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Students",
                columns: new[] { "Id", "City", "DateOfBirth", "EmailAddress", "IdentityUserId", "Name", "PhoneNumber", "StudentNumber" },
                values: new object[,]
                {
                    { new Guid("5fc90d6b-aa0a-4e9f-a4a9-691ebab27ff3"), 1, new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", "bbfe56c9-88c2-4a60-9479-18b16d8c4c9d", "Jane Doe", null, "2176034" },
                    { new Guid("942848fe-5958-41bc-8104-8813b9852ac8"), 2, new DateTime(2005, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "n.jones@student.avans.nl", "ea05a0b1-ea38-4c51-bde9-13c6fbb4b61b", "Norah Jones", null, "2176035" },
                    { new Guid("d061b645-3245-4d38-a71b-1df5c0fbf8a5"), 0, new DateTime(2006, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e.smith@student.avans.nl", "c16e4b0b-d7b3-4845-a788-52411e76b5de", "Evie Smith", null, "2176036" },
                    { new Guid("ec8115e0-37aa-4b3b-a1e5-e343a2a82aad"), 0, new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "el.stam@student.avans.nl", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e", "Esmée Stam", null, "2196911" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "Id", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("1964dc4c-d543-496b-b536-000a3c334313"), new Guid("ff009029-24b5-44f5-8026-3761bbb6271c"), "1234567", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f", "John Doe" },
                    { new Guid("1e01341f-2546-4429-b4d7-e361f35baefd"), new Guid("ff009029-24b5-44f5-8026-3761bbb6271c"), "7654322", "c49a1c5f-b9ad-49e9-8cb7-7fcb54b3b39a", "Johan Jansen" },
                    { new Guid("24340028-ad25-4538-b17c-bb0f9a2cf514"), new Guid("ff009029-24b5-44f5-8026-3761bbb6271c"), "7654321", "1dbd6d2b-4efb-4b56-93bc-90799c9beea5", "Jan Jansen" },
                    { new Guid("edb77448-9a6a-474b-9e02-259985e5506d"), new Guid("da3941aa-8ef8-4364-b210-304ac5a547d6"), "1234577", "b1c79773-6d4c-4605-9603-1cf695f0cda3", "Tim Timmermans" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "Packages",
                columns: new[] { "Id", "CanteenId", "DateOfPickUp", "Is18Plus", "MealType", "Name", "Price", "StudentId", "TimeOfPickUp" },
                values: new object[,]
                {
                    { new Guid("18f10e8e-95c0-40bd-81a6-79e98b01cc8f"), new Guid("ff009029-24b5-44f5-8026-3761bbb6271c"), new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Gevulde Koek met Fristi", 5.00m, new Guid("ec8115e0-37aa-4b3b-a1e5-e343a2a82aad"), new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2444f203-d6e2-4ebe-a8cd-7ad0467a7164"), new Guid("da3941aa-8ef8-4364-b210-304ac5a547d6"), new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Spa Blauw & Panini Salami", 5.50m, null, new DateTime(2025, 1, 31, 16, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30bb508b-4b34-4176-9577-5ba9aeb94a6e"), new Guid("da3941aa-8ef8-4364-b210-304ac5a547d6"), new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "Fanta & Saucijzenbroodje", 4.50m, null, new DateTime(2025, 1, 31, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46c3bc0c-1725-4d4b-8671-18fade721fac"), new Guid("ac2693c5-3aa3-4e77-95be-f624162f805a"), new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Broodje Gezond", 3.00m, null, new DateTime(2025, 1, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68255d0d-fc3d-4e08-9b65-1b6d66a462fc"), new Guid("ac2693c5-3aa3-4e77-95be-f624162f805a"), new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Panini Salami", 4.00m, null, new DateTime(2025, 1, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f22e219d-cdeb-4292-b09c-a03228b6fb27"), new Guid("ff009029-24b5-44f5-8026-3761bbb6271c"), new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Amstel & Stroopwafel", 10.00m, null, new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                columns: new[] { "PackagesId", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("18f10e8e-95c0-40bd-81a6-79e98b01cc8f"), new Guid("44a61765-faa6-4112-9f27-31470b00e70c") },
                    { new Guid("18f10e8e-95c0-40bd-81a6-79e98b01cc8f"), new Guid("73209267-a1ed-45a3-8ea2-a97074f38232") },
                    { new Guid("2444f203-d6e2-4ebe-a8cd-7ad0467a7164"), new Guid("a0e1ffc4-39b9-4f3c-a242-a44172172229") },
                    { new Guid("30bb508b-4b34-4176-9577-5ba9aeb94a6e"), new Guid("3ae01902-607f-42d2-8748-7adbbc8b1b39") },
                    { new Guid("46c3bc0c-1725-4d4b-8671-18fade721fac"), new Guid("afbd7019-aba7-4d6f-adc5-3bc30960d161") },
                    { new Guid("68255d0d-fc3d-4e08-9b65-1b6d66a462fc"), new Guid("157f4ced-fbed-403a-9efa-4e4a9b93257c") },
                    { new Guid("f22e219d-cdeb-4292-b09c-a03228b6fb27"), new Guid("5d1c9a4e-7968-4f94-a81c-ecca866c73a1") },
                    { new Guid("f22e219d-cdeb-4292-b09c-a03228b6fb27"), new Guid("db7b1a0e-6920-4bd2-b517-dc411635f85e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("1964dc4c-d543-496b-b536-000a3c334313"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("1e01341f-2546-4429-b4d7-e361f35baefd"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("24340028-ad25-4538-b17c-bb0f9a2cf514"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                keyColumn: "Id",
                keyValue: new Guid("edb77448-9a6a-474b-9e02-259985e5506d"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("18f10e8e-95c0-40bd-81a6-79e98b01cc8f"), new Guid("44a61765-faa6-4112-9f27-31470b00e70c") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("18f10e8e-95c0-40bd-81a6-79e98b01cc8f"), new Guid("73209267-a1ed-45a3-8ea2-a97074f38232") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("2444f203-d6e2-4ebe-a8cd-7ad0467a7164"), new Guid("a0e1ffc4-39b9-4f3c-a242-a44172172229") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("30bb508b-4b34-4176-9577-5ba9aeb94a6e"), new Guid("3ae01902-607f-42d2-8748-7adbbc8b1b39") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("46c3bc0c-1725-4d4b-8671-18fade721fac"), new Guid("afbd7019-aba7-4d6f-adc5-3bc30960d161") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("68255d0d-fc3d-4e08-9b65-1b6d66a462fc"), new Guid("157f4ced-fbed-403a-9efa-4e4a9b93257c") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("f22e219d-cdeb-4292-b09c-a03228b6fb27"), new Guid("5d1c9a4e-7968-4f94-a81c-ecca866c73a1") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "PackageProduct",
                keyColumns: new[] { "PackagesId", "ProductsId" },
                keyValues: new object[] { new Guid("f22e219d-cdeb-4292-b09c-a03228b6fb27"), new Guid("db7b1a0e-6920-4bd2-b517-dc411635f85e") });

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c4c47ed-dce2-4b80-b912-698f57f85f54"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf69778b-9ed3-47f6-a432-8b989a10d42f"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5fc90d6b-aa0a-4e9f-a4a9-691ebab27ff3"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("942848fe-5958-41bc-8104-8813b9852ac8"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d061b645-3245-4d38-a71b-1df5c0fbf8a5"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("18f10e8e-95c0-40bd-81a6-79e98b01cc8f"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("2444f203-d6e2-4ebe-a8cd-7ad0467a7164"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("30bb508b-4b34-4176-9577-5ba9aeb94a6e"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("46c3bc0c-1725-4d4b-8671-18fade721fac"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("68255d0d-fc3d-4e08-9b65-1b6d66a462fc"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("f22e219d-cdeb-4292-b09c-a03228b6fb27"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("157f4ced-fbed-403a-9efa-4e4a9b93257c"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ae01902-607f-42d2-8748-7adbbc8b1b39"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44a61765-faa6-4112-9f27-31470b00e70c"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d1c9a4e-7968-4f94-a81c-ecca866c73a1"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73209267-a1ed-45a3-8ea2-a97074f38232"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0e1ffc4-39b9-4f3c-a242-a44172172229"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afbd7019-aba7-4d6f-adc5-3bc30960d161"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db7b1a0e-6920-4bd2-b517-dc411635f85e"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("ac2693c5-3aa3-4e77-95be-f624162f805a"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("da3941aa-8ef8-4364-b210-304ac5a547d6"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Canteens",
                keyColumn: "Id",
                keyValue: new Guid("ff009029-24b5-44f5-8026-3761bbb6271c"));

            migrationBuilder.DeleteData(
                schema: "DontWasteFood",
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ec8115e0-37aa-4b3b-a1e5-e343a2a82aad"));

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
                values: new object[,]
                {
                    { new Guid("a96fda13-9eee-4a49-94b7-ddf4c84ec61e"), 0, new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "el.stam@student.avans.nl", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e", "Esmée Stam", null, "2196911" },
                    { new Guid("bda4d532-0dc9-4a75-b48c-1d0d433d5813"), 1, new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "j.doe@student.avans.nl", null, "Jane Doe", null, "2176034" }
                });

            migrationBuilder.InsertData(
                schema: "DontWasteFood",
                table: "CanteenWorkers",
                columns: new[] { "Id", "CanteenId", "EmployeeNumber", "IdentityUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f"), new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"), "1234567", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f", "John Doe" },
                    { new Guid("61a15bab-54da-42a8-80d1-25af7daad9da"), new Guid("3351496d-5b2f-4e00-b46e-3c4f68f171ca"), "7654321", null, "Jan Jansen" }
                });

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
    }
}
