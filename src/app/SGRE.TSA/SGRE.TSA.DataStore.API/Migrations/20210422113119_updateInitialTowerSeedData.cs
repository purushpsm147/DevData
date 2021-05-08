using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class updateInitialTowerSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_initial_towers_wtg_catalogue_id_tower",
                table: "initial_towers");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "STD", 6 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "STD", 6 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "STD", 6 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "STD", 6 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 5,
                column: "wtg_catalogue_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 6,
                column: "wtg_catalogue_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 7,
                column: "wtg_catalogue_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 8,
                column: "wtg_catalogue_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 9,
                column: "wtg_catalogue_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 10,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 11,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 12,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 13,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 14,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 15,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 16,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.InsertData(
                table: "initial_towers",
                columns: new[] { "id", "hub_height_max_m", "hub_height_min_m", "last_modified_date_time", "model", "record_insert_date_time", "tower", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 21, 91m, 79.5m, null, "MY21", null, "T91.41", 3 },
                    { 30, 165m, 85m, null, "MY21", null, "T102.5.44", 7 },
                    { 29, 120m, 111m, null, "MY21", null, "T114.30", 6 },
                    { 28, 111m, 104.75m, null, "MY21", null, "T108.30", 6 },
                    { 27, 104.75m, 99.25m, null, "MY21", null, "T101.5.31", 6 },
                    { 26, 99.25m, 84m, null, "MY21", null, "T97.31", 6 },
                    { 25, 110m, 77m, null, "MY21", null, "T84.43", 4 },
                    { 24, 165m, 115m, null, "MY21", null, "T127.5.45", 3 },
                    { 23, 115m, 91m, null, "MY21", null, "T102.5.43", 3 },
                    { 22, 115m, 91m, null, "MY21", null, "T102.5.42", 3 }
                });

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 1,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 3,
                column: "model",
                value: "STD_MKII");

            migrationBuilder.CreateIndex(
                name: "ix_initial_towers_wtg_catalogue_id_tower_model",
                table: "initial_towers",
                columns: new[] { "wtg_catalogue_id", "tower", "model" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_initial_towers_wtg_catalogue_id_tower_model",
                table: "initial_towers");

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "MY19", 5 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "MY19", 5 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "MY19", 5 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "model", "wtg_catalogue_id" },
                values: new object[] { "MY19", 5 });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 5,
                column: "wtg_catalogue_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 6,
                column: "wtg_catalogue_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 7,
                column: "wtg_catalogue_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 8,
                column: "wtg_catalogue_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 9,
                column: "wtg_catalogue_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 10,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 11,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 12,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 13,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 14,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 15,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 16,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 1,
                column: "model",
                value: "MKII");

            migrationBuilder.UpdateData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 3,
                column: "model",
                value: "MKII");

            migrationBuilder.CreateIndex(
                name: "ix_initial_towers_wtg_catalogue_id_tower",
                table: "initial_towers",
                columns: new[] { "wtg_catalogue_id", "tower" },
                unique: true);
        }
    }
}
