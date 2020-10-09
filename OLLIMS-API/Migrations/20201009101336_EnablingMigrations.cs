using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OLLIMS_API.Migrations
{
    public partial class EnablingMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accessLevels");

            migrationBuilder.DropTable(
                name: "instruments");

            migrationBuilder.DropTable(
                name: "measurementValues");

            migrationBuilder.DropTable(
                name: "SOP_trainees");

            migrationBuilder.DropTable(
                name: "laboratories");

            migrationBuilder.DropTable(
                name: "measurements");

            migrationBuilder.DropTable(
                name: "personel");

            migrationBuilder.DropTable(
                name: "SOP");
        }
    }
}
