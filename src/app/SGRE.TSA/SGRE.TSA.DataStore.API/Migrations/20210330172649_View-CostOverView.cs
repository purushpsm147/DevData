using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ViewCostOverView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_construction_cost_feed_back_cost_feeback_id",
                table: "costs_tower_construction");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_customs_cost_feed_back_cost_feeback_id",
                table: "costs_tower_customs");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_ex_works_cost_feed_back_cost_feeback_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_cost_feed_back_cost_feeback_id",
                table: "costs_tower_logistics");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_cost_feed_back_cost_feeback_id",
                table: "costs_tower_supplier");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_supplier",
                newName: "cost_feedback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_supplier_cost_feeback_id",
                table: "costs_tower_supplier",
                newName: "ix_costs_tower_supplier_cost_feedback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_logistics",
                newName: "cost_feedback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_logistics_cost_feeback_id",
                table: "costs_tower_logistics",
                newName: "ix_costs_tower_logistics_cost_feedback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_ex_works",
                newName: "cost_feedback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_ex_works_cost_feeback_id",
                table: "costs_tower_ex_works",
                newName: "ix_costs_tower_ex_works_cost_feedback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_customs",
                newName: "cost_feedback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_customs_cost_feeback_id",
                table: "costs_tower_customs",
                newName: "ix_costs_tower_customs_cost_feedback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_construction",
                newName: "cost_feedback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_construction_cost_feeback_id",
                table: "costs_tower_construction",
                newName: "ix_costs_tower_construction_cost_feedback_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_construction_cost_feed_back_cost_feedback_id",
                table: "costs_tower_construction",
                column: "cost_feedback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_customs_cost_feed_back_cost_feedback_id",
                table: "costs_tower_customs",
                column: "cost_feedback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_ex_works_cost_feed_back_cost_feedback_id",
                table: "costs_tower_ex_works",
                column: "cost_feedback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_cost_feed_back_cost_feedback_id",
                table: "costs_tower_logistics",
                column: "cost_feedback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_cost_feed_back_cost_feedback_id",
                table: "costs_tower_supplier",
                column: "cost_feedback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_construction_cost_feed_back_cost_feedback_id",
                table: "costs_tower_construction");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_customs_cost_feed_back_cost_feedback_id",
                table: "costs_tower_customs");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_ex_works_cost_feed_back_cost_feedback_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_cost_feed_back_cost_feedback_id",
                table: "costs_tower_logistics");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_cost_feed_back_cost_feedback_id",
                table: "costs_tower_supplier");

            migrationBuilder.RenameColumn(
                name: "cost_feedback_id",
                table: "costs_tower_supplier",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_supplier_cost_feedback_id",
                table: "costs_tower_supplier",
                newName: "ix_costs_tower_supplier_cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feedback_id",
                table: "costs_tower_logistics",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_logistics_cost_feedback_id",
                table: "costs_tower_logistics",
                newName: "ix_costs_tower_logistics_cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feedback_id",
                table: "costs_tower_ex_works",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_ex_works_cost_feedback_id",
                table: "costs_tower_ex_works",
                newName: "ix_costs_tower_ex_works_cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feedback_id",
                table: "costs_tower_customs",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_customs_cost_feedback_id",
                table: "costs_tower_customs",
                newName: "ix_costs_tower_customs_cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "cost_feedback_id",
                table: "costs_tower_construction",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_construction_cost_feedback_id",
                table: "costs_tower_construction",
                newName: "ix_costs_tower_construction_cost_feeback_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_construction_cost_feed_back_cost_feeback_id",
                table: "costs_tower_construction",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_customs_cost_feed_back_cost_feeback_id",
                table: "costs_tower_customs",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_ex_works_cost_feed_back_cost_feeback_id",
                table: "costs_tower_ex_works",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_cost_feed_back_cost_feeback_id",
                table: "costs_tower_logistics",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_cost_feed_back_cost_feeback_id",
                table: "costs_tower_supplier",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
