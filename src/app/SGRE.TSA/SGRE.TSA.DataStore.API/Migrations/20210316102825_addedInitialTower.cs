using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedInitialTower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_base_tower_design_dimensions_base_tower_id",
                table: "base_tower_design_dimensions");

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.CreateTable(
                name: "initial_towers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    tower = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    model = table.Column<string>(type: "text", nullable: true),
                    hub_height_min_m = table.Column<decimal>(type: "numeric", nullable: false),
                    hub_height_max_m = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_initial_towers", x => x.id);
                    table.ForeignKey(
                        name: "fk_initial_towers_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "country_id", "max_segment_length_mtrs", "max_tower_base_diameter_mtrs", "transport_mode_id" },
                values: new object[] { 2, 30m, 4.5m, 1 });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 3, 4.8m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 5, 4.7m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 7, 4.5m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 8, 4.3m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 32,
                column: "country_id",
                value: 12);

            migrationBuilder.InsertData(
                table: "initial_towers",
                columns: new[] { "id", "hub_height_max_m", "hub_height_min_m", "last_modified_date_time", "model", "record_insert_date_time", "tower", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 20, 125m, 155m, null, "", null, "T135-50A", 1 },
                    { 19, 100m, 125m, null, "", null, "T115-50A", 1 },
                    { 18, 112.25m, 135m, null, "", null, "T122.5-50A", 2 },
                    { 17, 90m, 112.25m, null, "", null, "T102.5-50A", 2 },
                    { 16, 77m, 110m, null, "MKII", null, "T84.41", 4 },
                    { 15, 142.5m, 165m, null, "MKII", null, "T157.5.40L2", 3 },
                    { 14, 115m, 142.5m, null, "MKII", null, "T127.5.40L2", 3 },
                    { 13, 96.25m, 115m, null, "MKII", null, "T102.5.43", 3 },
                    { 11, 84.75m, 96.25m, null, "MKII", null, "T90.41", 3 },
                    { 10, 79.5m, 84.75m, null, "MKII", null, "T79.5.40", 3 },
                    { 9, 111m, 120m, null, "MY20", null, "T114.30", 5 },
                    { 8, 104.75m, 111m, null, "MY20", null, "T108.30", 5 },
                    { 7, 99.25m, 104.75m, null, "MY20", null, "T101.5.31", 5 },
                    { 6, 90.5m, 99.25m, null, "MY20", null, "T97.31", 5 },
                    { 5, 84m, 90.5m, null, "MY20", null, "T84.36", 5 },
                    { 4, 107.75m, 120m, null, "MY19", null, "T114.30L2", 5 },
                    { 3, 92.75m, 107.75m, null, "MY19", null, "T101.5.30L2", 5 },
                    { 2, 84m, 92.75m, null, "MY19", null, "T84.32L5", 5 },
                    { 12, 96.25m, 115m, null, "MKII", null, "T102.5.42", 3 },
                    { 1, 84m, 92.75m, null, "MY19", null, "T84.32L2", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_design_dimensions_base_tower_id",
                table: "base_tower_design_dimensions",
                column: "base_tower_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_initial_towers_wtg_catalogue_id_tower",
                table: "initial_towers",
                columns: new[] { "wtg_catalogue_id", "tower" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "initial_towers");

            migrationBuilder.DropIndex(
                name: "ix_base_tower_design_dimensions_base_tower_id",
                table: "base_tower_design_dimensions");

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "country_id", "max_segment_length_mtrs", "max_tower_base_diameter_mtrs", "transport_mode_id" },
                values: new object[] { 4, 50m, 4.8m, 2 });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 2, 4.5m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 3, 4.3m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 5, 4.7m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "country_id", "max_tower_base_diameter_mtrs" },
                values: new object[] { 7, 4.5m });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 32,
                column: "country_id",
                value: 8);

            migrationBuilder.InsertData(
                table: "generic_market_boundaries",
                columns: new[] { "id", "country_id", "last_modified_date_time", "max_segment_length_mtrs", "max_segment_weight_ton", "max_tower_base_diameter_mtrs", "record_insert_date_time", "transport_mode_id" },
                values: new object[] { 33, 12, null, 30m, 95m, 4.3m, null, 1 });

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_design_dimensions_base_tower_id",
                table: "base_tower_design_dimensions",
                column: "base_tower_id");
        }
    }
}
