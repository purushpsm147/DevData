using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class RemovedQuoteIdUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_quotes_proposal_id",
                table: "quotes");

            migrationBuilder.DropIndex(
                name: "ix_quotes_quotation_id",
                table: "quotes");

            migrationBuilder.CreateIndex(
                name: "ix_quotes_proposal_id_quotation_id",
                table: "quotes",
                columns: new[] { "proposal_id", "quotation_id" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_quotes_proposal_id_quotation_id",
                table: "quotes");

            migrationBuilder.CreateIndex(
                name: "ix_quotes_proposal_id",
                table: "quotes",
                column: "proposal_id");

            migrationBuilder.CreateIndex(
                name: "ix_quotes_quotation_id",
                table: "quotes",
                column: "quotation_id",
                unique: true);
        }
    }
}
