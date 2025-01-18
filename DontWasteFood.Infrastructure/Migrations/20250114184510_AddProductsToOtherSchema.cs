using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsToOtherSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83c287b6-4aa8-4689-b4e8-f44a310355c3", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46734a15-5105-43c0-a92c-e9d30ec92c11", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46734a15-5105-43c0-a92c-e9d30ec92c11");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83c287b6-4aa8-4689-b4e8-f44a310355c3");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "46734a15-5105-43c0-a92c-e9d30ec92c11", null, "Student", "STUDENT" },
                    { "83c287b6-4aa8-4689-b4e8-f44a310355c3", null, "CanteenWorker", "CANTEENWORKER" }
                });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d29c81e6-4f31-4c28-ba0a-f400d6c701c8", "AQAAAAIAAYagAAAAELLANtwZcp+SuE1YNVuCGFfyzJdmGLclK4hdzbqDueMn5vXUXsfqdnvS+PXHySzRZA==", "439dae77-bc90-49e3-b334-2f50c99d0cb0" });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4300e58d-76ff-4a86-8ec7-e146c1c5e6bf", "AQAAAAIAAYagAAAAEERAGRuJH6Fybo50HwQu5u1Aag3R+nxaXdDT7AiS8GF5IBBJgEIV8AVZopS8odbQoA==", "e5050d67-4996-41e7-986b-6cff658771fe" });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "83c287b6-4aa8-4689-b4e8-f44a310355c3", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { "46734a15-5105-43c0-a92c-e9d30ec92c11", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
                });
        }
    }
}
