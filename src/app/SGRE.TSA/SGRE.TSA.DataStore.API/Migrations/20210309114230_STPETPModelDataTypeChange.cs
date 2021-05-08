using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class STPETPModelDataTypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_standard_foundation_height",
                table: "base_tower_design_dimensions");

            migrationBuilder.AddColumn<decimal>(
                name: "foundation_height",
                table: "base_tower_design_dimensions",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foundation_height",
                table: "base_tower_design_dimensions");

            migrationBuilder.AddColumn<bool>(
                name: "is_standard_foundation_height",
                table: "base_tower_design_dimensions",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
