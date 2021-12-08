using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class test57 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b95380d9-2111-4a84-8521-efecf65b7ce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef6c97ca-5299-4c2f-a690-29d265a36d5b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

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
    }
}
