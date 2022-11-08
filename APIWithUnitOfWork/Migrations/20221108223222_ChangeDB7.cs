using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class ChangeDB7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Types_TypeId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_TypeId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fbec549-f57f-4181-8bf1-df24c8612fc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d256cd6e-5725-4c70-a0fc-7b9e60f3c9ab");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50577236-0dd7-478f-8e13-69ade0df06bc", "047eac05-c102-4abf-aa9b-e0b367280581", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce87670b-fc9a-4da0-9c1b-1f57a2e9d5ed", "258f9cb9-d90a-4225-a30e-40c78be86f51", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50577236-0dd7-478f-8e13-69ade0df06bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce87670b-fc9a-4da0-9c1b-1f57a2e9d5ed");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Doctors",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_TypeId",
                table: "Doctors",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Types_TypeId",
                table: "Doctors",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
