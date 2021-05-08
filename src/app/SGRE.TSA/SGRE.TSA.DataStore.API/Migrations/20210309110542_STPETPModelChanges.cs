using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class STPETPModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "no_of_sections",
                table: "base_tower_design_dimensions");

            migrationBuilder.DropColumn(
                name: "features_doc_link",
                table: "base_tower");

            migrationBuilder.DropColumn(
                name: "noise_mode_doc_link",
                table: "base_tower");

            migrationBuilder.RenameColumn(
                name: "max_tower_base_diameter",
                table: "base_tower_design_dimensions",
                newName: "upper_template");

            migrationBuilder.RenameColumn(
                name: "max_section_weight",
                table: "base_tower_design_dimensions",
                newName: "grout_height");

            migrationBuilder.RenameColumn(
                name: "max_section_length",
                table: "base_tower_design_dimensions",
                newName: "ground_level");

            migrationBuilder.RenameColumn(
                name: "is_tower_loads_margin_available",
                table: "base_tower",
                newName: "tower_loads_margin_trigger");

            migrationBuilder.RenameColumn(
                name: "is_rna_loads_margin_available",
                table: "base_tower",
                newName: "is_rna_component_check");

            migrationBuilder.RenameColumn(
                name: "aep_p50net",
                table: "base_tower",
                newName: "max_shear");

            migrationBuilder.RenameColumn(
                name: "aep_p50gross",
                table: "base_tower",
                newName: "average_shear");

            migrationBuilder.AddColumn<decimal>(
                name: "concrete_pedestal",
                table: "base_tower_design_dimensions",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_p50hub_height",
                table: "base_tower",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "higher_hubheight_possible_trigger",
                table: "base_tower",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sar_code",
                table: "base_tower",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "sar_input_request_stages",
                table: "base_tower",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "concrete_pedestal",
                table: "base_tower_design_dimensions");

            migrationBuilder.DropColumn(
                name: "aep_p50hub_height",
                table: "base_tower");

            migrationBuilder.DropColumn(
                name: "higher_hubheight_possible_trigger",
                table: "base_tower");

            migrationBuilder.DropColumn(
                name: "sar_code",
                table: "base_tower");

            migrationBuilder.DropColumn(
                name: "sar_input_request_stages",
                table: "base_tower");

            migrationBuilder.RenameColumn(
                name: "upper_template",
                table: "base_tower_design_dimensions",
                newName: "max_tower_base_diameter");

            migrationBuilder.RenameColumn(
                name: "grout_height",
                table: "base_tower_design_dimensions",
                newName: "max_section_weight");

            migrationBuilder.RenameColumn(
                name: "ground_level",
                table: "base_tower_design_dimensions",
                newName: "max_section_length");

            migrationBuilder.RenameColumn(
                name: "tower_loads_margin_trigger",
                table: "base_tower",
                newName: "is_tower_loads_margin_available");

            migrationBuilder.RenameColumn(
                name: "max_shear",
                table: "base_tower",
                newName: "aep_p50net");

            migrationBuilder.RenameColumn(
                name: "is_rna_component_check",
                table: "base_tower",
                newName: "is_rna_loads_margin_available");

            migrationBuilder.RenameColumn(
                name: "average_shear",
                table: "base_tower",
                newName: "aep_p50gross");

            migrationBuilder.AddColumn<int>(
                name: "no_of_sections",
                table: "base_tower_design_dimensions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "features_doc_link",
                table: "base_tower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "noise_mode_doc_link",
                table: "base_tower",
                type: "text",
                nullable: true);
        }
    }
}
