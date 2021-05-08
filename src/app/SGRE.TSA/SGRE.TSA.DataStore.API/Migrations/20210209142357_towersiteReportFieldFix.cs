using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class towersiteReportFieldFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "weigth_kg",
                table: "towersite_report_total_sections_data",
                newName: "weight_kg");

            migrationBuilder.RenameColumn(
                name: "lenght_m",
                table: "towersite_report_total_sections_data",
                newName: "length_m");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "weight_kg",
                table: "towersite_report_total_sections_data",
                newName: "weigth_kg");

            migrationBuilder.RenameColumn(
                name: "length_m",
                table: "towersite_report_total_sections_data",
                newName: "lenght_m");
        }
    }
}
