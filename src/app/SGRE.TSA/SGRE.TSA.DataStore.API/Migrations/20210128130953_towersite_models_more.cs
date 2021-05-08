using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class towersite_models_more : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "d_grand_total",
                table: "towersite_plates_summary");

            migrationBuilder.DropColumn(
                name: "gwght_grand_total",
                table: "towersite_plates_summary");

            migrationBuilder.DropColumn(
                name: "nwght_grand_total",
                table: "towersite_plates_summary");

            migrationBuilder.DropColumn(
                name: "surf_grand_total",
                table: "towersite_plates_summary");

            migrationBuilder.CreateTable(
                name: "towersite_masses_section",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    section_nr = table.Column<int>(type: "integer", nullable: false),
                    length_mm = table.Column<decimal>(type: "numeric", nullable: false),
                    mass_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    lcog_mm = table.Column<decimal>(type: "numeric", nullable: false),
                    ra_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    tb_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_masses_section", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_plates_tower_summaries",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    d_grand_total = table.Column<decimal>(type: "numeric", nullable: true),
                    surf_grand_total = table.Column<decimal>(type: "numeric", nullable: true),
                    nwght_grand_total = table.Column<decimal>(type: "numeric", nullable: true),
                    gwght_grand_total = table.Column<decimal>(type: "numeric", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_plates_tower_summaries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "towersite_report",
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
                    error_message = table.Column<string>(type: "text", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_report", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(6732), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(6962), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7013), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7012), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7057), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7055), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7075), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7096), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7212), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7291), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7312), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7339), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7361), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7359), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7440), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7478), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7498), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7583), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7603), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7624), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7623), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7705), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7726), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7724), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7764), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7784), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7805), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7824), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7885), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7883), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7903), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7968), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7966), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7988), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(7986), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8008), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8068), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8107), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8128), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8126), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8148), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8167), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8166), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8187), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8206), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8205), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8225), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8246), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8245), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8285), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8284), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8305), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8303), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8471), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8469), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8497), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8536), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8558), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8579), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8619), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8638), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8657), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8697), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8695), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8736), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8756), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8775), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8774), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8861), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8902), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8922), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8941), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8999), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9037), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9059), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9078), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9098), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9137), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9156), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9155), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9175), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9255), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9279), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9277), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9298), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9297), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9337), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9336), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9356), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9354), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9375), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9394), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9413), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9433), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9432), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9451), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9472), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9471), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9491), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9490), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9511), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9509), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9548), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9569), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9568), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9589), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9587), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9648), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9647), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9669), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9709), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9708), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9729), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9766), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9786), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9826), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9844), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9865), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9864), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9922), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9943), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 644, DateTimeKind.Unspecified).AddTicks(9942), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(42), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(40), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(63), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(61), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(81), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(103), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(142), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(162), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(161), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(182), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(201), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(242), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(282), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(281), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(302), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(320), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(341), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(405), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(403), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(427), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(425), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(466), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(465), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(485), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(525), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(524), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(545), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(544), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(563), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(584), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(583), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(642), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(662), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(681), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(721), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(740), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(739), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(799), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(844), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(882), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(902), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(939), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(981), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4457), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4486), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4484), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4555), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4554), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4574), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4595), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4637), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4636), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4738), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4761), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4760), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4782), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4781), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4803), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4822), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4864), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4885), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4883), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4926), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4925), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4949), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4947), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4968), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4991), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5031), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5051), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5073), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5072), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5093), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5092), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5162), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5184), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5204), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5203), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5225), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5223), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5244), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5266), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5286), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5285), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 645, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(2806), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3395), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3397), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3403), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3402), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3414), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3413), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3415), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3419), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3422), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 13, 9, 52, 642, DateTimeKind.Unspecified).AddTicks(3421), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "towersite_masses_section");

            migrationBuilder.DropTable(
                name: "towersite_plates_tower_summaries");

            migrationBuilder.DropTable(
                name: "towersite_report");

            migrationBuilder.AddColumn<decimal>(
                name: "d_grand_total",
                table: "towersite_plates_summary",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "gwght_grand_total",
                table: "towersite_plates_summary",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "nwght_grand_total",
                table: "towersite_plates_summary",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "surf_grand_total",
                table: "towersite_plates_summary",
                type: "numeric",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6918), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6939), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6938), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6972), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6971), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7006), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7068), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7067), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7083), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7099), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7097), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7112), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7128), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7142), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7197), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7218), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7217), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7291), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7307), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7306), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7322), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7320), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7336), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7351), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7366), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7440), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7482), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7481), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7585), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7599), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7598), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7642), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7658), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7657), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7672), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7687), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7701), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7717), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7732), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7731), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7802), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7818), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7831), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7846), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7877), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7876), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7892), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7908), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7907), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7922), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7938), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7953), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7952), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7969), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7967), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7984), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(7999), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8058), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8057), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8073), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8088), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8102), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8118), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8133), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8147), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8162), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8161), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8177), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8192), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8206), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8265), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8281), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8296), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8311), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8309), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8326), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8324), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8363), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8381), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8409), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8425), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8440), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8469), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8468), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8484), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8483), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8498), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8514), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8512), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8529), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8528), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8543), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8558), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8574), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8573), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8588), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8587), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8603), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8602), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8618), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8702), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8718), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8733), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8746), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8761), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8807), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8867), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8897), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8949), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8968), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8967), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8982), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(8997), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9013), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9011), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9026), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9059), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9058), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9076), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9075), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9106), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9105), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9120), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9136), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9208), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9228), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9242), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9256), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9273), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9272), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9288), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9287), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9303), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9302), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9333), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9332), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9349), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9348), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9364), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9363), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9379), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9378), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9394), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9409), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9408), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9438), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9454), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9469), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9468), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9506), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9505), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9522), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9538), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9537), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9553), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9552), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9568), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9567), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9583), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9582), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9597), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9628), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9644), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9642), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9658), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9657), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9673), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9688), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9687), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9703), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9718), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9733), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9732), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9746), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9761), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9816), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9815), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9831), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9830), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9847), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9846), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9860), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9877), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9893), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9908), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9922), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9952), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9951), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9967), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9966), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9982), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9981), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9997), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 652, DateTimeKind.Unspecified).AddTicks(9996), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(12), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(26), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(25), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(41), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(40), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(56), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(55), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(71), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(70), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(109), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(123), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(140), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(139), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(155), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(154), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(169), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(198), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(214), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(213), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(229), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(244), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(259), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(289), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(288), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(317), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(333), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(348), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 653, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(6465), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7536), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7545), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7545), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7548), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7547), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7549), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7567), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 28, 6, 41, 14, 650, DateTimeKind.Unspecified).AddTicks(7570), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
