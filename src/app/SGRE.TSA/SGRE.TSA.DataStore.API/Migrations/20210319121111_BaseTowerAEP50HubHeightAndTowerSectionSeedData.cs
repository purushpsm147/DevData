using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class BaseTowerAEP50HubHeightAndTowerSectionSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "base_tower_aep_hubheight",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    base_tower_id = table.Column<int>(type: "integer", nullable: false),
                    aep_p50hub_height = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50nomination_gross = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50binding_offer_net = table.Column<decimal>(type: "numeric", nullable: false),
                    aep_p50signature_net = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_base_tower_aep_hubheight", x => x.id);
                    table.ForeignKey(
                        name: "fk_base_tower_aep_hubheight_base_tower_base_tower_id",
                        column: x => x.base_tower_id,
                        principalTable: "base_tower",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tower_sections",
                columns: new[] { "id", "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "last_modified_date_time", "record_insert_date_time", "section_height_m", "section_number", "section_type", "total_weight_kg", "tower_type_id" },
                values: new object[,]
                {
                    { 1, 4.7m, 4.7m, null, null, 13.564m, 1, null, 84958.3m, 1 },
                    { 32, 4.131m, 3.712m, null, null, 22.86m, 4, null, 69970.7862593915m, 77 },
                    { 31, 4.4335m, 4.131m, null, null, 20.33m, 3, null, 71395.49987894m, 77 },
                    { 30, 4.675m, 4.4335m, null, null, 18.805m, 2, null, 75629.5520237498m, 77 },
                    { 29, 4.68m, 4.675m, null, null, 14.685m, 1, null, 79873.2065903408m, 77 },
                    { 28, 3.598m, 3.395m, null, null, 32.25m, 3, null, 48381.3m, 79 },
                    { 27, 4.0225m, 3.598m, null, null, 30m, 2, null, 58971m, 79 },
                    { 26, 4.27m, 4.0225m, null, null, 29.75m, 1, null, 84879m, 79 },
                    { 25, 3.617m, 3.503m, null, null, 23.74m, 4, null, 41590.645453645m, 69 },
                    { 24, 4.023m, 3.617m, null, null, 20.82m, 3, null, 42107.8551723855m, 69 },
                    { 23, 4.032m, 4.023m, null, null, 20.82m, 2, null, 59192.004867504m, 69 },
                    { 22, 4.278m, 4.032m, null, null, 16.62m, 1, null, 68538.1527158438m, 69 },
                    { 21, 4.691m, 3.503m, null, null, 29.97m, 5, null, 63505.1130089599m, 43 },
                    { 20, 4.691m, 4.691m, null, null, 29.96m, 4, null, 73648.1220461621m, 43 },
                    { 19, 4.69m, 4.691m, null, null, 26.04m, 3, null, 88386.7504356758m, 43 },
                    { 18, 4.4912m, 4.69m, null, null, 20.72m, 2, null, 89339.6508417695m, 43 },
                    { 17, 4.6999m, 4.4912m, null, null, 13.18m, 1, null, 83703.4276702223m, 43 },
                    { 16, 3.3665m, 3.395m, null, null, 29.5m, 3, null, 43501.5358851085m, 73 },
                    { 2, 4.7m, 4.436m, null, null, 18.2m, 2, null, 84327.8m, 1 },
                    { 3, 4.436m, 4.427m, null, null, 23.8m, 3, null, 84548.3m, 1 },
                    { 4, 4.427m, 4.021m, null, null, 26.88m, 4, null, 71770.5m, 1 },
                    { 5, 4.021m, 3.503m, null, null, 29.97m, 5, null, 63863.1m, 1 },
                    { 6, 4.115m, 4.1065m, null, null, 16.18m, 1, null, 60050.0704076508m, 6 },
                    { 7, 4.1065m, 4.1m, null, null, 23.3m, 2, null, 57553.4559157892m, 6 },
                    { 33, 3.712m, 3.3725m, null, null, 25.82m, 5, null, 69651.0650992417m, 77 },
                    { 8, 4.1m, 4.0167m, null, null, 23.52m, 3, null, 44807.6526008422m, 6 },
                    { 10, 4.68m, 4.4297m, null, null, 19.465m, 1, null, 79304.2207846251m, 82 },
                    { 11, 4.4297m, 4.4222m, null, null, 24.09m, 2, null, 70365.0974274015m, 82 },
                    { 12, 4.4222m, 4.0182m, null, null, 27.46m, 3, null, 59567.7112101046m, 82 },
                    { 13, 4.0182m, 3.503m, null, null, 29.485m, 4, null, 52736.5238022118m, 82 },
                    { 14, 4.25m, 4.02m, null, null, 23.1m, 1, null, 61411.1449455023m, 73 },
                    { 15, 4.02m, 3.3665m, null, null, 29.4m, 2, null, 51510.2859937298m, 73 },
                    { 9, 4.0167m, 3.503m, null, null, 25m, 4, null, 41491.5666858333m, 6 },
                    { 34, 3.3725m, 3.395m, null, null, 29.5m, 6, null, 48927.5428520448m, 77 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_base_tower_aep_hubheight_base_tower_id",
                table: "base_tower_aep_hubheight",
                column: "base_tower_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "base_tower_aep_hubheight");

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 34);
        }
    }
}
