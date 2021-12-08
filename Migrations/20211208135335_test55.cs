using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class test55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserRole<Guid>");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "RoleId1",
                table: "AspNetUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "AspNetUserRoles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
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
                    { "898c7ba4-3364-448b-a2f0-e3d3d07c82cb", 0, null, "939b6b70-beee-47e1-9334-cbdace7108f0", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEDeGFy3hatlGw+zV3aGEbWN5Bw4kZmKdCeMEN2p1FCDB8oiNVginMWHy1nAaeu9YyA==", null, false, "d96c88b3-0095-4961-9653-b2925b3f84e8", false, null },
                    { "00c3b3df-704d-4929-84c0-19a880fe402e", 0, null, "4ecf4329-f937-47b3-8d3e-a5abc82c56ac", "user@user.com", false, "User", "Usersson", false, null, "USER@USER.COM", "USER", null, "AQAAAAEAACcQAAAAEOmL5pwqIYeuIkusce1S+vNjYjaDT4kRjn2vHvQW+28aFGZNTgrbEvAvjKi2iVGqpQ==", null, false, "6392b667-62b0-4807-9f68-da5fe7a4eabd", false, null }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "afd5fb54-c303-4841-b42c-062acc4bbe77", "9a03543e-9102-44fe-b469-94beb7b027a1", "Admin", "ADMIN" },
                    { "370814bf-68c0-48ca-9186-da4b04d63f44", "08afb684-1178-4f73-a5c5-1097b29c1044", "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00c3b3df-704d-4929-84c0-19a880fe402e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "898c7ba4-3364-448b-a2f0-e3d3d07c82cb");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<Guid>",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<Guid>", x => new { x.UserId, x.RoleId });
                });
        }
    }
}
