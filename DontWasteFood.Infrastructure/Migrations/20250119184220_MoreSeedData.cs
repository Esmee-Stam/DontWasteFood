using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e537829a-ffe8-42cd-9e2e-e9e8280f45ef", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0120aa0c-54d3-4772-81e3-650c45188def", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0120aa0c-54d3-4772-81e3-650c45188def");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e537829a-ffe8-42cd-9e2e-e9e8280f45ef");

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d13973e8-63e4-40d2-a939-c941eef836b4", null, "Student", "STUDENT" },
                    { "f61d531c-ea40-486f-bd97-5b3ac69fe033", null, "CanteenWorker", "CANTEENWORKER" }
                });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fea7054-73c6-4c14-85b6-a40f467f4bc5", "AQAAAAIAAYagAAAAEF7NtnkMQpIlSQ9RWgQIkFbUkMAdiMe4JXEy1n+60ek1+I7bwbqTtJjwfkgYJiRrWA==", "07ecc12c-54df-4551-a0f8-42e4cdcd06b2" });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc2253f-7b55-4b44-a291-b58bb199395e", "AQAAAAIAAYagAAAAELnQdSYcZlIFvJ4Hj3XJeGmvPnZrC4/hlp452qF2qmjwEygS6OYC3S4RS1/vPd0vDw==", "2d9d8637-3699-46e9-867f-9141119ee233" });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1dbd6d2b-4efb-4b56-93bc-90799c9beea5", 0, "fd8dc596-d2b7-4858-b66c-281fa3288aae", "j.jansen@avans.nl", true, false, null, "J.JANSEN@AVANS>NL", "J.JANSEN@AVANS.NL", "AQAAAAIAAYagAAAAEFDSvLyueTsazwgi6ZEKrcNsGIHKt1SbZucOxv9lNYV+LiQPFbqOOLKjd2fJIwYQ2w==", null, false, "e1d68df3-a4eb-4784-abb7-fa7f64630c3a", false, "j.jansen@avans.nl" },
                    { "b1c79773-6d4c-4605-9603-1cf695f0cda3", 0, "48b0b260-d874-489e-8c12-d17768feee38", "t.timmermans@avans.nl", true, false, null, "T.TIMMERMANS@AVANS>NL", "T.TIMMERMANS@AVANS.NL", "AQAAAAIAAYagAAAAEMBDVHBLQuOUiugSfL6IipUTxt/08R6FTgL4T6V1ac8HyZw5CMiDHwrT5l42Ly+9Nw==", null, false, "ab9cc05c-4488-4f8d-aef4-edaa02952bc5", false, "t.timmermans@avans.nl" },
                    { "bbfe56c9-88c2-4a60-9479-18b16d8c4c9d", 0, "f04d84e0-c8cc-4f30-8384-39a80e9e2e2f", "j.doe@student.avans.nl", true, false, null, "J.DOE@STUDENT.AVANS.NL", "J.DOE@STUDENT.AVANS.NL", "AQAAAAIAAYagAAAAEJ/Y/RWBhAizAxK78rZUSeryZ1oKQKCdxfj4rFN68ahqOsz/V+aMgJkD5MEH27+DIg==", null, false, "a9735db9-2367-4573-bd62-61bf8128a64b", false, "j.doe@student.avans.nl" },
                    { "c16e4b0b-d7b3-4845-a788-52411e76b5de", 0, "a896c007-a678-4e5e-8e5e-7b8131574a84", "e.smith@student.avans.nl", true, false, null, "E.SMITH@STUDENT.AVANS.NL", "E.SMITH@STUDENT.AVANS.NL", "AQAAAAIAAYagAAAAEG45WMiOpIOKdpypAOwkHTVW/AxHXV0eE1eqnEQR+wSoOeFnuA64JSNfju3dSEfrbQ==", null, false, "011f09bd-b17e-4457-bf73-c40ae5e792c2", false, "e.smith@student.avans.nl" },
                    { "c49a1c5f-b9ad-49e9-8cb7-7fcb54b3b39a", 0, "cb975c0b-dbdf-4499-8b4b-08c08001f82d", "jh.jansen@avans.nl", true, false, null, "JH.JANSEN@AVANS.NL", "JH.JANSEN@AVANS.NL", "AQAAAAIAAYagAAAAEJhOj1rO+Jr0GvjpsbkKN7eCz2uNAFPlTd2Cf/EHLSwhEI63P8GhTmzZn5a7Q6MarA==", null, false, "7476f17d-b5fc-447d-96f8-a04a2ccb014a", false, "jh.jansen@avans.nl" },
                    { "ea05a0b1-ea38-4c51-bde9-13c6fbb4b61b", 0, "e317eb47-66d8-4c57-a4b6-dc3ccdb4bb07", "n.jones@student.avans.nl", true, false, null, "N.JONES@STUDENT.AVANS.NL", "N.JONES@STUDENT.AVANS.NL", "AQAAAAIAAYagAAAAEFjCLKfkdjk7L/JFCnkENxTW/e4nQ79uRUoBgE32LUSVOSf5nFGGbpfJOOkbxfGhOg==", null, false, "295f2ed1-383c-4789-9049-207497d1b6cc", false, "n.jones@student.avans.nl" }
                });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 3, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "CanteenWorker", "b1c79773-6d4c-4605-9603-1cf695f0cda3" },
                    { 4, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "CanteenWorker", "c49a1c5f-b9ad-49e9-8cb7-7fcb54b3b39a" },
                    { 5, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "CanteenWorker", "1dbd6d2b-4efb-4b56-93bc-90799c9beea5" },
                    { 6, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Student", "bbfe56c9-88c2-4a60-9479-18b16d8c4c9d" },
                    { 7, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Student", "ea05a0b1-ea38-4c51-bde9-13c6fbb4b61b" },
                    { 8, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Student", "c16e4b0b-d7b3-4845-a788-52411e76b5de" }
                });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f61d531c-ea40-486f-bd97-5b3ac69fe033", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { "d13973e8-63e4-40d2-a939-c941eef836b4", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f61d531c-ea40-486f-bd97-5b3ac69fe033", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d13973e8-63e4-40d2-a939-c941eef836b4", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d13973e8-63e4-40d2-a939-c941eef836b4");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f61d531c-ea40-486f-bd97-5b3ac69fe033");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dbd6d2b-4efb-4b56-93bc-90799c9beea5");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c79773-6d4c-4605-9603-1cf695f0cda3");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbfe56c9-88c2-4a60-9479-18b16d8c4c9d");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c16e4b0b-d7b3-4845-a788-52411e76b5de");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c49a1c5f-b9ad-49e9-8cb7-7fcb54b3b39a");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea05a0b1-ea38-4c51-bde9-13c6fbb4b61b");

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0120aa0c-54d3-4772-81e3-650c45188def", null, "Student", "STUDENT" },
                    { "e537829a-ffe8-42cd-9e2e-e9e8280f45ef", null, "CanteenWorker", "CANTEENWORKER" }
                });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ed1766-9888-44a3-a1dd-9e015bc84fb4", "AQAAAAIAAYagAAAAEJecjBXHC3L+olEWnudvnNVVTdIzwE0iEj0YaRhD38XsSqJ9SeszaDTvdGhRtW6fdw==", "d89ff205-d8e6-4d70-b314-caec96189a53" });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1576d5c3-cc91-4c99-9ec0-a87e3c1f23f4", "AQAAAAIAAYagAAAAEJpTcFjNergMWJTdWOBl+9YBn7sGmS8RbXtj0kLNzerbAaxRg3QsHlLzALwx9wFqcw==", "61b76ed6-0729-46be-96bc-9372c7d44baf" });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e537829a-ffe8-42cd-9e2e-e9e8280f45ef", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { "0120aa0c-54d3-4772-81e3-650c45188def", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
                });
        }
    }
}
