using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class CostAndFeedBackModelsV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_costs",
                table: "costs_tower_logistics_line_item");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_line_item");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_logistics_line_item_costs_tower_logistics_id",
                table: "costs_tower_logistics_line_item");

            migrationBuilder.DropColumn(
                name: "costs_tower_logistics_id",
                table: "costs_tower_logistics_line_item");

            migrationBuilder.AlterColumn<int>(
                name: "costs_tower_logistics_supplier_id",
                table: "costs_tower_logistics_line_item",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_line_item",
                column: "costs_tower_logistics_supplier_id",
                principalTable: "costs_tower_logistics_supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_line_item");

            migrationBuilder.AlterColumn<int>(
                name: "costs_tower_logistics_supplier_id",
                table: "costs_tower_logistics_line_item",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "costs_tower_logistics_id",
                table: "costs_tower_logistics_line_item",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_line_item_costs_tower_logistics_id",
                table: "costs_tower_logistics_line_item",
                column: "costs_tower_logistics_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_costs",
                table: "costs_tower_logistics_line_item",
                column: "costs_tower_logistics_id",
                principalTable: "costs_tower_logistics",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_line_item",
                column: "costs_tower_logistics_supplier_id",
                principalTable: "costs_tower_logistics_supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
