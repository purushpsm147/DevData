using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class modifingtowersitandsstTowerColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_pause_scenario",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "is_retire_scenario",
                table: "sst_design_evaluation");

            migrationBuilder.AddColumn<string>(
                name: "error_code",
                table: "sst_tower",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "error_code",
                table: "sst_tower");

            migrationBuilder.AddColumn<bool>(
                name: "is_pause_scenario",
                table: "sst_design_evaluation",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_retire_scenario",
                table: "sst_design_evaluation",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
