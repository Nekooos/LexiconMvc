using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class identity11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3b9c4ffa-7fcb-4461-b0a8-2fea1210302b", "3f6c7cc5-385f-43dc-83e8-cf63807b7ae8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81075993-a067-4dd4-a240-a64a8cc60b62", "d8525f54-2606-4419-b91c-c59eebd0a129" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f6c7cc5-385f-43dc-83e8-cf63807b7ae8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8525f54-2606-4419-b91c-c59eebd0a129");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b9c4ffa-7fcb-4461-b0a8-2fea1210302b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81075993-a067-4dd4-a240-a64a8cc60b62");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "d8525f54-2606-4419-b91c-c59eebd0a129", "740f0c0c-b478-4dcb-a9c6-a0c46f7a5978", "Admin", "ADMIN" },
                    { "3f6c7cc5-385f-43dc-83e8-cf63807b7ae8", "207b8ca4-d72c-41b2-897d-f7cc12da5583", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "81075993-a067-4dd4-a240-a64a8cc60b62", 0, "1/1 1980", "8f3f62db-df2c-4412-b5e6-c816e7d29a75", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEP8dpbtL4O/CoaIbKpnd5Gr+RFr0WiCt7+VH9QYAt5BFx875V0c7Bq3JwZDK0m/+9A==", null, false, "88879a6c-0744-4a14-bc0c-853a356028b8", false, "admin@admin.com" },
                    { "3b9c4ffa-7fcb-4461-b0a8-2fea1210302b", 0, "1/1 1990", "82c512e1-f6e2-4b68-8c12-0348e9624a1b", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAEKjZWWUMggq3yukrnY5bosCLHjuNqjMI45EVLGDM3UYiyEzbsZWWkXmyXjfqIt1nqw==", null, false, "76393b6d-1c0a-4da2-b192-e2819fe519b5", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "81075993-a067-4dd4-a240-a64a8cc60b62", "d8525f54-2606-4419-b91c-c59eebd0a129", "IdentityUserRole<string>" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "3b9c4ffa-7fcb-4461-b0a8-2fea1210302b", "3f6c7cc5-385f-43dc-83e8-cf63807b7ae8", "IdentityUserRole<string>" });
        }
    }
}
