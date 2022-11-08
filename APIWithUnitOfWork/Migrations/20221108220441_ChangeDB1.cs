using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class ChangeDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51e359a0-3cf0-4ecf-a439-cb724c011c8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cc38395-eeab-4731-af3c-43eb1c76010e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dc59ada-7c17-4057-9555-d26d2462bd6c", "4236bf64-b257-4d19-a3d0-35b76b8222bb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08962348-5bfa-45b3-a080-85bd8404ffad", "5460ab59-b08c-4bc9-b376-396cc43a9ead", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08962348-5bfa-45b3-a080-85bd8404ffad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dc59ada-7c17-4057-9555-d26d2462bd6c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51e359a0-3cf0-4ecf-a439-cb724c011c8a", "e212d22b-a2b1-47f1-aac1-eb2c42d31141", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cc38395-eeab-4731-af3c-43eb1c76010e", "5bc11f37-1a6b-495b-9941-55d3fe6baf63", "Administrator", "ADMINISTRATOR" });
        }
    }
}
