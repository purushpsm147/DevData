using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class added_navigationProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "proposal_status",
                table: "proposals");

            migrationBuilder.AlterColumn<string>(
                name: "active_record_indicator",
                table: "roles",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "proposal_id",
                table: "proposals",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_main",
                table: "proposals",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 4,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 5,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 6,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 7,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 9,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 10,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 11,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 12,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 13,
                column: "active_record_indicator",
                value: null);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 14,
                column: "active_record_indicator",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_main",
                table: "proposals");

            migrationBuilder.AlterColumn<int>(
                name: "active_record_indicator",
                table: "roles",
                type: "integer",
                maxLength: 1,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "character varying(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "proposal_id",
                table: "proposals",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "proposal_status",
                table: "proposals",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 4,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 5,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 6,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 7,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 9,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 10,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 11,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 12,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 13,
                column: "active_record_indicator",
                value: 0);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 14,
                column: "active_record_indicator",
                value: 0);
        }
    }
}
