using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class towersiteReportFieldFixRemovedFieldsNotReqd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "error_message",
                table: "towersite_flanges");

            migrationBuilder.DropColumn(
                name: "is_error",
                table: "towersite_flanges");

            migrationBuilder.DropColumn(
                name: "error_message",
                table: "towersite_flange_pairs");

            migrationBuilder.DropColumn(
                name: "is_error",
                table: "towersite_flange_pairs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "error_message",
                table: "towersite_flanges",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_error",
                table: "towersite_flanges",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "error_message",
                table: "towersite_flange_pairs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_error",
                table: "towersite_flange_pairs",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
