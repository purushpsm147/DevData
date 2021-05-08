using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sf_sar_code",
                table: "quotes",
                newName: "sar_code");

            migrationBuilder.RenameColumn(
                name: "sf_quote_submission_date",
                table: "quotes",
                newName: "quote_submission_date");

            migrationBuilder.RenameColumn(
                name: "sf_quotation_status",
                table: "quotes",
                newName: "quotation_status");

            migrationBuilder.RenameColumn(
                name: "sf_quotation_name",
                table: "quotes",
                newName: "quotation_name");

            migrationBuilder.RenameColumn(
                name: "sf_quotation_id",
                table: "quotes",
                newName: "quotation_id");

            migrationBuilder.RenameColumn(
                name: "sf_offer_type",
                table: "quotes",
                newName: "offer_type");

            migrationBuilder.RenameColumn(
                name: "sf_offer_status",
                table: "quotes",
                newName: "offer_status");

            migrationBuilder.AlterColumn<string>(
                name: "proposal_sf_id",
                table: "proposals",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "generic_market_boundaries",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    country_id = table.Column<int>(type: "integer", nullable: false),
                    is_road_available = table.Column<bool>(type: "boolean", nullable: false),
                    is_rail_available = table.Column<bool>(type: "boolean", nullable: false),
                    max_tower_base_diameter_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    max_segment_weight_ton = table.Column<decimal>(type: "numeric", nullable: false),
                    max_segment_length_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_generic_market_boundaries", x => x.id);
                    table.ForeignKey(
                        name: "fk_generic_market_boundaries_countries_country_id",
                        column: x => x.country_id,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "logistic_statuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    status = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_logistic_statuses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "project_constraints",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    project_id = table.Column<int>(type: "integer", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_project_constraints", x => x.id);
                    table.ForeignKey(
                        name: "fk_project_constraints_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "construction_constraints",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    project_constraint_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    crane_lifting_heigh_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    crane_lifting_weight_ton = table.Column<decimal>(type: "numeric", nullable: false),
                    additional_requirements = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_construction_constraints", x => x.id);
                    table.ForeignKey(
                        name: "fk_construction_constraints_project_constraints_project_constr",
                        column: x => x.project_constraint_id,
                        principalTable: "project_constraints",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "logistic_constraints",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    project_constraint_id = table.Column<int>(type: "integer", nullable: false),
                    logistic_status_id = table.Column<int>(type: "integer", nullable: true),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    preliminary_logistics_document_link = table.Column<string>(type: "text", nullable: true),
                    road_survey_document_link = table.Column<string>(type: "text", nullable: true),
                    is_generic_market_boundary_available = table.Column<bool>(type: "boolean", nullable: false),
                    is_project_specific_boundary_available = table.Column<bool>(type: "boolean", nullable: false),
                    transport_mode = table.Column<int>(type: "integer", nullable: false),
                    max_tower_base_diameter_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    max_segment_weight_ton = table.Column<decimal>(type: "numeric", nullable: false),
                    max_segment_length_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_logistic_constraints", x => x.id);
                    table.ForeignKey(
                        name: "fk_logistic_constraints_logistic_statuses_logistic_status_id",
                        column: x => x.logistic_status_id,
                        principalTable: "logistic_statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_logistic_constraints_project_constraints_project_constraint",
                        column: x => x.project_constraint_id,
                        principalTable: "project_constraints",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permits_sales_constraints",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    project_constraint_id = table.Column<int>(type: "integer", nullable: false),
                    building_permits = table.Column<int>(type: "integer", nullable: false),
                    max_tip_height_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    max_tip_height_status = table.Column<int>(type: "integer", nullable: false),
                    max_hub_height_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    max_hub_height_status = table.Column<int>(type: "integer", nullable: false),
                    max_ground_clearance_mtrs = table.Column<decimal>(type: "numeric", nullable: false),
                    max_ground_clearance_status = table.Column<int>(type: "integer", nullable: false),
                    elevation_foundation_status = table.Column<bool>(type: "boolean", nullable: false),
                    max_elevation_foundation_mtrs = table.Column<decimal>(type: "numeric", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permits_sales_constraints", x => x.id);
                    table.ForeignKey(
                        name: "fk_permits_sales_constraints_project_constraints_project_const",
                        column: x => x.project_constraint_id,
                        principalTable: "project_constraints",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "special_requirements_sales_constraints",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    project_constraint_id = table.Column<int>(type: "integer", nullable: false),
                    sesimic_requirements = table.Column<bool>(type: "boolean", nullable: false),
                    sesimic_requirements_country_code = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    nearshore = table.Column<bool>(type: "boolean", nullable: false),
                    extreme_wind_conditions = table.Column<string[]>(type: "text[]", nullable: false),
                    extreme_wind_conditions_other_description = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    proj_req_limit_supplier_selection = table.Column<string[]>(type: "text[]", nullable: false),
                    supplier_requirements = table.Column<string>(type: "text", nullable: true),
                    additional_requirements = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_special_requirements_sales_constraints", x => x.id);
                    table.ForeignKey(
                        name: "fk_special_requirements_sales_constraints_project_constraints_",
                        column: x => x.project_constraint_id,
                        principalTable: "project_constraints",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "logistic_statuses",
                columns: new[] { "id", "status" },
                values: new object[,]
                {
                    { 1, "not available (use generic market boundaries)" },
                    { 2, "order received for Preliminary Logistics Assessment" },
                    { 3, "Preliminary Logistics Assessment available (for project-specific boundaries)" },
                    { 4, "order received for Road Survey" },
                    { 5, "Road Survey available" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_quotes_quotation_id",
                table: "quotes",
                column: "quotation_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_proposals_proposal_sf_id",
                table: "proposals",
                column: "proposal_sf_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_projects_opportunity_id",
                table: "projects",
                column: "opportunity_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_projects_project_name",
                table: "projects",
                column: "project_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_construction_constraints_project_constraint_id",
                table: "construction_constraints",
                column: "project_constraint_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_generic_market_boundaries_country_id",
                table: "generic_market_boundaries",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_logistic_constraints_logistic_status_id",
                table: "logistic_constraints",
                column: "logistic_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_logistic_constraints_project_constraint_id",
                table: "logistic_constraints",
                column: "project_constraint_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_permits_sales_constraints_project_constraint_id",
                table: "permits_sales_constraints",
                column: "project_constraint_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_project_constraints_id_project_id",
                table: "project_constraints",
                columns: new[] { "id", "project_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_project_constraints_project_id",
                table: "project_constraints",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "ix_special_requirements_sales_constraints_project_constraint_id",
                table: "special_requirements_sales_constraints",
                column: "project_constraint_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "construction_constraints");

            migrationBuilder.DropTable(
                name: "generic_market_boundaries");

            migrationBuilder.DropTable(
                name: "logistic_constraints");

            migrationBuilder.DropTable(
                name: "permits_sales_constraints");

            migrationBuilder.DropTable(
                name: "special_requirements_sales_constraints");

            migrationBuilder.DropTable(
                name: "logistic_statuses");

            migrationBuilder.DropTable(
                name: "project_constraints");

            migrationBuilder.DropIndex(
                name: "ix_quotes_quotation_id",
                table: "quotes");

            migrationBuilder.DropIndex(
                name: "ix_proposals_proposal_sf_id",
                table: "proposals");

            migrationBuilder.DropIndex(
                name: "ix_projects_opportunity_id",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "ix_projects_project_name",
                table: "projects");

            migrationBuilder.RenameColumn(
                name: "sar_code",
                table: "quotes",
                newName: "sf_sar_code");

            migrationBuilder.RenameColumn(
                name: "quote_submission_date",
                table: "quotes",
                newName: "sf_quote_submission_date");

            migrationBuilder.RenameColumn(
                name: "quotation_status",
                table: "quotes",
                newName: "sf_quotation_status");

            migrationBuilder.RenameColumn(
                name: "quotation_name",
                table: "quotes",
                newName: "sf_quotation_name");

            migrationBuilder.RenameColumn(
                name: "quotation_id",
                table: "quotes",
                newName: "sf_quotation_id");

            migrationBuilder.RenameColumn(
                name: "offer_type",
                table: "quotes",
                newName: "sf_offer_type");

            migrationBuilder.RenameColumn(
                name: "offer_status",
                table: "quotes",
                newName: "sf_offer_status");

            migrationBuilder.AlterColumn<string>(
                name: "proposal_sf_id",
                table: "proposals",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
