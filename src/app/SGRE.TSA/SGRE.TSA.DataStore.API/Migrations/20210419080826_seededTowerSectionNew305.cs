using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class seededTowerSectionNew305 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tower_sections",
                columns: new[] { "id", "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "last_modified_date_time", "record_insert_date_time", "section_height_m", "section_number", "section_type", "total_weight_kg", "tower_type_id" },
                values: new object[,]
                {
                    { 301, 4.5m, 4.5m, null, null, 13.180m, 1, null, 89293m, 29 },
                    { 302, 4.5m, 4.5m, null, null, 19.040m, 2, null, 90738m, 29 },
                    { 303, 4.5m, 4.4m, null, null, 23.8m, 3, null, 89933m, 29 },
                    { 304, 4.4m, 4.4m, null, null, 29.960m, 4, null, 79262m, 29 },
                    { 305, 4.4m, 3.503m, null, null, 32.210m, 5, null, 65219m, 29 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 305);
        }
    }
}
