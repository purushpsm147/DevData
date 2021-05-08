using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class towersite_viv_etl_job_audit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "etl_job_audit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    job_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    job_id = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    job_description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    job_name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    framework = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    load_type = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    source_system = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    destination_system = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    source_type = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    destination_type = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    execution_status = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    is_completed = table.Column<bool>(type: "boolean", nullable: false),
                    process_count = table.Column<int>(type: "integer", nullable: false),
                    reject_count = table.Column<int>(type: "integer", nullable: false),
                    target_count = table.Column<int>(type: "integer", nullable: false),
                    error_msg = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    start_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    end_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_etl_job_audit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_viv_bolts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    from_section = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    to_section = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    tightened_bolts_percentage = table.Column<decimal>(type: "numeric(10,5)", precision: 10, scale: 5, nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_viv_bolts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_viv_windspeed",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    stage_nr = table.Column<int>(type: "integer", nullable: false),
                    stage_description = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    crit10min_tmean_wind_m_s = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: true),
                    maxallowed10min_mean_wind_m_s = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: true),
                    preventive_measure = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    maxallowed_viv_duration = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_viv_windspeed", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(1831), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(1824), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2044), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2083), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2148), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2146), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2175), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2199), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2223), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2221), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2358), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2356), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2379), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2378), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2392), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2408), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2407), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2422), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2422), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2451), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2465), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2484), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2482), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2513), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2526), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2541), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2555), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2554), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2582), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2597), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2638), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2668), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2684), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2697), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2711), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2725), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2724), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2741), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2740), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2756), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2755), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2783), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2825), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2853), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2903), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2934), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2947), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2962), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2961), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2975), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3004), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3019), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3032), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3046), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3061), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3088), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3087), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3102), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3101), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3116), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3128), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3143), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3176), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3209), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3223), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3222), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3236), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3265), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3279), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3293), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3308), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3307), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3321), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3336), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3351), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3350), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3364), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3378), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3429), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3428), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3459), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3474), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3473), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3505), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3521), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3520), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3534), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3549), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3548), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3577), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3605), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3619), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3661), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3660), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3723), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3739), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3769), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3768), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3783), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3782), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3797), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3796), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3810), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3825), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3839), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3838), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3852), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3867), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3895), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3894), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3909), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3908), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3923), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3922), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3937), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3951), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3964), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4018), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4032), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4031), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4046), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4088), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4102), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4115), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4129), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4143), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4158), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4157), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4172), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4186), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4199), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4213), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4228), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4268), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4267), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4282), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4296), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4325), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4338), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4353), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4368), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4381), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4409), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4408), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4424), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4423), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4450), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4464), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4514), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4535), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4534), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4548), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4564), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4563), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4578), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4607), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4605), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4620), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4635), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4634), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4649), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4648), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4662), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4677), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4692), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4706), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4705), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4735), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4734), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4750), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4763), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4817), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4815), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4859), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4873), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4886), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4915), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4931), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4945), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4944), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4959), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4958), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4973), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4972), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4987), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(4986), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5002), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5016), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5030), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5029), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5043), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5057), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5094), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5093), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5108), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5124), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5138), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5152), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5151), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5165), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5179), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5208), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5207), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5222), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5221), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5236), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5235), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5279), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5278), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5292), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5307), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5321), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5320), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5384), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5417), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5431), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5445), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5444), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5459), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5472), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5501), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 824, DateTimeKind.Unspecified).AddTicks(5500), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(2596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(2087), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3158), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3168), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3167), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3169), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3176), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3181), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3184), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3184), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3187), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3187), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3191), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 20, 13, 34, 51, 822, DateTimeKind.Unspecified).AddTicks(3194), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "etl_job_audit");

            migrationBuilder.DropTable(
                name: "towersite_viv_bolts");

            migrationBuilder.DropTable(
                name: "towersite_viv_windspeed");

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(464), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(724), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(766), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(781), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(800), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(799), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(815), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(829), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(828), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(843), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(873), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(888), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(887), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(903), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(902), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(917), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(933), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(932), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(947), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(946), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(964), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1046), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1061), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1076), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1075), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1091), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1090), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1105), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1104), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1119), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1118), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1133), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1161), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1176), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1191), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1205), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1218), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1233), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1232), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1267), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1281), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1359), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1357), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1375), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1389), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1388), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1404), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1419), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1434), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1462), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1538), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1553), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1568), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1567), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1597), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1647), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1664), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1693), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1707), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1722), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1737), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1736), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1751), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1766), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1781), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1795), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1811), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1844), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1843), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1858), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1857), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1873), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1908), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1925), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1954), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1953), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1968), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1982), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2012), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2011), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2026), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2041), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2040), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2054), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2086), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2085), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2115), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2130), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2144), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2159), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2209), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2208), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2256), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2255), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2271), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2285), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2284), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2314), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2314), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2329), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2328), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2345), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2344), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2359), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2374), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2373), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2389), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2388), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2404), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2403), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2418), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2417), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2433), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2448), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2462), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2530), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2528), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2544), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2543), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2559), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2572), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2603), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2617), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2632), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2631), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2645), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2689), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2704), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2718), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2733), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2733), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2762), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2814), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2829), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2843), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2859), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2858), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2875), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2891), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2890), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2905), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2934), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2964), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2963), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3030), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3045), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3059), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3088), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3103), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3134), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3133), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3163), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3222), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3221), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3236), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3265), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3314), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3331), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3347), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3361), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3376), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3375), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3421), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3420), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3436), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3435), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3450), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3449), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3479), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3478), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3494), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3493), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3508), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3507), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3522), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3536), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3552), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3551), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3581), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3648), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3663), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3692), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3705), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3719), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3764), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3763), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3822), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3835), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3851), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3850), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3865), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3864), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3901), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3933), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3932), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3999), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(3998), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4014), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4072), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4102), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4115), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4145), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4145), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4160), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 493, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2638), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2641), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2647), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2649), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2648), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2651), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2653), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2657), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2658), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2661), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2663), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 19, 11, 22, 9, 491, DateTimeKind.Unspecified).AddTicks(2662), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
