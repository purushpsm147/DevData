using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeedDataSoftLaunch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_tower_types_wtg_catalogue_id_tower",
                table: "tower_types");

            migrationBuilder.DropIndex(
                name: "ix_application_modes_wtg_catalogue_id_application_mode_no_powe",
                table: "application_modes");

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

            migrationBuilder.InsertData(
                table: "application_modes",
                columns: new[] { "id", "application_mode_no", "last_modified_date_time", "power_rating", "record_insert_date_time", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 40, 3, null, 5m, null, 7 },
                    { 41, 2, null, 4.9m, null, 7 },
                    { 42, 1, null, 4.8m, null, 7 },
                    { 43, 0, null, 4.7m, null, 7 },
                    { 44, -1, null, 4.6m, null, 7 },
                    { 45, -2, null, 4.5m, null, 7 },
                    { 46, -3, null, 4.2m, null, 7 },
                    { 47, -4, null, 4m, null, 7 }
                });

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 10,
                column: "max_tower_base_diameter_mtrs",
                value: 4.8m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 28,
                column: "max_tower_base_diameter_mtrs",
                value: 4.3m);

            migrationBuilder.UpdateData(
                table: "nacelle_distances",
                keyColumn: "id",
                keyValue: 2,
                column: "distance_bottom_to_center_hub",
                value: 2265.941m);

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "﻿0", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 15 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 16 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "4", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "5", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "6", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "7", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "8", 17 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 105.5m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 104.5m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 103m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 102m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 101m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 100m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 99m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 98m, 18 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 2 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 19 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 20 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 101m, 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 100m, 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 80,
                column: "tower_type_id",
                value: 21);

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 81,
                column: "tower_type_id",
                value: 21);

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "0", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 22 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105m, "0", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "1", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103.5m, "2", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "3", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "4", 3 });

            migrationBuilder.InsertData(
                table: "noise_modes",
                columns: new[] { "id", "last_modified_date_time", "noise_level_decibels", "noise_mode_description", "noise_mode_no", "record_insert_date_time", "tower_type_id" },
                values: new object[,]
                {
                    { 298, null, 103m, 0m, "3", null, 62 },
                    { 299, null, 102m, 0m, "4", null, 62 },
                    { 300, null, 101m, 0m, "5", null, 62 },
                    { 301, null, 104m, 0m, "0", null, 62 },
                    { 302, null, 103m, 0m, "1", null, 62 },
                    { 303, null, 101.9m, 0m, "2", null, 62 },
                    { 304, null, 100.8m, 0m, "3", null, 62 },
                    { 305, null, 99.9m, 0m, "4", null, 62 },
                    { 311, null, 102m, 0m, "4", null, 63 },
                    { 307, null, 106.3m, 0m, "0", null, 63 },
                    { 308, null, 105m, 0m, "1", null, 63 },
                    { 309, null, 104m, 0m, "2", null, 63 },
                    { 310, null, 103m, 0m, "3", null, 63 },
                    { 297, null, 104m, 0m, "2", null, 62 },
                    { 312, null, 101m, 0m, "5", null, 63 },
                    { 313, null, 104m, 0m, "0", null, 63 },
                    { 306, null, 98.8m, 0m, "5", null, 62 },
                    { 296, null, 105m, 0m, "1", null, 62 },
                    { 290, null, 103m, 0m, "1", null, 14 },
                    { 294, null, 98.8m, 0m, "5", null, 14 },
                    { 277, null, 99.4m, 0m, "5", null, 56 },
                    { 278, null, 99.7m, 0m, "6", null, 56 },
                    { 279, null, 96.7m, 0m, "7", null, 56 },
                    { 280, null, 95.8m, 0m, "8", null, 56 },
                    { 281, null, 108.8m, 0m, "0", null, 68 },
                    { 282, null, 106.5m, 0m, "0", null, 68 },
                    { 283, null, 106.3m, 0m, "0", null, 14 },
                    { 284, null, 105m, 0m, "1", null, 14 },
                    { 285, null, 104m, 0m, "2", null, 14 },
                    { 286, null, 103m, 0m, "3", null, 14 },
                    { 287, null, 102m, 0m, "4", null, 14 },
                    { 288, null, 101m, 0m, "5", null, 14 },
                    { 289, null, 104m, 0m, "0", null, 14 },
                    { 314, null, 103m, 0m, "1", null, 63 },
                    { 291, null, 101.9m, 0m, "2", null, 14 },
                    { 292, null, 100.8m, 0m, "3", null, 14 },
                    { 293, null, 99.9m, 0m, "4", null, 14 },
                    { 295, null, 106.3m, 0m, "0", null, 62 },
                    { 315, null, 101.9m, 0m, "2", null, 63 },
                    { 321, null, 104m, 0m, "2", null, 64 },
                    { 317, null, 99.9m, 0m, "4", null, 63 },
                    { 340, null, 100.8m, 0m, "3", null, 64 },
                    { 341, null, 99.9m, 0m, "4", null, 64 },
                    { 342, null, 98.8m, 0m, "5", null, 64 },
                    { 343, null, 106.3m, 0m, "0", null, 64 },
                    { 344, null, 104m, 0m, "0", null, 64 },
                    { 345, null, 106.3m, 0m, "0", null, 65 },
                    { 346, null, 105m, 0m, "1", null, 65 },
                    { 347, null, 104m, 0m, "2", null, 65 },
                    { 348, null, 103m, 0m, "3", null, 65 },
                    { 349, null, 102m, 0m, "4", null, 65 },
                    { 350, null, 101m, 0m, "5", null, 65 },
                    { 351, null, 104m, 0m, "0", null, 65 },
                    { 352, null, 103m, 0m, "1", null, 65 },
                    { 353, null, 101.9m, 0m, "2", null, 65 },
                    { 354, null, 100.8m, 0m, "3", null, 65 },
                    { 355, null, 99.9m, 0m, "4", null, 65 },
                    { 356, null, 98.8m, 0m, "5", null, 65 },
                    { 339, null, 101.9m, 0m, "2", null, 64 },
                    { 316, null, 100.8m, 0m, "3", null, 63 },
                    { 337, null, 104m, 0m, "0", null, 64 },
                    { 335, null, 102m, 0m, "4", null, 64 },
                    { 318, null, 98.8m, 0m, "5", null, 63 },
                    { 319, null, 106.3m, 0m, "0", null, 64 },
                    { 320, null, 105m, 0m, "1", null, 64 },
                    { 276, null, 100.4m, 0m, "4", null, 56 },
                    { 322, null, 103m, 0m, "3", null, 64 },
                    { 323, null, 102m, 0m, "4", null, 64 },
                    { 324, null, 101m, 0m, "5", null, 64 },
                    { 325, null, 104m, 0m, "0", null, 64 },
                    { 326, null, 103m, 0m, "1", null, 64 },
                    { 327, null, 101.9m, 0m, "2", null, 64 },
                    { 328, null, 100.8m, 0m, "3", null, 64 },
                    { 329, null, 99.9m, 0m, "4", null, 64 },
                    { 330, null, 98.8m, 0m, "5", null, 64 },
                    { 331, null, 106.3m, 0m, "0", null, 64 },
                    { 332, null, 105m, 0m, "1", null, 64 },
                    { 333, null, 104m, 0m, "2", null, 64 },
                    { 334, null, 103m, 0m, "3", null, 64 },
                    { 336, null, 101m, 0m, "5", null, 64 },
                    { 275, null, 101.4m, 0m, "3", null, 56 },
                    { 338, null, 103m, 0m, "1", null, 64 },
                    { 273, null, 103.4m, 0m, "1", null, 56 },
                    { 193, null, 102m, 0m, "3", null, 23 },
                    { 192, null, 103.5m, 0m, "2", null, 23 },
                    { 191, null, 104m, 0m, "1", null, 23 },
                    { 190, null, 105m, 0m, "0", null, 23 },
                    { 189, null, 97m, 0m, "8", null, 32 },
                    { 188, null, 98m, 0m, "7", null, 32 },
                    { 187, null, 99m, 0m, "6", null, 32 },
                    { 186, null, 100m, 0m, "5", null, 32 },
                    { 185, null, 101m, 0m, "4", null, 32 },
                    { 274, null, 103m, 0m, "2", null, 56 },
                    { 184, null, 102m, 0m, "3", null, 32 },
                    { 182, null, 104m, 0m, "1", null, 32 },
                    { 181, null, 105m, 0m, "0", null, 32 },
                    { 180, null, 97m, 0m, "8", null, 31 },
                    { 179, null, 98m, 0m, "7", null, 31 },
                    { 178, null, 99m, 0m, "6", null, 31 },
                    { 177, null, 100m, 0m, "5", null, 31 },
                    { 176, null, 101m, 0m, "4", null, 31 },
                    { 175, null, 102m, 0m, "3", null, 31 },
                    { 174, null, 103.5m, 0m, "2", null, 31 },
                    { 183, null, 103.5m, 0m, "2", null, 32 },
                    { 121, null, 102m, 0m, "3", null, 26 },
                    { 120, null, 103.5m, 0m, "2", null, 26 },
                    { 119, null, 104m, 0m, "1", null, 26 },
                    { 98, null, 98m, 0m, "7", null, 3 },
                    { 99, null, 97m, 0m, "8", null, 3 },
                    { 100, null, 105m, 0m, "0", null, 24 },
                    { 101, null, 104m, 0m, "1", null, 24 },
                    { 102, null, 103.5m, 0m, "2", null, 24 },
                    { 103, null, 102m, 0m, "3", null, 24 },
                    { 104, null, 101m, 0m, "4", null, 24 },
                    { 105, null, 100m, 0m, "5", null, 24 },
                    { 106, null, 99m, 0m, "6", null, 24 },
                    { 107, null, 98m, 0m, "7", null, 24 },
                    { 108, null, 97m, 0m, "8", null, 24 },
                    { 109, null, 105m, 0m, "0", null, 25 },
                    { 110, null, 104m, 0m, "1", null, 25 },
                    { 111, null, 103.5m, 0m, "2", null, 25 },
                    { 112, null, 102m, 0m, "3", null, 25 },
                    { 113, null, 101m, 0m, "4", null, 25 },
                    { 114, null, 100m, 0m, "5", null, 25 },
                    { 115, null, 99m, 0m, "6", null, 25 },
                    { 116, null, 98m, 0m, "7", null, 25 },
                    { 117, null, 97m, 0m, "8", null, 25 },
                    { 118, null, 105m, 0m, "0", null, 26 },
                    { 173, null, 104m, 0m, "1", null, 31 },
                    { 172, null, 105m, 0m, "0", null, 31 },
                    { 171, null, 97m, 0m, "8", null, 30 },
                    { 170, null, 98m, 0m, "7", null, 30 },
                    { 144, null, 97m, 0m, "8", null, 28 },
                    { 143, null, 98m, 0m, "7", null, 28 },
                    { 142, null, 99m, 0m, "6", null, 28 },
                    { 141, null, 100m, 0m, "5", null, 28 },
                    { 140, null, 101m, 0m, "4", null, 28 },
                    { 139, null, 102m, 0m, "3", null, 28 },
                    { 138, null, 103.5m, 0m, "2", null, 28 },
                    { 137, null, 104m, 0m, "1", null, 28 },
                    { 136, null, 105m, 0m, "0", null, 28 },
                    { 135, null, 97m, 0m, "8", null, 27 },
                    { 134, null, 98m, 0m, "7", null, 27 },
                    { 133, null, 99m, 0m, "6", null, 27 },
                    { 132, null, 100m, 0m, "5", null, 27 },
                    { 131, null, 101m, 0m, "4", null, 27 },
                    { 130, null, 102m, 0m, "3", null, 27 },
                    { 129, null, 103.5m, 0m, "2", null, 27 },
                    { 128, null, 104m, 0m, "1", null, 27 },
                    { 127, null, 105m, 0m, "0", null, 27 },
                    { 126, null, 97m, 0m, "8", null, 26 },
                    { 125, null, 98m, 0m, "7", null, 26 },
                    { 124, null, 99m, 0m, "6", null, 26 },
                    { 145, null, 105m, 0m, "0", null, 4 },
                    { 97, null, 99m, 0m, "6", null, 3 },
                    { 146, null, 104m, 0m, "1", null, 4 },
                    { 148, null, 102m, 0m, "3", null, 4 },
                    { 169, null, 99m, 0m, "6", null, 30 },
                    { 168, null, 100m, 0m, "5", null, 30 },
                    { 167, null, 101m, 0m, "4", null, 30 },
                    { 166, null, 102m, 0m, "3", null, 30 },
                    { 165, null, 103.5m, 0m, "2", null, 30 },
                    { 164, null, 104m, 0m, "1", null, 30 },
                    { 163, null, 105m, 0m, "0", null, 30 },
                    { 162, null, 97m, 0m, "8", null, 29 },
                    { 161, null, 98m, 0m, "7", null, 29 },
                    { 160, null, 99m, 0m, "6", null, 29 },
                    { 159, null, 100m, 0m, "5", null, 29 },
                    { 158, null, 101m, 0m, "4", null, 29 },
                    { 157, null, 102m, 0m, "3", null, 29 },
                    { 156, null, 103.5m, 0m, "2", null, 29 },
                    { 155, null, 104m, 0m, "1", null, 29 },
                    { 154, null, 105m, 0m, "0", null, 29 },
                    { 153, null, 97m, 0m, "8", null, 4 },
                    { 152, null, 98m, 0m, "7", null, 4 },
                    { 151, null, 99m, 0m, "6", null, 4 },
                    { 150, null, 100m, 0m, "5", null, 4 },
                    { 149, null, 101m, 0m, "4", null, 4 },
                    { 147, null, 103.5m, 0m, "2", null, 4 },
                    { 123, null, 100m, 0m, "5", null, 26 },
                    { 122, null, 101m, 0m, "4", null, 26 },
                    { 226, null, 98m, 0m, "8", null, 33 },
                    { 203, null, 100.3m, 0m, "8", null, 40 },
                    { 202, null, 101.3m, 0m, "7", null, 40 },
                    { 201, null, 102.2m, 0m, "6", null, 40 },
                    { 200, null, 104m, 0m, "5", null, 40 },
                    { 199, null, 111.6m, 0m, "0", null, 40 },
                    { 198, null, 97m, 0m, "8", null, 23 },
                    { 197, null, 98m, 0m, "7", null, 23 },
                    { 225, null, 99m, 0m, "7", null, 33 },
                    { 196, null, 99m, 0m, "6", null, 23 },
                    { 194, null, 101m, 0m, "4", null, 23 },
                    { 215, null, 102.2m, 0m, "6", null, 33 },
                    { 227, null, 111.6m, 0m, "0", null, 34 },
                    { 228, null, 108m, 0m, "1", null, 34 },
                    { 229, null, 107.5m, 0m, "2", null, 34 },
                    { 230, null, 106m, 0m, "3", null, 34 },
                    { 231, null, 105m, 0m, "4", null, 34 },
                    { 195, null, 100m, 0m, "5", null, 23 },
                    { 224, null, 99.9m, 0m, "6", null, 33 },
                    { 223, null, 101.7m, 0m, "5", null, 33 },
                    { 222, null, 102.7m, 0m, "4", null, 33 },
                    { 214, null, 104m, 0m, "5", null, 33 },
                    { 213, null, 105m, 0m, "4", null, 33 },
                    { 212, null, 106m, 0m, "3", null, 33 },
                    { 96, null, 100m, 0m, "5", null, 3 },
                    { 211, null, 107.5m, 0m, "2", null, 33 },
                    { 210, null, 108m, 0m, "1", null, 33 },
                    { 209, null, 111.6m, 0m, "0", null, 33 },
                    { 208, null, 98m, 0m, "8", null, 40 },
                    { 207, null, 99m, 0m, "7", null, 40 },
                    { 206, null, 99.9m, 0m, "6", null, 40 },
                    { 205, null, 101.7m, 0m, "5", null, 40 },
                    { 204, null, 109.3m, 0m, "0", null, 40 },
                    { 217, null, 100.3m, 0m, "8", null, 33 },
                    { 218, null, 109.3m, 0m, "0", null, 33 },
                    { 219, null, 105.7m, 0m, "1", null, 33 },
                    { 220, null, 105.2m, 0m, "2", null, 33 },
                    { 221, null, 103.7m, 0m, "3", null, 33 },
                    { 232, null, 104m, 0m, "5", null, 34 },
                    { 233, null, 102.2m, 0m, "6", null, 34 },
                    { 216, null, 101.3m, 0m, "7", null, 33 },
                    { 235, null, 100.3m, 0m, "8", null, 34 },
                    { 262, null, 98m, 0m, "8", null, 38 },
                    { 257, null, 103.7m, 0m, "3", null, 38 },
                    { 258, null, 102.7m, 0m, "4", null, 38 },
                    { 259, null, 101.7m, 0m, "5", null, 38 },
                    { 272, null, 106.2m, 0m, "0", null, 56 },
                    { 271, null, 98.1m, 0m, "8", null, 56 },
                    { 234, null, 101.3m, 0m, "7", null, 34 },
                    { 255, null, 105.7m, 0m, "1", null, 38 },
                    { 270, null, 99m, 0m, "7", null, 56 },
                    { 268, null, 101.7m, 0m, "5", null, 56 },
                    { 267, null, 102.7m, 0m, "4", null, 56 },
                    { 266, null, 103.7m, 0m, "3", null, 56 },
                    { 265, null, 105.3m, 0m, "2", null, 56 },
                    { 264, null, 105.7m, 0m, "1", null, 56 },
                    { 260, null, 99.9m, 0m, "6", null, 38 },
                    { 261, null, 99m, 0m, "7", null, 38 },
                    { 269, null, 100m, 0m, "6", null, 56 },
                    { 254, null, 109.3m, 0m, "0", null, 38 },
                    { 256, null, 105.2m, 0m, "2", null, 38 },
                    { 252, null, 101.3m, 0m, "7", null, 38 },
                    { 236, null, 109.3m, 0m, "0", null, 34 },
                    { 237, null, 105.7m, 0m, "1", null, 34 },
                    { 238, null, 105.2m, 0m, "2", null, 34 },
                    { 239, null, 103.7m, 0m, "3", null, 34 },
                    { 240, null, 102.7m, 0m, "4", null, 34 },
                    { 253, null, 100.3m, 0m, "8", null, 38 },
                    { 242, null, 99.9m, 0m, "6", null, 34 },
                    { 243, null, 99m, 0m, "7", null, 34 },
                    { 241, null, 101.7m, 0m, "5", null, 34 },
                    { 245, null, 111.6m, 0m, "0", null, 38 },
                    { 246, null, 108m, 0m, "1", null, 38 },
                    { 247, null, 107.5m, 0m, "2", null, 38 },
                    { 248, null, 106m, 0m, "3", null, 38 },
                    { 249, null, 105m, 0m, "4", null, 38 },
                    { 250, null, 104m, 0m, "5", null, 38 },
                    { 251, null, 102.2m, 0m, "6", null, 38 },
                    { 244, null, 98m, 0m, "8", null, 34 },
                    { 263, null, 108.5m, 0m, "0", null, 56 }
                });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 5, 3, "georg.bischof@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 3, "carlos.sastre@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 4, "brenda.rodriguez@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 3, "jason.saizar@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 3, "luisa.vidal@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 2, 3, "renan.venturini@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 3, 3, "teddy.chandrakumar@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 5, 4, "henning.mentz@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 4, "shi.xiujuan@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 4, 4, "rene.hernandez@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 4, "maged.mostafa@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 4, "roberto.lozano@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 2, 4, "lucas.oyamada@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 3, 4, "teddy.chandrakumar@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 5, 6, "ingelise.nielsen@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 6, "fernando.vital@siemensgamesa.com" });

            migrationBuilder.InsertData(
                table: "preset_roles",
                columns: new[] { "id", "region_id", "role_id", "user_name" },
                values: new object[,]
                {
                    { 35, 5, 14, "lars.nissen@siemensgamesa.com" },
                    { 33, 2, 7, "domenico.barger@siemensgamesa.com" },
                    { 60, 5, 10, "oliver.kohn@siemensgamesa.com" },
                    { 59, 3, 9, "karthik.arumugam@siemensgamesa.com" },
                    { 58, 2, 9, "rodrigo.xambre@siemensgamesa.com" },
                    { 57, 6, 9, "charles.keyser@siemensgamesa.com" },
                    { 56, 7, 9, "miguel.diaz@siemensgamesa.com" },
                    { 55, 4, 9, "urko.sarasola@siemensgamesa.com" },
                    { 54, 1, 9, "" },
                    { 53, 5, 9, "oliver.kohn@siemensgamesa.com" },
                    { 52, 3, 8, "velmurugan.sundaram@siemensgamesa.com" },
                    { 51, 2, 8, "rodrigo.xambre@siemensgamesa.com" },
                    { 50, 6, 8, "klinton.burkett@siemensgamesa.com" },
                    { 49, 6, 8, "richard.cherry@siemensgamesa.com" },
                    { 48, 6, 8, "charles.keyser@siemensgamesa.com" },
                    { 47, 7, 8, "carlos.vildosola@siemensgamesa.com" },
                    { 46, 4, 8, "urko.sarasola@siemensgamesa.com" },
                    { 45, 4, 8, "juliana.diniz@siemensgamesa.com" },
                    { 44, 1, 8, "liqiang.xu@siemensgamesa.com" },
                    { 43, 1, 8, "guoxin.zhang.gz@siemensgamesa.com" },
                    { 42, 5, 8, "tanja.stahmer@siemensgamesa.com" },
                    { 41, 3, 14, "shanmuga.palanisamy@siemensgamesa.com" },
                    { 40, 2, 14, "justo.tirado@siemensgamesa.com" },
                    { 39, 6, 14, "justo.tirado@siemensgamesa.com" },
                    { 38, 7, 14, "maria.iturralde@siemensgamesa.com" },
                    { 37, 4, 14, "ana.hoyo@siemensgamesa.com" },
                    { 36, 1, 14, "tongbo.zhang@siemensgamesa.com" },
                    { 61, 1, 10, "waqar.hussain@siemensgamesa.com" },
                    { 34, 3, 7, "" },
                    { 62, 4, 10, "enrique.carballo@siemensgamesa.com" },
                    { 64, 6, 10, "paul.smith@siemensgamesa.com" },
                    { 17, 4, 6, "mikel.cenoz@siemensgamesa.com" },
                    { 18, 7, 6, "cristina.valencia.r@siemensgamesa.com" },
                    { 19, 6, 6, "eddie.rijo@siemensgamesa.com" },
                    { 20, 2, 6, "mikel.cenoz@siemensgamesa.com" },
                    { 21, 3, 6, "fernando.vital@siemensgamesa.com" },
                    { 63, 7, 10, "ines.zalacain@siemensgamesa.com" },
                    { 23, 5, 7, "roberto.decastro.c@siemensgamesa.com" },
                    { 24, 1, 7, "shuofei.cai@siemensgamesa.com" },
                    { 25, 1, 7, "zongying.zhao@siemensgamesa.com" },
                    { 22, 5, 7, "julieelaine.lherbier@siemensgamesa.com" },
                    { 27, 4, 7, "domenico.barger@siemensgamesa.com" },
                    { 28, 7, 7, "carlos.sanabria@siemensgamesa.com" },
                    { 29, 7, 7, "roberto.decastro@siemensgamesa.com" },
                    { 30, 6, 7, "elizabet.zaharieva@siemensgamesa.com" },
                    { 31, 6, 7, "domenico.barger@siemensgamesa.com" },
                    { 32, 2, 7, "" },
                    { 66, 3, 10, "manikandan.gurumoorthy@siemensgamesa.com" },
                    { 65, 2, 10, "sandro.patella@siemensgamesa.com" },
                    { 26, 4, 7, "carlos.mendez@siemensgamesa.com" }
                });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 6m, 5.682m, 15m, 91066.31003m, 2 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 5.682m, 5.678m, 84192.47139m, 2 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 5.678m, 4.8285m, 21.28m, 84470.30459m, 2 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.8285m, 4.4245m, 24.92m, 81538.36398m, 2 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.4245m, 4.42m, 26.88m, 68370.72276m, 2 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.42m, 3.503m, 26.134m, 6, 58393.18125m, 2 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.7m, 4.433m, 16.464m, 1, 79354.88909m, 3 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.433m, 4.427m, 22.68m, 2, 76299.29637m, 3 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.427m, 3.5566m, 27.16m, 3, 68693.00946m, 3 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 3.5566m, 3.574m, 33.61m, 4, 66933.01056m, 3 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.8m, 4.8m, 14.342m, 1, 84512.97202m, 4 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.8m, 4.8m, 19.368m, 2, 81456.61957m, 4 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.8m, 4.7925m, 26.832m, 3, 84754.19322m, 4 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.7925m, 4.099m, 29.977m, 4, 70462.43551m, 4 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.099m, 3.574m, 30m, 5, 56744.14819m, 4 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.115m, 4.1065m, 16.18m, 1, 60050.07041m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.1065m, 4.1m, 23.3m, 2, 57553.45592m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.1m, 4.0167m, 23.52m, 3, 44807.6526m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.0167m, 3.503m, 25m, 4, 41491.56669m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.678m, 4.43m, 19.7m, 1, 79730.43613m, 7 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.43m, 4.422m, 25.2999292m, 2, 71971.73324m, 7 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.422m, 4.017m, 28.1m, 3, 59627.713m, 7 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.017m, 3.503m, 27.336m, 4, 47562.59894m, 7 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.481m, 4.431m, 14.1m, 1, 62627.49387m, 8 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.431m, 4.424m, 16.9m, 2, 55264.09491m, 8 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.424m, 4.419m, 19.7m, 3, 49732.77538m, 8 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.419m, 4.416m, 25.3m, 4, 50217.58859m, 8 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.416m, 3.503m, 24.434m, 5, 43464.47028m, 8 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.67m, 4.67m, 16.265m, 75128.60571m, 9 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.67m, 4.433m, 18.18m, 68793.4201m, 9 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.433m, 4.423m, 18.185m, 57775.07995m, 9 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.423m, 4.121m, 22.88m, 56262.89418m, 9 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.121m, 3.817m, 22.99m, 43088.56415m, 9 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 3.817m, 3.503m, 27m, 47394.32028m, 9 });

            migrationBuilder.InsertData(
                table: "tower_sections",
                columns: new[] { "id", "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "last_modified_date_time", "record_insert_date_time", "section_height_m", "section_number", "section_type", "total_weight_kg", "tower_type_id" },
                values: new object[,]
                {
                    { 233, 4.031m, 4.024m, null, null, 20.92m, 2, null, 58746.20803m, 65 },
                    { 232, 4.278m, 4.031m, null, null, 16.615m, 1, null, 66996.79879m, 65 },
                    { 231, 3.3725m, 3.395m, null, null, 29.5m, 6, null, 48927.54285m, 64 },
                    { 230, 3.712m, 3.3725m, null, null, 25.82m, 5, null, 69651.0651m, 64 },
                    { 229, 4.131m, 3.712m, null, null, 22.86m, 4, null, 69970.78626m, 64 },
                    { 228, 4.4335m, 4.131m, null, null, 20.33m, 3, null, 71395.49988m, 64 },
                    { 227, 4.675m, 4.4335m, null, null, 18.805m, 2, null, 75629.55202m, 64 },
                    { 226, 4.68m, 4.675m, null, null, 14.685m, 1, null, 79873.20659m, 64 },
                    { 234, 4.024m, 4.017m, null, null, 20.935m, 3, null, 43002.44479m, 65 },
                    { 224, 4.422m, 3.928m, null, null, 24m, 4, null, 50004.9526m, 63 },
                    { 223, 4.427m, 4.422m, null, null, 21.115m, 3, null, 58383.45318m, 63 },
                    { 222, 4.436m, 4.427m, null, null, 20.94m, 2, null, 76993.39156m, 63 },
                    { 221, 4.678m, 4.436m, null, null, 16.945m, 1, null, 83749.99945m, 63 },
                    { 220, 3.928m, 3.395m, null, null, 27.345m, 5, null, 44460.825m, 62 },
                    { 225, 3.928m, 3.395m, null, null, 29m, 5, null, 48491.1258m, 63 },
                    { 235, 4.017m, 3.395m, null, null, 23.53m, 4, null, 42467.52242m, 65 },
                    { 247, 4.267m, 3.395m, null, null, 29.34m, 5, null, 48333.66421m, 68 },
                    { 237, 4.0225m, 3.598m, null, null, 30m, 2, null, 58971m, 66 },
                    { 219, 4.4185m, 3.928m, null, null, 23.14m, 4, null, 44320.3m, 62 },
                    { 251, 4.0182m, 3.503m, null, null, 29.485m, 4, null, 52736.5238m, 69 },
                    { 250, 4.4222m, 4.0182m, null, null, 27.46m, 3, null, 59567.71121m, 69 },
                    { 249, 4.4297m, 4.4222m, null, null, 24.09m, 2, null, 70365.09743m, 69 },
                    { 248, 4.68m, 4.4297m, null, null, 19.465m, 1, null, 79304.22078m, 69 },
                    { 246, 4.27m, 4.267m, null, null, 26.98m, 4, null, 50409.55414m, 68 },
                    { 236, 4.27m, 4.0225m, null, null, 29.75m, 1, null, 84879m, 66 },
                    { 245, 4.275m, 4.27m, null, null, 26.42m, 3, null, 64327.8424m, 68 },
                    { 243, 4.5m, 4.281m, null, null, 18.58m, 1, null, 80926.8656m, 68 },
                    { 242, 3.598m, 3.395m, null, null, 31.383m, 4, null, 47074.99878m, 67 },
                    { 241, 4.25m, 3.598m, null, null, 27m, 3, null, 49109.34244m, 67 },
                    { 240, 4.435m, 4.25m, null, null, 20m, 2, null, 52473.66552m, 67 },
                    { 239, 4.68m, 4.435m, null, null, 20m, 1, null, 70751.6173m, 67 },
                    { 238, 3.598m, 3.395m, null, null, 32.25m, 3, null, 48381.3m, 66 },
                    { 244, 4.281m, 4.275m, null, null, 24.18m, 2, null, 76535.21842m, 68 },
                    { 218, 4.422m, 4.4185m, null, null, 21.1m, 3, null, 49666.6m, 62 },
                    { 86, 4.8m, 4.5m, null, null, 30.24m, 3, null, 79213.5242m, 25 },
                    { 216, 4.678m, 4.43m, null, null, 16.26m, 1, null, 67400.6562m, 62 },
                    { 100, 4.5m, 4.4m, null, null, 23.8m, 3, null, 89933.23436m, 28 },
                    { 99, 4.5m, 4.5m, null, null, 19.04m, 2, null, 90738.24186m, 28 },
                    { 98, 4.5m, 4.5m, null, null, 13.18m, 1, null, 89293.03473m, 28 },
                    { 217, 4.43m, 4.422m, null, null, 18.155m, 2, null, 54725.375m, 62 },
                    { 96, 4.493m, 4.3m, null, null, 29.96m, 4, null, 73543.0482m, 27 },
                    { 95, 4.493m, 4.493m, null, null, 23.52m, 3, null, 81159.19328m, 27 },
                    { 94, 4.3005m, 4.493m, null, null, 18.48m, 2, null, 80482.3936m, 27 },
                    { 93, 4.5m, 4.3075m, null, null, 12.91m, 1, null, 79517.06165m, 27 },
                    { 92, 4.418m, 3.503m, null, null, 26.035m, 5, null, 52302.76342m, 26 },
                    { 91, 4.792m, 4.418m, null, null, 26.6m, 4, null, 64534.22405m, 26 },
                    { 90, 4.798m, 4.792m, null, null, 24.36m, 3, null, 75953.01047m, 26 },
                    { 89, 4.8m, 4.798m, null, null, 19.88m, 2, null, 80331.59808m, 26 },
                    { 88, 4.8m, 4.8m, null, null, 14.039m, 1, null, 80500.94002m, 26 },
                    { 87, 4.5m, 3.503m, null, null, 35.85m, 4, null, 74744.20523m, 25 },
                    { 85, 4.8m, 4.8m, null, null, 22.4m, 2, null, 78524.49403m, 25 },
                    { 84, 4.8m, 4.8m, null, null, 16.24m, 1, null, 80488.94645m, 25 },
                    { 83, 4.3m, 3.503m, null, null, 35.85m, 4, null, 72484.84805m, 24 },
                    { 82, 4.3m, 4.3m, null, null, 29.96m, 3, null, 81066.70883m, 24 },
                    { 81, 4.355m, 4.3m, null, null, 20.72m, 2, null, 79695.70112m, 24 },
                    { 101, 4.4m, 4.4m, null, null, 29.96m, 4, null, 79262.15784m, 28 },
                    { 80, 4.3691m, 4.355m, null, null, 13.18m, 1, null, 82880.30389m, 24 },
                    { 102, 4.4m, 3.503m, null, null, 32.21m, 5, null, 65218.85933m, 28 },
                    { 104, 4.4912m, 4.69m, null, null, 20.72m, 2, null, 89339.65084m, 30 },
                    { 123, 4.4265m, 4.422m, null, null, 21.115m, 2, null, 56613.2646m, 38 },
                    { 122, 4.68m, 4.4265m, null, null, 19.245m, 1, null, 72204.09538m, 38 },
                    { 121, 3.9677m, 3.503m, null, null, 25.12m, 4, null, 42060.18971m, 37 },
                    { 120, 4.4933m, 3.9677m, null, null, 25.897m, 3, null, 48339.37474m, 37 },
                    { 119, 4.4987m, 4.4933m, null, null, 24.535m, 2, null, 60834.11439m, 37 },
                    { 118, 4.5m, 4.4987m, null, null, 17.94m, 1, null, 63177.67835m, 37 },
                    { 117, 3.9607m, 3.503m, null, null, 25.08m, 4, null, 42970.7592m, 36 },
                    { 116, 4.494m, 3.9607m, null, null, 25.897m, 3, null, 49500.9413m, 36 },
                    { 115, 4.499m, 4.494m, null, null, 24.465m, 2, null, 61419.53434m, 36 },
                    { 114, 4.488m, 4.499m, null, null, 18.075m, 1, null, 64128.96002m, 36 },
                    { 113, 3.4805m, 3.503m, null, null, 34.5m, 3, null, 57133.5m, 35 },
                    { 112, 4.2235m, 3.4805m, null, null, 29.26m, 2, null, 62966.5m, 35 },
                    { 111, 4.47m, 4.2235m, null, null, 25.073m, 1, null, 78556.7m, 35 },
                    { 110, 3.481m, 3.503m, null, null, 34.5m, 3, null, 58854.62959m, 34 },
                    { 109, 4.224m, 3.481m, null, null, 29.26m, 2, null, 65774.31345m, 34 },
                    { 108, 4.47m, 4.224m, null, null, 25.072m, 1, null, 79335.33756m, 34 },
                    { 107, 4.691m, 3.503m, null, null, 29.97m, 5, null, 63505.11301m, 30 },
                    { 106, 4.691m, 4.691m, null, null, 29.96m, 4, null, 73648.12205m, 30 },
                    { 105, 4.69m, 4.691m, null, null, 26.04m, 3, null, 88386.75044m, 30 },
                    { 103, 4.6999m, 4.4912m, null, null, 13.18m, 1, null, 83703.42767m, 30 },
                    { 124, 4.422m, 4.017m, null, null, 26.29m, 3, null, 53955.87303m, 38 },
                    { 79, 4.493m, 3.503m, null, null, 25.77m, 4, null, 56143.28781m, 23 },
                    { 77, 4.493m, 4.493m, null, null, 22.68m, 2, null, 69556.99301m, 23 },
                    { 53, 4.493m, 3.503m, null, null, 34.45m, 4, null, 75793.06763m, 15 },
                    { 52, 4.493m, 4.493m, null, null, 26.88m, 3, null, 76060.20806m, 15 },
                    { 51, 4.7m, 4.493m, null, null, 21.56m, 2, null, 79745.69923m, 15 },
                    { 50, 4.7m, 4.7m, null, null, 14.3m, 1, null, 84033.49479m, 15 },
                    { 49, 3.617m, 3.395m, null, null, 29.5m, 4, null, 44546.9183m, 14 },
                    { 48, 4.021m, 3.617m, null, null, 26m, 3, null, 48034.30023m, 14 },
                    { 47, 4.199m, 4.021m, null, null, 25.5m, 2, null, 65000.03823m, 14 },
                    { 46, 4.262m, 4.199m, null, null, 18.5m, 1, null, 70160.09637m, 14 },
                    { 45, 3.7155m, 3.395m, null, null, 26.66m, 4, null, 41138.54661m, 13 },
                    { 44, 4.02m, 3.7155m, null, null, 23.62m, 3, null, 43041.61827m, 13 },
                    { 43, 4.0285m, 4.02m, null, null, 25.035m, 2, null, 62142.32845m, 13 },
                    { 42, 4.27m, 4.0285m, null, null, 19.715m, 1, null, 71264.2093m, 13 },
                    { 41, 3.369m, 3.395m, null, null, 29.5m, 3, null, 44269.27435m, 12 },
                    { 40, 4.023m, 3.369m, null, null, 29.5m, 2, null, 55748.72839m, 12 },
                    { 39, 4.25m, 4.023m, null, null, 23m, 1, null, 69271.09199m, 12 },
                    { 38, 3.6174m, 3.503m, null, null, 23.74m, 4, null, 39526.45656m, 11 },
                    { 37, 4.0221m, 3.6174m, null, null, 20.82m, 3, null, 40944.29283m, 11 },
                    { 36, 4.0305m, 4.0221m, null, null, 20.82m, 2, null, 56614.98997m, 11 },
                    { 35, 4.278m, 4.0305m, null, null, 16.62m, 1, null, 64903.80646m, 11 },
                    { 54, 4.5m, 4.2966m, null, null, 8.464m, 1, null, 61269.31384m, 16 },
                    { 78, 4.493m, 4.493m, null, null, 24.08m, 3, null, 54286.49734m, 23 },
                    { 55, 4.2958m, 4.5m, null, null, 14.84m, 2, null, 69796.97648m, 16 },
                    { 57, 4.495m, 4.495m, null, null, 17.64m, 4, null, 53453.98555m, 16 },
                    { 76, 4.7m, 4.493m, null, null, 14.86m, 1, null, 70416.81865m, 23 },
                    { 75, 4.44m, 3.503m, null, null, 29.97m, 8, null, 70760m, 21 },
                    { 74, 5.376m, 4.44m, null, null, 28.84m, 7, null, 83270m, 21 },
                    { 73, 5.975m, 5.376m, null, null, 18.48m, 6, null, 70170m, 21 },
                    { 72, 6.575m, 6.575m, null, null, 18.48m, 5, null, 80910m, 21 },
                    { 71, 6.575m, 6.575m, null, null, 16.24m, 4, null, 82980m, 21 },
                    { 70, 6.575m, 6.575m, null, null, 14.56m, 3, null, 82350m, 21 },
                    { 69, 6.575m, 6.575m, null, null, 13.44m, 2, null, 82320m, 21 },
                    { 68, 6.6m, 6.575m, null, null, 12.32m, 1, null, 83980m, 21 },
                    { 67, 4.45m, 3.503m, null, null, 26.89m, 8, null, 64480m, 20 },
                    { 66, 5.1m, 4.45m, null, null, 18.48m, 7, null, 50400m, 20 },
                    { 65, 5.75m, 5.1m, null, null, 18.48m, 6, null, 62220m, 20 },
                    { 64, 6.4m, 5.75m, null, null, 18.48m, 5, null, 73260m, 20 },
                    { 63, 6.4m, 6.4m, null, null, 18.2m, 4, null, 83910m, 20 },
                    { 62, 6.4m, 6.4m, null, null, 15.68m, 3, null, 83110m, 20 },
                    { 61, 6.4m, 6.4m, null, null, 14m, 2, null, 82480m, 20 },
                    { 60, 6.4m, 6.4m, null, null, 12.32m, 1, null, 83350m, 20 },
                    { 59, 4.1m, 3.503m, null, null, 21.85m, 6, null, 49717.40663m, 16 },
                    { 58, 4.495m, 4.1m, null, null, 21m, 5, null, 48049.17395m, 16 },
                    { 56, 4.5m, 4.495m, null, null, 15.12m, 3, null, 57634.6887m, 16 },
                    { 125, 4.017m, 3.503m, null, null, 28.85m, 4, null, 49483.72412m, 38 },
                    { 97, 4.3m, 3.503m, null, null, 29.97m, 5, null, 60725.34469m, 27 },
                    { 127, 4.4243m, 4.4195m, null, null, 21.09m, 2, null, 53794.85m, 39 },
                    { 192, 4.3m, 4.296m, null, null, 15.77m, 1, null, 54828.26892m, 54 },
                    { 191, 4.017m, 3.503m, null, null, 29.09m, 5, null, 51164.78652m, 53 },
                    { 190, 4.122m, 4.017m, null, null, 26.8m, 4, null, 52699.58362m, 53 },
                    { 189, 4.13m, 4.122m, null, null, 24.095m, 3, null, 65523.30707m, 53 },
                    { 188, 4.137m, 4.13m, null, null, 19.255m, 2, null, 66685.47842m, 53 },
                    { 187, 4.37m, 4.137m, null, null, 16.26m, 1, null, 73532.60208m, 53 },
                    { 186, 4.217m, 3.503m, null, null, 24.41m, 6, null, 43525.62314m, 52 },
                    { 185, 4.22m, 4.217m, null, null, 20.52m, 5, null, 41821.37454m, 52 },
                    { 184, 4.4845m, 4.22m, null, null, 19.83m, 4, null, 49490.79417m, 52 },
                    { 183, 4.4915m, 4.4845m, null, null, 15.165m, 3, null, 50659.15097m, 52 },
                    { 182, 4.4985m, 4.4915m, null, null, 14.805m, 2, null, 61914.27679m, 52 },
                    { 181, 4.5m, 4.4985m, null, null, 10.77m, 1, null, 60904.05083m, 52 },
                    { 180, 4.0185m, 3.503m, null, null, 27m, 5, null, 47416.38408m, 51 },
                    { 179, 4.423m, 4.0185m, null, null, 24.5m, 4, null, 52302.8453m, 51 },
                    { 178, 4.7265m, 4.423m, null, null, 20.39m, 3, null, 56451.07113m, 51 },
                    { 177, 5.03m, 4.7265m, null, null, 17.47m, 2, null, 60646.93779m, 51 },
                    { 176, 5.275m, 5.03m, null, null, 16.14m, 1, null, 70308.64683m, 51 },
                    { 175, 4.417m, 3.503m, null, null, 27m, 5, null, 49413.11914m, 50 },
                    { 174, 4.4215m, 4.417m, null, null, 27m, 4, null, 57571.48979m, 50 },
                    { 193, 4.296m, 4.287m, null, null, 28.82m, 2, null, 71675.36935m, 54 },
                    { 173, 4.429m, 4.4215m, null, null, 19.995m, 3, null, 57496.57436m, 50 },
                    { 194, 4.287m, 3.503m, null, null, 32.42m, 3, null, 59248.25671m, 54 },
                    { 196, 3.918m, 3.503m, null, null, 27m, 2, null, 45195.8603m, 55 },
                    { 215, 3.599m, 3.395m, null, null, 35m, 3, null, 54381.29081m, 61 },
                    { 214, 4.2425m, 3.599m, null, null, 26.88m, 2, null, 53858.94948m, 61 },
                    { 213, 4.49m, 4.2425m, null, null, 20.12m, 1, null, 59540.33194m, 61 },
                    { 212, 3.3665m, 3.395m, null, null, 29.5m, 3, null, 43501.53589m, 60 },
                    { 211, 4.02m, 3.3665m, null, null, 29.4m, 2, null, 51510.28599m, 60 },
                    { 210, 4.25m, 4.02m, null, null, 23.1m, 1, null, 61411.14495m, 60 },
                    { 209, 4.015m, 3.503m, null, null, 23.74m, 5, null, 40953.09284m, 59 },
                    { 208, 4.4205m, 4.015m, null, null, 22.78m, 4, null, 45698.19196m, 59 },
                    { 207, 4.427m, 4.4205m, null, null, 20.82m, 3, null, 56712.35986m, 59 },
                    { 206, 4.645m, 4.427m, null, null, 20.54m, 2, null, 71489.07045m, 59 },
                    { 205, 4.678m, 4.645m, null, null, 16.62m, 1, null, 77484.48261m, 59 },
                    { 204, 3.6174m, 3.503m, null, null, 23.74m, 4, null, 39427.1m, 57 },
                    { 203, 4.0215m, 3.6174m, null, null, 20.82m, 3, null, 39652.4m, 57 },
                    { 202, 4.0302m, 4.0215m, null, null, 20.82m, 2, null, 54284.1m, 57 },
                    { 201, 4.278m, 4.0302m, null, null, 16.62m, 1, null, 64077.2m, 57 },
                    { 200, 3.617m, 3.503m, null, null, 23.74m, 4, null, 41590.64545m, 56 },
                    { 126, 4.68m, 4.4243m, null, null, 19.22m, 1, null, 66305.38244m, 39 },
                    { 198, 4.032m, 4.023m, null, null, 20.82m, 2, null, 59192.00487m, 56 },
                    { 197, 4.278m, 4.032m, null, null, 16.62m, 1, null, 68538.15272m, 56 },
                    { 195, 4.424m, 3.918m, null, null, 27m, 1, null, 58359.71859m, 55 },
                    { 172, 4.4365m, 4.429m, null, null, 18.18m, 2, null, 69609.4845m, 50 },
                    { 199, 4.023m, 3.617m, null, null, 20.82m, 3, null, 42107.85517m, 56 },
                    { 170, 4.017m, 3.503m, null, null, 28.85m, 4, null, 50785.57918m, 49 },
                    { 146, 4.4735m, 4.0915m, null, null, 22.205m, 5, null, 56851.21807m, 42 },
                    { 145, 4.48m, 4.4735m, null, null, 18.55m, 4, null, 58358.59391m, 42 },
                    { 144, 4.491m, 4.48m, null, null, 15.095m, 3, null, 59554.11701m, 42 },
                    { 143, 4.494m, 4.491m, null, null, 11.845m, 2, null, 60849.19624m, 42 },
                    { 142, 4.5m, 4.494m, null, null, 10.005m, 1, null, 64431.91099m, 42 },
                    { 141, 3.819m, 3.503m, null, null, 27m, 6, null, 47561.01111m, 41 },
                    { 140, 4.1235m, 3.819m, null, null, 24.44m, 5, null, 53089.93662m, 41 },
                    { 139, 4.4255m, 4.1235m, null, null, 22.98m, 4, null, 62727.63006m, 41 },
                    { 138, 4.43m, 4.4255m, null, null, 19.97m, 3, null, 65240.65623m, 41 },
                    { 137, 4.586m, 4.43m, null, null, 17.595m, 2, null, 69161.63496m, 41 },
                    { 136, 4.68m, 4.586m, null, null, 13.515m, 1, null, 74860.92633m, 41 },
                    { 135, 3.819m, 3.503m, null, null, 27m, 6, null, 47561.01111m, 40 },
                    { 134, 4.125m, 3.819m, null, null, 24.44m, 5, null, 53371.02196m, 40 },
                    { 133, 4.429m, 4.125m, null, null, 22.98m, 4, null, 66182.01807m, 40 },
                    { 132, 4.4325m, 4.429m, null, null, 19.975m, 3, null, 70675.24599m, 40 },
                    { 131, 4.605m, 4.4325m, null, null, 17.595m, 2, null, 75005.04416m, 40 },
                    { 130, 4.68m, 4.605m, null, null, 13.51m, 1, null, 78578.24817m, 40 },
                    { 129, 4.0159m, 3.503m, null, null, 28.9m, 4, null, 47361.9m, 39 },
                    { 128, 4.4195m, 4.0159m, null, null, 26.29m, 3, null, 51346.75m, 39 },
                    { 148, 3.8175m, 3.503m, null, null, 23m, 7, null, 38853.98782m, 42 },
                    { 149, 4.78m, 4.732m, null, null, 17m, 1, null, 78186.1698m, 43 },
                    { 147, 4.0915m, 3.8175m, null, null, 24.8m, 6, null, 49843.74797m, 42 },
                    { 151, 4.725m, 4.422m, null, null, 25.995m, 3, null, 70815.575m, 43 },
                    { 169, 4.42m, 4.017m, null, null, 26.29m, 3, null, 50124.89976m, 49 },
                    { 168, 4.424m, 4.42m, null, null, 21.115m, 2, null, 53232.97105m, 49 },
                    { 167, 4.67m, 4.424m, null, null, 19.245m, 1, null, 66396.13345m, 49 },
                    { 166, 3.8167m, 3.503m, null, null, 23m, 7, null, 37803.13065m, 45 },
                    { 165, 4.09m, 3.8167m, null, null, 24.845m, 6, null, 46081.92967m, 45 },
                    { 171, 4.678m, 4.4365m, null, null, 13.325m, 1, null, 70694.81269m, 50 },
                    { 164, 4.4728m, 4.09m, null, null, 22.205m, 5, null, 53404.64679m, 45 },
                    { 150, 4.732m, 4.725m, null, null, 22.505m, 2, null, 76918.725m, 43 },
                    { 162, 4.486m, 4.477m, null, null, 15.095m, 3, null, 55293.63163m, 45 },
                    { 161, 4.485m, 4.486m, null, null, 11.785m, 2, null, 52478.72825m, 45 },
                    { 163, 4.477m, 4.4728m, null, null, 18.568m, 4, null, 55508.35701m, 45 },
                    { 159, 3.9167m, 3.503m, null, null, 27m, 6, null, 44796.22285m, 44 },
                    { 158, 4.2698m, 3.9167m, null, null, 24.4353m, 5, null, 47252.24584m, 44 },
                    { 157, 4.4838m, 4.2698m, null, null, 22.98m, 4, null, 57992.59446m, 44 },
                    { 156, 4.49m, 4.4838m, null, null, 19.955m, 3, null, 63115.49312m, 44 },
                    { 155, 4.655m, 4.49m, null, null, 17.62m, 2, null, 65570.8144m, 44 },
                    { 154, 4.68m, 4.655m, null, null, 13.51m, 1, null, 68164.20629m, 44 },
                    { 153, 3.917m, 3.503m, null, null, 30m, 5, null, 49962.7m, 43 },
                    { 152, 4.422m, 3.917m, null, null, 30m, 4, null, 63615.5m, 43 },
                    { 160, 4.5m, 4.485m, null, null, 10.005m, 1, null, 57739.07487m, 45 }
                });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.36", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 97m, "T97.31", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 101.5m, "T101.5.31", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 100m, "T100-51A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 101.5m, "T101.5-50A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 115m, "T115-51A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 115m, "T115-52A-WTC", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 135m, "T135-51A-WTC", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 145m, "T145-50A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 155m, "T155-50A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 165m, "T165-51A-MB", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 90m, "T90-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 102.5m, "T102.5-51A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 107.5m, "T107.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 113.5m, "T113.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 117.5m, "T117.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 120.5m, "T120.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 122.5m, "T122.5-51A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 122.5m, "T122.5-52A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 122.5m, "T122.5-53A-WTC", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 165m, "T165-50A-MB", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 90m, "T90.40", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 91m, "T91.40", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 91m, "T91.41", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 95.5m, "T95.5.40", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 95.5m, "T95.5.41", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 97.5m, "T97.5.40", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 97.5m, "T97.5.41", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.40", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.41", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.43", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.44", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.45", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.46", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 86m, "T86.40L1" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 90m, "T90.40L1" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 90m, "T90.40L2" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 97.5m, "T97.5.40L2" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 107.5m, "T107.5.40" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 107.5m, "T107.5.41" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 107.5m, "T107.5.42" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 117.5m, "T117.5.40L1" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 144m, "T144.41-MB" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 165m, "T165.40" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.40", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.43", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 79m, "T79.40", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 106.5m, "T106.5.40", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.39", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.310", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 108m, "T108.30", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 114m, "T114.30", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 134m, "T134.30", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.38", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 94m, "T94.31", 5 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 100.5m, "T100.5.31", 5 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.31", 5 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 102.5m, "T102.5.44", 7 });

            migrationBuilder.CreateIndex(
                name: "ix_tower_types_wtg_catalogue_id",
                table: "tower_types",
                column: "wtg_catalogue_id");

            migrationBuilder.CreateIndex(
                name: "ix_application_modes_wtg_catalogue_id",
                table: "application_modes",
                column: "wtg_catalogue_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_tower_types_wtg_catalogue_id",
                table: "tower_types");

            migrationBuilder.DropIndex(
                name: "ix_application_modes_wtg_catalogue_id",
                table: "application_modes");

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "application_modes",
                keyColumn: "id",
                keyValue: 47);

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

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 10,
                column: "max_tower_base_diameter_mtrs",
                value: 4.7m);

            migrationBuilder.UpdateData(
                table: "generic_market_boundaries",
                keyColumn: "id",
                keyValue: 28,
                column: "max_tower_base_diameter_mtrs",
                value: 4.8m);

            migrationBuilder.UpdateData(
                table: "nacelle_distances",
                keyColumn: "id",
                keyValue: 2,
                column: "distance_bottom_to_center_hub",
                value: 2265.9408m);

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 1 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 3 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.5m, "1", 4 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104.5m, "2", 4 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103m, "3", 4 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "4", 4 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "5", 4 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "6", 4 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 4 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "1", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103.5m, "2", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "3", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "4", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "5", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "6", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "7", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 97m, "8", 8 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "1", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103.5m, "2", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "3", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "4", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "5", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "6", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "noise_mode_no", "tower_type_id" },
                values: new object[] { "7", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 97m, "8", 9 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 104m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 103.5m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 102m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 101m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 100m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 99m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 98m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 97m, 14 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "1", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103.5m, "2", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102m, "3", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101m, "4", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100m, "5", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "6", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "7", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 97m, "8", 13 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 111.6m, "standard", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 108m, "1", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 107.5m, "2", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 106m, "3", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105m, "4", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "5", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102.2m, "6", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.3m, "7", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 100.3m, "8", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 109.3m, "standard", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.7m, "1", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 105.2m, "2", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 103.7m, "3", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 102.7m, "4", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 101.7m, "5", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99.9m, "6", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 99m, "7", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 98m, "8", 21 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 111.6m, "standard", 23 });

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
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 101.7m, 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "noise_level_decibels", "tower_type_id" },
                values: new object[] { 99.9m, 23 });

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 80,
                column: "tower_type_id",
                value: 23);

            migrationBuilder.UpdateData(
                table: "noise_modes",
                keyColumn: "id",
                keyValue: 81,
                column: "tower_type_id",
                value: 23);

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
                columns: new[] { "noise_level_decibels", "noise_mode_no", "tower_type_id" },
                values: new object[] { 104m, "standard", 2 });

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

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 1, "anilananda.chakrabortty@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 2, "purushottam.p@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 1, "siddartha.kopparapu@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 4, "BHARATH.M@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 5, "nagarjuna.n@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 6, "akash.mukhopadhyay@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 7, "achla.singh.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 8, "rakshitha.nithyanand@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 9, "visweswara.dontamsetti.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 10, "shalini.jeyakumar@siemensgam.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 11, "Ramesh.Shanmugam@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 12, "kannan.m.ext@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 13, "siddartha.kopparapu@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 14, "anilananda.chakrabortty@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 15, "akash.mukhopadhyay@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 16, "purushottam.p@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.7m, 4.7m, 13.564m, 84958.3m, 1 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.7m, 4.436m, 84327.8m, 1 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.436m, 4.427m, 23.8m, 84548.3m, 1 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.427m, 4.021m, 26.88m, 71770.5m, 1 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.021m, 3.503m, 29.97m, 63863.1m, 1 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.115m, 4.1065m, 16.18m, 1, 60050.0704076508m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.1065m, 4.1m, 23.3m, 2, 57553.4559157892m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.1m, 4.0167m, 23.52m, 3, 44807.6526008422m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.0167m, 3.503m, 25m, 4, 41491.5666858333m, 6 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.6999m, 4.4912m, 13.18m, 1, 83703.4276702223m, 43 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.4912m, 4.69m, 20.72m, 2, 89339.6508417695m, 43 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.69m, 4.691m, 26.04m, 3, 88386.7504356758m, 43 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.691m, 4.691m, 29.96m, 4, 73648.1220461621m, 43 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.691m, 3.503m, 29.97m, 5, 63505.1130089599m, 43 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.278m, 4.032m, 16.62m, 1, 68538.1527158438m, 69 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.032m, 4.023m, 20.82m, 2, 59192.004867504m, 69 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.023m, 3.617m, 20.82m, 3, 42107.8551723855m, 69 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 3.617m, 3.503m, 23.74m, 4, 41590.645453645m, 69 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T84.32L2", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T84.32L5", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T84.36", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T97.31", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T101.5.30L2", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T101.5.31", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T114.30L2", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T108.30", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T114.30", 4 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T84.32L2", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T84.32L5", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.36", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 97m, "T97.31", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T101.5.30L2", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 101.5m, "T101.5.31", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 0m, "T114.30L2", 6 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 100m, "T100-51A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 101.5m, "T101.5-50A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 115m, "T115-51A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 115m, "T115-52A-WTC", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 135m, "T135-51A-WTC", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 145m, "T145-50A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 155m, "T155-50A", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 165m, "T165-51A-MB", 1 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 90m, "T90-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 102.5m, "T102.5-51A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 107.5m, "T107.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 113.5m, "T113.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 117.5m, "T117.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 120.5m, "T120.5-50A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 122.5m, "T122.5-51A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 122.5m, "T122.5-52A", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 122.5m, "T122.5-53A-WTC", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 165m, "T165-50A-MB", 2 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 90m, "T90.40" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 91m, "T91.40" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 91m, "T91.41" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 95.5m, "T95.5.40" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 95.5m, "T95.5.41" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 97.5m, "T97.5.40" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 97.5m, "T97.5.41" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 127.5m, "T127.5.40" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 127.5m, "T127.5.41" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "hub_height_m", "tower" },
                values: new object[] { 127.5m, "T127.5.43" });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.44", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.45", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 127.5m, "T127.5.46", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 86m, "T86.40L1", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 90m, "T90.40L1", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 90m, "T90.40L2", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 97.5m, "T97.5.40L2", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 107.5m, "T107.5.40", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 107.5m, "T107.5.41", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 107.5m, "T107.5.42", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 117.5m, "T117.5.40L1", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 144m, "T144.41-MB", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 165m, "T165.40", 3 });

            migrationBuilder.UpdateData(
                table: "tower_types",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[] { 84m, "T84.40", 4 });

            migrationBuilder.InsertData(
                table: "tower_types",
                columns: new[] { "id", "hub_height_m", "tower", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 81, 127.5m, "T127.5.31", 5 },
                    { 80, 100.5m, "T100.5.31", 5 },
                    { 79, 94m, "T94.31", 5 },
                    { 78, 84m, "T84.38", 6 },
                    { 77, 134m, "T134.30", 6 },
                    { 76, 114m, "T114.30", 6 },
                    { 75, 108m, "T108.30", 6 },
                    { 74, 84m, "T84.310", 6 },
                    { 73, 84m, "T84.39", 6 },
                    { 72, 106.5m, "T106.5.40", 4 },
                    { 71, 79m, "T79.40", 4 },
                    { 82, 102.5m, "T102.5.44", 7 },
                    { 70, 84m, "T84.43", 4 }
                });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.68m, 4.4297m, 19.465m, 1, 79304.2207846251m, 82 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.4297m, 4.4222m, 24.09m, 2, 70365.0974274015m, 82 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.4222m, 4.0182m, 27.46m, 3, 59567.7112101046m, 82 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.0182m, 3.503m, 29.485m, 4, 52736.5238022118m, 82 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.25m, 4.02m, 23.1m, 1, 61411.1449455023m, 73 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.02m, 3.3665m, 29.4m, 2, 51510.2859937298m, 73 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 3.3665m, 3.395m, 29.5m, 3, 43501.5358851085m, 73 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.27m, 4.0225m, 29.75m, 1, 84879m, 79 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.0225m, 3.598m, 30m, 2, 58971m, 79 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "section_number", "total_weight_kg", "tower_type_id" },
                values: new object[] { 3.598m, 3.395m, 32.25m, 3, 48381.3m, 79 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.68m, 4.675m, 14.685m, 79873.2065903408m, 77 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.675m, 4.4335m, 18.805m, 75629.5520237498m, 77 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.4335m, 4.131m, 20.33m, 71395.49987894m, 77 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 4.131m, 3.712m, 22.86m, 69970.7862593915m, 77 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 3.712m, 3.3725m, 25.82m, 69651.0650992417m, 77 });

            migrationBuilder.UpdateData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "section_height_m", "total_weight_kg", "tower_type_id" },
                values: new object[] { 3.3725m, 3.395m, 29.5m, 48927.5428520448m, 77 });

            migrationBuilder.CreateIndex(
                name: "ix_tower_types_wtg_catalogue_id_tower",
                table: "tower_types",
                columns: new[] { "wtg_catalogue_id", "tower" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_application_modes_wtg_catalogue_id_application_mode_no_powe",
                table: "application_modes",
                columns: new[] { "wtg_catalogue_id", "application_mode_no", "power_rating" },
                unique: true);
        }
    }
}
