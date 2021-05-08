using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class TowerDesignCostAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tower_design_costs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    currency_id = table.Column<int>(type: "integer", nullable: false),
                    cost_kilo = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tower_design_costs", x => x.id);
                    table.ForeignKey(
                        name: "fk_tower_design_costs_currencies_currency_id",
                        column: x => x.currency_id,
                        principalTable: "currencies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "role_name",
                value: "Opportunity Owner");

            migrationBuilder.InsertData(
                table: "tower_design_costs",
                columns: new[] { "id", "cost_kilo", "currency_id", "last_modified_date_time", "record_insert_date_time" },
                values: new object[,]
                {
                    { 1, 25m, 5, null, null },
                    { 2, 29.31m, 2, null, null },
                    { 3, 192.44m, 1, null, null },
                    { 4, 165.12m, 3, null, null },
                    { 5, 2147.35m, 4, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "ix_tower_design_costs_currency_id",
                table: "tower_design_costs",
                column: "currency_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tower_design_costs");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "role_name",
                value: "Sales Manager");
        }
    }
}
