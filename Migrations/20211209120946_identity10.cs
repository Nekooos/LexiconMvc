using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class identity10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
