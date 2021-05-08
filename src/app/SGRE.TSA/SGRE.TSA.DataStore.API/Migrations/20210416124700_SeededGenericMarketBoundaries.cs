using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeededGenericMarketBoundaries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 27,
                column: "max_segment_length_mtrs",
                value: 36m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 28,
                column: "max_segment_length_mtrs",
                value: 36m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 29,
                column: "max_segment_length_mtrs",
                value: 36m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 30,
                column: "max_segment_length_mtrs",
                value: 36m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 31,
                column: "max_segment_length_mtrs",
                value: 36m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 32,
                column: "max_segment_length_mtrs",
                value: 36m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 27,
                column: "max_segment_length_mtrs",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 28,
                column: "max_segment_length_mtrs",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 29,
                column: "max_segment_length_mtrs",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 30,
                column: "max_segment_length_mtrs",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 31,
                column: "max_segment_length_mtrs",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 32,
                column: "max_segment_length_mtrs",
                value: 30m);
        }
    }
}
