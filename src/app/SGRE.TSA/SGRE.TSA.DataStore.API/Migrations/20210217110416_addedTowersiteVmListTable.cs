using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedTowersiteVmListTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "towersite_vm_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    sst_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    image_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    vm_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    vm_status = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    job_status = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    vm_username = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    vm_password = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_towersite_vm_list", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "towersite_vm_list");
        }
    }
}
