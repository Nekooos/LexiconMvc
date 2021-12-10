using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class identity8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "b20e599a-d678-4a44-a017-7dddf6dac786", "34dcb651-e4ab-4177-93e0-45c28f66c8fe", "Admin", "ADMIN" },
                    { "e2c50ce0-4a5f-4555-8f0a-2cd6137b2a23", "5a27715e-d1d2-4508-b240-dd85a985c883", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9e887d32-78d3-4425-ab3a-2d2aaaefdd1d", 0, "1/1 1980", "384d7652-ce56-480f-9298-ea23f781f76c", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEBl4wq5PdT9Cd/oiXp7836+oZnHD1LGlI/vjrQ1DF1TmyZjn+5kyWQtsgJ7CnrH37w==", null, false, "b97145ff-fe52-498e-8f1a-42c5d834185c", false, "admin@admin.com" },
                    { "ce213a0d-931d-409a-85af-f2ae3d23220d", 0, "1/1 1990", "d2f78baf-973a-47fc-aa74-2c0f1c9c315a", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAEOE5F+WQf9kYjZ1AAnbLDh9B3TLwrGsJRKXw05tVfOCEJ+wuk2HEi7LbtAm1Yb9WAQ==", null, false, "c2ae66ac-8afa-49c5-8406-47ecf5d02951", false, "user@user.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20e599a-d678-4a44-a017-7dddf6dac786");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2c50ce0-4a5f-4555-8f0a-2cd6137b2a23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e887d32-78d3-4425-ab3a-2d2aaaefdd1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce213a0d-931d-409a-85af-f2ae3d23220d");

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
    }
}
