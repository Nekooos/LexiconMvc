using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class identity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fadb03b-8a58-4bc2-aede-e309e137bb1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63379c04-235f-4ca9-92ba-96633f69a67d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ba2ca8d-727c-4555-8f94-b929a671cd95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95ccc393-31b7-42b4-8b85-a2768a2114d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b51a0594-859b-40a1-830b-27d217a76f31", "61a893ab-850d-4924-a4dd-9ce4ac809593", "Admin", "ADMIN" },
                    { "6f421e74-2faf-4048-bdc8-4eaf1cbca939", "a6415699-dd48-4a22-b29e-e436641bf6e9", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c81479b4-bd7a-4d1f-9046-b954b29977ab", 0, "1/1 1980", "5de4306f-e2f7-4033-9363-b3db0e3059d4", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEAOYbfrkYWHF7t89F9zeYpGhJRTvgceSN9RfsvQDBH2DyzaokslIhhrVl4chttKwSg==", null, false, "52b26317-717a-494e-abd1-ebeb7628c438", false, "admin@admin.com" },
                    { "fa7a9b42-bea4-40ad-ab2a-0e7f851456ee", 0, "1/1 1990", "2ae52e1c-efb8-4821-ba31-34d20d2b302c", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAEIuqOZ9+P7xhVSMCXrBKgNVTuLE8lJ5E9K3W7U5nZiiXwPOGWuDK9OK2E5onnmHwEQ==", null, false, "0ac9c109-7222-4251-9a71-166aa7e27c32", false, "user@user.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f421e74-2faf-4048-bdc8-4eaf1cbca939");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b51a0594-859b-40a1-830b-27d217a76f31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c81479b4-bd7a-4d1f-9046-b954b29977ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa7a9b42-bea4-40ad-ab2a-0e7f851456ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63379c04-235f-4ca9-92ba-96633f69a67d", "c0eb0830-19c1-4c60-9323-899ca383c4e7", "Admin", "ADMIN" },
                    { "0fadb03b-8a58-4bc2-aede-e309e137bb1a", "31f67155-48bd-486e-b145-d83001610e51", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "95ccc393-31b7-42b4-8b85-a2768a2114d9", 0, "1/1 1980", "d2b77aac-32aa-4aee-8a87-5fe1eff3c90c", null, false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEJ6PzSW/xlPTZK469tFScaI+BT7uYHZJkFrREv6oA0p++/wh2tbBCcR3YDOfAHaeqg==", null, false, "5479e9f9-4a9b-4924-8f2a-6471a780f5e3", false, "admin@admin.com" },
                    { "7ba2ca8d-727c-4555-8f94-b929a671cd95", 0, "1/1 1990", "4d03299b-83e8-43f4-aae8-80c18ca71af8", null, false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAELHWccBaHqwiW5sG6ddEL0dSeCbFeXRCuj0+g7F1zYjcb22miBbS0hayPKX/FoiXSg==", null, false, "b6bd8f9f-0fd6-48ce-84e3-151ab33d59f0", false, "user@user.com" }
                });
        }
    }
}
