using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mile_stones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mile_stone_name = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_mile_stones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "project_modules",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    module_name = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    module_description = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    created_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    updated_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_project_modules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    region_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_name = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    role_description = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    created_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    updated_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    active_record_indicator = table.Column<int>(type: "integer", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    country_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    region_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_countries", x => x.id);
                    table.ForeignKey(
                        name: "fk_countries_regions_region_id",
                        column: x => x.region_id,
                        principalTable: "regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<int>(type: "integer", nullable: false),
                    project_module_id = table.Column<int>(type: "integer", nullable: false),
                    permission_type = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    updated_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permissions", x => x.id);
                    table.ForeignKey(
                        name: "fk_permissions_project_modules_project_module_id",
                        column: x => x.project_module_id,
                        principalTable: "project_modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_permissions_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opportunity_id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    project_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    customer_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    contract_status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    country_id = table.Column<int>(type: "integer", nullable: false),
                    sst_request_similar_projects = table.Column<string>(type: "text", nullable: true),
                    created_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    updated_by = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    record_end_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    active_record_indicator = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_projects", x => x.id);
                    table.ForeignKey(
                        name: "fk_projects_countries_country_id",
                        column: x => x.country_id,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "project_mile_stones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    project_id = table.Column<int>(type: "integer", nullable: false),
                    mile_stone_id = table.Column<int>(type: "integer", nullable: false),
                    mile_stone_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    mile_stone_offer_status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_project_mile_stones", x => x.id);
                    table.ForeignKey(
                        name: "fk_project_mile_stones_mile_stones_mile_stone_id",
                        column: x => x.mile_stone_id,
                        principalTable: "mile_stones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_mile_stones_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "project_roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    project_id = table.Column<int>(type: "integer", nullable: false),
                    role_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_project_roles", x => x.id);
                    table.ForeignKey(
                        name: "fk_project_roles_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_roles_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proposals",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    project_id = table.Column<int>(type: "integer", nullable: false),
                    proposal_id = table.Column<string>(type: "text", nullable: true),
                    proposal_status = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    record_end_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    active_record_indicator = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_proposals", x => x.id);
                    table.ForeignKey(
                        name: "fk_proposals_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "active_record_indicator", "created_by", "last_modified_date_time", "record_insert_date_time", "role_description", "role_name", "updated_by" },
                values: new object[,]
                {
                    { 1, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sales Manger", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 2, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Proposal Manager", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 3, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Siting Engineer", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 4, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Technical Project Manager", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 5, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Global Project Engineering", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 6, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Planning Towers", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 7, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Procurement Manager", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 8, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Logistic Pre-Sales Road Engineer", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 9, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PR Pre-Sales (Logistic)", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 10, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PR Pre-Sales (Construction)", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 11, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Construction Technical Office", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 12, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tower Development", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 13, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Loads and Control Engineering", "visweswara.dontamsetti.ext@siemensgamesa.com" },
                    { 14, 0, "visweswara.dontamsetti.ext@siemensgamesa.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Certification Engineering", "visweswara.dontamsetti.ext@siemensgamesa.com" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_countries_region_id",
                table: "countries",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "ix_permissions_project_module_id",
                table: "permissions",
                column: "project_module_id");

            migrationBuilder.CreateIndex(
                name: "ix_permissions_role_id",
                table: "permissions",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_project_mile_stones_mile_stone_id",
                table: "project_mile_stones",
                column: "mile_stone_id");

            migrationBuilder.CreateIndex(
                name: "ix_project_mile_stones_project_id",
                table: "project_mile_stones",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "ix_project_roles_project_id",
                table: "project_roles",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "ix_project_roles_role_id",
                table: "project_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_projects_country_id",
                table: "projects",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_proposals_project_id",
                table: "proposals",
                column: "project_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "project_mile_stones");

            migrationBuilder.DropTable(
                name: "project_roles");

            migrationBuilder.DropTable(
                name: "proposals");

            migrationBuilder.DropTable(
                name: "project_modules");

            migrationBuilder.DropTable(
                name: "mile_stones");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "regions");
        }
    }
}
