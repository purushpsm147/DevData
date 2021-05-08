using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class added_IsMandatory_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "comments",
                table: "costs_tower_customs");

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "costs_tower_supplier_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "costs_tower_logistics_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "costs_tower_logistics_lead_time_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "costs_tower_ex_works_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "costs_tower_customs_supplier",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "costs_tower_customs_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "costs_tower_construction_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "costs_tower_construction_lead_time_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_mandatory",
                table: "cost_over_view_meta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 5,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 6,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 7,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 8,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "cost_over_view_meta",
                keyColumn: "id",
                keyValue: 9,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_lead_time_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 5,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 6,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 7,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 8,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 9,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 10,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 11,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 12,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 13,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_ex_works_meta",
                keyColumn: "id",
                keyValue: 14,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_lead_time_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_lead_time_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_lead_time_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 5,
                column: "is_mandatory",
                value: true);

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 6,
                column: "is_mandatory",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "costs_tower_supplier_meta");

            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "costs_tower_logistics_meta");

            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "costs_tower_logistics_lead_time_meta");

            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "costs_tower_ex_works_meta");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "costs_tower_customs_supplier");

            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "costs_tower_customs_meta");

            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "costs_tower_construction_meta");

            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "costs_tower_construction_lead_time_meta");

            migrationBuilder.DropColumn(
                name: "is_mandatory",
                table: "cost_over_view_meta");

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "costs_tower_customs",
                type: "text",
                nullable: true);
        }
    }
}
