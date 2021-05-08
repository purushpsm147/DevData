using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeededTowerTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "hub_height_m",
                table: "tower_types",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "initial_tower_id",
                table: "sst_tower",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_initial_tower_found",
                table: "sst_tower",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 1,
                column: "hub_height_m",
                value: 115m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 2,
                column: "hub_height_m",
                value: 135m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 3,
                column: "hub_height_m",
                value: 102.5m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 4,
                column: "hub_height_m",
                value: 122.5m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 5,
                column: "hub_height_m",
                value: 79.5m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 6,
                column: "hub_height_m",
                value: 90m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 7,
                column: "hub_height_m",
                value: 102.5m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 8,
                column: "hub_height_m",
                value: 102.5m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 9,
                column: "hub_height_m",
                value: 127.5m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 10,
                column: "hub_height_m",
                value: 157.5m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 11,
                column: "hub_height_m",
                value: 84m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 23,
                column: "hub_height_m",
                value: 84m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 24,
                column: "hub_height_m",
                value: 97m);

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 26,
                column: "hub_height_m",
                value: 101.5m);

            migrationBuilder.InsertData(
                table: "tower_types",
                columns: new[] { "id", "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 80, 100.5m, "T100.5.31", 5 },
                    { 64, 107.5m, "T107.5.41", 3 },
                    { 65, 107.5m, "T107.5.42", 3 },
                    { 66, 117.5m, "T117.5.40L1", 3 },
                    { 67, 144m, "T144.41-MB", 3 },
                    { 68, 165m, "T165.40", 3 },
                    { 69, 84m, "T84.40", 4 },
                    { 70, 84m, "T84.43", 4 },
                    { 81, 127.5m, "T127.5.31", 5 },
                    { 71, 79m, "T79.40", 4 },
                    { 73, 84m, "T84.39", 6 },
                    { 74, 84m, "T84.310", 6 },
                    { 75, 108m, "T108.30", 6 },
                    { 76, 114m, "T114.30", 6 },
                    { 77, 134m, "T134.30", 6 },
                    { 63, 107.5m, "T107.5.40", 3 },
                    { 79, 94m, "T94.31", 5 },
                    { 72, 106.5m, "T106.5.40", 4 },
                    { 78, 84m, "T84.38", 6 },
                    { 62, 97.5m, "T97.5.40L2", 3 },
                    { 60, 90m, "T90.40L1", 3 },
                    { 29, 101.5m, "T101.5-50A", 1 },
                    { 30, 115m, "T115-51A", 1 },
                    { 31, 115m, "T115-52A-WTC", 1 },
                    { 32, 135m, "T135-51A-WTC", 1 },
                    { 33, 145m, "T145-50A", 1 },
                    { 34, 155m, "T155-50A", 1 },
                    { 35, 165m, "T165-51A-MB", 1 },
                    { 36, 90m, "T90-50A", 2 },
                    { 37, 102.5m, "T102.5-51A", 2 },
                    { 38, 107.5m, "T107.5-50A", 2 },
                    { 39, 113.5m, "T113.5-50A", 2 },
                    { 40, 117.5m, "T117.5-50A", 2 },
                    { 41, 120.5m, "T120.5-50A", 2 },
                    { 42, 122.5m, "T122.5-51A", 2 },
                    { 61, 90m, "T90.40L2", 3 },
                    { 43, 122.5m, "T122.5-52A", 2 },
                    { 45, 165m, "T165-50A-MB", 2 },
                    { 59, 86m, "T86.40L1", 3 },
                    { 58, 127.5m, "T127.5.46", 3 },
                    { 57, 127.5m, "T127.5.45", 3 },
                    { 56, 127.5m, "T127.5.44", 3 },
                    { 55, 127.5m, "T127.5.43", 3 },
                    { 54, 127.5m, "T127.5.41", 3 },
                    { 53, 127.5m, "T127.5.40", 3 },
                    { 52, 97.5m, "T97.5.41", 3 },
                    { 51, 97.5m, "T97.5.40", 3 },
                    { 50, 95.5m, "T95.5.41", 3 },
                    { 49, 95.5m, "T95.5.40", 3 },
                    { 48, 91m, "T91.41", 3 },
                    { 47, 91m, "T91.40", 3 },
                    { 46, 90m, "T90.40", 3 },
                    { 44, 122.5m, "T122.5-53A-WTC", 2 },
                    { 28, 100m, "T100-51A", 1 }
                });

            migrationBuilder.InsertData(
                table: "wtg_catalogues",
                columns: new[] { "id", "last_modified_date_time", "platform", "record_insert_date_time", "wtg_size_mw", "wtg_type" },
                values: new object[] { 7, null, "SG4.X", null, 5m, "SG 4.7-155" });

            migrationBuilder.InsertData(
                table: "tower_types",
                columns: new[] { "id", "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 82, 102.5m, "T102.5.44", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "wtg_catalogues",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "hub_height_m",
                table: "tower_types");

            migrationBuilder.DropColumn(
                name: "initial_tower_id",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "is_initial_tower_found",
                table: "sst_tower");
        }
    }
}
