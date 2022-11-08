using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class ChangeDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categories_CategortyId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08962348-5bfa-45b3-a080-85bd8404ffad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dc59ada-7c17-4057-9555-d26d2462bd6c");

            migrationBuilder.RenameColumn(
                name: "CategortyId",
                table: "Doctors",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_CategortyId",
                table: "Doctors",
                newName: "IX_Doctors_CategoryId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0ae2ed6-76c5-4945-a515-b9d7c0b1a499", "f0cf3a9c-f0f4-4888-bd6c-5a51326ee87f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38f19389-a952-4081-8a6e-028447546296", "106b6532-6a30-42db-b6ae-f41a2c85e580", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38f19389-a952-4081-8a6e-028447546296");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0ae2ed6-76c5-4945-a515-b9d7c0b1a499");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Doctors",
                newName: "CategortyId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_CategoryId",
                table: "Doctors",
                newName: "IX_Doctors_CategortyId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dc59ada-7c17-4057-9555-d26d2462bd6c", "4236bf64-b257-4d19-a3d0-35b76b8222bb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08962348-5bfa-45b3-a080-85bd8404ffad", "5460ab59-b08c-4bc9-b376-396cc43a9ead", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categories_CategortyId",
                table: "Doctors",
                column: "CategortyId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
