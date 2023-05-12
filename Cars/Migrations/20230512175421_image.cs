using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Images_ImagesID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ImagesID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ImagesID",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "VehicleID",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Images_VehicleID",
                table: "Images",
                column: "VehicleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Vehicles_VehicleID",
                table: "Images",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Vehicles_VehicleID",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_VehicleID",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "VehicleID",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "ImagesID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ImagesID",
                table: "Vehicles",
                column: "ImagesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Images_ImagesID",
                table: "Vehicles",
                column: "ImagesID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
