using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdatedScenarioDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "design_evaluation",
                table: "scenario_designs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6206), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6490), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6488), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6511), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6510), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6527), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6526), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6542), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6592), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6608), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6607), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6625), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6702), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6758), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6826), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6825), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6841), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6855), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6870), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6887), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6886), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6902), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6945), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6976), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7046), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7067), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7065), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7097), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7112), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7111), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7126), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7125), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7142), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7140), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7202), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7201), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7217), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7231), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7246), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7245), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7275), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7291), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7333), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7351), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7366), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7425), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7440), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7454), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7469), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7468), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7484), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7499), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7498), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7528), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7601), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7620), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7634), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7633), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7723), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7722), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7751), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7766), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7781), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7796), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7795), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7811), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7844), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7859), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7858), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7874), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7873), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7912), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7931), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7946), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7945), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7976), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7975), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(7989), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8004), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8019), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8034), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8049), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8063), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8077), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8092), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8107), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8123), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8138), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8137), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8151), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8167), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8166), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8181), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8223), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8238), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8237), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8252), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8251), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8267), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8282), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8281), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8296), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8311), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8324), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8340), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8339), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8354), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8353), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8384), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8413), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8427), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8426), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8441), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8441), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8456), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8469), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8535), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8534), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8551), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8550), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8565), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8581), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8595), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8611), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8610), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8626), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8625), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8639), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8702), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8718), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8758), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8824), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8838), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8883), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8898), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8897), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8913), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8929), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8944), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8943), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8959), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8974), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8989), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(8988), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9003), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9002), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9018), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9033), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9074), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9073), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9104), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9119), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9118), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9133), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9164), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9179), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9178), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9208), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9224), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9237), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9253), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9252), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9268), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9282), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9281), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9297), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9296), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9310), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9326), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9325), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9389), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9403), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9419), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9418), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9434), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9433), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9463), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9462), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9478), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9477), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9493), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9492), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9506), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9522), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9537), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9536), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9552), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9551), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9565), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9581), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9595), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9610), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9609), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9624), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9668), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9667), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9687), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9686), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9717), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9733), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9732), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9763), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9778), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9777), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9793), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9792), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9823), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9837), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9869), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9899), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9898), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9913), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9927), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9968), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9967), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 711, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6345), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6958), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6964), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6963), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6968), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6972), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6976), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6978), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6982), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6988), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6987), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 15, 6, 25, 10, 709, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "design_evaluation",
                table: "scenario_designs");

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3230), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3227), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3267), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3283), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3281), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3300), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3315), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3330), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3329), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3344), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3343), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3397), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3426), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3425), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3440), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3468), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3482), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3501), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3500), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3531), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3530), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3546), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3558), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3574), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3573), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3602), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3601), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3615), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3682), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3697), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3739), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3738), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3783), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3798), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3797), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3827), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3826), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3840), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3855), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3854), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3869), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3883), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3882), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3897), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3935), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3934), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3951), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3966), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(3993), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4008), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4023), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4037), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4051), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4065), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4079), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4078), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4093), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4108), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4121), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4136), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4135), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4164), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4179), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4213), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4231), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4245), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4244), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4260), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4259), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4275), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4289), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4304), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4303), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4318), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4332), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4331), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4359), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4374), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4373), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4387), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4401), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4416), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4415), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4488), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4487), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4558), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4557), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4572), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4587), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4602), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4601), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4630), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4629), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4643), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4658), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4673), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4687), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4686), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4729), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4743), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4742), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4757), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4756), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4791), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4809), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4824), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4837), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4836), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4851), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4866), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4865), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4880), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4894), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4908), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4907), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4922), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4936), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4935), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4949), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4964), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4978), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4977), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4993), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5020), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5019), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5049), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5048), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5087), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5102), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5101), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5116), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5115), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5172), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5172), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5186), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5201), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5214), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5229), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5228), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5244), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5271), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5287), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5286), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5344), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5359), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5373), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5372), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5414), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5429), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5428), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5443), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5442), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5457), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5472), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5471), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5498), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5513), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5512), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5527), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5540), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5557), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5624), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5623), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5651), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5693), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5723), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5750), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5764), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5779), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5778), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5809), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5807), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5823), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5822), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5903), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5902), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5917), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5931), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5945), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5944), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5959), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5972), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5987), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(5986), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6001), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6014), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6029), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6043), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6058), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6057), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6072), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6072), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6087), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6085), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6128), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6163), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6179), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6208), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6207), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6236), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6263), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6292), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6321), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6320), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6349), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6376), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6404), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6439), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6456), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6455), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6469), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6483), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6498), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6513), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6512), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6527), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6526), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6541), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 512, DateTimeKind.Unspecified).AddTicks(6540), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(4711), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(4222), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5195), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5204), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5203), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5206), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5205), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5208), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5207), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5213), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5212), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5214), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5217), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5222), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5222), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5225), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5224), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5229), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 12, 7, 19, 6, 510, DateTimeKind.Unspecified).AddTicks(5228), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
