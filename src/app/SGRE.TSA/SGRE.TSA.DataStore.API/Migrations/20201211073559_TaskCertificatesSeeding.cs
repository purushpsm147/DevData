using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class TaskCertificatesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "certification_date",
                table: "proposals",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "certification_id",
                table: "proposals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "certifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    certification_name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_certifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "quotes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    proposal_id = table.Column<int>(type: "integer", nullable: false),
                    sf_quotation_id = table.Column<string>(type: "text", nullable: false),
                    sf_quotation_status = table.Column<bool>(type: "boolean", nullable: false),
                    sf_offer_type = table.Column<bool>(type: "boolean", nullable: false),
                    sf_quote_submission_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    sf_sar_code = table.Column<string>(type: "text", nullable: false),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_quotes", x => x.id);
                    table.ForeignKey(
                        name: "fk_quotes_proposals_proposal_id",
                        column: x => x.proposal_id,
                        principalTable: "proposals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    task_name = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tasks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proposal_tasks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    proposal_id = table.Column<int>(type: "integer", nullable: false),
                    task_id = table.Column<int>(type: "integer", nullable: false),
                    is_customer = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_proposal_tasks", x => x.id);
                    table.ForeignKey(
                        name: "fk_proposal_tasks_proposals_proposal_id",
                        column: x => x.proposal_id,
                        principalTable: "proposals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_proposal_tasks_tasks_task_id",
                        column: x => x.task_id,
                        principalTable: "tasks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "certifications",
                columns: new[] { "id", "certification_name" },
                values: new object[,]
                {
                    { 1, "Tower component certificate" },
                    { 2, "Site Suitability Design Assessment (SSDA)" },
                    { 3, "Tower component certificate & Site Suitability Design Assessment (SSDA)" },
                    { 4, "none" }
                });

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 2,
                column: "mile_stone_name",
                value: "PM040 - Binding offer");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 3,
                column: "mile_stone_name",
                value: "PM070 - Contract signature");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 4,
                column: "mile_stone_name",
                value: "PM080 - Notice to proceed");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 5,
                column: "mile_stone_name",
                value: "Certification Target");

            migrationBuilder.InsertData(
                table: "mile_stones",
                columns: new[] { "id", "last_modified_date_time", "mile_stone_name", "record_insert_date_time" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM650 - Take-over to customer", null });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "id", "last_modified_date_time", "record_insert_date_time", "task_name" },
                values: new object[,]
                {
                    { 4, null, null, "Preliminary Logistic Assessment" },
                    { 2, null, null, "Foundation design" },
                    { 6, null, null, "Transport oversea" },
                    { 7, null, null, "Transport inland" },
                    { 8, null, null, "Anchor cage delivery" },
                    { 9, null, null, "Foundation construction" },
                    { 10, null, null, "Tower installation" },
                    { 1, null, null, "Tower design" },
                    { 3, null, null, "Anchor Cage design" },
                    { 5, null, null, "Road Survey" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_proposals_certification_id",
                table: "proposals",
                column: "certification_id");

            migrationBuilder.CreateIndex(
                name: "ix_proposal_tasks_proposal_id",
                table: "proposal_tasks",
                column: "proposal_id");

            migrationBuilder.CreateIndex(
                name: "ix_proposal_tasks_task_id",
                table: "proposal_tasks",
                column: "task_id");

            migrationBuilder.CreateIndex(
                name: "ix_quotes_proposal_id",
                table: "quotes",
                column: "proposal_id");

            migrationBuilder.AddForeignKey(
                name: "fk_proposals_certifications_certification_id",
                table: "proposals",
                column: "certification_id",
                principalTable: "certifications",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_proposals_certifications_certification_id",
                table: "proposals");

            migrationBuilder.DropTable(
                name: "certifications");

            migrationBuilder.DropTable(
                name: "proposal_tasks");

            migrationBuilder.DropTable(
                name: "quotes");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropIndex(
                name: "ix_proposals_certification_id",
                table: "proposals");

            migrationBuilder.DeleteData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "certification_date",
                table: "proposals");

            migrationBuilder.DropColumn(
                name: "certification_id",
                table: "proposals");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 2,
                column: "mile_stone_name",
                value: "PM070 - Contract signature");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 3,
                column: "mile_stone_name",
                value: "PM080 - Notice to proceed");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 4,
                column: "mile_stone_name",
                value: "Certification Target");

            migrationBuilder.UpdateData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 5,
                column: "mile_stone_name",
                value: "PM650 - Take-over to customer");
        }
    }
}
