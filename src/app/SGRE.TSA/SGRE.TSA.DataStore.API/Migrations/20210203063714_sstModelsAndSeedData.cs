using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class sstModelsAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_scenarios_wtg_catalogues_wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.DropIndex(
                name: "ix_scenarios_id_wtg_configuration_id",
                table: "scenarios");

            migrationBuilder.DropIndex(
                name: "ix_scenarios_wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "load_cluster",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "wtg_configuration_id",
                table: "scenarios");

            migrationBuilder.RenameColumn(
                name: "aep_net_in_ghw",
                table: "swat_loads",
                newName: "aep_net_in_gwh");

            migrationBuilder.RenameColumn(
                name: "aep_gross_in_ghw",
                table: "swat_loads",
                newName: "aep_gross_in_gwh");

            migrationBuilder.RenameColumn(
                name: "wtg_catalogue_id",
                table: "scenarios",
                newName: "quotation_id");

            migrationBuilder.AddColumn<int>(
                name: "item_id",
                table: "scenarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quote_id",
                table: "scenarios",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "nacelle_distances",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    distance_bottom_to_center_hub = table.Column<decimal>(type: "numeric", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_nacelle_distances", x => x.id);
                    table.ForeignKey(
                        name: "fk_nacelle_distances_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sst_inputs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    scenario_id = table.Column<int>(type: "integer", nullable: false),
                    windfarm_configuration_id = table.Column<string>(type: "text", nullable: false),
                    loads_cluster_id = table.Column<int>(type: "integer", nullable: true),
                    load_cluster_id = table.Column<int>(type: "integer", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    turbine_quantity = table.Column<int>(type: "integer", nullable: false),
                    cluster_size = table.Column<decimal>(type: "numeric", nullable: false),
                    turbine_quantity_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    windfarm_size_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    tower_type_id = table.Column<int>(type: "integer", nullable: true),
                    initial_tower_id = table.Column<int>(type: "integer", nullable: false),
                    existing_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    target_life_time = table.Column<decimal>(type: "numeric", nullable: false),
                    rna_loads = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_load_result = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_load_result_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    application_modes = table.Column<int[]>(type: "integer[]", nullable: false),
                    noise_modes = table.Column<int[]>(type: "integer[]", nullable: false),
                    noise_mode_doc_link = table.Column<string>(type: "text", nullable: true),
                    features = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    elsa_load_envelop_link = table.Column<string>(type: "text", nullable: true),
                    safal_load_envelop_link = table.Column<string>(type: "text", nullable: true),
                    application_reasons = table.Column<int[]>(type: "integer[]", nullable: false),
                    is_sar_input_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_design_evaluation_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_duplicate_scenario = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_inputs", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_inputs_loads_clusters_loads_cluster_id",
                        column: x => x.loads_cluster_id,
                        principalTable: "loads_clusters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sst_inputs_tower_types_tower_type_id",
                        column: x => x.tower_type_id,
                        principalTable: "tower_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sst_inputs_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "towersite_cloe_report",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    lifetime_years = table.Column<int>(type: "integer", nullable: false),
                    rna_status = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    rna_status_simplified = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    warning_message = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_cloe_report", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sst_predesign_dimesions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_input_id = table.Column<int>(type: "integer", nullable: false),
                    max_tower_base_diameter = table.Column<decimal>(type: "numeric", nullable: false),
                    max_section_weight = table.Column<decimal>(type: "numeric", nullable: false),
                    max_section_length = table.Column<decimal>(type: "numeric", nullable: false),
                    ground_level = table.Column<decimal>(type: "numeric", nullable: false),
                    concrete_pedestal = table.Column<decimal>(type: "numeric", nullable: false),
                    grout_height = table.Column<decimal>(type: "numeric", nullable: false),
                    upper_template = table.Column<decimal>(type: "numeric", nullable: false),
                    total_foundation_height = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_nacelle_distance = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_foundation_height = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_height = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_predesign_dimesions", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_predesign_dimesions_sst_inputs_sst_input_id",
                        column: x => x.sst_input_id,
                        principalTable: "sst_inputs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sst_predesign_existing_hub_heights",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_input_id = table.Column<int>(type: "integer", nullable: false),
                    existing_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_nomination_gross = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_binding_offer_net = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_signature_net = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "sst_predesign_proposed_hub_heights",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_input_id = table.Column<int>(type: "integer", nullable: false),
                    existing_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_nomination_gross = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_binding_offer_net = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_signature_net = table.Column<decimal>(type: "numeric", nullable: false),
                    nomination_gross_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    binding_offer_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    signature_net_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_predesign_proposed_hub_heights", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_predesign_proposed_hub_heights_sst_inputs_sst_input_id",
                        column: x => x.sst_input_id,
                        principalTable: "sst_inputs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "nacelle_distances",
                columns: new[] { "id", "distance_bottom_to_center_hub", "last_modified_date_time", "record_insert_date_time", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 1, 2295.909m, null, null, 1 },
                    { 2, 2265.9408m, null, null, 2 },
                    { 3, 2086.56m, null, null, 3 },
                    { 4, 2086.56m, null, null, 4 },
                    { 5, 2010.98m, null, null, 5 },
                    { 6, 2002.61m, null, null, 6 }
                });

            migrationBuilder.InsertData(
                table: "noise_modes",
                columns: new[] { "id", "last_modified_date_time", "noise_level_decibels", "noise_mode_description", "noise_mode_no", "record_insert_date_time", "tower_type_id" },
                values: new object[,]
                {
                    { 73, null, 108m, 0m, "1", null, 9 },
                    { 74, null, 107.5m, 0m, "2", null, 9 },
                    { 75, null, 106m, 0m, "3", null, 9 },
                    { 76, null, 105m, 0m, "4", null, 9 },
                    { 77, null, 104m, 0m, "5", null, 9 },
                    { 80, null, 100.3m, 0m, "8", null, 9 },
                    { 79, null, 101.3m, 0m, "7", null, 9 },
                    { 72, null, 111.6m, 0m, "standard", null, 9 },
                    { 81, null, 109.3m, 0m, "standard", null, 9 },
                    { 82, null, 105.7m, 0m, "1", null, 9 },
                    { 78, null, 102.2m, 0m, "6", null, 9 },
                    { 71, null, 98m, 0m, "8", null, 21 },
                    { 68, null, 101.7m, 0m, "5", null, 21 },
                    { 69, null, 99.9m, 0m, "6", null, 21 },
                    { 83, null, 105.2m, 0m, "2", null, 9 },
                    { 67, null, 102.7m, 0m, "4", null, 21 },
                    { 66, null, 103.7m, 0m, "3", null, 21 },
                    { 65, null, 105.2m, 0m, "2", null, 21 },
                    { 64, null, 105.7m, 0m, "1", null, 21 },
                    { 63, null, 109.3m, 0m, "standard", null, 21 },
                    { 62, null, 100.3m, 0m, "8", null, 21 },
                    { 61, null, 101.3m, 0m, "7", null, 21 },
                    { 60, null, 102.2m, 0m, "6", null, 21 },
                    { 59, null, 104m, 0m, "5", null, 21 },
                    { 70, null, 99m, 0m, "7", null, 21 },
                    { 84, null, 103.7m, 0m, "3", null, 9 },
                    { 87, null, 99.9m, 0m, "6", null, 9 },
                    { 86, null, 101.7m, 0m, "5", null, 9 },
                    { 111, null, 100.8m, 0m, "3", null, 2 },
                    { 110, null, 101.9m, 0m, "2", null, 2 },
                    { 109, null, 103m, 0m, "1", null, 2 },
                    { 108, null, 104m, 0m, "standard", null, 2 },
                    { 107, null, 101m, 0m, "5", null, 2 },
                    { 106, null, 102m, 0m, "4", null, 2 },
                    { 105, null, 103m, 0m, "3", null, 2 },
                    { 104, null, 104m, 0m, "2", null, 2 },
                    { 103, null, 105m, 0m, "1", null, 2 },
                    { 102, null, 106.3m, 0m, "standard", null, 2 },
                    { 101, null, 106.5m, 0m, "standard", null, 23 },
                    { 100, null, 108.8m, 0m, "standard", null, 23 },
                    { 99, null, 98m, 0m, "8", null, 23 },
                    { 98, null, 99m, 0m, "7", null, 23 },
                    { 97, null, 99.9m, 0m, "6", null, 23 },
                    { 96, null, 101.7m, 0m, "5", null, 23 },
                    { 95, null, 109.3m, 0m, "standard", null, 23 },
                    { 94, null, 100.3m, 0m, "8", null, 23 },
                    { 93, null, 101.3m, 0m, "7", null, 23 },
                    { 92, null, 102.2m, 0m, "6", null, 23 },
                    { 91, null, 104m, 0m, "5", null, 23 },
                    { 90, null, 111.6m, 0m, "standard", null, 23 },
                    { 89, null, 98m, 0m, "8", null, 9 },
                    { 88, null, 99m, 0m, "7", null, 9 },
                    { 58, null, 105m, 0m, "4", null, 21 },
                    { 85, null, 102.7m, 0m, "4", null, 9 },
                    { 57, null, 106m, 0m, "3", null, 21 },
                    { 54, null, 111.6m, 0m, "standard", null, 21 },
                    { 55, null, 108m, 0m, "1", null, 21 },
                    { 25, null, 101m, 0m, "4", null, 8 },
                    { 24, null, 102m, 0m, "3", null, 8 },
                    { 23, null, 103.5m, 0m, "2", null, 8 },
                    { 22, null, 104m, 0m, "1", null, 8 },
                    { 21, null, 99m, 0m, "7", null, 4 },
                    { 20, null, 100m, 0m, "6", null, 4 },
                    { 19, null, 101m, 0m, "5", null, 4 },
                    { 18, null, 102m, 0m, "4", null, 4 },
                    { 17, null, 103m, 0m, "3", null, 4 },
                    { 16, null, 104.5m, 0m, "2", null, 4 },
                    { 15, null, 105.5m, 0m, "1", null, 4 },
                    { 14, null, 99m, 0m, "7", null, 3 },
                    { 13, null, 100m, 0m, "6", null, 3 },
                    { 12, null, 101m, 0m, "5", null, 3 },
                    { 11, null, 102m, 0m, "4", null, 3 },
                    { 10, null, 103m, 0m, "3", null, 3 },
                    { 9, null, 104.5m, 0m, "2", null, 3 },
                    { 8, null, 105.5m, 0m, "1", null, 3 },
                    { 7, null, 99m, 0m, "7", null, 1 },
                    { 6, null, 100m, 0m, "6", null, 1 },
                    { 5, null, 101m, 0m, "5", null, 1 },
                    { 4, null, 102m, 0m, "4", null, 1 },
                    { 3, null, 103m, 0m, "3", null, 1 },
                    { 2, null, 104.5m, 0m, "2", null, 1 },
                    { 1, null, 105.5m, 0m, "1", null, 1 },
                    { 26, null, 100m, 0m, "5", null, 8 },
                    { 56, null, 107.5m, 0m, "2", null, 21 },
                    { 27, null, 99m, 0m, "6", null, 8 },
                    { 29, null, 97m, 0m, "8", null, 8 },
                    { 112, null, 99.9m, 0m, "4", null, 2 },
                    { 53, null, 97m, 0m, "8", null, 13 },
                    { 52, null, 98m, 0m, "7", null, 13 },
                    { 51, null, 99m, 0m, "6", null, 13 },
                    { 50, null, 100m, 0m, "5", null, 13 },
                    { 49, null, 101m, 0m, "4", null, 13 },
                    { 48, null, 102m, 0m, "3", null, 13 },
                    { 47, null, 103.5m, 0m, "2", null, 13 },
                    { 46, null, 104m, 0m, "1", null, 13 },
                    { 45, null, 97m, 0m, "8", null, 14 },
                    { 44, null, 98m, 0m, "7", null, 14 },
                    { 43, null, 99m, 0m, "6", null, 14 },
                    { 42, null, 100m, 0m, "5", null, 14 },
                    { 41, null, 101m, 0m, "4", null, 14 },
                    { 40, null, 102m, 0m, "3", null, 14 },
                    { 39, null, 103.5m, 0m, "2", null, 14 },
                    { 38, null, 104m, 0m, "1", null, 14 },
                    { 37, null, 97m, 0m, "8", null, 9 },
                    { 36, null, 98m, 0m, "7", null, 9 },
                    { 35, null, 99m, 0m, "6", null, 9 },
                    { 34, null, 100m, 0m, "5", null, 9 },
                    { 33, null, 101m, 0m, "4", null, 9 },
                    { 32, null, 102m, 0m, "3", null, 9 },
                    { 31, null, 103.5m, 0m, "2", null, 9 },
                    { 30, null, 104m, 0m, "1", null, 9 },
                    { 28, null, 98m, 0m, "7", null, 8 },
                    { 113, null, 98.8m, 0m, "5", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_quote_id",
                table: "scenarios",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_scenario_type_item_id",
                table: "scenarios",
                columns: new[] { "scenario_type", "item_id" });

            migrationBuilder.CreateIndex(
                name: "ix_nacelle_distances_wtg_catalogue_id",
                table: "nacelle_distances",
                column: "wtg_catalogue_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_loads_cluster_id",
                table: "sst_inputs",
                column: "loads_cluster_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_scenario_id_windfarm_configuration_id",
                table: "sst_inputs",
                columns: new[] { "scenario_id", "windfarm_configuration_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_tower_type_id",
                table: "sst_inputs",
                column: "tower_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_wtg_catalogue_id",
                table: "sst_inputs",
                column: "wtg_catalogue_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_dimesions_sst_input_id",
                table: "sst_predesign_dimesions",
                column: "sst_input_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_existing_hub_heights_sst_input_id",
                table: "sst_predesign_existing_hub_heights",
                column: "sst_input_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_proposed_hub_heights_sst_input_id",
                table: "sst_predesign_proposed_hub_heights",
                column: "sst_input_id");

            migrationBuilder.AddForeignKey(
                name: "fk_scenarios_quotes_quote_id",
                table: "scenarios",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_scenarios_quotes_quote_id",
                table: "scenarios");

            migrationBuilder.DropTable(
                name: "nacelle_distances");

            migrationBuilder.DropTable(
                name: "sst_predesign_dimesions");

            migrationBuilder.DropTable(
                name: "sst_predesign_existing_hub_heights");

            migrationBuilder.DropTable(
                name: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropTable(
                name: "towersite_cloe_report");

            migrationBuilder.DropTable(
                name: "sst_inputs");

            migrationBuilder.DropIndex(
                name: "ix_scenarios_quote_id",
                table: "scenarios");

            migrationBuilder.DropIndex(
                name: "ix_scenarios_scenario_type_item_id",
                table: "scenarios");

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DropColumn(
                name: "item_id",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "quote_id",
                table: "scenarios");

            migrationBuilder.RenameColumn(
                name: "aep_net_in_gwh",
                table: "swat_loads",
                newName: "aep_net_in_ghw");

            migrationBuilder.RenameColumn(
                name: "aep_gross_in_gwh",
                table: "swat_loads",
                newName: "aep_gross_in_ghw");

            migrationBuilder.RenameColumn(
                name: "quotation_id",
                table: "scenarios",
                newName: "wtg_catalogue_id");

            migrationBuilder.AddColumn<string>(
                name: "load_cluster",
                table: "scenarios",
                type: "character varying(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "wtg_configuration_id",
                table: "scenarios",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_id_wtg_configuration_id",
                table: "scenarios",
                columns: new[] { "id", "wtg_configuration_id" });

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_wtg_catalogue_id",
                table: "scenarios",
                column: "wtg_catalogue_id");

            migrationBuilder.AddForeignKey(
                name: "fk_scenarios_wtg_catalogues_wtg_catalogue_id",
                table: "scenarios",
                column: "wtg_catalogue_id",
                principalTable: "wtg_catalogues",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
