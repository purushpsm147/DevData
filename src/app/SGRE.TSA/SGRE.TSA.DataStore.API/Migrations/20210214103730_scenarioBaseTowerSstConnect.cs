using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class scenarioBaseTowerSstConnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_scenarios_wtg_catalogues_wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.DropForeignKey(
                name: "fk_sst_inputs_tower_types_tower_type_id",
                table: "sst_inputs");

            migrationBuilder.DropTable(
                name: "sst_predesign_existing_hub_heights");

            migrationBuilder.DropIndex(
                name: "ix_sst_inputs_scenario_id_windfarm_configuration_id",
                table: "sst_inputs");

            migrationBuilder.DropIndex(
                name: "ix_scenarios_wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "initial_tower_id",
                table: "sst_inputs");

            migrationBuilder.DropColumn(
                name: "scenario_id",
                table: "sst_inputs");

            migrationBuilder.DropColumn(
                name: "load_cluster",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "hub_height",
                table: "scenario_designs");

            migrationBuilder.DropColumn(
                name: "lifetime",
                table: "scenario_designs");

            migrationBuilder.DropColumn(
                name: "step_progress",
                table: "scenario_designs");

            migrationBuilder.DropColumn(
                name: "tower_weight",
                table: "scenario_designs");

            migrationBuilder.DropColumn(
                name: "aep_p50delta",
                table: "scenario_costs_kpis");

            migrationBuilder.RenameColumn(
                name: "wtg_configuration_id",
                table: "scenarios",
                newName: "windfarm_configuration_id");

            migrationBuilder.RenameColumn(
                name: "coe_delta",
                table: "scenario_costs_kpis",
                newName: "aep_p50signature_net");

            migrationBuilder.RenameColumn(
                name: "coe",
                table: "scenario_costs_kpis",
                newName: "aep_p50nomination_gross");

            migrationBuilder.RenameColumn(
                name: "capex_delta",
                table: "scenario_costs_kpis",
                newName: "aep_p50binding_offer_net");

            migrationBuilder.AlterColumn<int>(
                name: "tower_type_id",
                table: "sst_inputs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "tower_weight",
                table: "sst_inputs",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "step_progress",
                table: "scenarios",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "base_tower",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    quote_id = table.Column<int>(type: "integer", nullable: false),
                    windfarm_configuration_id = table.Column<string>(type: "text", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    loads_cluster_id = table.Column<int>(type: "integer", nullable: false),
                    tower_type_id = table.Column<int>(type: "integer", nullable: false),
                    turbine_quantity = table.Column<int>(type: "integer", nullable: false),
                    cluster_size = table.Column<decimal>(type: "numeric", nullable: false),
                    hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    application_modes = table.Column<int[]>(type: "integer[]", nullable: false),
                    noise_modes = table.Column<int[]>(type: "integer[]", nullable: false),
                    noise_mode_doc_link = table.Column<string>(type: "text", nullable: true),
                    features = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    features_doc_link = table.Column<string>(type: "text", nullable: true),
                    rna_life_time = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50gross = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50net = table.Column<decimal>(type: "numeric", nullable: false),
                    is_rna_loads_margin_available = table.Column<bool>(type: "boolean", nullable: false),
                    tower_loads_margin = table.Column<decimal>(type: "numeric", nullable: false),
                    is_tower_loads_margin_available = table.Column<bool>(type: "boolean", nullable: false),
                    is_sar_input_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_predesign_logistic_assessment_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_cost_timelines_request = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_base_tower", x => x.id);
                    table.ForeignKey(
                        name: "fk_base_tower_loads_clusters_loads_cluster_id",
                        column: x => x.loads_cluster_id,
                        principalTable: "loads_clusters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_base_tower_quotes_quote_id",
                        column: x => x.quote_id,
                        principalTable: "quotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_base_tower_tower_types_tower_type_id",
                        column: x => x.tower_type_id,
                        principalTable: "tower_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_base_tower_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "base_tower_design_dimensions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    base_tower_id = table.Column<int>(type: "integer", nullable: false),
                    max_tower_base_diameter = table.Column<decimal>(type: "numeric", nullable: false),
                    max_section_weight = table.Column<decimal>(type: "numeric", nullable: false),
                    max_section_length = table.Column<decimal>(type: "numeric", nullable: false),
                    no_of_sections = table.Column<int>(type: "integer", nullable: false),
                    total_weight = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    total_foundation_height = table.Column<decimal>(type: "numeric", nullable: false),
                    is_standard_foundation_height = table.Column<bool>(type: "boolean", nullable: false),
                    tower_nacelle_distance = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_height = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_base_tower_design_dimensions", x => x.id);
                    table.ForeignKey(
                        name: "fk_base_tower_design_dimensions_base_tower_base_tower_id",
                        column: x => x.base_tower_id,
                        principalTable: "base_tower",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_loads_cluster_id",
                table: "base_tower",
                column: "loads_cluster_id");

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_quote_id",
                table: "base_tower",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_tower_type_id",
                table: "base_tower",
                column: "tower_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_wtg_catalogue_id",
                table: "base_tower",
                column: "wtg_catalogue_id");

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_design_dimensions_base_tower_id",
                table: "base_tower_design_dimensions",
                column: "base_tower_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sst_inputs_tower_types_tower_type_id",
                table: "sst_inputs",
                column: "tower_type_id",
                principalTable: "tower_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_inputs_tower_types_tower_type_id",
                table: "sst_inputs");

            migrationBuilder.DropTable(
                name: "base_tower_design_dimensions");

            migrationBuilder.DropTable(
                name: "base_tower");

            migrationBuilder.DropColumn(
                name: "tower_weight",
                table: "sst_inputs");

            migrationBuilder.DropColumn(
                name: "step_progress",
                table: "scenarios");

            migrationBuilder.RenameColumn(
                name: "windfarm_configuration_id",
                table: "scenarios",
                newName: "wtg_configuration_id");

            migrationBuilder.RenameColumn(
                name: "aep_p50signature_net",
                table: "scenario_costs_kpis",
                newName: "coe_delta");

            migrationBuilder.RenameColumn(
                name: "aep_p50nomination_gross",
                table: "scenario_costs_kpis",
                newName: "coe");

            migrationBuilder.RenameColumn(
                name: "aep_p50binding_offer_net",
                table: "scenario_costs_kpis",
                newName: "capex_delta");

            migrationBuilder.AlterColumn<int>(
                name: "tower_type_id",
                table: "sst_inputs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "initial_tower_id",
                table: "sst_inputs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "scenario_id",
                table: "sst_inputs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "load_cluster",
                table: "scenarios",
                type: "character varying(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "wtg_catalogue_id",
                table: "scenarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "hub_height",
                table: "scenario_designs",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "lifetime",
                table: "scenario_designs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "step_progress",
                table: "scenario_designs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "tower_weight",
                table: "scenario_designs",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "aep_p50delta",
                table: "scenario_costs_kpis",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "sst_predesign_existing_hub_heights",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    aep_binding_offer_net = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_nomination_gross = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_signature_net = table.Column<decimal>(type: "numeric", nullable: false),
                    existing_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    sst_input_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_predesign_existing_hub_heights", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_predesign_existing_hub_heights_sst_inputs_sst_input_id",
                        column: x => x.sst_input_id,
                        principalTable: "sst_inputs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_scenario_id_windfarm_configuration_id",
                table: "sst_inputs",
                columns: new[] { "scenario_id", "windfarm_configuration_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_wtg_catalogue_id",
                table: "scenarios",
                column: "wtg_catalogue_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_existing_hub_heights_sst_input_id",
                table: "sst_predesign_existing_hub_heights",
                column: "sst_input_id");

            migrationBuilder.AddForeignKey(
                name: "fk_scenarios_wtg_catalogues_wtg_catalogue_id",
                table: "scenarios",
                column: "wtg_catalogue_id",
                principalTable: "wtg_catalogues",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sst_inputs_tower_types_tower_type_id",
                table: "sst_inputs",
                column: "tower_type_id",
                principalTable: "tower_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
