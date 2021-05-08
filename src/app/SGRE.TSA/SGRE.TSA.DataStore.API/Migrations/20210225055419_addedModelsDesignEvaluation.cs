using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedModelsDesignEvaluation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "is_design_evaluation_complete",
                table: "sst_tower",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "request_design_evaluation_end_datetime",
                table: "sst_tower",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "request_design_evaluation_start_datetime",
                table: "sst_tower",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "sst_uuid",
                table: "sst_tower",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "last_modified_date_time",
                table: "scenario_designs",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "record_insert_date_time",
                table: "scenario_designs",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "last_modified_date_time",
                table: "scenario_costs_kpis",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "record_insert_date_time",
                table: "scenario_costs_kpis",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "sst_design_evaluation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    design_lifetime_status = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    loads_assessment_status = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    tower_design_status = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    is_seismic_constraint = table.Column<bool>(type: "boolean", nullable: false),
                    is_pause_scenario = table.Column<bool>(type: "boolean", nullable: false),
                    is_retire_scenario = table.Column<bool>(type: "boolean", nullable: false),
                    is_preliminary_logistic_assessment_request = table.Column<bool>(type: "boolean", nullable: false),
                    is_costs_timeline_feedback_request = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_design_evaluation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sst_design_seismic_assessment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_design_evaluation_id = table.Column<int>(type: "integer", nullable: false),
                    seismic_assessment_status_types = table.Column<int>(type: "integer", nullable: false),
                    seismic_assessment_result_types = table.Column<int>(type: "integer", nullable: false),
                    is_first_level_assessment_request = table.Column<bool>(type: "boolean", nullable: false),
                    first_level_assessment_doc_link = table.Column<string>(type: "text", nullable: true),
                    is_second_level_assessment_request = table.Column<bool>(type: "boolean", nullable: false),
                    second_level_assessment_doc_link = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_design_seismic_assessment", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_design_seismic_assessment_sst_design_evaluation_sst_des",
                        column: x => x.sst_design_evaluation_id,
                        principalTable: "sst_design_evaluation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 72,
                column: "tower_type_id",
                value: 23);

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "5", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102.2m, "6", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.3m, "7", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100.3m, "8", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 109.3m, "standard", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.7m, "5", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99.9m, "6", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 108.8m, "standard", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106.5m, "standard", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106.3m, "standard", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105m, "1", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "2", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 104m, 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "1", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.9m, "2", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100.8m, "3", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99.9m, "4", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98.8m, "5", 2 });

            migrationBuilder.CreateIndex(
                name: "ix_sst_design_seismic_assessment_sst_design_evaluation_id",
                table: "sst_design_seismic_assessment",
                column: "sst_design_evaluation_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sst_design_seismic_assessment");

            migrationBuilder.DropTable(
                name: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "is_design_evaluation_complete",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "request_design_evaluation_end_datetime",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "request_design_evaluation_start_datetime",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "sst_uuid",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "last_modified_date_time",
                table: "scenario_designs");

            migrationBuilder.DropColumn(
                name: "record_insert_date_time",
                table: "scenario_designs");

            migrationBuilder.DropColumn(
                name: "last_modified_date_time",
                table: "scenario_costs_kpis");

            migrationBuilder.DropColumn(
                name: "record_insert_date_time",
                table: "scenario_costs_kpis");

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 72,
                column: "tower_type_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 108m, "1", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 107.5m, "2", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "3", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105m, "4", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "5", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102.2m, "6", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.3m, "7", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100.3m, "8", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 109.3m, "standard", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.7m, "1", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.2m, "2", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103.7m, "3", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102.7m, "4", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.7m, "5", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99.9m, "6", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 111.6m, 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "5", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102.2m, "6", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.3m, "7", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100.3m, "8", 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 109.3m, "standard", 23 });

            migrationBuilder.InsertData(
                table: "noise_modes",
                columns: new[] { "id", "last_modified_date_time", "noise_level_decibels", "noise_mode_description", "noise_mode_no", "record_insert_date_time", "tower_type_id" },
                values: new object[,]
                {
                    { 112, null, 99.9m, 0m, "4", null, 2 },
                    { 97, null, 99.9m, 0m, "6", null, 23 },
                    { 98, null, 99m, 0m, "7", null, 23 },
                    { 99, null, 98m, 0m, "8", null, 23 },
                    { 100, null, 108.8m, 0m, "standard", null, 23 },
                    { 101, null, 106.5m, 0m, "standard", null, 23 },
                    { 102, null, 106.3m, 0m, "standard", null, 2 },
                    { 103, null, 105m, 0m, "1", null, 2 },
                    { 104, null, 104m, 0m, "2", null, 2 },
                    { 105, null, 103m, 0m, "3", null, 2 },
                    { 106, null, 102m, 0m, "4", null, 2 },
                    { 107, null, 101m, 0m, "5", null, 2 },
                    { 108, null, 104m, 0m, "standard", null, 2 },
                    { 109, null, 103m, 0m, "1", null, 2 },
                    { 110, null, 101.9m, 0m, "2", null, 2 },
                    { 111, null, 100.8m, 0m, "3", null, 2 },
                    { 113, null, 98.8m, 0m, "5", null, 2 },
                    { 96, null, 101.7m, 0m, "5", null, 23 }
                });
        }
    }
}
