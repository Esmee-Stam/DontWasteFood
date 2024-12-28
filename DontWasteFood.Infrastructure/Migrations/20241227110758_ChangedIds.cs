using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5018e04-daad-4562-8587-a50f12503833", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15aed218-ee8c-4f0e-a2aa-09db40f46c5f", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15aed218-ee8c-4f0e-a2aa-09db40f46c5f");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5018e04-daad-4562-8587-a50f12503833");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "15aed218-ee8c-4f0e-a2aa-09db40f46c5f", null, "Student", "STUDENT" },
                    { "d5018e04-daad-4562-8587-a50f12503833", null, "Kantinemedewerker", "KANTINEMEDEWERKER" }
                });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1a54bce-3741-4ff0-83b3-2a543048d36e", "AQAAAAIAAYagAAAAEGyIcIZSDtMinRx/v0o04hV2MXweULajNAo6A+b5UUvMhxgn/Hax5q6HzlOzRdAzRw==", "458b8750-d607-4695-8fe0-d704cf6743a2" });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66ee8b47-f3c9-456b-ade8-5ad02ff63056", "AQAAAAIAAYagAAAAEIDzGofU9kyhqTvl3Z+NMBEARpswXB5a2r+nUym/PxE7xsaAzAgzLIe3ghJ6Rla4HQ==", "c858db83-1a26-4a91-a23b-40164a97c4d6" });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d5018e04-daad-4562-8587-a50f12503833", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { "15aed218-ee8c-4f0e-a2aa-09db40f46c5f", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
                });
        }
    }
}
