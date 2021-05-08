using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdateSSTModelAddedAep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "existing_hub_height",
                table: "sst_predesign_proposed_hub_heights");

            migrationBuilder.AlterColumn<decimal>(
                name: "existing_hub_height",
                table: "sst_tower",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<bool>(
                name: "is_propose_hub_height",
                table: "sst_tower",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "proposed_hub_height",
                table: "sst_tower",
                type: "numeric",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "sst_predesign_existing_hub_heights",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_tower_id = table.Column<int>(type: "integer", nullable: false),
                    aep_nomination_gross = table.Column<decimal>(type: "numeric", nullable: true),
                    aep_binding_offer_net = table.Column<decimal>(type: "numeric", nullable: true),
                    aep_signature_net = table.Column<decimal>(type: "numeric", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sst_predesign_existing_hub_heights", x => x.id);
                    table.ForeignKey(
                        name: "fk_sst_predesign_existing_hub_heights_sst_tower_sst_tower_id",
                        column: x => x.sst_tower_id,
                        principalTable: "sst_tower",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_sst_tower_initial_tower_id",
                table: "sst_tower",
                column: "initial_tower_id");

            migrationBuilder.CreateIndex(
                name: "ix_sst_predesign_existing_hub_heights_sst_tower_id",
                table: "sst_predesign_existing_hub_heights",
                column: "sst_tower_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_sst_tower_initial_towers_initial_tower_id",
                table: "sst_tower",
                column: "initial_tower_id",
                principalTable: "initial_towers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.Sql("DROP VIEW If Exists scenario_overview");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sst_tower_initial_towers_initial_tower_id",
                table: "sst_tower");

            migrationBuilder.DropTable(
                name: "sst_predesign_existing_hub_heights");

            migrationBuilder.DropIndex(
                name: "ix_sst_tower_initial_tower_id",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "is_propose_hub_height",
                table: "sst_tower");

            migrationBuilder.DropColumn(
                name: "proposed_hub_height",
                table: "sst_tower");

            migrationBuilder.AlterColumn<decimal>(
                name: "existing_hub_height",
                table: "sst_tower",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "existing_hub_height",
                table: "sst_predesign_proposed_hub_heights",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
