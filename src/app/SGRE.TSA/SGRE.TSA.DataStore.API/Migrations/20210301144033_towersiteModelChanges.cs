using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class towersiteModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "error_message",
                table: "towersite_report_total_sections_data");

            migrationBuilder.DropColumn(
                name: "is_error",
                table: "towersite_report_total_sections_data");

            migrationBuilder.DropColumn(
                name: "error_message",
                table: "towersite_report_sections_data");

            migrationBuilder.DropColumn(
                name: "is_error",
                table: "towersite_report_sections_data");

            migrationBuilder.DropColumn(
                name: "error_message",
                table: "towersite_report_general_data");

            migrationBuilder.DropColumn(
                name: "is_error",
                table: "towersite_report_general_data");

            migrationBuilder.AddColumn<string>(
                name: "nominal_tower",
                table: "towersite_report_general_data",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "region",
                table: "towersite_report_general_data",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "rna_load_margin",
                table: "towersite_cloe_report",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "towersite_report_design_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    is_error = table.Column<bool>(type: "boolean", nullable: false),
                    error_message = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_report_design_status", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "towersite_report_design_status");

            migrationBuilder.DropColumn(
                name: "nominal_tower",
                table: "towersite_report_general_data");

            migrationBuilder.DropColumn(
                name: "region",
                table: "towersite_report_general_data");

            migrationBuilder.DropColumn(
                name: "rna_load_margin",
                table: "towersite_cloe_report");

            migrationBuilder.AddColumn<string>(
                name: "error_message",
                table: "towersite_report_total_sections_data",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_error",
                table: "towersite_report_total_sections_data",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "error_message",
                table: "towersite_report_sections_data",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_error",
                table: "towersite_report_sections_data",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "error_message",
                table: "towersite_report_general_data",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_error",
                table: "towersite_report_general_data",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
