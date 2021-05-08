using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class interfaceModalUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "wind_shear",
                table: "swat_loads",
                newName: "tower_hub_height_m");

            migrationBuilder.RenameColumn(
                name: "turbine_type",
                table: "swat_loads",
                newName: "turbine_type_smk_variant");

            migrationBuilder.RenameColumn(
                name: "tower_hub_height_standard_scenario",
                table: "swat_loads",
                newName: "pedestal_height_m");

            migrationBuilder.AddColumn<decimal>(
                name: "avg_shear",
                table: "swat_loads",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "loadset_hub_height_m",
                table: "swat_loads",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "max_shear",
                table: "swat_loads",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "turbine_type_loads_config",
                table: "swat_loads",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "turbine_type_smk_main",
                table: "swat_loads",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<JsonDocument>(
                name: "job_payload",
                table: "etl_job_audit",
                type: "jsonb",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "avg_shear",
                table: "swat_loads");

            migrationBuilder.DropColumn(
                name: "loadset_hub_height_m",
                table: "swat_loads");

            migrationBuilder.DropColumn(
                name: "max_shear",
                table: "swat_loads");

            migrationBuilder.DropColumn(
                name: "turbine_type_loads_config",
                table: "swat_loads");

            migrationBuilder.DropColumn(
                name: "turbine_type_smk_main",
                table: "swat_loads");

            migrationBuilder.DropColumn(
                name: "job_payload",
                table: "etl_job_audit");

            migrationBuilder.RenameColumn(
                name: "turbine_type_smk_variant",
                table: "swat_loads",
                newName: "turbine_type");

            migrationBuilder.RenameColumn(
                name: "tower_hub_height_m",
                table: "swat_loads",
                newName: "wind_shear");

            migrationBuilder.RenameColumn(
                name: "pedestal_height_m",
                table: "swat_loads",
                newName: "tower_hub_height_standard_scenario");
        }
    }
}
