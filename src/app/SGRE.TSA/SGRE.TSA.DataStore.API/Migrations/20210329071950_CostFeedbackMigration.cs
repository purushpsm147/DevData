using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class CostFeedbackMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cost_over_view_cost_over_view_meta_cost_over_view_meta_id",
                table: "cost_over_view");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_construction_lead_time_cost_over_view_cost_over",
                table: "costs_tower_construction_lead_time");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_lead_time_cost_over_view_cost_over_vi",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.DropIndex(
                name: "ix_cost_over_view_cost_over_view_meta_id",
                table: "cost_over_view");

            migrationBuilder.DropColumn(
                name: "cost_over_view_meta_id",
                table: "cost_over_view");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_construction_lead_time_cost_over_view_cost_over_v",
                table: "costs_tower_construction_lead_time",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_lead_time_cost_over_view_cost_over_view",
                table: "costs_tower_logistics_lead_time",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_construction_lead_time_cost_over_view_cost_over_v",
                table: "costs_tower_construction_lead_time");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_lead_time_cost_over_view_cost_over_view",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.AddColumn<int>(
                name: "cost_over_view_meta_id",
                table: "cost_over_view",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_cost_over_view_cost_over_view_meta_id",
                table: "cost_over_view",
                column: "cost_over_view_meta_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cost_over_view_cost_over_view_meta_cost_over_view_meta_id",
                table: "cost_over_view",
                column: "cost_over_view_meta_id",
                principalTable: "cost_over_view_meta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_construction_lead_time_cost_over_view_cost_over",
                table: "costs_tower_construction_lead_time",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_lead_time_cost_over_view_cost_over_vi",
                table: "costs_tower_logistics_lead_time",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
