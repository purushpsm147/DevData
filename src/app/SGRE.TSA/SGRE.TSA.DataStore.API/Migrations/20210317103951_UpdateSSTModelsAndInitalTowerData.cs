using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdateSSTModelsAndInitalTowerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tower_load_result_trigger",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "binding_offer_trigger",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropColumn(
                name: "nomination_gross_trigger",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.DropColumn(
                name: "signature_net_trigger",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.RenameColumn(
                name: "tower_load_result",
                table: "sst_tower",
                newName: "max_shear");

            migrationBuilder.RenameColumn(
                name: "rna_loads",
                table: "sst_tower",
                newName: "loadset_hub_height");

            migrationBuilder.AddColumn<decimal>(
                name: "average_shear",
                table: "sst_tower",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 92.75m, 84m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 92.75m, 84m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 107.75m, 92.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 120m, 107.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 90.5m, 84m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 99.25m, 90.5m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 104.75m, 99.25m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 111m, 104.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 120m, 111m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 84.75m, 79.5m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 96.25m, 84.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 115m, 96.25m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 115m, 96.25m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 142.5m, 115m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 165m, 142.5m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 110m, 77m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 112.25m, 90m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 135m, 112.25m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 125m, 100m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 155m, 125m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "average_shear",
                table: "sst_tower");

            migrationBuilder.RenameColumn(
                name: "max_shear",
                table: "sst_tower",
                newName: "tower_load_result");

            migrationBuilder.RenameColumn(
                name: "loadset_hub_height",
                table: "sst_tower",
                newName: "rna_loads");

            migrationBuilder.AddColumn<bool>(
                name: "tower_load_result_trigger",
                table: "sst_tower",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "binding_offer_trigger",
                table: "sst_predesign_proposed_hub_heights",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "nomination_gross_trigger",
                table: "sst_predesign_proposed_hub_heights",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "signature_net_trigger",
                table: "sst_predesign_proposed_hub_heights",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 84m, 92.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 84m, 92.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 92.75m, 107.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 107.75m, 120m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 84m, 90.5m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 90.5m, 99.25m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 99.25m, 104.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 104.75m, 111m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 111m, 120m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 79.5m, 84.75m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 84.75m, 96.25m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 96.25m, 115m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 96.25m, 115m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 115m, 142.5m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 142.5m, 165m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 77m, 110m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 90m, 112.25m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 112.25m, 135m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 100m, 125m });

            migrationBuilder.UpdateData(
                table: "initial_towers",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "hub_height_max_m", "hub_height_min_m" },
                values: new object[] { 125m, 155m });
        }
    }
}
