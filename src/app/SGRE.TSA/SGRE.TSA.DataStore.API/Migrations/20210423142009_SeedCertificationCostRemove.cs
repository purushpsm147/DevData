using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeedCertificationCostRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "certification_costs",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "Logistic Pre-Sales Road Engineer", "Logistic Pre-Sales Road Engineer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "certification_costs",
                columns: new[] { "id", "certification_id", "cost_kilo", "currency_id", "last_modified_date_time", "record_insert_date_time" },
                values: new object[,]
                {
                    { 1, 1, 20m, 5, null, null },
                    { 19, 4, 0m, 4, null, null },
                    { 18, 4, 0m, 1, null, null },
                    { 17, 4, 0m, 2, null, null },
                    { 16, 4, 0m, 5, null, null },
                    { 15, 3, 438m, 3, null, null },
                    { 14, 3, 6503m, 4, null, null },
                    { 13, 3, 596m, 1, null, null },
                    { 12, 3, 83m, 2, null, null },
                    { 20, 4, 0m, 3, null, null },
                    { 11, 3, 70m, 5, null, null },
                    { 9, 2, 4645m, 4, null, null },
                    { 8, 2, 426m, 1, null, null },
                    { 7, 2, 60m, 2, null, null },
                    { 6, 2, 50m, 5, null, null },
                    { 5, 1, 125m, 3, null, null },
                    { 4, 1, 1858m, 4, null, null },
                    { 3, 1, 170m, 1, null, null },
                    { 2, 1, 24m, 2, null, null },
                    { 10, 2, 313m, 3, null, null }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "Logistic Pre Sales Road Engineer", "Logistic Pre Sales Road Engineer" });
        }
    }
}
