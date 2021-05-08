using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeedDataTowerDesignCostRNACost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs");

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

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 8,
                column: "cost_kilo",
                value: 2523m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 9,
                column: "cost_kilo",
                value: 2403m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 10,
                column: "cost_kilo",
                value: 1622m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 11,
                column: "cost_kilo",
                value: 1689m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 12,
                column: "cost_kilo",
                value: 1822m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 13,
                column: "cost_kilo",
                value: 1435m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 14,
                column: "cost_kilo",
                value: 1369m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 15,
                column: "cost_kilo",
                value: 18041m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 16,
                column: "cost_kilo",
                value: 17182m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 17,
                column: "cost_kilo",
                value: 11599m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 18,
                column: "cost_kilo",
                value: 12076m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 19,
                column: "cost_kilo",
                value: 13029m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 20,
                column: "cost_kilo",
                value: 10263m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 21,
                column: "cost_kilo",
                value: 9787m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 22,
                column: "cost_kilo",
                value: 13250m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 23,
                column: "cost_kilo",
                value: 12619m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 24,
                column: "cost_kilo",
                value: 8519m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 25,
                column: "cost_kilo",
                value: 8869m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 26,
                column: "cost_kilo",
                value: 9569m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 27,
                column: "cost_kilo",
                value: 7538m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 28,
                column: "cost_kilo",
                value: 7188m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 29,
                column: "cost_kilo",
                value: 196948m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 30,
                column: "cost_kilo",
                value: 187565m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 31,
                column: "cost_kilo",
                value: 126623m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 32,
                column: "cost_kilo",
                value: 131825m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 33,
                column: "cost_kilo",
                value: 142230m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 34,
                column: "cost_kilo",
                value: 112037m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 35,
                column: "cost_kilo",
                value: 106835m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 2,
                column: "cost_kilo",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 3,
                column: "cost_kilo",
                value: 213m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 4,
                column: "cost_kilo",
                value: 156m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 5,
                column: "cost_kilo",
                value: 2323m);

            migrationBuilder.CreateIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs",
                column: "certification_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs");

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

            migrationBuilder.InsertData(
                table: "certification_costs",
                columns: new[] { "id", "certification_id", "cost_kilo", "currency_id", "last_modified_date_time", "record_insert_date_time" },
                values: new object[,]
                {
                    { 14, 3, 6503m, 4, null, null },
                    { 1, 1, 20m, 5, null, null },
                    { 3, 1, 170m, 1, null, null },
                    { 4, 1, 1858m, 4, null, null },
                    { 6, 2, 50m, 5, null, null },
                    { 7, 2, 60m, 2, null, null },
                    { 2, 1, 24m, 2, null, null },
                    { 9, 2, 4645m, 4, null, null },
                    { 11, 3, 70m, 5, null, null },
                    { 12, 3, 83m, 2, null, null },
                    { 13, 3, 596m, 1, null, null },
                    { 8, 2, 426m, 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 8,
                column: "cost_kilo",
                value: 2570m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 9,
                column: "cost_kilo",
                value: 2445m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 10,
                column: "cost_kilo",
                value: 1650m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 11,
                column: "cost_kilo",
                value: 1718m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 12,
                column: "cost_kilo",
                value: 1854m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 13,
                column: "cost_kilo",
                value: 1460m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 14,
                column: "cost_kilo",
                value: 1392m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 15,
                column: "cost_kilo",
                value: 16487m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 16,
                column: "cost_kilo",
                value: 15701m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 17,
                column: "cost_kilo",
                value: 10600m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 18,
                column: "cost_kilo",
                value: 11035m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 19,
                column: "cost_kilo",
                value: 11906m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 20,
                column: "cost_kilo",
                value: 9379m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 21,
                column: "cost_kilo",
                value: 8943m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 22,
                column: "cost_kilo",
                value: 13909m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 23,
                column: "cost_kilo",
                value: 13246m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 24,
                column: "cost_kilo",
                value: 8942m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 25,
                column: "cost_kilo",
                value: 9310m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 26,
                column: "cost_kilo",
                value: 10044m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 27,
                column: "cost_kilo",
                value: 7912m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 28,
                column: "cost_kilo",
                value: 7545m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 29,
                column: "cost_kilo",
                value: 183501m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 30,
                column: "cost_kilo",
                value: 174759m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 31,
                column: "cost_kilo",
                value: 117978m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 32,
                column: "cost_kilo",
                value: 122825m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 33,
                column: "cost_kilo",
                value: 132519m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 34,
                column: "cost_kilo",
                value: 104388m);

            migrationBuilder.UpdateData(
                table: "rna_costs",
                keyColumn: "id",
                keyValue: 35,
                column: "cost_kilo",
                value: 99541m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 2,
                column: "cost_kilo",
                value: 29.31m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 3,
                column: "cost_kilo",
                value: 192.44m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 4,
                column: "cost_kilo",
                value: 165.12m);

            migrationBuilder.UpdateData(
                table: "tower_design_costs",
                keyColumn: "id",
                keyValue: 5,
                column: "cost_kilo",
                value: 2147.35m);

            migrationBuilder.CreateIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs",
                column: "certification_id");
        }
    }
}
