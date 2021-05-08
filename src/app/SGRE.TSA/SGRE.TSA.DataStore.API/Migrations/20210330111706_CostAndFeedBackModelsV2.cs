using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class CostAndFeedBackModelsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_customs_supplier_costs_tower_customs_costs_towe",
                table: "costs_tower_customs_supplier");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_ex_works_line_item_costs_tower_ex_works_costs_t",
                table: "costs_tower_ex_works_line_item");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_supplier_costs_tower_logistics_costs_",
                table: "costs_tower_logistics_supplier");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_costs_t",
                table: "costs_tower_supplier_line_item");

            migrationBuilder.RenameColumn(
                name: "lead_times_signature",
                table: "costs_tower_construction",
                newName: "lead_times_signature_wtg");

            migrationBuilder.RenameColumn(
                name: "lead_times_offer",
                table: "costs_tower_construction",
                newName: "lead_times_offer_wtg");

            migrationBuilder.RenameColumn(
                name: "lead_times_nomination",
                table: "costs_tower_construction",
                newName: "lead_times_nomination_wtg");

            migrationBuilder.RenameColumn(
                name: "tower_component_certificate_windfarm_signature",
                table: "costs_technology",
                newName: "tower_component_certificate_windfarm_cluster_signature");

            migrationBuilder.RenameColumn(
                name: "tower_component_certificate_windfarm_offer",
                table: "costs_technology",
                newName: "tower_component_certificate_windfarm_cluster_offer");

            migrationBuilder.RenameColumn(
                name: "tower_component_certificate_windfarm_nomination",
                table: "costs_technology",
                newName: "tower_component_certificate_windfarm_cluster_nomination");

            migrationBuilder.CreateTable(
                name: "costs_tower_logistics_line_item",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    costs_tower_logistics_meta_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_logistics_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<decimal>(type: "numeric", nullable: false),
                    offer = table.Column<decimal>(type: "numeric", nullable: false),
                    signature = table.Column<decimal>(type: "numeric", nullable: false),
                    costs_tower_logistics_supplier_id = table.Column<int>(type: "integer", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_logistics_line_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_costs",
                        column: x => x.costs_tower_logistics_id,
                        principalTable: "costs_tower_logistics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_meta_",
                        column: x => x.costs_tower_logistics_meta_id,
                        principalTable: "costs_tower_logistics_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_line_item_costs_tower_logistics_suppl",
                        column: x => x.costs_tower_logistics_supplier_id,
                        principalTable: "costs_tower_logistics_supplier",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_line_item_costs_tower_logistics_id",
                table: "costs_tower_logistics_line_item",
                column: "costs_tower_logistics_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_line_item_costs_tower_logistics_meta_",
                table: "costs_tower_logistics_line_item",
                column: "costs_tower_logistics_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_line_item_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_line_item",
                column: "costs_tower_logistics_supplier_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_customs_supplier_costs_tower_customs_costs_tower",
                table: "costs_tower_customs_supplier",
                column: "costs_tower_customs_id",
                principalTable: "costs_tower_customs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_ex_works_line_item_costs_tower_ex_works_costs_to",
                table: "costs_tower_ex_works_line_item",
                column: "costs_tower_ex_works_id",
                principalTable: "costs_tower_ex_works",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_supplier_costs_tower_logistics_costs_t",
                table: "costs_tower_logistics_supplier",
                column: "costs_tower_logistics_id",
                principalTable: "costs_tower_logistics",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_costs_to",
                table: "costs_tower_supplier_line_item",
                column: "costs_tower_supplier_id",
                principalTable: "costs_tower_supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_customs_supplier_costs_tower_customs_costs_tower",
                table: "costs_tower_customs_supplier");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_ex_works_line_item_costs_tower_ex_works_costs_to",
                table: "costs_tower_ex_works_line_item");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_supplier_costs_tower_logistics_costs_t",
                table: "costs_tower_logistics_supplier");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_costs_to",
                table: "costs_tower_supplier_line_item");

            migrationBuilder.DropTable(
                name: "costs_tower_logistics_line_item");

            migrationBuilder.RenameColumn(
                name: "lead_times_signature_wtg",
                table: "costs_tower_construction",
                newName: "lead_times_signature");

            migrationBuilder.RenameColumn(
                name: "lead_times_offer_wtg",
                table: "costs_tower_construction",
                newName: "lead_times_offer");

            migrationBuilder.RenameColumn(
                name: "lead_times_nomination_wtg",
                table: "costs_tower_construction",
                newName: "lead_times_nomination");

            migrationBuilder.RenameColumn(
                name: "tower_component_certificate_windfarm_cluster_signature",
                table: "costs_technology",
                newName: "tower_component_certificate_windfarm_signature");

            migrationBuilder.RenameColumn(
                name: "tower_component_certificate_windfarm_cluster_offer",
                table: "costs_technology",
                newName: "tower_component_certificate_windfarm_offer");

            migrationBuilder.RenameColumn(
                name: "tower_component_certificate_windfarm_cluster_nomination",
                table: "costs_technology",
                newName: "tower_component_certificate_windfarm_nomination");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_customs_supplier_costs_tower_customs_costs_towe",
                table: "costs_tower_customs_supplier",
                column: "costs_tower_customs_id",
                principalTable: "costs_tower_customs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_ex_works_line_item_costs_tower_ex_works_costs_t",
                table: "costs_tower_ex_works_line_item",
                column: "costs_tower_ex_works_id",
                principalTable: "costs_tower_ex_works",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_supplier_costs_tower_logistics_costs_",
                table: "costs_tower_logistics_supplier",
                column: "costs_tower_logistics_id",
                principalTable: "costs_tower_logistics",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_costs_t",
                table: "costs_tower_supplier_line_item",
                column: "costs_tower_supplier_id",
                principalTable: "costs_tower_supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
