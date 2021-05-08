using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdateBaseTowerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "features_doc_link",
                table: "base_tower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "noise_mode_doc_link",
                table: "base_tower",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "features_doc_link",
                table: "base_tower");

            migrationBuilder.DropColumn(
                name: "noise_mode_doc_link",
                table: "base_tower");
        }
    }
}
