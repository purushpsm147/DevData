using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedNewFieldsLogisticConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "transport_mode_id",
                table: "logistic_constraints",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "using_project_specific_boundary",
                table: "logistic_constraints",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "ix_logistic_constraints_transport_mode_id",
                table: "logistic_constraints",
                column: "transport_mode_id");

            migrationBuilder.AddForeignKey(
                name: "fk_logistic_constraints_transport_modes_transport_mode_id",
                table: "logistic_constraints",
                column: "transport_mode_id",
                principalTable: "transport_modes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_logistic_constraints_transport_modes_transport_mode_id",
                table: "logistic_constraints");

            migrationBuilder.DropIndex(
                name: "ix_logistic_constraints_transport_mode_id",
                table: "logistic_constraints");

            migrationBuilder.DropColumn(
                name: "transport_mode_id",
                table: "logistic_constraints");

            migrationBuilder.DropColumn(
                name: "using_project_specific_boundary",
                table: "logistic_constraints");
        }
    }
}
