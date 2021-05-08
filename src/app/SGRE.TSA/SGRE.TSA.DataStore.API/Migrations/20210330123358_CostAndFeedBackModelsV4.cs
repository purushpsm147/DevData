using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class CostAndFeedBackModelsV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_cost_feed_back_scenario_id",
                table: "cost_feed_back");

            migrationBuilder.CreateIndex(
                name: "ix_cost_feed_back_scenario_id",
                table: "cost_feed_back",
                column: "scenario_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_cost_feed_back_scenario_id",
                table: "cost_feed_back");

            migrationBuilder.CreateIndex(
                name: "ix_cost_feed_back_scenario_id",
                table: "cost_feed_back",
                column: "scenario_id");
        }
    }
}
