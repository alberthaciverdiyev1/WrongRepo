using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class nb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesId",
                table: "BodyTypes");

            migrationBuilder.DropIndex(
                name: "IX_BodyTypes_VehiclesId",
                table: "BodyTypes");

            migrationBuilder.DropColumn(
                name: "VehiclesId",
                table: "BodyTypes");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColors_VehiclesID",
                table: "VehicleColors",
                column: "VehiclesID");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleColors_Vehicles_VehiclesID",
                table: "VehicleColors",
                column: "VehiclesID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleColors_Vehicles_VehiclesID",
                table: "VehicleColors");

            migrationBuilder.DropIndex(
                name: "IX_VehicleColors_VehiclesID",
                table: "VehicleColors");

            migrationBuilder.AddColumn<int>(
                name: "VehiclesId",
                table: "BodyTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BodyTypes_VehiclesId",
                table: "BodyTypes",
                column: "VehiclesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesId",
                table: "BodyTypes",
                column: "VehiclesId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }
    }
}
