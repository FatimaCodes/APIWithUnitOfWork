using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class ChangeDB4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc0b1ca5-68f5-45a6-9803-d1c90d12ea12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2406b89-5dd2-4c1a-9aa8-96d181f1cdcc");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Doctors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83f0b0dc-2e5d-41ed-875b-c2cb4b18905d", "f531a1ce-24b8-42a7-833a-77274f123480", "User", "USER" },
                    { "e7dd8f85-bdb5-4e5b-a93c-4a0d9e8a086b", "0d3b9a37-00bd-4fb9-97a1-11d16057c767", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83f0b0dc-2e5d-41ed-875b-c2cb4b18905d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7dd8f85-bdb5-4e5b-a93c-4a0d9e8a086b");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d2406b89-5dd2-4c1a-9aa8-96d181f1cdcc", "1cf22493-93de-4ca4-baa1-a2961036c73d", "User", "USER" },
                    { "cc0b1ca5-68f5-45a6-9803-d1c90d12ea12", "20122c26-c305-472d-bb8e-81e2a095cbac", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 5);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
