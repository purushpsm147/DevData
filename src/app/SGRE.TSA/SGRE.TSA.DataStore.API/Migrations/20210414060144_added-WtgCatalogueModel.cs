using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedWtgCatalogueModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "wtg_catalogue_model_id",
                table: "sst_tower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "wtg_catalogue_models",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    model = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_wtg_catalogue_models", x => x.id);
                    table.ForeignKey(
                        name: "fk_wtg_catalogue_models_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "wtg_catalogue_models",
                columns: new[] { "id", "last_modified_date_time", "model", "record_insert_date_time", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 1, null, "MKII", null, 3 },
                    { 2, null, "MY21", null, 3 },
                    { 3, null, "MKII", null, 4 },
                    { 4, null, "MY21", null, 4 },
                    { 5, null, "MY21", null, 7 },
                    { 6, null, "MY20", null, 5 },
                    { 7, null, "MY21", null, 5 },
                    { 8, null, "MY19", null, 6 },
                    { 9, null, "MY20", null, 6 },
                    { 10, null, "MY21", null, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_sst_tower_wtg_catalogue_model_id",
                table: "sst_tower",
                column: "wtg_catalogue_model_id");

            migrationBuilder.CreateIndex(
                name: "ix_wtg_catalogue_models_wtg_catalogue_id",
                table: "wtg_catalogue_models",
                column: "wtg_catalogue_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sst_tower_wtg_catalogue_models_wtg_catalogue_model_id",
                table: "sst_tower",
                column: "wtg_catalogue_model_id",
                principalTable: "wtg_catalogue_models",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_tower_wtg_catalogue_models_wtg_catalogue_model_id",
                table: "sst_tower");

            migrationBuilder.DropTable(
                name: "wtg_catalogue_models");

            migrationBuilder.DropIndex(
                name: "ix_sst_tower_wtg_catalogue_model_id",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "wtg_catalogue_model_id",
                table: "sst_tower");
        }
    }
}
