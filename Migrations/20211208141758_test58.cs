using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class test58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f457bdd-0bc0-48ff-a40c-adeb6dbbe003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2b08745-0342-4cfe-8b71-9d41febf53fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "292d2d89-e672-4b7c-912a-ef92f8c894ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c0f9391-fa0f-49f1-9930-3fe1e70681b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a5136fe-f3b4-49c8-b186-7b0cbf7059ec", "c9aca262-c30c-43f6-9045-e4acdef89262", "Admin", "ADMIN" },
                    { "ae1c3e53-359a-479b-bcad-2355ffeee397", "b0de0891-1724-4393-92a5-7b74479c85c1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1518e164-7095-49a5-90e1-be89a20632d0", 0, "1/1 1980", "95f5b2de-fff8-4f69-8b8f-590458e219d8", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEG88PStIvRFlDnl9lRioMSomCIhe+3oJzdbFALcqAy16CmdDKMhzUKIgk6LBTx/t6g==", null, false, "e90df0f6-5ad0-46d1-aeff-d68a9aa1b5eb", false, null },
                    { "6ccda77a-550f-4e3d-b9f9-7f92f5e6e16a", 0, "1/1 1990", "55dd79af-2ea1-4ba7-95c2-57fc3d62fcdb", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", null, "AQAAAAEAACcQAAAAEJRGBoGXzXgvpaNjqWNW07eu2AXo5AoeP82JnrgR3h4OT7h2SuONiGviFQ0fLHcFCw==", null, false, "99bb9c92-2a35-4e85-9d39-ffa072d3294a", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a5136fe-f3b4-49c8-b186-7b0cbf7059ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae1c3e53-359a-479b-bcad-2355ffeee397");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1518e164-7095-49a5-90e1-be89a20632d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ccda77a-550f-4e3d-b9f9-7f92f5e6e16a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f457bdd-0bc0-48ff-a40c-adeb6dbbe003", "f86512af-e5b1-488e-a1a5-9abd39c6fa29", "Admin", "ADMIN" },
                    { "e2b08745-0342-4cfe-8b71-9d41febf53fd", "88ade802-4410-4858-9d15-5a6cc05b2ff1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "292d2d89-e672-4b7c-912a-ef92f8c894ed", 0, "1/1 1980", "860ee39b-f4df-460b-9b00-6b5cf6816974", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEKUfQr1k2hbSdQWOCjjaMcaqmxZxbf1gC3q1P+27RLvkpFVN/RXsYjopsrrMfJVqMQ==", null, false, "76dd7fae-f820-4e8c-b4e2-f35a3a1d1c72", false, null },
                    { "9c0f9391-fa0f-49f1-9930-3fe1e70681b5", 0, "1/1 1990", "68bdc40a-000d-4391-bd4b-f4c3538cde18", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", null, "AQAAAAEAACcQAAAAEBmcO0fhMmquTj1GMGHqSwDHH5ibI1GKbAzAK+ckwOvF5o+AibfVbgpfR3HlaTB49Q==", null, false, "08d397dc-bf41-46dc-ac74-12cf0b888e6c", false, null }
                });
        }
    }
}
