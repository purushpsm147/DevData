using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class segmentDimensionsSummaryView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_sst_design_evaluation_sst_tower_id",
                table: "sst_design_evaluation");

            migrationBuilder.AddColumn<string>(
                name: "higher_hub_height_possible",
                table: "sst_tower",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_sst_design_evaluation_sst_tower_id",
                table: "sst_design_evaluation",
                column: "sst_tower_id",
                unique: true);            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_sst_design_evaluation_sst_tower_id",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "higher_hub_height_possible",
                table: "sst_tower");

            migrationBuilder.CreateIndex(
                name: "ix_sst_design_evaluation_sst_tower_id",
                table: "sst_design_evaluation",
                column: "sst_tower_id");
        }
    }
}
