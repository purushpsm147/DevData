using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class GeneralMarketBoundariesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 10,
                column: "max_tower_base_diameter_mtrs",
                value: 4.7m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 11,
                column: "max_tower_base_diameter_mtrs",
                value: 4.7m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 18,
                column: "max_segment_length_mtrs",
                value: 30m);

            migrationBuilder.InsertData(
                table: "generic_market_boundaries",
                columns: new[] { "id", "country_id", "last_modified_date_time", "max_segment_length_mtrs", "max_segment_weight_ton", "max_tower_base_diameter_mtrs", "record_insert_date_time", "transport_mode_id" },
                values: new object[,]
                {
                    { 19, 56, null, 36m, 85m, 4.5m, null, 1 },
                    { 33, 12, null, 30m, 95m, 4.3m, null, 1 },
                    { 31, 7, null, 30m, 95m, 4.5m, null, 1 },
                    { 30, 5, null, 30m, 95m, 4.7m, null, 1 },
                    { 29, 3, null, 30m, 95m, 4.3m, null, 1 },
                    { 28, 2, null, 30m, 95m, 4.5m, null, 1 },
                    { 32, 8, null, 30m, 95m, 4.3m, null, 1 },
                    { 26, 4, null, 50m, 95m, 4.3m, null, 1 },
                    { 25, 96, null, 36m, 72.57m, 4.115m, null, 2 },
                    { 24, 96, null, 36m, 72.57m, 4.5m, null, 1 },
                    { 27, 4, null, 50m, 95m, 4.8m, null, 2 },
                    { 23, 103, null, 36m, 80m, 4.68m, null, 1 },
                    { 22, 101, null, 36m, 80m, 4.5m, null, 1 },
                    { 21, 102, null, 36m, 80m, 4.7m, null, 1 },
                    { 20, 47, null, 36m, 85m, 4.5m, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "admin@siemensgamesa.com", "admin@siemensgamesa.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 10,
                column: "max_tower_base_diameter_mtrs",
                value: 4.8m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 11,
                column: "max_tower_base_diameter_mtrs",
                value: 4.8m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 18,
                column: "max_segment_length_mtrs",
                value: 29m);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "created_by", "updated_by" },
                values: new object[] { "visweswara.dontamsetti.ext@siemensgamesa.com", "visweswara.dontamsetti.ext@siemensgamesa.com" });
        }
    }
}
