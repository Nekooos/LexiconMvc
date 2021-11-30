using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMvc.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 101, "Göteborg", "Kristoffer", "0701112233" },
                    { 102, "Växjö", "Marvin", "0701112244" },
                    { 103, "Växjö", "Malin", "0701112255" },
                    { 104, "Göteborg", "Sara", "0701112266" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 104);

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Göteborg", "Kristoffer", "0701112233" },
                    { 2, "Växjö", "Marvin", "0701112244" },
                    { 3, "Växjö", "Malin", "0701112255" },
                    { 4, "Göteborg", "Sara", "0701112266" }
                });
        }
    }
}
