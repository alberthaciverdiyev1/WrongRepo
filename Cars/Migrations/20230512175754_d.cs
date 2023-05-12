using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BodyTypes_BodyTypeID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BodyTypeID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BodyTypeID",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "VehiclesID",
                table: "BodyTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BodyTypes_VehiclesID",
                table: "BodyTypes",
                column: "VehiclesID");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesID",
                table: "BodyTypes",
                column: "VehiclesID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesID",
                table: "BodyTypes");

            migrationBuilder.DropIndex(
                name: "IX_BodyTypes_VehiclesID",
                table: "BodyTypes");

            migrationBuilder.DropColumn(
                name: "VehiclesID",
                table: "BodyTypes");

            migrationBuilder.AddColumn<int>(
                name: "BodyTypeID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyTypeID",
                table: "Vehicles",
                column: "BodyTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BodyTypes_BodyTypeID",
                table: "Vehicles",
                column: "BodyTypeID",
                principalTable: "BodyTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
