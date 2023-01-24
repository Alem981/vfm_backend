using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleFleetManagement.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "EnginPower", "ExpRegDate", "ModelId", "Registration", "Seats", "VehicleWeight" },
                values: new object[] { 7, 103, new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "S323-K-217", 5, 1275 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
