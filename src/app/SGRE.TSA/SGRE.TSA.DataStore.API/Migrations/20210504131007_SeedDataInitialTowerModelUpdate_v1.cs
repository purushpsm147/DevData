using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeedDataInitialTowerModelUpdate_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 17,
                column: "model",
                value: "STD_CII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 18,
                column: "model",
                value: "STD_CII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 19,
                column: "model",
                value: "STD_CIII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 20,
                column: "model",
                value: "STD_CIII");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 17,
                column: "model",
                value: "STD");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 18,
                column: "model",
                value: "STD");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 19,
                column: "model",
                value: "STD");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 20,
                column: "model",
                value: "STD");
        }
    }
}
