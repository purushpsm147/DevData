using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class CostAndFeedBackModelsAndSeedingMeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "costs_technical_office",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    toolkit_evaluation = table.Column<string>(type: "text", nullable: true),
                    evaluation_doc_link = table.Column<string>(type: "text", nullable: true),
                    additinal_feedback = table.Column<string>(type: "text", nullable: true),
                    design_costs_windfarm = table.Column<double>(type: "double precision", nullable: false),
                    manufacturing_investment_costs_windfarm = table.Column<double>(type: "double precision", nullable: false),
                    additional_timeline_weeks_windfarm = table.Column<double>(type: "double precision", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
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
                name: "costs_technology",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost_over_view_id = table.Column<int>(type: "integer", nullable: false),
                    tower_component_certificate_windfarm_nomination = table.Column<int>(type: "integer", nullable: false),
                    tower_component_certificate_windfarm_signature = table.Column<int>(type: "integer", nullable: false),
                    tower_component_certificate_windfarm_offer = table.Column<int>(type: "integer", nullable: false),
                    additinal_comments = table.Column<string>(type: "text", nullable: true),
                    is_feedback = table.Column<bool>(type: "boolean", nullable: false),
                    is_feedback_request = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_costs_technology", x => x.id);
                    table.ForeignKey(
                        name: "fk_costs_technology_cost_over_view_cost_over_view_id",
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
                    leadtime_tower_nomination = table.Column<int>(type: "integer", nullable: false),
                    leadtime_tower_offer = table.Column<int>(type: "integer", nullable: false),
                    leadtime_tower_signature = table.Column<int>(type: "integer", nullable: false),
                    envelop = table.Column<string>(type: "text", nullable: true),
                    is_leadtime_input_request = table.Column<bool>(type: "boolean", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
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

            migrationBuilder.InsertData(
                table: "costs_tower_construction_lead_time_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[] { 1, null, "Total erection(dys)", null, "decimel", null, 0 });

            migrationBuilder.InsertData(
                table: "costs_tower_construction_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[,]
                {
                    { 1, null, "Total per WTG", null, "decimel", null, 2 },
                    { 2, null, "Total", null, "decimel", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "costs_tower_customs_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[,]
                {
                    { 1, null, "Customs rate on Tower EXW and LOG(%)", null, "decimel", null, 0 },
                    { 2, null, "Customs cost per WTG on Tower EXW and LOG", null, "decimel", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "costs_tower_logistics_lead_time_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[,]
                {
                    { 1, null, "Transport at origin", null, "int", null, 0 },
                    { 2, null, "Sea freight", null, "int", null, 0 },
                    { 3, null, "Transport at destination to site", null, "int", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "costs_tower_logistics_meta",
                columns: new[] { "id", "last_modified_date_time", "line_item_name", "line_item_source", "line_item_type", "record_insert_date_time", "type_of_tower" },
                values: new object[,]
                {
                    { 1, null, "1.2.1 - Logistic Costs - Origin", null, "decimel", null, 0 },
                    { 2, null, "1.2.2 - Logistic Costs - Sea freight", null, "decimel", null, 0 },
                    { 3, null, "1.2.3 - Logistic Costs - Destination", null, "decimel", null, 0 },
                    { 4, null, "1.2.4 - Costs out of EXWss scope", null, "decimel", null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_costs_technical_office_cost_over_view_id",
                table: "costs_technical_office",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_technology_cost_over_view_id",
                table: "costs_technology",
                column: "cost_over_view_id");

            migrationBuilder.CreateIndex(
                name: "ix_costs_technology_tower_development_leadtime_cost_over_view_",
                table: "costs_technology_tower_development_leadtime",
                column: "cost_over_view_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "costs_technical_office");

            migrationBuilder.DropTable(
                name: "costs_technology");

            migrationBuilder.DropTable(
                name: "costs_technology_tower_development_leadtime");

            migrationBuilder.DeleteData(
                table: "costs_tower_construction_lead_time_meta",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "costs_tower_construction_meta",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "costs_tower_customs_meta",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "costs_tower_logistics_lead_time_meta",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "costs_tower_logistics_lead_time_meta",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "costs_tower_logistics_lead_time_meta",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "costs_tower_logistics_meta",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
