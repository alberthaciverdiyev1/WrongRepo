using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class CreateAndSetDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProducedYear = table.Column<int>(type: "int", nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BodyTypes_Vehicles_VehiclesID",
                        column: x => x.VehiclesID,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclesID = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    VehiclesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Vehicles_VehiclesID",
                        column: x => x.VehiclesID,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleColors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclesID = table.Column<int>(type: "int", nullable: false),
                    ColorsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VehicleColors_Colors_ColorsID",
                        column: x => x.ColorsID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleColors_Vehicles_VehiclesID",
                        column: x => x.VehiclesID,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclesID = table.Column<int>(type: "int", nullable: false),
                    TagsID = table.Column<int>(type: "int", nullable: false),
                    ColorsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VehicleTags_Colors_ColorsID",
                        column: x => x.ColorsID,
                        principalTable: "Colors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VehicleTags_Tags_TagsID",
                        column: x => x.TagsID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleTags_Vehicles_VehiclesID",
                        column: x => x.VehiclesID,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyTypes_VehiclesID",
                table: "BodyTypes",
                column: "VehiclesID");

            migrationBuilder.CreateIndex(
                name: "IX_Fuels_VehiclesID",
                table: "Fuels",
                column: "VehiclesID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_VehiclesID",
                table: "Images",
                column: "VehiclesID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColors_ColorsID",
                table: "VehicleColors",
                column: "ColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColors_VehiclesID",
                table: "VehicleColors",
                column: "VehiclesID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTags_ColorsID",
                table: "VehicleTags",
                column: "ColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTags_TagsID",
                table: "VehicleTags",
                column: "TagsID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTags_VehiclesID",
                table: "VehicleTags",
                column: "VehiclesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyTypes");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "VehicleColors");

            migrationBuilder.DropTable(
                name: "VehicleTags");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
