using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdatedQuotesAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quote_submission_date",
                table: "quotes");

            migrationBuilder.RenameColumn(
                name: "quotation_status",
                table: "quotes",
                newName: "quotation_type");

            migrationBuilder.RenameColumn(
                name: "offer_status",
                table: "quotes",
                newName: "quote_status");

            migrationBuilder.AlterColumn<string>(
                name: "offer_type",
                table: "quotes",
                type: "text",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "offer_submission_date",
                table: "quotes",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "role_description",
                value: "Opportunity Owner");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "Logistic Pre Sales Road Engineer", "Logistic Pre Sales Road Engineer" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "PR Pre-Sales Logistic", "PR Pre-Sales Logistic" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "PR Pre-Sales Construction", "PR Pre-Sales Construction" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 16,
                column: "role_name",
                value: "Certification  SSA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "offer_submission_date",
                table: "quotes");

            migrationBuilder.RenameColumn(
                name: "quote_status",
                table: "quotes",
                newName: "offer_status");

            migrationBuilder.RenameColumn(
                name: "quotation_type",
                table: "quotes",
                newName: "quotation_status");

            migrationBuilder.AlterColumn<bool>(
                name: "offer_type",
                table: "quotes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateTime>(
                name: "quote_submission_date",
                table: "quotes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "role_description",
                value: "Opportunity Owner/ Sales Manager");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "Logistic Pre-Sales Road Engineering", "Logistic Pre Sales Road Engineer (regional)" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "PR Pre-Sales(Logistic)", "PR Pre-Sales (Logistic)" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "role_description", "role_name" },
                values: new object[] { "PR Pre-Sales(Construction)", "PR Pre-Sales (general / CNS)" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 16,
                column: "role_name",
                value: "Certification  SSA (part of GE TPM)");
        }
    }
}
