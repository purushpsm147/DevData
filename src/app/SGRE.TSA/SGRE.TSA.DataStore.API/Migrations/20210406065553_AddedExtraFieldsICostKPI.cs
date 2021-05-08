using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedExtraFieldsICostKPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "total_tower_exw_cost",
                table: "scenario_costs_kpis",
                newName: "total_tower_exw_cost_signature");

            migrationBuilder.RenameColumn(
                name: "total_cost",
                table: "scenario_costs_kpis",
                newName: "total_tower_exw_cost_offer");

            migrationBuilder.AddColumn<decimal>(
                name: "total_cost_nomination",
                table: "scenario_costs_kpis",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "total_cost_offer",
                table: "scenario_costs_kpis",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "total_cost_signature",
                table: "scenario_costs_kpis",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "total_tower_exw_cost_nomination",
                table: "scenario_costs_kpis",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "total_cost_nomination",
                table: "scenario_costs_kpis");

            migrationBuilder.DropColumn(
                name: "total_cost_offer",
                table: "scenario_costs_kpis");

            migrationBuilder.DropColumn(
                name: "total_cost_signature",
                table: "scenario_costs_kpis");

            migrationBuilder.DropColumn(
                name: "total_tower_exw_cost_nomination",
                table: "scenario_costs_kpis");

            migrationBuilder.RenameColumn(
                name: "total_tower_exw_cost_signature",
                table: "scenario_costs_kpis",
                newName: "total_tower_exw_cost");

            migrationBuilder.RenameColumn(
                name: "total_tower_exw_cost_offer",
                table: "scenario_costs_kpis",
                newName: "total_cost");
        }
    }
}
