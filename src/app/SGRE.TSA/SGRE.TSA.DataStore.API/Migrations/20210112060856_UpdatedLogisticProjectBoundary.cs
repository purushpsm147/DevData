using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdatedLogisticProjectBoundary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_logistic_project_boundaries_logistic_constraints_logistic_c",
                table: "logistic_project_boundaries");

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1456), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1440), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1806), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1803), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1836), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1853), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1852), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1887), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1903), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1935), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1982), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(1997), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2013), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2012), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2027), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2043), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2061), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2060), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2077), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2138), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2154), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2185), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2199), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2215), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2231), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2245), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2260), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2275), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2291), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2307), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2306), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2322), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2321), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2338), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2355), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2369), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2408), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2407), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2425), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2424), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2439), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2455), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2454), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2469), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2485), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2501), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2530), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2545), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2607), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2623), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2622), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2638), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2653), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2704), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2722), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2736), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2751), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2767), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2766), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2781), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2796), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2841), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2841), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2856), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2905), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2934), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2972), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3021), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3020), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3066), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3081), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3097), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3158), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3206), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3221), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3220), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3236), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3235), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3289), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3307), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3306), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3338), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3337), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3353), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3369), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3399), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3414), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3413), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3431), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3461), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3477), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3475), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3492), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3491), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3507), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3522), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3536), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3552), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3551), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3607), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3639), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3654), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3684), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3684), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3715), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3746), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3745), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3761), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3760), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3776), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3775), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3822), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3837), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3852), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3851), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3867), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3932), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3949), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3948), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3964), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(3995), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4012), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4088), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4173), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4172), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4203), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4219), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4218), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4234), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4233), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4265), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4296), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4296), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4312), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4326), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4357), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4356), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4372), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4371), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4387), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4387), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4403), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4418), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4417), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4432), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4473), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4488), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4487), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4504), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4503), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4519), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4518), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4535), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4534), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4564), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4580), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4595), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4611), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4610), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4625), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4671), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4686), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4685), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4716), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4731), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4768), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4767), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4786), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4785), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4802), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4817), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4816), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4832), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4877), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4892), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4908), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4907), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4923), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4922), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4939), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4954), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4953), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4968), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4984), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(4983), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5265), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5294), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5353), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5351), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5369), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5385), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5417), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5433), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5432), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5448), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5464), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5463), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5479), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5509), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5525), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5524), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5540), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5801), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5800), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5817), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 599, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1024), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(547), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1509), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1503), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1511), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1525), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1533), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 6, 8, 55, 597, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "fk_logistic_project_boundaries_logistic_constraints_logistic_co",
                table: "logistic_project_boundaries",
                column: "logistic_constraint_id",
                principalTable: "logistic_constraints",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_logistic_project_boundaries_logistic_constraints_logistic_co",
                table: "logistic_project_boundaries");

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7068), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7301), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7326), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7361), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7360), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7427), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7460), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7476), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7492), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7597), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7646), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7661), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7724), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7723), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7754), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7768), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7784), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7799), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7814), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7830), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7846), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7903), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7901), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7918), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7933), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7948), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7947), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7963), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7979), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(7993), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8009), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8009), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8025), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8024), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8040), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8039), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8055), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8085), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8101), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8116), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8147), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8162), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8161), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8201), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8200), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8217), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8216), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8232), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8231), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8247), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8263), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8278), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8293), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8308), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8307), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8322), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8339), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8338), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8354), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8353), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8387), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8386), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8401), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8418), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8433), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8432), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8533), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8548), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8547), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8563), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8562), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8592), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8608), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8624), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8623), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8639), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8638), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8654), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8653), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8669), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8731), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8889), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8889), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8919), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8935), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8934), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8949), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8997), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(8996), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9012), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9011), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9027), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9026), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9056), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9056), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9086), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9086), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9101), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9153), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9152), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9170), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9169), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9185), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9185), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9200), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9199), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9215), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9231), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9261), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9277), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9276), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9292), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9307), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9322), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9338), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9337), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9353), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9367), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9383), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9397), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9413), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9495), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9494), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9533), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9532), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9548), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9547), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9563), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9579), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9578), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9597), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9612), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9629), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9628), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9644), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9642), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9658), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9674), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9673), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9688), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9703), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9742), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9741), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9759), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9775), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9774), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9789), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9805), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9804), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9819), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9871), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9919), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9918), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9935), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9949), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9963), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9978), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9977), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 897, DateTimeKind.Unspecified).AddTicks(9993), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(9), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(8), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(24), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(23), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(38), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(93), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(92), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(107), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(137), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(136), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(153), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(152), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(167), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(183), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(182), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(198), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(197), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(213), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(212), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(242), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(242), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(257), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(256), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(272), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(286), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(286), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(300), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(315), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(331), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(415), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(429), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(444), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(460), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(459), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(474), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(490), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(489), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(519), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(518), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(534), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(533), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(548), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(563), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(562), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(577), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(592), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(591), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(606), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(620), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(692), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(708), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(707), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(737), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(766), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(781), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(796), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(795), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(825), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(855), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(885), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(884), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 898, DateTimeKind.Unspecified).AddTicks(899), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8256), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(7755), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8764), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8774), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8775), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8787), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8786), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8791), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 5, 35, 6, 895, DateTimeKind.Unspecified).AddTicks(8797), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "fk_logistic_project_boundaries_logistic_constraints_logistic_c",
                table: "logistic_project_boundaries",
                column: "logistic_constraint_id",
                principalTable: "logistic_constraints",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
