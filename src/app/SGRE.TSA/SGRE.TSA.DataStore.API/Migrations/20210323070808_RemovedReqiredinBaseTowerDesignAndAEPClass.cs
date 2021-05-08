using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class RemovedReqiredinBaseTowerDesignAndAEPClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "features_doc_link",
                table: "base_tower");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "features_doc_link",
                table: "base_tower",
                type: "text",
                nullable: true);
        }
    }
}
