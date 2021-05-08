using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ScenariosCreations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "scenarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    scenario_no = table.Column<int>(type: "integer", nullable: false),
                    scenario_type = table.Column<int>(type: "integer", maxLength: 8, nullable: false),
                    wtg_configuration_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    progress = table.Column<int>(type: "integer", nullable: false),
                    load_cluster = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    options = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_scenarios", x => x.id);
                    table.ForeignKey(
                        name: "fk_scenarios_wtg_configurations_wtg_configuration_id",
                        column: x => x.wtg_configuration_id,
                        principalTable: "wtg_configurations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "swat_loads",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sar_code = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    site_latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    site_longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    configuration_id = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    load_cluster_id = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    cloe_tower_id = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    turbine_type = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    turbine_quantity = table.Column<int>(type: "integer", nullable: false),
                    tower_hub_height_standard_scenario = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_steps_in_m = table.Column<decimal[]>(type: "numeric[]", nullable: false),
                    aep_gross_in_percent = table.Column<decimal[]>(type: "numeric[]", nullable: false),
                    aep_gross_in_ghw = table.Column<decimal[]>(type: "numeric[]", nullable: false),
                    aep_net_in_percent = table.Column<decimal[]>(type: "numeric[]", nullable: true),
                    aep_net_in_ghw = table.Column<decimal[]>(type: "numeric[]", nullable: true),
                    acs2x_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    application_modes = table.Column<int[]>(type: "integer[]", nullable: false),
                    tower_type_swat = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    rna_lifetime = table.Column<decimal>(type: "numeric", nullable: false),
                    rna_suitability = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    tower_loads_margin = table.Column<decimal>(type: "numeric", nullable: false),
                    rna_loads_margin = table.Column<decimal>(type: "numeric", nullable: false),
                    wind_shear = table.Column<decimal>(type: "numeric", nullable: false),
                    elsa_filesize = table.Column<decimal>(type: "numeric", nullable: false),
                    safal_filesize = table.Column<decimal>(type: "numeric", nullable: false),
                    json_payload = table.Column<string[]>(type: "text[]", nullable: false),
                    elsa_file_name = table.Column<string>(type: "text", nullable: false),
                    link_to_elsa_file = table.Column<string>(type: "text", nullable: false),
                    safal_file_name = table.Column<string>(type: "text", nullable: false),
                    link_to_safal_file = table.Column<string>(type: "text", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_swat_loads", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_list_regions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    region_name = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    units = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_list_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_list_towers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    platform = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    tower = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    wtgmachine = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    description = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    gpcode = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    hubheight_m = table.Column<decimal>(type: "numeric", nullable: true),
                    technology = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    totaltowerweight_kg = table.Column<decimal>(type: "numeric", nullable: true),
                    hubheightmin_m = table.Column<decimal>(type: "numeric", nullable: true),
                    hubheightmax_m = table.Column<decimal>(type: "numeric", nullable: true),
                    defaulthubheight_m = table.Column<decimal>(type: "numeric", nullable: true),
                    defaultmaxsectionnumber = table.Column<int>(type: "integer", nullable: true),
                    defaultmaxsectiondiameter_m = table.Column<decimal>(type: "numeric", nullable: true),
                    defaultmaxsectionlength_m = table.Column<decimal>(type: "numeric", nullable: true),
                    defaultmaxsectionweight_kg = table.Column<decimal>(type: "numeric", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_list_towers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scenario_costs_kpis",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    scenario_id = table.Column<int>(type: "integer", nullable: false),
                    total_tower_exw_cost = table.Column<decimal>(type: "numeric", nullable: false),
                    total_cost = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50gross = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50net = table.Column<decimal>(type: "numeric", nullable: false),
                    coe = table.Column<decimal>(type: "numeric", nullable: false),
                    coe_delta = table.Column<decimal>(type: "numeric", nullable: false),
                    capex_delta = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50delta = table.Column<decimal>(type: "numeric", nullable: false),
                    risks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_scenario_costs_kpis", x => x.id);
                    table.ForeignKey(
                        name: "fk_scenario_costs_kpis_scenarios_scenario_id",
                        column: x => x.scenario_id,
                        principalTable: "scenarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scenario_designs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    scenario_id = table.Column<int>(type: "integer", nullable: false),
                    step_progress = table.Column<bool>(type: "boolean", nullable: false),
                    hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_weight = table.Column<decimal>(type: "numeric", nullable: false),
                    lifetime = table.Column<int>(type: "integer", nullable: false),
                    risks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_scenario_designs", x => x.id);
                    table.ForeignKey(
                        name: "fk_scenario_designs_scenarios_scenario_id",
                        column: x => x.scenario_id,
                        principalTable: "scenarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_scenario_costs_kpis_scenario_id",
                table: "scenario_costs_kpis",
                column: "scenario_id");

            migrationBuilder.CreateIndex(
                name: "ix_scenario_designs_scenario_id",
                table: "scenario_designs",
                column: "scenario_id");

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_id_wtg_configuration_id",
                table: "scenarios",
                columns: new[] { "id", "wtg_configuration_id" });

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_wtg_configuration_id",
                table: "scenarios",
                column: "wtg_configuration_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "scenario_costs_kpis");

            migrationBuilder.DropTable(
                name: "scenario_designs");

            migrationBuilder.DropTable(
                name: "swat_loads");

            migrationBuilder.DropTable(
                name: "towersite_list_regions");

            migrationBuilder.DropTable(
                name: "towersite_list_towers");

            migrationBuilder.DropTable(
                name: "scenarios");
        }
    }
}
