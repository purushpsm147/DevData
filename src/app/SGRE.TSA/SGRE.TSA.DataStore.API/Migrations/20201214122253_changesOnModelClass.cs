using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class changesOnModelClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wtg_configuations");

            migrationBuilder.CreateTable(
                name: "wtg_configurations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    quote_id = table.Column<int>(type: "integer", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    windfarm_size_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    quantity_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    windfarm_size = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_wtg_configurations", x => x.id);
                    table.ForeignKey(
                        name: "fk_wtg_configurations_quotes_quote_id",
                        column: x => x.quote_id,
                        principalTable: "quotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_wtg_configurations_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_wtg_configurations_quote_id",
                table: "wtg_configurations",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_wtg_configurations_wtg_catalogue_id",
                table: "wtg_configurations",
                column: "wtg_catalogue_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wtg_configurations");

            migrationBuilder.CreateTable(
                name: "wtg_configuations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    quantity_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    quote_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    windfarm_size = table.Column<int>(type: "integer", nullable: false),
                    windfarm_size_trigger = table.Column<bool>(type: "boolean", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_wtg_configuations", x => x.id);
                    table.ForeignKey(
                        name: "fk_wtg_configuations_quotes_quote_id",
                        column: x => x.quote_id,
                        principalTable: "quotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_wtg_configuations_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_wtg_configuations_quote_id",
                table: "wtg_configuations",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_wtg_configuations_wtg_catalogue_id",
                table: "wtg_configuations",
                column: "wtg_catalogue_id");
        }
    }
}
