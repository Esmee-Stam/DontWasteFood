using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f513bdd1-8c29-489b-acd4-864daec2c4b2", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7b8343b2-53cd-43fe-90fe-2a006522cfcf", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8343b2-53cd-43fe-90fe-2a006522cfcf");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f513bdd1-8c29-489b-acd4-864daec2c4b2");

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46734a15-5105-43c0-a92c-e9d30ec92c11", null, "Student", "STUDENT" },
                    { "83c287b6-4aa8-4689-b4e8-f44a310355c3", null, "CanteenWorker", "CANTEENWORKER" }
                });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "CanteenWorker", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { 2, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Student", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

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
                    { "7b8343b2-53cd-43fe-90fe-2a006522cfcf", null, "Student", "STUDENT" },
                    { "f513bdd1-8c29-489b-acd4-864daec2c4b2", null, "Kantinemedewerker", "KANTINEMEDEWERKER" }
                });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285980bd-185f-44ff-b74d-bc8384a196ec", "AQAAAAIAAYagAAAAEJ/PjwLldJSmPQPILnmypynr+FcXOcLUbtFRfO1Q/E92hcFzBgy095/brnIh2NXoYA==", "0e534d16-3844-4a3f-84df-323af9cb0ea7" });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ea70091-e24a-46d1-922e-11a48b1186e9", "AQAAAAIAAYagAAAAEGMQw34NfNksSFPh876HO7OfPKHI3nuYTR/p4UbUsU4DvbcXAyfIEbhMjnEK9lLdGA==", "b939b867-a3f6-4b48-b938-870dbfb26c1b" });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f513bdd1-8c29-489b-acd4-864daec2c4b2", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { "7b8343b2-53cd-43fe-90fe-2a006522cfcf", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
                });
        }
    }
}
