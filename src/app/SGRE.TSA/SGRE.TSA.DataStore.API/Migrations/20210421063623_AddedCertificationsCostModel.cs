using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedCertificationsCostModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "certification_costs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    currency_id = table.Column<int>(type: "integer", nullable: false),
                    certification_id = table.Column<int>(type: "integer", nullable: false),
                    cost_kilo = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_certification_costs", x => x.id);
                    table.ForeignKey(
                        name: "fk_certification_costs_certifications_certification_id",
                        column: x => x.certification_id,
                        principalTable: "certifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_certification_costs_currencies_currency_id",
                        column: x => x.currency_id,
                        principalTable: "currencies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "certification_costs",
                columns: new[] { "id", "certification_id", "cost_kilo", "currency_id", "last_modified_date_time", "record_insert_date_time" },
                values: new object[,]
                {
                    { 1, 1, 20m, 5, null, null },
                    { 2, 1, 24m, 2, null, null },
                    { 3, 1, 170m, 1, null, null },
                    { 4, 1, 1858m, 4, null, null },
                    { 5, 1, 125m, 3, null, null },
                    { 6, 2, 50m, 5, null, null },
                    { 7, 2, 60m, 2, null, null },
                    { 8, 2, 426m, 1, null, null },
                    { 9, 2, 4645m, 4, null, null },
                    { 10, 2, 313m, 3, null, null },
                    { 11, 3, 70m, 5, null, null },
                    { 12, 3, 83m, 2, null, null },
                    { 13, 3, 596m, 1, null, null },
                    { 14, 3, 6503m, 4, null, null },
                    { 15, 3, 438m, 3, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "ix_certification_costs_certification_id",
                table: "certification_costs",
                column: "certification_id");

            migrationBuilder.CreateIndex(
                name: "ix_certification_costs_currency_id",
                table: "certification_costs",
                column: "currency_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "certification_costs");
        }
    }
}
