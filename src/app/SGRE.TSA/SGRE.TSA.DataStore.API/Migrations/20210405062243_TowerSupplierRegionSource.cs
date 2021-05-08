using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class TowerSupplierRegionSource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "interface_tools",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    tool_name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_interface_tools", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tower_supplier_regions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    region_id = table.Column<int>(type: "integer", nullable: false),
                    region_name = table.Column<string>(type: "text", nullable: true),
                    interface_tools_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tower_supplier_regions", x => x.id);
                    table.ForeignKey(
                        name: "fk_tower_supplier_regions_interface_tools_interface_tools_id",
                        column: x => x.interface_tools_id,
                        principalTable: "interface_tools",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tower_supplier_regions_regions_region_id",
                        column: x => x.region_id,
                        principalTable: "regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tower_supplier_sources",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    tower_supplier_region_id = table.Column<int>(type: "integer", nullable: false),
                    sourcing_name = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tower_supplier_sources", x => x.id);
                    table.ForeignKey(
                        name: "fk_tower_supplier_sources_tower_supplier_regions_tower_supplier",
                        column: x => x.tower_supplier_region_id,
                        principalTable: "tower_supplier_regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "line_item_source",
                value: "TowerSupplierRegion");

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "line_item_source",
                value: "TowerSupplierSource");

            migrationBuilder.InsertData(
                table: "interface_tools",
                columns: new[] { "id", "description", "last_modified_date_time", "record_insert_date_time", "tool_name" },
                values: new object[,]
                {
                    { 1, "Towersite Interface", null, null, "TowerCubo" },
                    { 2, "SST Interface", null, null, "SST" },
                    { 3, "Towersite Interface", null, null, "TowerSite" }
                });

            migrationBuilder.InsertData(
                table: "tower_supplier_regions",
                columns: new[] { "id", "interface_tools_id", "last_modified_date_time", "record_insert_date_time", "region_id", "region_name" },
                values: new object[,]
                {
                    { 1, 1, null, null, 1, "APAC" },
                    { 2, 1, null, null, 2, "BRA" },
                    { 3, 1, null, null, 3, "IN" },
                    { 4, 1, null, null, 4, "LATAM" },
                    { 5, 1, null, null, 6, "NA" },
                    { 6, 1, null, null, 5, "NEME" },
                    { 7, 1, null, null, 7, "SEA" },
                    { 8, 2, null, null, 5, "EUROPE" },
                    { 9, 2, null, null, 1, "APAC" },
                    { 10, 3, null, null, 1, "China" },
                    { 11, 3, null, null, 2, "BRAZIL" },
                    { 12, 3, null, null, 3, "INDIA" },
                    { 13, 3, null, null, 4, "LATAM" },
                    { 14, 3, null, null, 6, "NA" },
                    { 15, 3, null, null, 5, "NEME" },
                    { 16, 3, null, null, 7, "SE&A" }
                });

            migrationBuilder.InsertData(
                table: "tower_supplier_sources",
                columns: new[] { "id", "last_modified_date_time", "record_insert_date_time", "sourcing_name", "tower_supplier_region_id" },
                values: new object[,]
                {
                    { 1, null, null, "China", 1 },
                    { 22, null, null, "ITALY", 8 },
                    { 21, null, null, "DENMARK", 8 },
                    { 20, null, null, "SPAIN", 8 },
                    { 19, null, null, "Spain/Portugal", 7 },
                    { 18, null, null, "Italy (Pugliese)", 7 },
                    { 17, null, null, "Greece (EMEK)", 7 },
                    { 16, null, null, "Egypt (SIAG)", 7 },
                    { 15, null, null, "Egypt (NSF)", 7 },
                    { 14, null, null, "Turkey", 6 },
                    { 13, null, null, "Poland (GSG)", 6 },
                    { 12, null, null, "Denmark (Valmont SM)", 6 },
                    { 11, null, null, "USA - South", 5 },
                    { 10, null, null, "USA - North", 5 },
                    { 9, null, null, "Mexico - North", 4 },
                    { 8, null, null, "Mexico - East", 4 },
                    { 7, null, null, "India - TN", 3 },
                    { 6, null, null, "India - MH", 3 },
                    { 5, null, null, "India - GJ", 3 },
                    { 4, null, null, "Brazil", 2 },
                    { 3, null, null, "Vietnam (CS WIND)", 1 },
                    { 2, null, null, "Indonesia (Kenertec)", 1 },
                    { 23, null, null, "CHINA", 9 },
                    { 24, null, null, "VIETNAM", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_tower_supplier_regions_interface_tools_id",
                table: "tower_supplier_regions",
                column: "interface_tools_id");

            migrationBuilder.CreateIndex(
                name: "ix_tower_supplier_regions_region_id",
                table: "tower_supplier_regions",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "ix_tower_supplier_sources_tower_supplier_region_id",
                table: "tower_supplier_sources",
                column: "tower_supplier_region_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tower_supplier_sources");

            migrationBuilder.DropTable(
                name: "tower_supplier_regions");

            migrationBuilder.DropTable(
                name: "interface_tools");

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 3,
                column: "line_item_source",
                value: "Region");

            migrationBuilder.UpdateData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 4,
                column: "line_item_source",
                value: "Country");
        }
    }
}
