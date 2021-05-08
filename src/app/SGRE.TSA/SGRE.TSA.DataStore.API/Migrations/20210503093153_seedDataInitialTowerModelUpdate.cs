using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class seedDataInitialTowerModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 25,
                column: "hub_height_max_m",
                value: 91.75m);

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 11,
                column: "model",
                value: "STD_CIII");

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 12,
                column: "model",
                value: "STD_CII");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 25,
                column: "hub_height_max_m",
                value: 110m);

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 11,
                column: "model",
                value: "STD");

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 12,
                column: "model",
                value: "STD");
        }
    }
}
