using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddDesignEvaluationSummaryView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_sst_predesign_proposed_hub_heights_sst_tower_id",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropIndex(
                name: "ix_sst_predesign_dimesions_sst_tower_id",
                table: "sst_predesign_dimesions");

            migrationBuilder.DropColumn(
                name: "project_id",
                table: "sst_design_evaluation");

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_proposed_hub_heights_sst_tower_id",
                table: "sst_predesign_proposed_hub_heights",
                column: "sst_tower_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_dimesions_sst_tower_id",
                table: "sst_predesign_dimesions",
                column: "sst_tower_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_sst_predesign_proposed_hub_heights_sst_tower_id",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropIndex(
                name: "ix_sst_predesign_dimesions_sst_tower_id",
                table: "sst_predesign_dimesions");

            migrationBuilder.AddColumn<int>(
                name: "project_id",
                table: "sst_design_evaluation",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_proposed_hub_heights_sst_tower_id",
                table: "sst_predesign_proposed_hub_heights",
                column: "sst_tower_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_dimesions_sst_tower_id",
                table: "sst_predesign_dimesions",
                column: "sst_tower_id");
        }
    }
}
