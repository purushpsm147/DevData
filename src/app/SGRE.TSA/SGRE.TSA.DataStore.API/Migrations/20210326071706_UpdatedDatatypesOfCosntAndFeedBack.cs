using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdatedDatatypesOfCosntAndFeedBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_supplier",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_supplier",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_supplier",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_logistics_lead_time",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_logistics_lead_time",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_logistics_lead_time",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_logistics",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_logistics",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_logistics",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_ex_works",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_ex_works",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_ex_works",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_customs",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_customs",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_customs",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_construction_lead_time",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_construction_lead_time",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_construction_lead_time",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_construction",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_construction",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_construction",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "leadtime_tower_signature",
                table: "costs_technology_tower_development_leadtime",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "leadtime_tower_offer",
                table: "costs_technology_tower_development_leadtime",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "leadtime_tower_nomination",
                table: "costs_technology_tower_development_leadtime",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "tower_component_certificate_windfarm_signature",
                table: "costs_technology",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "tower_component_certificate_windfarm_offer",
                table: "costs_technology",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "tower_component_certificate_windfarm_nomination",
                table: "costs_technology",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "manufacturing_investment_costs_windfarm",
                table: "costs_technical_office",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<decimal>(
                name: "design_costs_windfarm",
                table: "costs_technical_office",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "additional_timeline_weeks_windfarm",
                table: "costs_technical_office",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "cost_over_view",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "cost_over_view",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "cost_over_view",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_lead_time_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "line_item_type",
                value: "decimal");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "line_item_type",
                value: "decimal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "costs_tower_supplier",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "costs_tower_supplier",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "costs_tower_supplier",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "costs_tower_logistics_lead_time",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "costs_tower_logistics_lead_time",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "costs_tower_logistics_lead_time",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "costs_tower_logistics",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "costs_tower_logistics",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "costs_tower_logistics",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "costs_tower_ex_works",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "costs_tower_ex_works",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "costs_tower_ex_works",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "costs_tower_customs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "costs_tower_customs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "costs_tower_customs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "costs_tower_construction_lead_time",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "costs_tower_construction_lead_time",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "costs_tower_construction_lead_time",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "leadtime_tower_signature",
                table: "costs_technology_tower_development_leadtime",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "leadtime_tower_offer",
                table: "costs_technology_tower_development_leadtime",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "leadtime_tower_nomination",
                table: "costs_technology_tower_development_leadtime",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "tower_component_certificate_windfarm_signature",
                table: "costs_technology",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "tower_component_certificate_windfarm_offer",
                table: "costs_technology",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "tower_component_certificate_windfarm_nomination",
                table: "costs_technology",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<double>(
                name: "manufacturing_investment_costs_windfarm",
                table: "costs_technical_office",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<double>(
                name: "design_costs_windfarm",
                table: "costs_technical_office",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<double>(
                name: "additional_timeline_weeks_windfarm",
                table: "costs_technical_office",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "signature",
                table: "cost_over_view",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "offer",
                table: "cost_over_view",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "nomination",
                table: "cost_over_view",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_lead_time_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 1,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 2,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "line_item_type",
                value: "decimel");

            migrationBuilder.UpdateData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "line_item_type",
                value: "decimel");
        }
    }
}
