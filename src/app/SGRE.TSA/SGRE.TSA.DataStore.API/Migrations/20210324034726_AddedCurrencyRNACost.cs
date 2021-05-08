using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class AddedCurrencyRNACost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "currency_id",
                table: "projects",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "currency_id",
                table: "countries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "currencies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    code = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    display_name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_currencies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rna_costs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    currency_id = table.Column<int>(type: "integer", nullable: false),
                    wtg_catalogue_id = table.Column<int>(type: "integer", nullable: false),
                    cost = table.Column<decimal>(type: "numeric", nullable: false),
                    record_insert_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    last_modified_date_time = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rna_costs", x => x.id);
                    table.ForeignKey(
                        name: "fk_rna_costs_currencies_currency_id",
                        column: x => x.currency_id,
                        principalTable: "currencies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_rna_costs_wtg_catalogues_wtg_catalogue_id",
                        column: x => x.wtg_catalogue_id,
                        principalTable: "wtg_catalogues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "currencies",
                columns: new[] { "id", "code", "description", "display_name", "last_modified_date_time", "name", "record_insert_date_time" },
                values: new object[,]
                {
                    { 1, "CNY/RNB", "Chinese Yuan/Renminbi - CNY/RMB (¥)", "CNY/RMB (¥)", null, "Chinese Yuan/Renminbi", null },
                    { 2, "USD", "US Dollar - USD ($)", "USD ($)", null, "United States dollar", null },
                    { 3, "BRL", "Brazilian Real - BRL (R$)", "BRL (R$)", null, "Brazilian Real", null },
                    { 4, "INR", "Indian Rupee - INR (₹)", "INR (₹)", null, "Indian Rupee", null },
                    { 5, "EUR", "Euro - EUR (€)", "EUR (€)", null, "Euro", null }
                });

            migrationBuilder.UpdateData(
                table: "wtg_catalogues",
                keyColumn: "id",
                keyValue: 5,
                column: "platform",
                value: "SG3.X");

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 1,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 2,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 3,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 4,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 5,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 6,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 7,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 8,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 9,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 10,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 11,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 12,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 13,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 14,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 15,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 16,
                column: "currency_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 17,
                column: "currency_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 18,
                column: "currency_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 19,
                column: "currency_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 20,
                column: "currency_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 21,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 22,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 23,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 24,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 25,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 26,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 27,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 28,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 29,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 30,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 31,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 32,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 33,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 34,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 35,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 36,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 37,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 38,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 39,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 40,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 41,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 42,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 43,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 44,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 45,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 46,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 47,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 48,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 49,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 50,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 51,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 52,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 53,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 54,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 55,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 56,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 57,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 58,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 59,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 60,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 61,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 62,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 63,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 64,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 65,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 66,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 67,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 68,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 69,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 70,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 71,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 72,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 73,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 74,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 75,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 76,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 77,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 78,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 79,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 80,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 81,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 82,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 83,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 84,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 85,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 86,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 87,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 88,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 89,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 90,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 91,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 92,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 93,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 94,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 95,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 96,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 97,
                column: "currency_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 98,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 99,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 100,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 101,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 102,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 103,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 104,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 105,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 106,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 107,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 108,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 109,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 110,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 111,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 112,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 113,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 114,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 115,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 116,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 117,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 118,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 119,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 120,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 121,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 122,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 123,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 124,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 125,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 126,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 127,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 128,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 129,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 130,
                column: "currency_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "countries",
                keyColumn: "id",
                keyValue: 131,
                column: "currency_id",
                value: 5);

            migrationBuilder.InsertData(
                table: "rna_costs",
                columns: new[] { "id", "cost", "currency_id", "last_modified_date_time", "record_insert_date_time", "wtg_catalogue_id" },
                values: new object[,]
                {
                    { 7, 1150m, 5, null, null, 6 },
                    { 5, 1531m, 5, null, null, 7 },
                    { 16, 15701m, 1, null, null, 2 },
                    { 17, 10600m, 1, null, null, 4 },
                    { 18, 11035m, 1, null, null, 3 },
                    { 19, 11906m, 1, null, null, 7 },
                    { 20, 9379m, 1, null, null, 5 },
                    { 21, 8943m, 1, null, null, 6 },
                    { 8, 2570m, 2, null, null, 1 },
                    { 9, 2445m, 2, null, null, 2 },
                    { 10, 1650m, 2, null, null, 4 },
                    { 11, 1718m, 2, null, null, 3 },
                    { 12, 1854m, 2, null, null, 7 },
                    { 13, 1460m, 2, null, null, 5 },
                    { 14, 1392m, 2, null, null, 6 },
                    { 22, 13909m, 3, null, null, 1 },
                    { 23, 13246m, 3, null, null, 2 },
                    { 24, 8942m, 3, null, null, 4 },
                    { 25, 9310m, 3, null, null, 3 },
                    { 4, 1419m, 5, null, null, 3 },
                    { 3, 1363m, 5, null, null, 4 },
                    { 2, 2019m, 5, null, null, 2 },
                    { 1, 2120m, 5, null, null, 1 },
                    { 35, 99541m, 4, null, null, 6 },
                    { 34, 104388m, 4, null, null, 5 },
                    { 6, 1206m, 5, null, null, 5 },
                    { 33, 132519m, 4, null, null, 7 },
                    { 31, 117978m, 4, null, null, 4 },
                    { 30, 174759m, 4, null, null, 2 },
                    { 29, 183501m, 4, null, null, 1 },
                    { 28, 7545m, 3, null, null, 6 },
                    { 27, 7912m, 3, null, null, 5 },
                    { 26, 10044m, 3, null, null, 7 },
                    { 32, 122825m, 4, null, null, 3 },
                    { 15, 16487m, 1, null, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_projects_currency_id",
                table: "projects",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "ix_countries_currency_id",
                table: "countries",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "ix_rna_costs_currency_id",
                table: "rna_costs",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "ix_rna_costs_wtg_catalogue_id",
                table: "rna_costs",
                column: "wtg_catalogue_id");

            migrationBuilder.AddForeignKey(
                name: "fk_countries_currencies_currency_id",
                table: "countries",
                column: "currency_id",
                principalTable: "currencies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_projects_currencies_currency_id",
                table: "projects",
                column: "currency_id",
                principalTable: "currencies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_countries_currencies_currency_id",
                table: "countries");

            migrationBuilder.DropForeignKey(
                name: "fk_projects_currencies_currency_id",
                table: "projects");

            migrationBuilder.DropTable(
                name: "rna_costs");

            migrationBuilder.DropTable(
                name: "currencies");

            migrationBuilder.DropIndex(
                name: "ix_projects_currency_id",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "ix_countries_currency_id",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "currency_id",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "currency_id",
                table: "countries");

            migrationBuilder.UpdateData(
                table: "wtg_catalogues",
                keyColumn: "id",
                keyValue: 5,
                column: "platform",
                value: "SG4.X");
        }
    }
}
