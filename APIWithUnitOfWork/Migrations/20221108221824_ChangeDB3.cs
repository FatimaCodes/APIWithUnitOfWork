using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class ChangeDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38f19389-a952-4081-8a6e-028447546296");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0ae2ed6-76c5-4945-a515-b9d7c0b1a499");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2406b89-5dd2-4c1a-9aa8-96d181f1cdcc", "1cf22493-93de-4ca4-baa1-a2961036c73d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc0b1ca5-68f5-45a6-9803-d1c90d12ea12", "20122c26-c305-472d-bb8e-81e2a095cbac", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc0b1ca5-68f5-45a6-9803-d1c90d12ea12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2406b89-5dd2-4c1a-9aa8-96d181f1cdcc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0ae2ed6-76c5-4945-a515-b9d7c0b1a499", "f0cf3a9c-f0f4-4888-bd6c-5a51326ee87f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38f19389-a952-4081-8a6e-028447546296", "106b6532-6a30-42db-b6ae-f41a2c85e580", "Administrator", "ADMINISTRATOR" });
        }
    }
}
