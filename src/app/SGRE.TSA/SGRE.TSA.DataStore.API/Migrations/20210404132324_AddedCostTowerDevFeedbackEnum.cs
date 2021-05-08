using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedCostTowerDevFeedbackEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_feedback",
                table: "costs_technology");

            migrationBuilder.AddColumn<int>(
                name: "cost_tower_dev_feedback",
                table: "costs_technology",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cost_tower_dev_feedback",
                table: "costs_technology");

            migrationBuilder.AddColumn<bool>(
                name: "is_feedback",
                table: "costs_technology",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
