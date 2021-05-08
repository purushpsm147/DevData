using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedWtgCatalogandConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wtg_catalogue",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    wtg_type = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    wtg_size_mw = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_wtg_catalogue", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "wtg_configuation",
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
                    table.PrimaryKey("pk_wtg_configuation", x => x.id);
                    table.ForeignKey(
                        name: "fk_wtg_configuation_quotes_quote_id",
                        column: x => x.quote_id,
                        principalTable: "quotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_wtg_configuation_wtg_catalogue_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogue",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "wtg_catalogue",
                columns: new[] { "id", "wtg_size_mw", "wtg_type" },
                values: new object[,]
                {
                    { 1, 6f, "SG 6.0-170" },
                    { 2, 6f, "SG 6.0-155" },
                    { 3, 5f, "SG 5.0-145" },
                    { 4, 5f, "SG 5.0-132" },
                    { 5, 4f, "SG 4.5-145" },
                    { 6, 4f, "SG 4.5-132" },
                    { 7, 3.465f, "SG 3.4-132 CIIA" },
                    { 8, 3.465f, "SG 3.4-132 CIA" },
                    { 9, 3.465f, "SG 3.4-145 CS" },
                    { 10, 2.625f, "SG 2.6-114 CIA" },
                    { 11, 2.625f, "SG 2.6-114 CIIA MY18" },
                    { 12, 2.625f, "SG 2.6-114 CS MY20" },
                    { 13, 2.14f, "SG 2.1-114 CIIA/IIIA MY18" },
                    { 14, 2.2f, "SG 2.2-122" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_wtg_configuation_quote_id",
                table: "wtg_configuation",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_wtg_configuation_wtg_catalogue_id",
                table: "wtg_configuation",
                column: "wtg_catalogue_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wtg_configuation");

            migrationBuilder.DropTable(
                name: "wtg_catalogue");
        }
    }
}
