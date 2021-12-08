using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class test60 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22500370-a5ce-42d7-8bde-47ee98d153e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69400318-8df9-4af4-927f-5b3b3ff13e40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "806a41c9-7a22-471a-8b2a-628f08485644");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fb7a6a2-db61-4549-b615-a336155f2dcf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55d466fb-a154-476f-ae81-c4884d0585a3", "0db4f0eb-2d3c-46e7-b401-8f060c2c88ad", "Admin", "ADMIN" },
                    { "ff8cc382-6d2b-4a9f-b7c0-216bc387c71b", "18ff2481-4531-4974-8a4b-27b61e89625d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "eb12bc97-242a-4d9c-88a1-9a79774e097e", 0, "1/1 1980", "bf452211-080c-45e9-b1cf-bcce6f1d9571", null, false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEEgKeBZ832aHoWXza15UfcxFYEhWe929/7OLLLqEed5maqFrEI7CF42fG0U6blav0g==", null, false, "520303fd-5890-416a-9d28-d946e5e40134", false, "admin@admin.com" },
                    { "f980fc02-bafa-4fe2-86e7-e8693421c329", 0, "1/1 1990", "b1082360-a4c6-43c3-9f56-25e00bc58d64", null, false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAEMtgRwvOFLb6AO0IfQw3ty5lf/PsucLuMzhGl5QXeFDbp+yG+KgfTRldZKAwHHV0RA==", null, false, "23b403e3-cd15-407e-881c-1ec59a6ded63", false, "user@user.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55d466fb-a154-476f-ae81-c4884d0585a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff8cc382-6d2b-4a9f-b7c0-216bc387c71b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb12bc97-242a-4d9c-88a1-9a79774e097e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f980fc02-bafa-4fe2-86e7-e8693421c329");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69400318-8df9-4af4-927f-5b3b3ff13e40", "60c3528e-2de4-43cf-95da-a3e1f91ca8bf", "Admin", "ADMIN" },
                    { "22500370-a5ce-42d7-8bde-47ee98d153e4", "f1f34ea9-2f35-49e3-9ae7-90530aa1706d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "806a41c9-7a22-471a-8b2a-628f08485644", 0, "1/1 1980", "5d38e8bd-9639-4676-9a4a-d1936a64a024", null, false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAECQYAkgQytr4AQg7W6DvOwzIuOSG2lEfayM1O/XH3RFmgIfTjhf8Di9+WjGxQSn1tw==", null, false, "7b237c97-1a7f-4582-8d6c-d80ed94a3a85", false, "admin@admin.com" },
                    { "9fb7a6a2-db61-4549-b615-a336155f2dcf", 0, "1/1 1990", "20f15f6a-d46f-4a18-ac02-91273709c296", null, false, "User", "Usersson", false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAEKztdAjQvBd1o9rA9t4V6EN7Gir8ilCA44tdNjKvtBPlY2MoatUPWLcJSglyYGvuig==", null, false, "9f724b71-f32e-4f83-9c0a-98921afcc844", false, "user@user.com" }
                });
        }
    }
}
