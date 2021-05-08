using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class renamebaseTowerDesignDimension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_base_tower_design_dimensions_base_tower_base_tower_id",
                table: "base_tower_design_dimensions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_base_tower_design_dimensions",
                table: "base_tower_design_dimensions");

            migrationBuilder.RenameTable(
                name: "base_tower_design_dimensions",
                newName: "base_tower_design_dimension");

            migrationBuilder.RenameIndex(
                name: "ix_base_tower_design_dimensions_base_tower_id",
                table: "base_tower_design_dimension",
                newName: "ix_base_tower_design_dimension_base_tower_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_base_tower_design_dimension",
                table: "base_tower_design_dimension",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_base_tower_design_dimension_base_tower_base_tower_id",
                table: "base_tower_design_dimension",
                column: "base_tower_id",
                principalTable: "base_tower",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_base_tower_design_dimension_base_tower_base_tower_id",
                table: "base_tower_design_dimension");

            migrationBuilder.DropPrimaryKey(
                name: "pk_base_tower_design_dimension",
                table: "base_tower_design_dimension");

            migrationBuilder.RenameTable(
                name: "base_tower_design_dimension",
                newName: "base_tower_design_dimensions");

            migrationBuilder.RenameIndex(
                name: "ix_base_tower_design_dimension_base_tower_id",
                table: "base_tower_design_dimensions",
                newName: "ix_base_tower_design_dimensions_base_tower_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_base_tower_design_dimensions",
                table: "base_tower_design_dimensions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_base_tower_design_dimensions_base_tower_base_tower_id",
                table: "base_tower_design_dimensions",
                column: "base_tower_id",
                principalTable: "base_tower",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
