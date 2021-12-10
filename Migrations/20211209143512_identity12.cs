using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class identity12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "95ce3f99-5b0c-41d7-ab5f-27f156ce5b21", "5084b69e-644a-4867-8680-7f1e617c64bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f2818213-cc57-4164-b3ec-865071aa1aa7", "2add90e4-8331-4376-ac4f-5c97b71eaef3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2add90e4-8331-4376-ac4f-5c97b71eaef3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5084b69e-644a-4867-8680-7f1e617c64bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95ce3f99-5b0c-41d7-ab5f-27f156ce5b21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2818213-cc57-4164-b3ec-865071aa1aa7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06152daa-3459-46cc-8c8f-8683a88ab17d", "0042f2a8-ca57-40b2-89d4-6d3486c863fb", "Admin", "ADMIN" },
                    { "c2fc9cd4-ada0-44f4-9a9a-b4d24d6bf9c6", "e98cdcbe-9264-439e-8ebe-b4f701b878aa", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f1af3b55-5d96-4e5b-86c3-ce6ea6b589bd", 0, "1/1 1980", "11e88562-9f67-473f-8dbf-e9df2a1be8bf", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFXmnRc9x60YYUYpp8JbG6h8VAAemDAbZNwmvRnYtZYhL4eshelVmNxNhiNn03DuMw==", null, false, "f50b8444-a7a9-4e07-9978-482b8ec25acd", false, "admin@admin.com" },
                    { "b6e04281-dc7b-4f1b-82a5-19e68a5e9f41", 0, "1/1 1990", "50eed44f-4b87-4377-b1e0-325c14a1b528", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAEAACcQAAAAEIj8xxTAKglIdqV8OjhPmU10ZtJhMTwrwazgukNz0JlIHsLF/CN3TlA6RI/tkxQKjw==", null, false, "38ff7dc2-6407-4f16-b2db-6b4a2bc351ad", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "f1af3b55-5d96-4e5b-86c3-ce6ea6b589bd", "06152daa-3459-46cc-8c8f-8683a88ab17d", "IdentityUserRole<string>" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "b6e04281-dc7b-4f1b-82a5-19e68a5e9f41", "c2fc9cd4-ada0-44f4-9a9a-b4d24d6bf9c6", "IdentityUserRole<string>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b6e04281-dc7b-4f1b-82a5-19e68a5e9f41", "c2fc9cd4-ada0-44f4-9a9a-b4d24d6bf9c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f1af3b55-5d96-4e5b-86c3-ce6ea6b589bd", "06152daa-3459-46cc-8c8f-8683a88ab17d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06152daa-3459-46cc-8c8f-8683a88ab17d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2fc9cd4-ada0-44f4-9a9a-b4d24d6bf9c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6e04281-dc7b-4f1b-82a5-19e68a5e9f41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1af3b55-5d96-4e5b-86c3-ce6ea6b589bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2add90e4-8331-4376-ac4f-5c97b71eaef3", "6b0c0427-f1c8-49ab-90e7-7b8a57b6697b", "Admin", "ADMIN" },
                    { "5084b69e-644a-4867-8680-7f1e617c64bc", "96a9c250-243f-4748-95c4-689a4010bfaa", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f2818213-cc57-4164-b3ec-865071aa1aa7", 0, "1/1 1980", "3e5a68f2-ffd1-441e-9cf6-12d97552278d", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEEokqwg065mbADI1mQx7W8bFej4GPQUQV98+PYrRmLtRuE205j3vNIvrHpMWAbjJPA==", null, false, "3d851f52-20d7-4a72-b2b8-31e25aecc964", false, "admin@admin.com" },
                    { "95ce3f99-5b0c-41d7-ab5f-27f156ce5b21", 0, "1/1 1990", "4c3a1822-401d-4bea-92c4-3cbc9a16bd83", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAENGpvNcdtKX9k7hUPzW3gxahk3TzeaR3lpiQYzavdpMBhzDGAtZPm9KBbMcXbndtQw==", null, false, "7cea78dc-a6a0-4977-b505-aa466a0ac8c9", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "f2818213-cc57-4164-b3ec-865071aa1aa7", "2add90e4-8331-4376-ac4f-5c97b71eaef3", "IdentityUserRole<string>" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "95ce3f99-5b0c-41d7-ab5f-27f156ce5b21", "5084b69e-644a-4867-8680-7f1e617c64bc", "IdentityUserRole<string>" });
        }
    }
}
