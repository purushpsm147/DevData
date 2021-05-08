using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class designEvaluationSavePause : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "project_id",
                table: "sst_design_evaluation",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sst_tower_id",
                table: "sst_design_evaluation",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_sst_design_evaluation_sst_tower_id",
                table: "sst_design_evaluation",
                column: "sst_tower_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sst_design_evaluation_sst_tower_sst_tower_id",
                table: "sst_design_evaluation",
                column: "sst_tower_id",
                principalTable: "sst_tower",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_design_evaluation_sst_tower_sst_tower_id",
                table: "sst_design_evaluation");

            migrationBuilder.DropIndex(
                name: "ix_sst_design_evaluation_sst_tower_id",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "project_id",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "sst_tower_id",
                table: "sst_design_evaluation");
        }
    }
}
