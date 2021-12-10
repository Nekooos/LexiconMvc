using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class identity9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6ef3ee3d-d4c0-4396-b5ae-0f430e8f51ab", "eed56306-6d5d-4421-bc24-fd007d0cb06f", "Admin", "ADMIN" },
                    { "c5614031-7ade-4596-be3b-0fd8171f3933", "ea64c4ff-e095-411e-a16a-346c6542d069", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4386e645-8c5a-4c5e-8f68-ef58b6506b14", 0, "1/1 1980", "0edafcba-0073-475c-80c4-4ca5a7027d97", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEHQ1F+obTS7y4qteKY3Of/ErxWj0fRU9advDNyD33pFMhjpUAg9hTLf3l//K39Tt/A==", null, false, "5d720509-b29b-425e-9a45-9693075d8e8e", false, "admin@admin.com" },
                    { "5e052217-62e1-4f9a-b4a6-29166a082dd9", 0, "1/1 1990", "9407e2bd-bd4e-4477-9b91-b6bf5f181071", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAEEtbHZrGJx9L+mHsU2lwqT8m/gQseLaXsjgOmnHtq9/XjC5P/556DjEEquRkJt+amA==", null, false, "421c9364-c293-4869-9375-dca8c14fbb1c", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "4386e645-8c5a-4c5e-8f68-ef58b6506b14", "6ef3ee3d-d4c0-4396-b5ae-0f430e8f51ab", "IdentityUserRole<string>" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "5e052217-62e1-4f9a-b4a6-29166a082dd9", "c5614031-7ade-4596-be3b-0fd8171f3933", "IdentityUserRole<string>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4386e645-8c5a-4c5e-8f68-ef58b6506b14", "6ef3ee3d-d4c0-4396-b5ae-0f430e8f51ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5e052217-62e1-4f9a-b4a6-29166a082dd9", "c5614031-7ade-4596-be3b-0fd8171f3933" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ef3ee3d-d4c0-4396-b5ae-0f430e8f51ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5614031-7ade-4596-be3b-0fd8171f3933");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4386e645-8c5a-4c5e-8f68-ef58b6506b14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e052217-62e1-4f9a-b4a6-29166a082dd9");

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
    }
}
