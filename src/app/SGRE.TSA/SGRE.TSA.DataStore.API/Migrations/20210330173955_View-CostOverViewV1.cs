using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ViewCostOverViewV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_technology_cost_feed_back_cost_feeback_id",
                table: "costs_technology");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_technology",
                newName: "cost_feedback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_technology_cost_feeback_id",
                table: "costs_technology",
                newName: "ix_costs_technology_cost_feedback_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_technology_cost_feed_back_cost_feedback_id",
                table: "costs_technology",
                column: "cost_feedback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_technology_cost_feed_back_cost_feedback_id",
                table: "costs_technology");

            migrationBuilder.RenameColumn(
                name: "cost_feedback_id",
                table: "costs_technology",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_technology_cost_feedback_id",
                table: "costs_technology",
                newName: "ix_costs_technology_cost_feeback_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_technology_cost_feed_back_cost_feeback_id",
                table: "costs_technology",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
