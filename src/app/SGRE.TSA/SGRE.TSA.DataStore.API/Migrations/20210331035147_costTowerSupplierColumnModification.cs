using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class costTowerSupplierColumnModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "costs_tower_supplier_meta",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "signature",
                table: "costs_tower_supplier_line_item",
                type: "text",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "offer",
                table: "costs_tower_supplier_line_item",
                type: "text",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "nomination",
                table: "costs_tower_supplier_line_item",
                type: "text",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "signature",
                table: "costs_tower_supplier_line_item",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "offer",
                table: "costs_tower_supplier_line_item",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "nomination",
                table: "costs_tower_supplier_line_item",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "costs_tower_supplier_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[,]
                {
                    { 7, null, "Capacity", null, "bool", null, 2 },
                    { 8, null, "Capability", null, "bool", null, 2 },
                    { 9, null, "Approval", null, "bool", null, 2 }
                });
        }
    }
}
