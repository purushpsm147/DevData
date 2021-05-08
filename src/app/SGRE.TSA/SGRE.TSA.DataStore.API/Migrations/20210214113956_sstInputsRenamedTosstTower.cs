using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class sstInputsRenamedTosstTower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_predesign_dimesions_sst_inputs_sst_input_id",
                table: "sst_predesign_dimesions");

            migrationBuilder.DropForeignKey(
                name: "fk_sst_predesign_proposed_hub_heights_sst_inputs_sst_input_id",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropTable(
                name: "sst_inputs");

            migrationBuilder.RenameColumn(
                name: "sst_input_id",
                table: "sst_predesign_proposed_hub_heights",
                newName: "sst_tower_id");

            migrationBuilder.RenameIndex(
                name: "ix_sst_predesign_proposed_hub_heights_sst_input_id",
                table: "sst_predesign_proposed_hub_heights",
                newName: "ix_sst_predesign_proposed_hub_heights_sst_tower_id");

            migrationBuilder.RenameColumn(
                name: "sst_input_id",
                table: "sst_predesign_dimesions",
                newName: "sst_tower_id");

            migrationBuilder.RenameIndex(
                name: "ix_sst_predesign_dimesions_sst_input_id",
                table: "sst_predesign_dimesions",
                newName: "ix_sst_predesign_dimesions_sst_tower_id");

            migrationBuilder.CreateTable(
                name: "sst_tower",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    quote_id = table.Column<int>(type: "integer", nullable: false),
                    windfarm_configuration_id = table.Column<string>(type: "text", nullable: false),
                    loads_cluster_id = table.Column<int>(type: "integer", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    turbine_quantity = table.Column<int>(type: "integer", nullable: false),
                    cluster_size = table.Column<decimal>(type: "numeric", nullable: false),
                    turbine_quantity_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    windfarm_size_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    tower_type_id = table.Column<int>(type: "integer", nullable: false),
                    existing_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_weight = table.Column<decimal>(type: "numeric", nullable: false),
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
                    application_reasons_other_description = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    is_sar_input_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_design_evaluation_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_duplicate_scenario = table.Column<bool>(type: "boolean", nullable: false),
                    aep_lookup_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_tower", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_tower_loads_clusters_loads_cluster_id",
                        column: x => x.loads_cluster_id,
                        principalTable: "loads_clusters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sst_tower_quotes_quote_id",
                        column: x => x.quote_id,
                        principalTable: "quotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sst_tower_tower_types_tower_type_id",
                        column: x => x.tower_type_id,
                        principalTable: "tower_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sst_tower_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_sst_tower_loads_cluster_id",
                table: "sst_tower",
                column: "loads_cluster_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_tower_quote_id",
                table: "sst_tower",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_tower_tower_type_id",
                table: "sst_tower",
                column: "tower_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_tower_wtg_catalogue_id",
                table: "sst_tower",
                column: "wtg_catalogue_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sst_predesign_dimesions_sst_tower_sst_tower_id",
                table: "sst_predesign_dimesions",
                column: "sst_tower_id",
                principalTable: "sst_tower",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sst_predesign_proposed_hub_heights_sst_tower_sst_tower_id",
                table: "sst_predesign_proposed_hub_heights",
                column: "sst_tower_id",
                principalTable: "sst_tower",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_predesign_dimesions_sst_tower_sst_tower_id",
                table: "sst_predesign_dimesions");

            migrationBuilder.DropForeignKey(
                name: "fk_sst_predesign_proposed_hub_heights_sst_tower_sst_tower_id",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropTable(
                name: "sst_tower");

            migrationBuilder.RenameColumn(
                name: "sst_tower_id",
                table: "sst_predesign_proposed_hub_heights",
                newName: "sst_input_id");

            migrationBuilder.RenameIndex(
                name: "ix_sst_predesign_proposed_hub_heights_sst_tower_id",
                table: "sst_predesign_proposed_hub_heights",
                newName: "ix_sst_predesign_proposed_hub_heights_sst_input_id");

            migrationBuilder.RenameColumn(
                name: "sst_tower_id",
                table: "sst_predesign_dimesions",
                newName: "sst_input_id");

            migrationBuilder.RenameIndex(
                name: "ix_sst_predesign_dimesions_sst_tower_id",
                table: "sst_predesign_dimesions",
                newName: "ix_sst_predesign_dimesions_sst_input_id");

            migrationBuilder.CreateTable(
                name: "sst_inputs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    aep_lookup_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    application_modes = table.Column<int[]>(type: "integer[]", nullable: false),
                    application_reasons = table.Column<int[]>(type: "integer[]", nullable: false),
                    application_reasons_other_description = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    cluster_size = table.Column<decimal>(type: "numeric", nullable: false),
                    elsa_load_envelop_link = table.Column<string>(type: "text", nullable: true),
                    existing_hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    features = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    is_design_evaluation_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_duplicate_scenario = table.Column<bool>(type: "boolean", nullable: false),
                    is_sar_input_request = table.Column<bool>(type: "boolean", nullable: false),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    loads_cluster_id = table.Column<int>(type: "integer", nullable: false),
                    noise_mode_doc_link = table.Column<string>(type: "text", nullable: true),
                    noise_modes = table.Column<int[]>(type: "integer[]", nullable: false),
                    quote_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    rna_loads = table.Column<decimal>(type: "numeric", nullable: false),
                    safal_load_envelop_link = table.Column<string>(type: "text", nullable: true),
                    target_life_time = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_load_result = table.Column<decimal>(type: "numeric", nullable: false),
                    tower_load_result_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    tower_type_id = table.Column<int>(type: "integer", nullable: false),
                    tower_weight = table.Column<decimal>(type: "numeric", nullable: false),
                    turbine_quantity = table.Column<int>(type: "integer", nullable: false),
                    turbine_quantity_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    windfarm_configuration_id = table.Column<string>(type: "text", nullable: false),
                    windfarm_size_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_inputs", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_inputs_loads_clusters_loads_cluster_id",
                        column: x => x.loads_cluster_id,
                        principalTable: "loads_clusters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sst_inputs_quotes_quote_id",
                        column: x => x.quote_id,
                        principalTable: "quotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sst_inputs_tower_types_tower_type_id",
                        column: x => x.tower_type_id,
                        principalTable: "tower_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sst_inputs_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_loads_cluster_id",
                table: "sst_inputs",
                column: "loads_cluster_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_quote_id",
                table: "sst_inputs",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_tower_type_id",
                table: "sst_inputs",
                column: "tower_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_wtg_catalogue_id",
                table: "sst_inputs",
                column: "wtg_catalogue_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sst_predesign_dimesions_sst_inputs_sst_input_id",
                table: "sst_predesign_dimesions",
                column: "sst_input_id",
                principalTable: "sst_inputs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sst_predesign_proposed_hub_heights_sst_inputs_sst_input_id",
                table: "sst_predesign_proposed_hub_heights",
                column: "sst_input_id",
                principalTable: "sst_inputs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
