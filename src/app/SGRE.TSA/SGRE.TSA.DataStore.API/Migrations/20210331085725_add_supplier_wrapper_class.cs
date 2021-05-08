using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class add_supplier_wrapper_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_costs_to",
                table: "costs_tower_supplier_line_item");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "costs_tower_supplier");

            migrationBuilder.DropColumn(
                name: "is_approvals_applicable",
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

            migrationBuilder.RenameColumn(
                name: "costs_tower_supplier_id",
                table: "costs_tower_supplier_line_item",
                newName: "suppliers_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_supplier_line_item_costs_tower_supplier_id",
                table: "costs_tower_supplier_line_item",
                newName: "ix_costs_tower_supplier_line_item_suppliers_id");

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    costs_tower_supplier_id = table.Column<int>(type: "integer", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: true),
                    tower_planning_comments = table.Column<string>(type: "text", nullable: true),
                    is_offer_capacity = table.Column<bool>(type: "boolean", nullable: false),
                    is_offer_capability = table.Column<bool>(type: "boolean", nullable: false),
                    is_offer_approval = table.Column<bool>(type: "boolean", nullable: false),
                    is_signature_capacity = table.Column<bool>(type: "boolean", nullable: false),
                    is_signature_capability = table.Column<bool>(type: "boolean", nullable: false),
                    is_signature_approval = table.Column<bool>(type: "boolean", nullable: false),
                    is_approvals_applicable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_suppliers", x => x.id);
                    table.ForeignKey(
                        name: "fk_suppliers_costs_tower_supplier_costs_tower_supplier_id",
                        column: x => x.costs_tower_supplier_id,
                        principalTable: "costs_tower_supplier",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_suppliers_costs_tower_supplier_id",
                table: "suppliers",
                column: "costs_tower_supplier_id");

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_line_item_suppliers_suppliers_id",
                table: "costs_tower_supplier_line_item",
                column: "suppliers_id",
                principalTable: "suppliers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_costs_tower_supplier_line_item_suppliers_suppliers_id",
                table: "costs_tower_supplier_line_item");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.RenameColumn(
                name: "suppliers_id",
                table: "costs_tower_supplier_line_item",
                newName: "costs_tower_supplier_id");

            migrationBuilder.RenameIndex(
                name: "ix_costs_tower_supplier_line_item_suppliers_id",
                table: "costs_tower_supplier_line_item",
                newName: "ix_costs_tower_supplier_line_item_costs_tower_supplier_id");

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "costs_tower_supplier",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_approvals_applicable",
                table: "costs_tower_supplier",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddForeignKey(
                name: "fk_costs_tower_supplier_line_item_costs_tower_supplier_costs_to",
                table: "costs_tower_supplier_line_item",
                column: "costs_tower_supplier_id",
                principalTable: "costs_tower_supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
