using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class updatedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 12,
                column: "role_name",
                value: "Tower Development Structure");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 13,
                column: "role_name",
                value: "Tower Development Internals / Drawings / BOM");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 14,
                column: "role_name",
                value: "Customs Tower");

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "active_record_indicator", "created_by", "last_modified_date_time", "record_insert_date_time", "role_description", "role_name", "updated_by" },
                values: new object[,]
                {
                    { 15, null, "visweswara.dontamsetti.ext@siemensgamesa.com", null, null, null, "Certification Tower Component Certificate", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 16, null, "visweswara.dontamsetti.ext@siemensgamesa.com", null, null, null, "Certification SSA", "visweswara.dontamsetti.ext@siemensgamesa.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 12,
                column: "role_name",
                value: "Tower Development");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 13,
                column: "role_name",
                value: "Loads and Control Engineering");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 14,
                column: "role_name",
                value: "Certification Engineering");
        }
    }
}
