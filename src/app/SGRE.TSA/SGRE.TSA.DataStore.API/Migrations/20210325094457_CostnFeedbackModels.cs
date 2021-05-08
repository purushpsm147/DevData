using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class CostnFeedbackModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cost_over_view_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sub_section_name = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cost_over_view_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_construction_lead_time_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    line_item_name = table.Column<string>(type: "text", nullable: false),
                    line_item_type = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_construction_lead_time_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_construction_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    line_item_name = table.Column<string>(type: "text", nullable: false),
                    line_item_type = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_construction_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_customs_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    line_item_name = table.Column<string>(type: "text", nullable: false),
                    line_item_type = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_customs_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_ex_works_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    line_item_name = table.Column<string>(type: "text", nullable: false),
                    line_item_type = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_ex_works_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_logistics_lead_time_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    line_item_name = table.Column<string>(type: "text", nullable: false),
                    line_item_type = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_logistics_lead_time_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_logistics_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    line_item_name = table.Column<string>(type: "text", nullable: false),
                    line_item_type = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_logistics_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_supplier_meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    line_item_name = table.Column<string>(type: "text", nullable: false),
                    line_item_type = table.Column<string>(type: "text", nullable: false),
                    line_item_source = table.Column<string>(type: "text", nullable: true),
                    type_of_tower = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_supplier_meta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cost_over_view",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_meta_id = table.Column<int>(type: "integer", nullable: false),
                    scenario_id = table.Column<int>(type: "integer", nullable: false),
                    quote_id = table.Column<int>(type: "integer", nullable: false),
                    windfarm_configuration_id = table.Column<string>(type: "text", nullable: false),
                    scenario_type = table.Column<int>(type: "integer", nullable: false),
                    item_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cost_over_view", x => x.id);
                    table.ForeignKey(
                        name: "fk_cost_over_view_cost_over_view_meta_cost_over_view_meta_id",
                        column: x => x.cost_over_view_meta_id,
                        principalTable: "cost_over_view_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "costs_tower_construction",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_construction_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_construction", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_construction_cost_over_view_cost_over_view_id",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_construction_costs_tower_construction_meta_cost",
                        column: x => x.costs_tower_construction_meta_id,
                        principalTable: "costs_tower_construction_meta",
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
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_construction_lead_time", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_construction_lead_time_cost_over_view_cost_over",
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

            migrationBuilder.CreateTable(
                name: "costs_tower_customs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_customs_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_customs", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_customs_cost_over_view_cost_over_view_id",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_customs_costs_tower_customs_meta_costs_tower_cu",
                        column: x => x.costs_tower_customs_meta_id,
                        principalTable: "costs_tower_customs_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_ex_works",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_ex_works_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_ex_works", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_ex_works_cost_over_view_cost_over_view_id",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_ex_works_costs_tower_ex_works_meta_costs_tower_",
                        column: x => x.costs_tower_ex_works_meta_id,
                        principalTable: "costs_tower_ex_works_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_logistics",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_logistics_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_logistics", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_cost_over_view_cost_over_view_id",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_costs_tower_logistics_meta_costs_towe",
                        column: x => x.costs_tower_logistics_meta_id,
                        principalTable: "costs_tower_logistics_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_logistics_lead_time",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_logistics_lead_time_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_logistics_lead_time", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_lead_time_cost_over_view_cost_over_vi",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_logistics_lead_time_costs_tower_logistics_lead_",
                        column: x => x.costs_tower_logistics_lead_time_meta_id,
                        principalTable: "costs_tower_logistics_lead_time_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costs_tower_supplier",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    costs_tower_supplier_meta_id = table.Column<int>(type: "integer", nullable: false),
                    nomination = table.Column<int>(type: "integer", nullable: false),
                    offer = table.Column<int>(type: "integer", nullable: false),
                    signature = table.Column<int>(type: "integer", nullable: false),
                    scenario_progress = table.Column<int>(type: "integer", nullable: false),
                    is_phase_complete = table.Column<bool>(type: "boolean", nullable: false),
                    is_approvals_applicable = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_tower_supplier", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_tower_supplier_cost_over_view_cost_over_view_id",
                        column: x => x.cost_over_view_id,
                        principalTable: "cost_over_view",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_costs_tower_supplier_costs_tower_supplier_meta_costs_tower_",
                        column: x => x.costs_tower_supplier_meta_id,
                        principalTable: "costs_tower_supplier_meta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cost_over_view_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_source", "record_insert_date_time", "sub_section_name", "type_of_tower" },
                values: new object[,]
                {
                    { 1, null, null, null, "Tower EXW", 0 },
                    { 8, null, null, null, "RNA*", 0 },
                    { 7, null, null, null, "Total Cost", 0 },
                    { 6, null, null, null, "Certification", 0 },
                    { 9, null, null, null, "Cost incl. RNA", 0 },
                    { 4, null, null, null, "Customs", 0 },
                    { 3, null, null, null, "Construction", 0 },
                    { 2, null, null, null, "Logistics", 0 },
                    { 5, null, null, null, "Tower Design", 0 }
                });

            migrationBuilder.InsertData(
                table: "costs_tower_ex_works_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[,]
                {
                    { 10, null, "Mounting kit", null, "decimal", null, 0 },
                    { 16, null, "Customs raw material (if in scope)", null, "decimal ", null, 0 },
                    { 15, null, "Tower Transport(if not EXW)", null, "decimal", null, 0 },
                    { 14, null, "Handling fee", null, "decimal", null, 0 },
                    { 13, null, "Anchor Cage System", null, "decimal", null, 0 },
                    { 12, null, "Flanges - anchor cage", null, "decimal", null, 0 },
                    { 11, null, "Structural Bolt", null, "decimal", null, 0 },
                    { 9, null, "Tarps & Plugs", null, "decimal", null, 0 },
                    { 8, null, "Others", null, "decimal", null, 0 },
                    { 7, null, "Internals", null, "decimal", null, 0 },
                    { 6, null, "Elevator", null, "decimal", null, 0 },
                    { 5, null, "Doorframe", null, "decimal", null, 0 },
                    { 4, null, "Tower Conversion", null, "decimal", null, 0 },
                    { 3, null, "Tower Shell", null, "decimal", null, 0 },
                    { 2, null, "Paint", null, "decimal", null, 0 },
                    { 1, null, "Tower Flanges", null, "decimal", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "costs_tower_supplier_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[,]
                {
                    { 1, null, "No. of towers", null, "int", null, 0 },
                    { 2, null, "Supplier name", null, "string", null, 0 },
                    { 3, null, "Supplier region", "Region", "string", null, 0 },
                    { 4, null, "Country", "Country", "string", null, 0 },
                    { 5, null, "Lead time est. (wks)", null, "int", null, 0 },
                    { 6, null, "Lead time (wks)", null, "int", null, 0 },
                    { 7, null, "Capacity", null, "bool", null, 2 },
                    { 8, null, "Capability", null, "bool", null, 2 },
                    { 9, null, "Approval", null, "bool", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_cost_over_view_cost_over_view_meta_id",
                table: "cost_over_view",
                column: "cost_over_view_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_cost_over_view_quote_id",
                table: "cost_over_view",
                column: "quote_id");

            migrationBuilder.CreateIndex(
                name: "ix_cost_over_view_scenario_id",
                table: "cost_over_view",
                column: "scenario_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_cost_over_view_id",
                table: "costs_tower_construction",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_costs_tower_construction_meta_id",
                table: "costs_tower_construction",
                column: "costs_tower_construction_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_lead_time_cost_over_view_id",
                table: "costs_tower_construction_lead_time",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_construction_lead_time_costs_tower_construction",
                table: "costs_tower_construction_lead_time",
                column: "costs_tower_construction_lead_time_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_customs_cost_over_view_id",
                table: "costs_tower_customs",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_customs_costs_tower_customs_meta_id",
                table: "costs_tower_customs",
                column: "costs_tower_customs_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_ex_works_cost_over_view_id",
                table: "costs_tower_ex_works",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_ex_works_costs_tower_ex_works_meta_id",
                table: "costs_tower_ex_works",
                column: "costs_tower_ex_works_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_cost_over_view_id",
                table: "costs_tower_logistics",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_costs_tower_logistics_meta_id",
                table: "costs_tower_logistics",
                column: "costs_tower_logistics_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_lead_time_cost_over_view_id",
                table: "costs_tower_logistics_lead_time",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_logistics_lead_time_costs_tower_logistics_lead_",
                table: "costs_tower_logistics_lead_time",
                column: "costs_tower_logistics_lead_time_meta_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_supplier_cost_over_view_id",
                table: "costs_tower_supplier",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_tower_supplier_costs_tower_supplier_meta_id",
                table: "costs_tower_supplier",
                column: "costs_tower_supplier_meta_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "costs_tower_construction");

            migrationBuilder.DropTable(
                name: "costs_tower_construction_lead_time");

            migrationBuilder.DropTable(
                name: "costs_tower_customs");

            migrationBuilder.DropTable(
                name: "costs_tower_ex_works");

            migrationBuilder.DropTable(
                name: "costs_tower_logistics");

            migrationBuilder.DropTable(
                name: "costs_tower_logistics_lead_time");

            migrationBuilder.DropTable(
                name: "costs_tower_supplier");

            migrationBuilder.DropTable(
                name: "costs_tower_construction_meta");

            migrationBuilder.DropTable(
                name: "costs_tower_construction_lead_time_meta");

            migrationBuilder.DropTable(
                name: "costs_tower_customs_meta");

            migrationBuilder.DropTable(
                name: "costs_tower_ex_works_meta");

            migrationBuilder.DropTable(
                name: "costs_tower_logistics_meta");

            migrationBuilder.DropTable(
                name: "costs_tower_logistics_lead_time_meta");

            migrationBuilder.DropTable(
                name: "cost_over_view");

            migrationBuilder.DropTable(
                name: "costs_tower_supplier_meta");

            migrationBuilder.DropTable(
                name: "cost_over_view_meta");
        }
    }
}
