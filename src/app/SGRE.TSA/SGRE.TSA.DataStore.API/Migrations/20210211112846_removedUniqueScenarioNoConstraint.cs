using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class removedUniqueScenarioNoConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_scenarios_quotes_quote_id",
                table: "scenarios");

            migrationBuilder.DropForeignKey(
                name: "fk_sst_inputs_quotes_quote_id",
                table: "sst_inputs");

            migrationBuilder.DropIndex(
                name: "ix_scenarios_scenario_no",
                table: "scenarios");

            migrationBuilder.DropColumn(
                name: "quotation_id",
                table: "sst_inputs");

            migrationBuilder.DropColumn(
                name: "quotation_id",
                table: "scenarios");

            migrationBuilder.AlterColumn<int>(
                name: "quote_id",
                table: "sst_inputs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "application_reasons_other_description",
                table: "sst_inputs",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "quote_id",
                table: "scenarios",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_scenarios_quotes_quote_id",
                table: "scenarios",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sst_inputs_quotes_quote_id",
                table: "sst_inputs",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_scenarios_quotes_quote_id",
                table: "scenarios");

            migrationBuilder.DropForeignKey(
                name: "fk_sst_inputs_quotes_quote_id",
                table: "sst_inputs");

            migrationBuilder.DropColumn(
                name: "application_reasons_other_description",
                table: "sst_inputs");

            migrationBuilder.AlterColumn<int>(
                name: "quote_id",
                table: "sst_inputs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "quotation_id",
                table: "sst_inputs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "quote_id",
                table: "scenarios",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "quotation_id",
                table: "scenarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_scenarios_scenario_no",
                table: "scenarios",
                column: "scenario_no",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_scenarios_quotes_quote_id",
                table: "scenarios",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_sst_inputs_quotes_quote_id",
                table: "sst_inputs",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
