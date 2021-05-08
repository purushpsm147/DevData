using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SGRE.TSA.DataStore.API.Models;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AepLookupTowerSiteChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_inputs_loads_clusters_loads_cluster_id",
                table: "sst_inputs");

            migrationBuilder.DropTable(
                name: "towersite_report");

            migrationBuilder.DropColumn(
                name: "ts_lower_mm",
                table: "towersite_flanges");

            migrationBuilder.RenameColumn(
                name: "ts_upper_mm",
                table: "towersite_flanges",
                newName: "ts_mm");

            migrationBuilder.RenameColumn(
                name: "load_cluster_id",
                table: "sst_inputs",
                newName: "quotation_id");

            migrationBuilder.AddColumn<string>(
                name: "error_message",
                table: "towersite_flanges",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_error",
                table: "towersite_flanges",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "section_nr",
                table: "towersite_flanges",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_aep_lookup_done",
                table: "sst_predesign_proposed_hub_heights",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "loads_cluster_id",
                table: "sst_inputs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "aep_lookup_uuid",
                table: "sst_inputs",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "quote_id",
                table: "sst_inputs",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "sst_aep_lookup_gross",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    estimation_type = table.Column<string>(type: "text", nullable: true),
                    is_proposed_hub_height_found = table.Column<bool>(type: "boolean", nullable: false),
                    aep_nomination_gross = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_input_file = table.Column<IEnumerable<AepInputJson>>(type: "jsonb", nullable: true),
                    aep_lookup_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_aep_lookup_gross", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_flange_pairs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    flange_pair_nr_top_to_bottom = table.Column<int>(type: "integer", nullable: false),
                    flange_pair_nr_bottom_to_top = table.Column<int>(type: "integer", nullable: false),
                    z_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    tf_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    wf_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    nh_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    ts_upper_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    ts_lower_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    rc_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    dso_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    db_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    lb_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    nb = table.Column<decimal>(type: "numeric", nullable: true),
                    dcb_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    dh_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    lbe_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    dbeo_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    dbei_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    mass_kg = table.Column<decimal>(type: "numeric", nullable: true),
                    totalmass_kg = table.Column<decimal>(type: "numeric", nullable: true),
                    price = table.Column<decimal>(type: "numeric", nullable: true),
                    price_currency = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: true),
                    flange_type = table.Column<decimal>(type: "numeric", nullable: true),
                    tf_type = table.Column<decimal>(type: "numeric", nullable: true),
                    dbco_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    dfo_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    fb_pt_nom_kn = table.Column<decimal>(type: "numeric", nullable: true),
                    tfa_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    wfa_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    tbp_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    wbp_mm = table.Column<decimal>(type: "numeric", nullable: true),
                    is_error = table.Column<bool>(type: "boolean", nullable: false),
                    error_message = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_flange_pairs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_report_general_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    bottom_extreme_loads_knm = table.Column<decimal>(type: "numeric", nullable: false),
                    bottom_fatigue_loads_knm = table.Column<decimal>(type: "numeric", nullable: false),
                    bottom_extreme_loads_vs_nominal_percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    bottom_fatigue_loads_vs_nominal_percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    is_error = table.Column<bool>(type: "boolean", nullable: false),
                    error_message = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_report_general_data", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_report_sections_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    section_nr = table.Column<int>(type: "integer", nullable: false),
                    section_type = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    upper_flange_external_diameter_m = table.Column<decimal>(type: "numeric", nullable: false),
                    lower_flange_external_diameter_m = table.Column<decimal>(type: "numeric", nullable: false),
                    section_length_m = table.Column<decimal>(type: "numeric", nullable: false),
                    section_weight_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    is_error = table.Column<bool>(type: "boolean", nullable: false),
                    error_message = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_report_sections_data", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_report_total_sections_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    lenght_m = table.Column<decimal>(type: "numeric", nullable: false),
                    length_nominal_percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    weigth_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    weight_nominal_percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    is_error = table.Column<bool>(type: "boolean", nullable: false),
                    error_message = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_report_total_sections_data", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "role_description",
                value: "Sales Manager");

            migrationBuilder.CreateIndex(
                name: "ix_sst_inputs_quote_id",
                table: "sst_inputs",
                column: "quote_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sst_inputs_loads_clusters_loads_cluster_id",
                table: "sst_inputs",
                column: "loads_cluster_id",
                principalTable: "loads_clusters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sst_inputs_quotes_quote_id",
                table: "sst_inputs",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_inputs_loads_clusters_loads_cluster_id",
                table: "sst_inputs");

            migrationBuilder.DropForeignKey(
                name: "fk_sst_inputs_quotes_quote_id",
                table: "sst_inputs");

            migrationBuilder.DropTable(
                name: "sst_aep_lookup_gross");

            migrationBuilder.DropTable(
                name: "towersite_flange_pairs");

            migrationBuilder.DropTable(
                name: "towersite_report_general_data");

            migrationBuilder.DropTable(
                name: "towersite_report_sections_data");

            migrationBuilder.DropTable(
                name: "towersite_report_total_sections_data");

            migrationBuilder.DropIndex(
                name: "ix_sst_inputs_quote_id",
                table: "sst_inputs");

            migrationBuilder.DropColumn(
                name: "error_message",
                table: "towersite_flanges");

            migrationBuilder.DropColumn(
                name: "is_error",
                table: "towersite_flanges");

            migrationBuilder.DropColumn(
                name: "section_nr",
                table: "towersite_flanges");

            migrationBuilder.DropColumn(
                name: "is_aep_lookup_done",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropColumn(
                name: "aep_lookup_uuid",
                table: "sst_inputs");

            migrationBuilder.DropColumn(
                name: "quote_id",
                table: "sst_inputs");

            migrationBuilder.RenameColumn(
                name: "ts_mm",
                table: "towersite_flanges",
                newName: "ts_upper_mm");

            migrationBuilder.RenameColumn(
                name: "quotation_id",
                table: "sst_inputs",
                newName: "load_cluster_id");

            migrationBuilder.AddColumn<decimal>(
                name: "ts_lower_mm",
                table: "towersite_flanges",
                type: "numeric",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "loads_cluster_id",
                table: "sst_inputs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "towersite_report",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    bottom_extreme_loads_knm = table.Column<decimal>(type: "numeric", nullable: false),
                    bottom_extreme_loads_vs_nominal_percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    bottom_fatigue_loads_knm = table.Column<decimal>(type: "numeric", nullable: false),
                    bottom_fatigue_loads_vs_nominal_percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    error_message = table.Column<string>(type: "text", nullable: true),
                    is_error = table.Column<bool>(type: "boolean", nullable: false),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_report", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "role_description",
                value: "Opportunity Owner");

            migrationBuilder.AddForeignKey(
                name: "fk_sst_inputs_loads_clusters_loads_cluster_id",
                table: "sst_inputs",
                column: "loads_cluster_id",
                principalTable: "loads_clusters",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
