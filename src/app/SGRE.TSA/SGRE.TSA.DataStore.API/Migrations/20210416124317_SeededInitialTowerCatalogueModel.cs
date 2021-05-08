using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeededInitialTowerCatalogueModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 17,
                column: "model",
                value: "STD");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 18,
                column: "model",
                value: "STD");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 19,
                column: "model",
                value: "STD");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 20,
                column: "model",
                value: "STD");

            migrationBuilder.InsertData(
                table: "wtg_catalogue_models",
                columns: new[] { "id", "last_modified_date_time", "model", "record_insert_date_time", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 11, null, "STD", null, 1 },
                    { 12, null, "STD", null, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "wtg_catalogue_models",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 17,
                column: "model",
                value: "");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 18,
                column: "model",
                value: "");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 19,
                column: "model",
                value: "");

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 20,
                column: "model",
                value: "");
        }
    }
}
