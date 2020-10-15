using Microsoft.EntityFrameworkCore.Migrations;

namespace OLLIMS_API.Migrations
{
    public partial class AddedForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasurementId",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "SOPId",
                table: "Instruments");

            migrationBuilder.AddColumn<int>(
                name: "Instruments",
                table: "InstrumentSOPs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SOP_trainees_EmployeeId",
                table: "SOP_trainees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SOP_trainees_SOPId",
                table: "SOP_trainees",
                column: "SOPId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_AccessLevelId",
                table: "Personel",
                column: "AccessLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementValues_MeasurementId",
                table: "MeasurementValues",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_InstrumentId",
                table: "Measurements",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentSOPs_Instruments",
                table: "InstrumentSOPs",
                column: "Instruments");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_LaboratoryId",
                table: "Instruments",
                column: "LaboratoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Laboratories_LaboratoryId",
                table: "Instruments",
                column: "LaboratoryId",
                principalTable: "Laboratories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentSOPs_Instruments_Instruments",
                table: "InstrumentSOPs",
                column: "Instruments",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Instruments_InstrumentId",
                table: "Measurements",
                column: "InstrumentId",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeasurementValues_Measurements_MeasurementId",
                table: "MeasurementValues",
                column: "MeasurementId",
                principalTable: "Measurements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personel_AccessLevels_AccessLevelId",
                table: "Personel",
                column: "AccessLevelId",
                principalTable: "AccessLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SOP_trainees_Personel_EmployeeId",
                table: "SOP_trainees",
                column: "EmployeeId",
                principalTable: "Personel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SOP_trainees_InstrumentSOPs_SOPId",
                table: "SOP_trainees",
                column: "SOPId",
                principalTable: "InstrumentSOPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Laboratories_LaboratoryId",
                table: "Instruments");

            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentSOPs_Instruments_Instruments",
                table: "InstrumentSOPs");

            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Instruments_InstrumentId",
                table: "Measurements");

            migrationBuilder.DropForeignKey(
                name: "FK_MeasurementValues_Measurements_MeasurementId",
                table: "MeasurementValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Personel_AccessLevels_AccessLevelId",
                table: "Personel");

            migrationBuilder.DropForeignKey(
                name: "FK_SOP_trainees_Personel_EmployeeId",
                table: "SOP_trainees");

            migrationBuilder.DropForeignKey(
                name: "FK_SOP_trainees_InstrumentSOPs_SOPId",
                table: "SOP_trainees");

            migrationBuilder.DropIndex(
                name: "IX_SOP_trainees_EmployeeId",
                table: "SOP_trainees");

            migrationBuilder.DropIndex(
                name: "IX_SOP_trainees_SOPId",
                table: "SOP_trainees");

            migrationBuilder.DropIndex(
                name: "IX_Personel_AccessLevelId",
                table: "Personel");

            migrationBuilder.DropIndex(
                name: "IX_MeasurementValues_MeasurementId",
                table: "MeasurementValues");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_InstrumentId",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_InstrumentSOPs_Instruments",
                table: "InstrumentSOPs");

            migrationBuilder.DropIndex(
                name: "IX_Instruments_LaboratoryId",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "Instruments",
                table: "InstrumentSOPs");

            migrationBuilder.AddColumn<int>(
                name: "MeasurementId",
                table: "Instruments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SOPId",
                table: "Instruments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
