using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedNacelleDistanceForWtgCatalog7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "nacelle_distances",
                columns: new[] { "id", "distance_bottom_to_center_hub", "last_modified_date_time", "record_insert_date_time", "wtg_catalogue_id" },
                values: new object[] { 7, 2086.56m, null, null, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "nacelle_distances",
                keyColumn: "id",
                keyValue: 7);
        }
    }
}
