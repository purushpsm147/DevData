using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedWtg_threshold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wtg_threshold",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    wind_farm_size = table.Column<int>(type: "integer", nullable: false),
                    turbine_quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_wtg_threshold", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 5,
                column: "mile_stone_name",
                value: "Certification Target Date");

            migrationBuilder.InsertData(
                table: "wtg_threshold",
                columns: new[] { "id", "turbine_quantity", "wind_farm_size" },
                values: new object[] { 1, 20, 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wtg_threshold");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 5,
                column: "mile_stone_name",
                value: "Certification Target");
        }
    }
}
