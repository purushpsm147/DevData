using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedWtg_threshold_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_wtg_threshold",
                table: "wtg_threshold");

            migrationBuilder.RenameTable(
                name: "wtg_threshold",
                newName: "wtg_thresholds");

            migrationBuilder.AddPrimaryKey(
                name: "pk_wtg_thresholds",
                table: "wtg_thresholds",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_wtg_thresholds",
                table: "wtg_thresholds");

            migrationBuilder.RenameTable(
                name: "wtg_thresholds",
                newName: "wtg_threshold");

            migrationBuilder.AddPrimaryKey(
                name: "pk_wtg_threshold",
                table: "wtg_threshold",
                column: "id");
        }
    }
}
