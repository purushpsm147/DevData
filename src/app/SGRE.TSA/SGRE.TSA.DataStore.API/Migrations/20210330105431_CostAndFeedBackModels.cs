using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class CostAndFeedBackModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_technology_cost_over_view_cost_over_view_id",
                table: "costs_technology");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_construction_cost_over_view_cost_over_view_id",
                table: "costs_tower_construction");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_customs_cost_over_view_cost_over_view_id",
                table: "costs_tower_customs");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_customs_costs_tower_customs_meta_costs_tower_cu",
                table: "costs_tower_customs");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_ex_works_cost_over_view_cost_over_view_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_ex_works_costs_tower_ex_works_meta_costs_tower_",
                table: "costs_tower_ex_works");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_cost_over_view_cost_over_view_id",
                table: "costs_tower_logistics");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_costs_tower_logistics_meta_costs_towe",
                table: "costs_tower_logistics");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_lead_time_cost_over_view_cost_over_view",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_cost_over_view_cost_over_view_id",
                table: "costs_tower_supplier");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_costs_tower_supplier_meta_costs_tower_",
                table: "costs_tower_supplier");

            migrationBuilder.DropTable(
                name: "costs_technical_office");

            migrationBuilder.DropTable(
                name: "costs_technology_tower_development_leadtime");

            migrationBuilder.DropTable(
                name: "costs_tower_construction_lead_time");

            migrationBuilder.DropTable(
                name: "cost_over_view");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_supplier_cost_over_view_id",
                table: "costs_tower_supplier");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_logistics_lead_time_cost_over_view_id",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_logistics_cost_over_view_id",
                table: "costs_tower_logistics");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_ex_works_cost_over_view_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_ex_works_costs_tower_ex_works_meta_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_customs_cost_over_view_id",
                table: "costs_tower_customs");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_construction_cost_over_view_id",
                table: "costs_tower_construction");

            migrationBuilder.DropIndex(
                name: "ix_costs_technology_cost_over_view_id",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "cost_over_view_id",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "nomination",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "offer",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "signature",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "cost_over_view_id",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.DropColumn(
                name: "is_phase_complete",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.DropColumn(
                name: "cost_over_view_id",
                table: "costs_tower_logistics");

            migrationBuilder.DropColumn(
                name: "nomination",
                table: "costs_tower_logistics");

            migrationBuilder.DropColumn(
                name: "offer",
                table: "costs_tower_logistics");

            migrationBuilder.DropColumn(
                name: "signature",
                table: "costs_tower_logistics");

            migrationBuilder.DropColumn(
                name: "cost_over_view_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropColumn(
                name: "nomination",
                table: "costs_tower_ex_works");

            migrationBuilder.DropColumn(
                name: "offer",
                table: "costs_tower_ex_works");

            migrationBuilder.DropColumn(
                name: "signature",
                table: "costs_tower_ex_works");

            migrationBuilder.DropColumn(
                name: "cost_over_view_id",
                table: "costs_tower_customs");

            migrationBuilder.DropColumn(
                name: "nomination",
                table: "costs_tower_customs");

            migrationBuilder.DropColumn(
                name: "offer",
                table: "costs_tower_customs");

            migrationBuilder.DropColumn(
                name: "signature",
                table: "costs_tower_customs");

            migrationBuilder.RenameColumn(
                name: "costs_tower_supplier_meta_id",
                table: "costs_tower_supplier",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_supplier_costs_tower_supplier_meta_id",
                table: "costs_tower_supplier",
                newName: "ix_costs_tower_supplier_cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "scenario_progress",
                table: "costs_tower_logistics_lead_time",
                newName: "costs_tower_logistics_suppliers_id");

            migrationBuilder.RenameColumn(
                name: "costs_tower_logistics_meta_id",
                table: "costs_tower_logistics",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_logistics_costs_tower_logistics_meta_id",
                table: "costs_tower_logistics",
                newName: "ix_costs_tower_logistics_cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "costs_tower_ex_works_meta_id",
                table: "costs_tower_ex_works",
                newName: "cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "costs_tower_customs_meta_id",
                table: "costs_tower_customs",
                newName: "cost_feeback_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_customs_costs_tower_customs_meta_id",
                table: "costs_tower_customs",
                newName: "ix_costs_tower_customs_cost_feeback_id");

            migrationBuilder.RenameColumn(
                name: "signature",
                table: "costs_tower_construction",
                newName: "manufacturing_investment_costs_wind_farm");

            migrationBuilder.RenameColumn(
                name: "offer",
                table: "costs_tower_construction",
                newName: "design_cost_wind_farm");

            migrationBuilder.RenameColumn(
                name: "nomination",
                table: "costs_tower_construction",
                newName: "cost_signature");

            migrationBuilder.RenameColumn(
                name: "cost_over_view_id",
                table: "costs_tower_construction",
                newName: "tool_kit_evaluation");

            migrationBuilder.RenameColumn(
                name: "cost_over_view_id",
                table: "costs_technology",
                newName: "scenario_progress");

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "costs_tower_supplier",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_offer_approval",
                table: "costs_tower_supplier",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_offer_capability",
                table: "costs_tower_supplier",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_offer_capacity",
                table: "costs_tower_supplier",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_signature_approval",
                table: "costs_tower_supplier",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_signature_capability",
                table: "costs_tower_supplier",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_signature_capacity",
                table: "costs_tower_supplier",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "tower_planning_comments",
                table: "costs_tower_supplier",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "costs_tower_logistics",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tower_fabrication_comments",
                table: "costs_tower_ex_works",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "costs_tower_customs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "additional_feeback",
                table: "costs_tower_construction",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "additional_timeline_weeks_windfarm",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "costs_tower_construction",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cost_feeback_id",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "cost_nomination",
                table: "costs_tower_construction",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "cost_offer",
                table: "costs_tower_construction",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "lead_times_nomination",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_times_offer",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_times_signature",
                table: "costs_tower_construction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "tool_kit_evaluation_doc_link",
                table: "costs_tower_construction",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cost_feeback_id",
                table: "costs_technology",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "envelop_status",
                table: "costs_technology",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_lead_time_input_request",
                table: "costs_technology",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_phase_complete",
                table: "costs_technology",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "lead_time_tower_nomination",
                table: "costs_technology",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "lead_time_tower_offer",
                table: "costs_technology",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "lead_time_tower_signature",
                table: "costs_technology",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "cost_feed_back",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    scenario_id = table.Column<int>(type: "integer", nullable: false),
                    scenario_type = table.Column<int>(type: "integer", nullable: false),
                    is_cost_feeback_request = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cost_feed_back", x => x.id);
                    table.ForeignKey(
                        name: "fk_cost_feed_back_scenarios_scenario_id",
                        column: x => x.scenario_id,
                        principalTable: "scenarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_customs_supplier",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    costs_tower_customs_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_customs_supplier", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_customs_supplier_costs_tower_customs_costs_towe",
                        column: x => x.costs_tower_customs_id,
                        principalTable: "costs_tower_customs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_ex_works_line_item",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    costs_tower_ex_works_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_ex_works_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<decimal>(type: "numeric", nullable: false),
                    offer = table.Column<decimal>(type: "numeric", nullable: false),
                    signature = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_ex_works_line_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_ex_works_line_item_costs_tower_ex_works_costs_t",
                        column: x => x.costs_tower_ex_works_id,
                        principalTable: "costs_tower_ex_works",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_ex_works_line_item_costs_tower_ex_works_meta_co",
                        column: x => x.costs_tower_ex_works_meta_id,
                        principalTable: "costs_tower_ex_works_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_logistics_supplier",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    costs_tower_logistics_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_logistics_supplier", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_supplier_costs_tower_logistics_costs_",
                        column: x => x.costs_tower_logistics_id,
                        principalTable: "costs_tower_logistics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_supplier_line_item",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    costs_tower_supplier_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_supplier_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<decimal>(type: "numeric", nullable: false),
                    offer = table.Column<decimal>(type: "numeric", nullable: false),
                    signature = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_supplier_line_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_costs_t",
                        column: x => x.costs_tower_supplier_id,
                        principalTable: "costs_tower_supplier",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_meta_co",
                        column: x => x.costs_tower_supplier_meta_id,
                        principalTable: "costs_tower_supplier_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_customs_line_item",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    costs_tower_customs_supplier_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_customs_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<decimal>(type: "numeric", nullable: false),
                    offer = table.Column<decimal>(type: "numeric", nullable: false),
                    signature = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_customs_line_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_customs_line_item_costs_tower_customs_meta_cost",
                        column: x => x.costs_tower_customs_meta_id,
                        principalTable: "costs_tower_customs_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_customs_line_item_costs_tower_customs_supplier_",
                        column: x => x.costs_tower_customs_supplier_id,
                        principalTable: "costs_tower_customs_supplier",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_lead_time_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_lead_time",
                column: "costs_tower_logistics_suppliers_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_ex_works_cost_feeback_id",
                table: "costs_tower_ex_works",
                column: "cost_feeback_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_cost_feeback_id",
                table: "costs_tower_construction",
                column: "cost_feeback_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_costs_technology_cost_feeback_id",
                table: "costs_technology",
                column: "cost_feeback_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_cost_feed_back_scenario_id",
                table: "cost_feed_back",
                column: "scenario_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_customs_line_item_costs_tower_customs_meta_id",
                table: "costs_tower_customs_line_item",
                column: "costs_tower_customs_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_customs_line_item_costs_tower_customs_supplier_",
                table: "costs_tower_customs_line_item",
                column: "costs_tower_customs_supplier_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_customs_supplier_costs_tower_customs_id",
                table: "costs_tower_customs_supplier",
                column: "costs_tower_customs_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_ex_works_line_item_costs_tower_ex_works_id",
                table: "costs_tower_ex_works_line_item",
                column: "costs_tower_ex_works_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_ex_works_line_item_costs_tower_ex_works_meta_id",
                table: "costs_tower_ex_works_line_item",
                column: "costs_tower_ex_works_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_supplier_costs_tower_logistics_id",
                table: "costs_tower_logistics_supplier",
                column: "costs_tower_logistics_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_supplier_line_item_costs_tower_supplier_id",
                table: "costs_tower_supplier_line_item",
                column: "costs_tower_supplier_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_supplier_line_item_costs_tower_supplier_meta_id",
                table: "costs_tower_supplier_line_item",
                column: "costs_tower_supplier_meta_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_technology_cost_feed_back_cost_feeback_id",
                table: "costs_technology",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_construction_cost_feed_back_cost_feeback_id",
                table: "costs_tower_construction",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_customs_cost_feed_back_cost_feeback_id",
                table: "costs_tower_customs",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_ex_works_cost_feed_back_cost_feeback_id",
                table: "costs_tower_ex_works",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_cost_feed_back_cost_feeback_id",
                table: "costs_tower_logistics",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_lead_time_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_lead_time",
                column: "costs_tower_logistics_suppliers_id",
                principalTable: "costs_tower_logistics_supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_cost_feed_back_cost_feeback_id",
                table: "costs_tower_supplier",
                column: "cost_feeback_id",
                principalTable: "cost_feed_back",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_technology_cost_feed_back_cost_feeback_id",
                table: "costs_technology");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_construction_cost_feed_back_cost_feeback_id",
                table: "costs_tower_construction");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_customs_cost_feed_back_cost_feeback_id",
                table: "costs_tower_customs");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_ex_works_cost_feed_back_cost_feeback_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_cost_feed_back_cost_feeback_id",
                table: "costs_tower_logistics");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_logistics_lead_time_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_cost_feed_back_cost_feeback_id",
                table: "costs_tower_supplier");

            migrationBuilder.DropTable(
                name: "cost_feed_back");

            migrationBuilder.DropTable(
                name: "costs_tower_customs_line_item");

            migrationBuilder.DropTable(
                name: "costs_tower_ex_works_line_item");

            migrationBuilder.DropTable(
                name: "costs_tower_logistics_supplier");

            migrationBuilder.DropTable(
                name: "costs_tower_supplier_line_item");

            migrationBuilder.DropTable(
                name: "costs_tower_customs_supplier");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_logistics_lead_time_costs_tower_logistics_suppl",
                table: "costs_tower_logistics_lead_time");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_ex_works_cost_feeback_id",
                table: "costs_tower_ex_works");

            migrationBuilder.DropIndex(
                name: "ix_costs_tower_construction_cost_feeback_id",
                table: "costs_tower_construction");

            migrationBuilder.DropIndex(
                name: "ix_costs_technology_cost_feeback_id",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "is_offer_approval",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "is_offer_capability",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "is_offer_capacity",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "is_signature_approval",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "is_signature_capability",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "is_signature_capacity",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "tower_planning_comments",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "costs_tower_logistics");

            migrationBuilder.DropColumn(
                name: "tower_fabrication_comments",
                table: "costs_tower_ex_works");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "costs_tower_customs");

            migrationBuilder.DropColumn(
                name: "additional_feeback",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "additional_timeline_weeks_windfarm",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "cost_feeback_id",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "cost_nomination",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "cost_offer",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "lead_times_nomination",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "lead_times_offer",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "lead_times_signature",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "tool_kit_evaluation_doc_link",
                table: "costs_tower_construction");

            migrationBuilder.DropColumn(
                name: "cost_feeback_id",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "envelop_status",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "is_lead_time_input_request",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "is_phase_complete",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "lead_time_tower_nomination",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "lead_time_tower_offer",
                table: "costs_technology");

            migrationBuilder.DropColumn(
                name: "lead_time_tower_signature",
                table: "costs_technology");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_supplier",
                newName: "costs_tower_supplier_meta_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_supplier_cost_feeback_id",
                table: "costs_tower_supplier",
                newName: "ix_costs_tower_supplier_costs_tower_supplier_meta_id");

            migrationBuilder.RenameColumn(
                name: "costs_tower_logistics_suppliers_id",
                table: "costs_tower_logistics_lead_time",
                newName: "scenario_progress");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_logistics",
                newName: "costs_tower_logistics_meta_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_logistics_cost_feeback_id",
                table: "costs_tower_logistics",
                newName: "ix_costs_tower_logistics_costs_tower_logistics_meta_id");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_ex_works",
                newName: "costs_tower_ex_works_meta_id");

            migrationBuilder.RenameColumn(
                name: "cost_feeback_id",
                table: "costs_tower_customs",
                newName: "costs_tower_customs_meta_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_customs_cost_feeback_id",
                table: "costs_tower_customs",
                newName: "ix_costs_tower_customs_costs_tower_customs_meta_id");

            migrationBuilder.RenameColumn(
                name: "tool_kit_evaluation",
                table: "costs_tower_construction",
                newName: "cost_over_view_id");

            migrationBuilder.RenameColumn(
                name: "manufacturing_investment_costs_wind_farm",
                table: "costs_tower_construction",
                newName: "signature");

            migrationBuilder.RenameColumn(
                name: "design_cost_wind_farm",
                table: "costs_tower_construction",
                newName: "offer");

            migrationBuilder.RenameColumn(
                name: "cost_signature",
                table: "costs_tower_construction",
                newName: "nomination");

            migrationBuilder.RenameColumn(
                name: "scenario_progress",
                table: "costs_technology",
                newName: "cost_over_view_id");

            migrationBuilder.AddColumn<int>(
                name: "cost_over_view_id",
                table: "costs_tower_supplier",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "nomination",
                table: "costs_tower_supplier",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "offer",
                table: "costs_tower_supplier",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "signature",
                table: "costs_tower_supplier",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "cost_over_view_id",
                table: "costs_tower_logistics_lead_time",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_phase_complete",
                table: "costs_tower_logistics_lead_time",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "cost_over_view_id",
                table: "costs_tower_logistics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "nomination",
                table: "costs_tower_logistics",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "offer",
                table: "costs_tower_logistics",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "signature",
                table: "costs_tower_logistics",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "cost_over_view_id",
                table: "costs_tower_ex_works",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "nomination",
                table: "costs_tower_ex_works",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "offer",
                table: "costs_tower_ex_works",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "signature",
                table: "costs_tower_ex_works",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "cost_over_view_id",
                table: "costs_tower_customs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "nomination",
                table: "costs_tower_customs",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "offer",
                table: "costs_tower_customs",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "signature",
                table: "costs_tower_customs",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "cost_over_view",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    item_id = table.Column<int>(type: "integer", nullable: false),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    nomination = table.Column<decimal>(type: "numeric", nullable: false),
                    offer = table.Column<decimal>(type: "numeric", nullable: false),
                    quote_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    scenario_id = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    scenario_type = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<decimal>(type: "numeric", nullable: false),
                    windfarm_configuration_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cost_over_view", x => x.id);
                    table.ForeignKey(
                        name: "fk_cost_over_view_quotes_quote_id",
                        column: x => x.quote_id,
                        principalTable: "quotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cost_over_view_scenarios_scenario_id",
                        column: x => x.scenario_id,
                        principalTable: "scenarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_technical_office",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    additinal_feedback = table.Column<string>(type: "text", nullable: true),
                    additional_timeline_weeks_windfarm = table.Column<int>(type: "integer", nullable: false),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    design_costs_windfarm = table.Column<decimal>(type: "numeric", nullable: false),
                    evaluation_doc_link = table.Column<string>(type: "text", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    manufacturing_investment_costs_windfarm = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    toolkit_evaluation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_technical_office", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_technical_office_cost_over_view_cost_over_view_id",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_technology_tower_development_leadtime",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    is_leadtime_input_request = table.Column<bool>(type: "boolean", nullable: false),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    leadtime_tower_nomination = table.Column<decimal>(type: "numeric", nullable: false),
                    leadtime_tower_offer = table.Column<decimal>(type: "numeric", nullable: false),
                    leadtime_tower_signature = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    envelop = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_technology_tower_development_leadtime", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_technology_tower_development_leadtime_cost_over_view_",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_construction_lead_time",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_construction_lead_time_meta_id = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    nomination = table.Column<decimal>(type: "numeric", nullable: false),
                    offer = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_construction_lead_time", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_construction_lead_time_cost_over_view_cost_over_v",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_construction_lead_time_costs_tower_construction",
                        column: x => x.costs_tower_construction_lead_time_meta_id,
                        principalTable: "costs_tower_construction_lead_time_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_supplier_cost_over_view_id",
                table: "costs_tower_supplier",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_lead_time_cost_over_view_id",
                table: "costs_tower_logistics_lead_time",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_cost_over_view_id",
                table: "costs_tower_logistics",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_ex_works_cost_over_view_id",
                table: "costs_tower_ex_works",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_ex_works_costs_tower_ex_works_meta_id",
                table: "costs_tower_ex_works",
                column: "costs_tower_ex_works_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_customs_cost_over_view_id",
                table: "costs_tower_customs",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_cost_over_view_id",
                table: "costs_tower_construction",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_technology_cost_over_view_id",
                table: "costs_technology",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_cost_over_view_quote_id",
                table: "cost_over_view",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_cost_over_view_scenario_id",
                table: "cost_over_view",
                column: "scenario_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_technical_office_cost_over_view_id",
                table: "costs_technical_office",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_technology_tower_development_leadtime_cost_over_view_",
                table: "costs_technology_tower_development_leadtime",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_lead_time_cost_over_view_id",
                table: "costs_tower_construction_lead_time",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_lead_time_costs_tower_construction",
                table: "costs_tower_construction_lead_time",
                column: "costs_tower_construction_lead_time_meta_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_technology_cost_over_view_cost_over_view_id",
                table: "costs_technology",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_construction_cost_over_view_cost_over_view_id",
                table: "costs_tower_construction",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_customs_cost_over_view_cost_over_view_id",
                table: "costs_tower_customs",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_customs_costs_tower_customs_meta_costs_tower_cu",
                table: "costs_tower_customs",
                column: "costs_tower_customs_meta_id",
                principalTable: "costs_tower_customs_meta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_ex_works_cost_over_view_cost_over_view_id",
                table: "costs_tower_ex_works",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_ex_works_costs_tower_ex_works_meta_costs_tower_",
                table: "costs_tower_ex_works",
                column: "costs_tower_ex_works_meta_id",
                principalTable: "costs_tower_ex_works_meta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_cost_over_view_cost_over_view_id",
                table: "costs_tower_logistics",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_costs_tower_logistics_meta_costs_towe",
                table: "costs_tower_logistics",
                column: "costs_tower_logistics_meta_id",
                principalTable: "costs_tower_logistics_meta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_logistics_lead_time_cost_over_view_cost_over_view",
                table: "costs_tower_logistics_lead_time",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_cost_over_view_cost_over_view_id",
                table: "costs_tower_supplier",
                column: "cost_over_view_id",
                principalTable: "cost_over_view",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_costs_tower_supplier_meta_costs_tower_",
                table: "costs_tower_supplier",
                column: "costs_tower_supplier_meta_id",
                principalTable: "costs_tower_supplier_meta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
