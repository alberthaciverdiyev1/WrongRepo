using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesID",
                table: "BodyTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Vehicles_VehiclesID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleColors_Vehicles_VehiclesID",
                table: "VehicleColors");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTags_Colors_ColorsID",
                table: "VehicleTags");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropIndex(
                name: "IX_VehicleTags_ColorsID",
                table: "VehicleTags");

            migrationBuilder.DropIndex(
                name: "IX_VehicleColors_VehiclesID",
                table: "VehicleColors");

            migrationBuilder.DropIndex(
                name: "IX_Images_VehiclesID",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_BodyTypes_VehiclesID",
                table: "BodyTypes");

            migrationBuilder.DropColumn(
                name: "ColorsID",
                table: "VehicleTags");

            migrationBuilder.DropColumn(
                name: "VehiclesID",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "VehiclesID",
                table: "BodyTypes");

            migrationBuilder.AddColumn<int>(
                name: "BodyTypeID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImagesID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyTypeID",
                table: "Vehicles",
                column: "BodyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ImagesID",
                table: "Vehicles",
                column: "ImagesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BodyTypes_BodyTypeID",
                table: "Vehicles",
                column: "BodyTypeID",
                principalTable: "BodyTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Images_ImagesID",
                table: "Vehicles",
                column: "ImagesID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BodyTypes_BodyTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Images_ImagesID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BodyTypeID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ImagesID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BodyTypeID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ImagesID",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "ColorsID",
                table: "VehicleTags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiclesID",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehiclesID",
                table: "BodyTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclesID = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fuels_Vehicles_VehiclesID",
                        column: x => x.VehiclesID,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTags_ColorsID",
                table: "VehicleTags",
                column: "ColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColors_VehiclesID",
                table: "VehicleColors",
                column: "VehiclesID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_VehiclesID",
                table: "Images",
                column: "VehiclesID");

            migrationBuilder.CreateIndex(
                name: "IX_BodyTypes_VehiclesID",
                table: "BodyTypes",
                column: "VehiclesID");

            migrationBuilder.CreateIndex(
                name: "IX_Fuels_VehiclesID",
                table: "Fuels",
                column: "VehiclesID");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyTypes_Vehicles_VehiclesID",
                table: "BodyTypes",
                column: "VehiclesID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Vehicles_VehiclesID",
                table: "Images",
                column: "VehiclesID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleColors_Vehicles_VehiclesID",
                table: "VehicleColors",
                column: "VehiclesID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTags_Colors_ColorsID",
                table: "VehicleTags",
                column: "ColorsID",
                principalTable: "Colors",
                principalColumn: "ID");
        }
    }
}
