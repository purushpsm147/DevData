using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class PresetRolesNorthAmericaElizabetMichaelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs");

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 26,
                column: "user_name",
                value: "Elizabet.Zaharieva@siemensgamesa.com");

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 39,
                column: "user_name",
                value: "Michael.Wilt@siemensgamesa.com");

            migrationBuilder.CreateIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs",
                column: "certification_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs");

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 26,
                column: "user_name",
                value: "elizabet.zaharieva@siemensgamesa.com");

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 39,
                column: "user_name",
                value: "charles.keyser@siemensgamesa.com");

            migrationBuilder.CreateIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs",
                column: "certification_id",
                unique: true);
        }
    }
}
