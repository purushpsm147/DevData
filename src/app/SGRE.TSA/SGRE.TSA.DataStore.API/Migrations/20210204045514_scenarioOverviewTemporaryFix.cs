using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class scenarioOverviewTemporaryFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "wtg_configuration_id",
                table: "scenarios",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "load_cluster",
                table: "scenarios",
                type: "character varying(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "wtg_catalogue_id",
                table: "scenarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_wtg_catalogue_id",
                table: "scenarios",
                column: "wtg_catalogue_id");

            migrationBuilder.AddForeignKey(
                name: "fk_scenarios_wtg_catalogues_wtg_catalogue_id",
                table: "scenarios",
                column: "wtg_catalogue_id",
                principalTable: "wtg_catalogues",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_scenarios_wtg_catalogues_wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.DropIndex(
                name: "ix_scenarios_wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "load_cluster",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "wtg_catalogue_id",
                table: "scenarios");

            migrationBuilder.AlterColumn<string>(
                name: "wtg_configuration_id",
                table: "scenarios",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
