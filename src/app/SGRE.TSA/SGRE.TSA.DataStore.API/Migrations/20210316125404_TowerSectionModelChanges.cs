using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class TowerSectionModelChanges : Migration
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
                name: "tower_sections",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    tower_type_id = table.Column<int>(type: "integer", nullable: false),
                    section_number = table.Column<int>(type: "integer", nullable: false),
                    section_type = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    section_height_m = table.Column<decimal>(type: "numeric", nullable: false),
                    total_weight_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    external_diameter_upper_flange_m = table.Column<decimal>(type: "numeric", nullable: false),
                    external_diameter_lower_flange_m = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tower_sections", x => x.id);
                    table.ForeignKey(
                        name: "fk_tower_sections_tower_types_tower_type_id",
                        column: x => x.tower_type_id,
                        principalTable: "tower_types",
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

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_design_dimensions_base_tower_id",
                table: "base_tower_design_dimensions",
                column: "base_tower_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_tower_sections_tower_type_id_section_number",
                table: "tower_sections",
                columns: new[] { "tower_type_id", "section_number" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tower_sections");

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
