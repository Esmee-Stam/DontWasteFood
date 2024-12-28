using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f1d9e56b-a3d3-4ab8-a504-197a320e3511", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ee95552-789b-40b2-a9ee-c76f70f83a1f", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee95552-789b-40b2-a9ee-c76f70f83a1f");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1d9e56b-a3d3-4ab8-a504-197a320e3511");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "5ee95552-789b-40b2-a9ee-c76f70f83a1f", null, "Student", "STUDENT" },
                    { "f1d9e56b-a3d3-4ab8-a504-197a320e3511", null, "Kantinemedewerker", "KANTINEMEDEWERKER" }
                });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b60a8fd-bfbc-4380-b38a-f503b0cabc4a", "AQAAAAIAAYagAAAAECmuHGTcz0B3GNh7chd97LcSvZmBMOs4CYpdXFS9XJUI/YEKc76sdFO+eAt4m3PWgw==", "29d25d10-0b88-4399-8788-9b5405366725" });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "508f8494-a890-4e98-8e01-5f11b0ee41a6", "AQAAAAIAAYagAAAAEP9rHzBECkFaXpkNuI6drhJS44QB0sIaUAuKsvTn+3vIRSGsKNz9QxabMEDp4RUU8Q==", "51a57105-2aa0-49dc-a7c2-3d777597caef" });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f1d9e56b-a3d3-4ab8-a504-197a320e3511", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { "5ee95552-789b-40b2-a9ee-c76f70f83a1f", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
                });
        }
    }
}
