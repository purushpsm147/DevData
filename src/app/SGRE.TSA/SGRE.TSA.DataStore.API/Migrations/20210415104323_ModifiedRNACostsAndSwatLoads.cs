using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ModifiedRNACostsAndSwatLoads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cost",
                table: "rna_costs",
                newName: "cost_kilo");

            migrationBuilder.AlterColumn<string>(
                name: "cloe_tower_id",
                table: "swat_loads",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cost_kilo",
                table: "rna_costs",
                newName: "cost");

            migrationBuilder.AlterColumn<string>(
                name: "cloe_tower_id",
                table: "swat_loads",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(64)",
                oldMaxLength: 64);
        }
    }
}
