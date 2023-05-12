using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class jaj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Vehicles_VehicleID",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "Images",
                newName: "VehiclesID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_VehicleID",
                table: "Images",
                newName: "IX_Images_VehiclesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Vehicles_VehiclesID",
                table: "Images",
                column: "VehiclesID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Vehicles_VehiclesID",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "VehiclesID",
                table: "Images",
                newName: "VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_VehiclesID",
                table: "Images",
                newName: "IX_Images_VehicleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Vehicles_VehicleID",
                table: "Images",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
