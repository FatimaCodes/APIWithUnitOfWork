using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWithUnitOfWork.Migrations
{
    public partial class EditModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Doctors_DoctorId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Doctors_DoctorId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_DoctorId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DoctorId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategortyId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CategortyId",
                table: "Doctors",
                column: "CategortyId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CountryId",
                table: "Doctors",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categories_CategortyId",
                table: "Doctors",
                column: "CategortyId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Countries_CountryId",
                table: "Doctors",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categories_CategortyId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Countries_CountryId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_CategortyId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_CountryId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CategortyId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DoctorId",
                table: "Countries",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DoctorId",
                table: "Categories",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Doctors_DoctorId",
                table: "Categories",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Doctors_DoctorId",
                table: "Countries",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
