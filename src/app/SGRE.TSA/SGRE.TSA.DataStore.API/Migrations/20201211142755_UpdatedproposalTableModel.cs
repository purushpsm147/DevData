using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdatedproposalTableModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "proposal_id",
                table: "proposals");

            migrationBuilder.AddColumn<string>(
                name: "sf_offer_status",
                table: "quotes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sf_quotation_name",
                table: "quotes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "proposal_sf_id",
                table: "proposals",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sf_offer_status",
                table: "quotes");

            migrationBuilder.DropColumn(
                name: "sf_quotation_name",
                table: "quotes");

            migrationBuilder.DropColumn(
                name: "proposal_sf_id",
                table: "proposals");

            migrationBuilder.AddColumn<string>(
                name: "proposal_id",
                table: "proposals",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
