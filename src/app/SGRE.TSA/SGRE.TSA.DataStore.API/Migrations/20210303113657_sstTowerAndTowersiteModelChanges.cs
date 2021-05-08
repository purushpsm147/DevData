using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class sstTowerAndTowersiteModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "towersite_masses_section");

            migrationBuilder.DropColumn(
                name: "json_payload",
                table: "swat_loads");

            migrationBuilder.RenameColumn(
                name: "towersite_design_output_files_link",
                table: "sst_tower",
                newName: "towersite_design_output_file_link");

            migrationBuilder.AddColumn<int>(
                name: "towersite_design_output_file_size_bytes",
                table: "sst_tower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "towersite_masses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    section_nr = table.Column<int>(type: "integer", nullable: false),
                    length_mm = table.Column<decimal>(type: "numeric", nullable: false),
                    mass_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    lcog_mm = table.Column<decimal>(type: "numeric", nullable: false),
                    ra_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    rb_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_masses", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "towersite_masses");

            migrationBuilder.DropColumn(
                name: "towersite_design_output_file_size_bytes",
                table: "sst_tower");

            migrationBuilder.RenameColumn(
                name: "towersite_design_output_file_link",
                table: "sst_tower",
                newName: "towersite_design_output_files_link");

            migrationBuilder.AddColumn<string[]>(
                name: "json_payload",
                table: "swat_loads",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0]);

            migrationBuilder.CreateTable(
                name: "towersite_masses_section",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    lcog_mm = table.Column<decimal>(type: "numeric", nullable: false),
                    length_mm = table.Column<decimal>(type: "numeric", nullable: false),
                    mass_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    ra_kg = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    section_nr = table.Column<int>(type: "integer", nullable: false),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    tb_kg = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_masses_section", x => x.id);
                });
        }
    }
}
