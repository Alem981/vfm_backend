using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleFleetManagement.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    VehicleWeight = table.Column<int>(type: "int", nullable: false),
                    ExpRegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnginPower = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Models_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Acura" },
                    { 2, "Alfa Romeo" },
                    { 3, "Aston Martin" },
                    { 4, "Audi" },
                    { 5, "Bentley" },
                    { 6, "BMW" },
                    { 7, "Bugatti" },
                    { 8, "Buick" },
                    { 9, "Cadillac" },
                    { 10, "Chevrolet" },
                    { 11, "Chrysler" },
                    { 12, "Citroen" },
                    { 13, "Cupra" },
                    { 14, "Dacia" },
                    { 15, "Daewoo" },
                    { 16, "Dodge" },
                    { 17, "DS Automobiles" },
                    { 18, "Ferrari" },
                    { 19, "Fiat" },
                    { 20, "Ford" },
                    { 21, "GMC" },
                    { 22, "Holden" },
                    { 23, "Honda" },
                    { 24, "Hummer" },
                    { 25, "Hyundai" },
                    { 26, "Infiniti" },
                    { 27, "Isuzu" },
                    { 28, "Jaguar" },
                    { 29, "Jeep" },
                    { 30, "Kia" },
                    { 31, "Koenigsegg" },
                    { 32, "Lada" },
                    { 33, "Lamborghini" },
                    { 34, "Lancia" },
                    { 35, "Land Rover" },
                    { 36, "Lexus" },
                    { 37, "Lincoln" },
                    { 38, "Lotus" },
                    { 39, "Maserati" },
                    { 40, "Maybach" },
                    { 41, "Mazda" },
                    { 42, "McLaren" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 43, "Mercedes-Benz" },
                    { 44, "Mini" },
                    { 45, "Mitsubishi" },
                    { 46, "Nissan" },
                    { 47, "Opel" },
                    { 48, "Pagani" },
                    { 49, "Peugeot" },
                    { 50, "Pontiac" },
                    { 51, "Porsche" },
                    { 52, "Ram" },
                    { 53, "Renault" },
                    { 54, "Rimac" },
                    { 55, "Rolls-Royce" },
                    { 56, "Saab" },
                    { 57, "Saleen" },
                    { 58, "Scion" },
                    { 59, "Seat" },
                    { 60, "Škoda" },
                    { 61, "Smart" },
                    { 62, "Subaru" },
                    { 63, "Suzuki" },
                    { 64, "Tesla" },
                    { 65, "Toyota" },
                    { 66, "Vauxhall" },
                    { 67, "Volkswagen" },
                    { 68, "Volvo" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "EnginPower", "ExpRegDate", "ModelId", "Registration", "Seats", "VehicleWeight" },
                values: new object[,]
                {
                    { 1, 265, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "A08-I-415", 7, 1600 },
                    { 2, 375, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "A68-E-425", 5, 1450 },
                    { 3, 309, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, "M55-A-405", 5, 1575 },
                    { 5, 309, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "M21-E-452", 5, 1575 },
                    { 6, 125, new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "M33-K-217", 5, 1475 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name", "VehicleId" },
                values: new object[,]
                {
                    { 1, 1, "CDX", null },
                    { 2, 1, "ILX", null },
                    { 3, 1, "MDX", null },
                    { 4, 1, "NSX", null },
                    { 5, 1, "RDX", null },
                    { 23, 2, "Giulia", null },
                    { 24, 2, "Giulietta", null },
                    { 25, 2, "Stelvio", null },
                    { 26, 2, "Tonale", null },
                    { 27, 2, "146", null },
                    { 28, 2, "147", null },
                    { 54, 3, "DB11", null },
                    { 55, 3, "DBS Superleggera", null },
                    { 56, 3, "DBX", null },
                    { 57, 3, "V12 Vantage", null },
                    { 58, 3, "Valkyrie", null },
                    { 80, 4, "A1", null },
                    { 81, 4, "A1 citycarver", null },
                    { 82, 4, "A3", null },
                    { 83, 4, "A4", null },
                    { 84, 4, "A4 Allroad", null },
                    { 85, 4, "A5", null },
                    { 86, 4, "A6", null },
                    { 87, 4, "A6 Allroad", null },
                    { 101, 4, "Q8", null },
                    { 102, 4, "R8", null },
                    { 103, 4, "RS e-tron GT", null },
                    { 104, 4, "RS Q3", null },
                    { 105, 4, "RS Q3 Sportback", null },
                    { 106, 4, "RS Q8", null },
                    { 107, 4, "RS3", null },
                    { 108, 4, "RS4", null },
                    { 109, 4, "RS5", null },
                    { 110, 4, "RS6", null },
                    { 111, 4, "RS7", null },
                    { 112, 4, "S3", null },
                    { 113, 4, "S4", null },
                    { 114, 4, "S5", null },
                    { 115, 4, "S6", null },
                    { 116, 4, "S7", null },
                    { 117, 4, "S8", null },
                    { 118, 4, "SQ2", null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name", "VehicleId" },
                values: new object[,]
                {
                    { 119, 4, "SQ5", null },
                    { 120, 4, "SQ5 Sportback", null },
                    { 121, 4, "SQ7", null },
                    { 122, 4, "SQ8", null },
                    { 123, 4, "TT", null },
                    { 124, 4, "TT RS", null },
                    { 125, 4, "TT S", null },
                    { 126, 4, "100", null },
                    { 127, 4, "200", null },
                    { 128, 4, "4000", null },
                    { 129, 4, "5+5", null },
                    { 130, 4, "5000", null },
                    { 131, 4, "80", null },
                    { 132, 4, "90", null },
                    { 133, 4, "A2", null },
                    { 134, 4, "Allroad", null },
                    { 135, 4, "Cabriolet", null },
                    { 136, 4, "Coupe", null },
                    { 137, 4, "RS2", null },
                    { 138, 4, "S1", null },
                    { 139, 4, "S2", null },
                    { 140, 4, "V8", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_VehicleId",
                table: "Models",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
