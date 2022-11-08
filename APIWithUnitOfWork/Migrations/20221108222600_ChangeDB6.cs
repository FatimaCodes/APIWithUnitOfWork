using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class ChangeDB6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83f0b0dc-2e5d-41ed-875b-c2cb4b18905d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7dd8f85-bdb5-4e5b-a93c-4a0d9e8a086b");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Doctors",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_CategoryId",
                table: "Doctors",
                newName: "IX_Doctors_TypeId");

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9fbec549-f57f-4181-8bf1-df24c8612fc9", "1c54171c-230e-4998-ac8e-7a01342d75b2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d256cd6e-5725-4c70-a0fc-7b9e60f3c9ab", "bd0df3c0-08d2-4320-8d4b-f8cd2f71b868", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Types_TypeId",
                table: "Doctors",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Types_TypeId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fbec549-f57f-4181-8bf1-df24c8612fc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d256cd6e-5725-4c70-a0fc-7b9e60f3c9ab");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Doctors",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_TypeId",
                table: "Doctors",
                newName: "IX_Doctors_CategoryId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83f0b0dc-2e5d-41ed-875b-c2cb4b18905d", "f531a1ce-24b8-42a7-833a-77274f123480", "User", "USER" },
                    { "e7dd8f85-bdb5-4e5b-a93c-4a0d9e8a086b", "0d3b9a37-00bd-4fb9-97a1-11d16057c767", "Administrator", "ADMINISTRATOR" }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categories_CategoryId",
                table: "Doctors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
