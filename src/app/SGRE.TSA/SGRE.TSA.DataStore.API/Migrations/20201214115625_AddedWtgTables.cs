using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedWtgTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_wtg_configuation_quotes_quote_id",
                table: "wtg_configuation");

            migrationBuilder.DropForeignKey(
                name: "fk_wtg_configuation_wtg_catalogue_wtg_catalogue_id",
                table: "wtg_configuation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_wtg_configuation",
                table: "wtg_configuation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_wtg_catalogue",
                table: "wtg_catalogue");

            migrationBuilder.RenameTable(
                name: "wtg_configuation",
                newName: "wtg_configuations");

            migrationBuilder.RenameTable(
                name: "wtg_catalogue",
                newName: "wtg_catalogues");

            migrationBuilder.RenameIndex(
                name: "ix_wtg_configuation_wtg_catalogue_id",
                table: "wtg_configuations",
                newName: "ix_wtg_configuations_wtg_catalogue_id");

            migrationBuilder.RenameIndex(
                name: "ix_wtg_configuation_quote_id",
                table: "wtg_configuations",
                newName: "ix_wtg_configuations_quote_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_wtg_configuations",
                table: "wtg_configuations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_wtg_catalogues",
                table: "wtg_catalogues",
                column: "id");

            migrationBuilder.CreateTable(
                name: "sar_studies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: true),
                    record_insert_dtm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    last_update_dtm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sar_studies", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "fk_wtg_configuations_quotes_quote_id",
                table: "wtg_configuations",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_wtg_configuations_wtg_catalogues_wtg_catalogue_id",
                table: "wtg_configuations",
                column: "wtg_catalogue_id",
                principalTable: "wtg_catalogues",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_wtg_configuations_quotes_quote_id",
                table: "wtg_configuations");

            migrationBuilder.DropForeignKey(
                name: "fk_wtg_configuations_wtg_catalogues_wtg_catalogue_id",
                table: "wtg_configuations");

            migrationBuilder.DropTable(
                name: "sar_studies");

            migrationBuilder.DropPrimaryKey(
                name: "pk_wtg_configuations",
                table: "wtg_configuations");

            migrationBuilder.DropPrimaryKey(
                name: "pk_wtg_catalogues",
                table: "wtg_catalogues");

            migrationBuilder.RenameTable(
                name: "wtg_configuations",
                newName: "wtg_configuation");

            migrationBuilder.RenameTable(
                name: "wtg_catalogues",
                newName: "wtg_catalogue");

            migrationBuilder.RenameIndex(
                name: "ix_wtg_configuations_wtg_catalogue_id",
                table: "wtg_configuation",
                newName: "ix_wtg_configuation_wtg_catalogue_id");

            migrationBuilder.RenameIndex(
                name: "ix_wtg_configuations_quote_id",
                table: "wtg_configuation",
                newName: "ix_wtg_configuation_quote_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_wtg_configuation",
                table: "wtg_configuation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_wtg_catalogue",
                table: "wtg_catalogue",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_wtg_configuation_quotes_quote_id",
                table: "wtg_configuation",
                column: "quote_id",
                principalTable: "quotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_wtg_configuation_wtg_catalogue_wtg_catalogue_id",
                table: "wtg_configuation",
                column: "wtg_catalogue_id",
                principalTable: "wtg_catalogue",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
