using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class nn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesID",
                table: "BodyTypes");

            migrationBuilder.RenameColumn(
                name: "VehiclesID",
                table: "BodyTypes",
                newName: "VehiclesId");

            migrationBuilder.RenameIndex(
                name: "IX_BodyTypes_VehiclesID",
                table: "BodyTypes",
                newName: "IX_BodyTypes_VehiclesId");

            migrationBuilder.AddColumn<int>(
                name: "BodyTypeID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VehiclesId",
                table: "BodyTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyTypeID",
                table: "Vehicles",
                column: "BodyTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesId",
                table: "BodyTypes",
                column: "VehiclesId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BodyTypes_BodyTypeID",
                table: "Vehicles",
                column: "BodyTypeID",
                principalTable: "BodyTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesId",
                table: "BodyTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BodyTypes_BodyTypeID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BodyTypeID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BodyTypeID",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "VehiclesId",
                table: "BodyTypes",
                newName: "VehiclesID");

            migrationBuilder.RenameIndex(
                name: "IX_BodyTypes_VehiclesId",
                table: "BodyTypes",
                newName: "IX_BodyTypes_VehiclesID");

            migrationBuilder.AlterColumn<int>(
                name: "VehiclesID",
                table: "BodyTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesID",
                table: "BodyTypes",
                column: "VehiclesID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
