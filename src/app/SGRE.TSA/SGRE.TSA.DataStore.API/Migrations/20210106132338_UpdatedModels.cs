using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3227), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3218), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3425), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3423), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3449), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3465), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3479), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3531), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3529), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3549), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3547), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3605), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3630), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3644), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3671), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4011), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4037), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4051), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4051), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4090), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4118), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4133), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4146), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4145), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4160), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4173), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4187), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4186), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4217), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4232), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4232), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4246), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4246), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4261), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4260), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4426), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4439), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4537), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4564), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4563), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4591), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4604), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4618), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4633), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4647), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4646), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4660), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4673), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4687), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4686), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4727), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4755), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4793), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4792), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4807), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4822), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4836), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4849), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4877), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4892), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4919), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4932), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4945), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4960), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4959), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4974), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4973), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4987), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(4986), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5016), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5056), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5055), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5097), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5112), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5127), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5141), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5155), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5169), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5168), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5183), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5197), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5210), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5224), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5223), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5238), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5237), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5252), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5265), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5279), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5278), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5292), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5438), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5454), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5453), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5468), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5467), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5482), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5481), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5495), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5509), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5508), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5523), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5522), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5549), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5563), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5563), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5577), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5591), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5631), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5725), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5766), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5779), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5778), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5792), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5807), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5861), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5875), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5875), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5889), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5903), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5902), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5917), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5955), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5968), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5982), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5996), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(5995), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6009), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6037), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6051), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6050), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6064), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6077), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6105), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6104), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6152), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6168), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6184), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6198), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6211), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6225), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6224), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6238), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6238), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6251), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6279), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6293), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6292), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6320), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6333), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6347), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6346), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6375), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6374), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6388), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6387), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6441), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6455), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6454), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6467), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6482), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6496), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6495), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6509), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6509), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6523), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6522), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6536), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6535), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6564), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6563), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6604), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6603), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6618), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6632), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6631), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6646), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6645), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6752), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6781), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6794), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6793), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6807), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6821), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6834), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6861), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6875), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6874), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6889), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6943), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6957), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6957), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7008), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7007), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7035), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7049), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7048), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7076), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7075), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7090), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7103), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7102), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7117), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7116), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 143, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3477), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(2790), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3985), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3993), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3995), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3998), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4002), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4005), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4006), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4008), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4012), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4011), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4014), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4018), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 23, 38, 141, DateTimeKind.Unspecified).AddTicks(4017), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2682), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2884), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2908), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2907), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2939), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2958), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2973), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2972), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3017), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3016), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3031), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3030), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3045), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3136), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3151), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3166), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3183), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3198), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3213), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3228), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3227), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3242), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3255), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3271), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3284), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3298), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3312), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3328), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3327), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3341), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3355), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3409), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3424), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3423), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3468), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3482), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3497), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3496), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3511), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3510), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3525), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3524), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3538), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3553), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3552), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3582), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3581), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3595), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3610), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3609), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3624), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3674), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3704), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3704), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3733), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3746), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3761), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3760), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3775), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3774), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3789), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3804), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3803), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3819), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3818), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3832), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3847), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3861), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3875), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3889), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3904), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3919), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3957), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3972), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3987), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(3987), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4002), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4030), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4030), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4054), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4081), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4079), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4161), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4221), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4246), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4272), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4291), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4307), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4364), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4379), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4408), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4407), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4422), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4421), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4450), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4464), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4494), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4493), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4535), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4564), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4580), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4579), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4594), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4607), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4648), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4647), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4662), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4677), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4706), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4705), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4734), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4763), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4777), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4776), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4791), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4806), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4820), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4819), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4834), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4850), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4849), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4864), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4877), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4892), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4947), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4974), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5004), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5003), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5031), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5046), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5045), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5059), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5075), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5090), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5089), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5108), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5107), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5122), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5121), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5186), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5201), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5217), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5231), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5230), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5244), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5287), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5286), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5340), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5339), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5359), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5373), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5372), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5429), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5444), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5443), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5457), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5472), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5471), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5485), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5500), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5514), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5513), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5527), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5542), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5569), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5568), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5583), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5582), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5597), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5635), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5651), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5695), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5723), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5766), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5781), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5794), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5810), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5809), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5824), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5823), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5866), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5865), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5880), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5879), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5918), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5917), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5934), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5933), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5949), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5948), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5963), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5978), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5977), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6007), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6020), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6035), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6050), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6049), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6064), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6079), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6093), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6122), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6121), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6136), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6165), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6203), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6202), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6219), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6233), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6247), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6263), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6276), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6292), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6305), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6320), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6320), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6349), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6378), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 473, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(3571), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(3065), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4124), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4123), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4126), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4163), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4169), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4168), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4173), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4172), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4177), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4182), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4184), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4187), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "project_modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4192), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 6, 13, 4, 24, 471, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
