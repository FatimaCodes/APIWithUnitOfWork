using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "rhinoplasty" },
                    { 2, "Dentist" },
                    { 3, "Cardiologist" },
                    { 4, "Urology" },
                    { 5, "Oncology" },
                    { 6, "exp-spine-surgery" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Turkey", "TR" },
                    { 2, "Iran", "IR" },
                    { 3, "Jamaica", "JM" },
                    { 4, "Bahamas", "BS" },
                    { 5, "Cayman Island", "CI" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "CategortyId", "CountryId", "Name", "Rating", "Surname" },
                values: new object[,]
                {
                    { 1, "Address1", 1, 1, "Mina", 5.0, "Amini" },
                    { 2, "Address1", 1, 1, "Andi", 4.4000000000000004, "Naiak" },
                    { 3, "Address1", 1, 1, "Sara", 3.5, "Doniat" },
                    { 4, "Address1", 4, 2, "John", 4.9000000000000004, "Wilson" },
                    { 5, "Address1", 5, 3, "Adams", 3.7999999999999998, "Robinson" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
