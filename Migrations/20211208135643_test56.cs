using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class test56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00c3b3df-704d-4929-84c0-19a880fe402e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "898c7ba4-3364-448b-a2f0-e3d3d07c82cb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "370814bf-68c0-48ca-9186-da4b04d63f44");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "afd5fb54-c303-4841-b42c-062acc4bbe77");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ef6c97ca-5299-4c2f-a690-29d265a36d5b", 0, "1/1 1980", "ca689220-9f87-42b6-afa7-5ec63bfbd6bc", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEMjAHr5WrcUO+PL594GaAruXE98zkuOC06g2sPNTSaNZc6UqK+P84CbkTjpGe2bLrw==", null, false, "157b651d-1784-4651-84f2-7eb6ed692366", false, null },
                    { "b95380d9-2111-4a84-8521-efecf65b7ce7", 0, "1/1 1990", "4d415628-a208-42db-b091-b2db68a8c743", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", null, "AQAAAAEAACcQAAAAED1Bm4TQdWsDMa0xdHUPCdZMtN5pni2xFlgxnFduaqH0xvatLesvck+Yv3OVzO8AXA==", null, false, "dd82992a-8580-405a-89c3-f63105c7158b", false, null }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d4f84cd9-780d-4e5e-a37e-ca5d3c08d12f", "d105a4f2-8980-4454-9132-c2d12003234a", "Admin", "ADMIN" },
                    { "beca47ff-dfd0-4ee5-a2da-b4697f98e3e3", "33756978-ea56-4d8f-9398-f0c88300323a", "User", "USER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b95380d9-2111-4a84-8521-efecf65b7ce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef6c97ca-5299-4c2f-a690-29d265a36d5b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "beca47ff-dfd0-4ee5-a2da-b4697f98e3e3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d4f84cd9-780d-4e5e-a37e-ca5d3c08d12f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "898c7ba4-3364-448b-a2f0-e3d3d07c82cb", 0, null, "939b6b70-beee-47e1-9334-cbdace7108f0", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEDeGFy3hatlGw+zV3aGEbWN5Bw4kZmKdCeMEN2p1FCDB8oiNVginMWHy1nAaeu9YyA==", null, false, "d96c88b3-0095-4961-9653-b2925b3f84e8", false, null },
                    { "00c3b3df-704d-4929-84c0-19a880fe402e", 0, null, "4ecf4329-f937-47b3-8d3e-a5abc82c56ac", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", null, "AQAAAAEAACcQAAAAEOmL5pwqIYeuIkusce1S+vNjYjaDT4kRjn2vHvQW+28aFGZNTgrbEvAvjKi2iVGqpQ==", null, false, "6392b667-62b0-4807-9f68-da5fe7a4eabd", false, null }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "afd5fb54-c303-4841-b42c-062acc4bbe77", "9a03543e-9102-44fe-b469-94beb7b027a1", "Admin", "ADMIN" },
                    { "370814bf-68c0-48ca-9186-da4b04d63f44", "08afb684-1178-4f73-a5c5-1097b29c1044", "User", "USER" }
                });
        }
    }
}
