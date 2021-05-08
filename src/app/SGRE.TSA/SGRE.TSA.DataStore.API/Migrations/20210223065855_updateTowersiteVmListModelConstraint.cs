using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class updateTowersiteVmListModelConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<JsonDocument>(
                name: "payload",
                table: "towersite_vm_list",
                type: "jsonb",
                nullable: true,
                oldClrType: typeof(JsonDocument),
                oldType: "jsonb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<JsonDocument>(
                name: "payload",
                table: "towersite_vm_list",
                type: "jsonb",
                nullable: false,
                oldClrType: typeof(JsonDocument),
                oldType: "jsonb",
                oldNullable: true);
        }
    }
}
