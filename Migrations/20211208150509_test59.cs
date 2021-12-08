using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class test59 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
