using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class BaseTowerAEP50HubHeightColumnNameChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aep_p50binding_offer_net",
                table: "base_tower_aep_hubheight");

            migrationBuilder.DropColumn(
                name: "aep_p50hub_height",
                table: "base_tower_aep_hubheight");

            migrationBuilder.DropColumn(
                name: "aep_p50nomination_gross",
                table: "base_tower_aep_hubheight");

            migrationBuilder.DropColumn(
                name: "aep_p50signature_net",
                table: "base_tower_aep_hubheight");

            migrationBuilder.RenameColumn(
                name: "total_weight",
                table: "base_tower_design_dimension",
                newName: "tower_weight");

            migrationBuilder.AddColumn<decimal>(
                name: "aep_binding_offer_net",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_hub_height",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_nomination_gross",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_signature_net",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aep_binding_offer_net",
                table: "base_tower_aep_hubheight");

            migrationBuilder.DropColumn(
                name: "aep_hub_height",
                table: "base_tower_aep_hubheight");

            migrationBuilder.DropColumn(
                name: "aep_nomination_gross",
                table: "base_tower_aep_hubheight");

            migrationBuilder.DropColumn(
                name: "aep_signature_net",
                table: "base_tower_aep_hubheight");

            migrationBuilder.RenameColumn(
                name: "tower_weight",
                table: "base_tower_design_dimension",
                newName: "total_weight");

            migrationBuilder.AddColumn<decimal>(
                name: "aep_p50binding_offer_net",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_p50hub_height",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_p50nomination_gross",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_p50signature_net",
                table: "base_tower_aep_hubheight",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
