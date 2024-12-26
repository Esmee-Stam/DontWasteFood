using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DontWasteFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "383929a2-6d64-485b-be94-5b212d52374c", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2be63278-8807-4d8d-bfcc-828e26f90663", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" });

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2be63278-8807-4d8d-bfcc-828e26f90663");

            migrationBuilder.DeleteData(
                schema: "Authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "383929a2-6d64-485b-be94-5b212d52374c");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2be63278-8807-4d8d-bfcc-828e26f90663", null, "Student", "STUDENT" },
                    { "383929a2-6d64-485b-be94-5b212d52374c", null, "Kantinemedewerker", "KANTINEMEDEWERKER" }
                });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707999a6-39f3-4ddf-8c4b-d576d74214fa", "AQAAAAIAAYagAAAAEIpdhSCgCbY9OKVg2E2QAwx9lslP43O5mft73hutyGDPNqgg7RmoVNuaCUk/ljE47g==", "296661ab-9ecb-478e-9aaf-5306db621ad6" });

            migrationBuilder.UpdateData(
                schema: "Authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54b69a4-b456-4f13-8e2b-ae0e456c70dd", "AQAAAAIAAYagAAAAEP6Mx6IUsXkmWEKKnV0wIe+MgryaUTLlGWSiP7HT1mThA6scwgNB5tzYJpuPDiP5ww==", "a8f3b200-1d20-484e-82b9-7c697a6c0c30" });

            migrationBuilder.InsertData(
                schema: "Authentication",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "383929a2-6d64-485b-be94-5b212d52374c", "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f" },
                    { "2be63278-8807-4d8d-bfcc-828e26f90663", "a96fda13-9eee-4a49-94b7-ddf4c84ec61e" }
                });
        }
    }
}
