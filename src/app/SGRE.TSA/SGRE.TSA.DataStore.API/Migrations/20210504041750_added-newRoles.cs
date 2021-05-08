using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addednewRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                column: "role_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 2, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 3, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 3, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 3, 4, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 3, 4, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 3, 4, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 5, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 5, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 5, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 6, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 6, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 6, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 6, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 6, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 7, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 7, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 8, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 8, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 9, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 9, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 10, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 10, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 11, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 11, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 11, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 12, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 12, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 12, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "id", "created_by", "last_modified_date_time", "permission_type", "project_module_id", "record_insert_date_time", "role_id", "updated_by" },
                values: new object[,]
                {
                    { 220, "admin@siemensgamesa.com", null, 1, 13, null, 16, "admin@siemensgamesa.com" },
                    { 219, "admin@siemensgamesa.com", null, 1, 13, null, 15, "admin@siemensgamesa.com" },
                    { 218, "admin@siemensgamesa.com", null, 1, 13, null, 14, "admin@siemensgamesa.com" },
                    { 217, "admin@siemensgamesa.com", null, 1, 13, null, 13, "admin@siemensgamesa.com" },
                    { 216, "admin@siemensgamesa.com", null, 1, 13, null, 12, "admin@siemensgamesa.com" },
                    { 215, "admin@siemensgamesa.com", null, 1, 13, null, 11, "admin@siemensgamesa.com" },
                    { 214, "admin@siemensgamesa.com", null, 1, 13, null, 10, "admin@siemensgamesa.com" },
                    { 213, "admin@siemensgamesa.com", null, 1, 13, null, 9, "admin@siemensgamesa.com" },
                    { 212, "admin@siemensgamesa.com", null, 1, 13, null, 8, "admin@siemensgamesa.com" },
                    { 211, "admin@siemensgamesa.com", null, 1, 13, null, 7, "admin@siemensgamesa.com" },
                    { 210, "admin@siemensgamesa.com", null, 1, 13, null, 6, "admin@siemensgamesa.com" },
                    { 209, "admin@siemensgamesa.com", null, 1, 13, null, 5, "admin@siemensgamesa.com" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "active_record_indicator", "created_by", "last_modified_date_time", "record_insert_date_time", "role_description", "role_name", "updated_by" },
                values: new object[] { 17, null, "admin@siemensgamesa.com", null, null, "", "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", "admin@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 1, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 2, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 3, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 3, 4, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 5, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 6, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 17 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 17 });

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "id", "created_by", "last_modified_date_time", "permission_type", "project_module_id", "record_insert_date_time", "role_id", "updated_by" },
                values: new object[] { 221, "admin@siemensgamesa.com", null, 1, 13, null, 17, "admin@siemensgamesa.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 18,
                column: "role_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 20,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 21,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 22,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 23,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 24,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 25,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 26,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 27,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 28,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 29,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 30,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 31,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 32,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 37,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 38,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 39,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 40,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 41,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 42,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 43,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 44,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 45,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 46,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 47,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 48,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 54,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 55,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 56,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 57,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 58,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 59,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 60,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 61,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 62,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 63,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 64,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 5, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 5, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 5, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 1, 5, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 71,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 72,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 73,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 74,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 75,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 76,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 77,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 78,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 79,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 80,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 6, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 6, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 89,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 90,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 91,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 92,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 94,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 95,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 96,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 7, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 7, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 105,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 107,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 108,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 109,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 110,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 111,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 8, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 8, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 8, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 122,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 123,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 124,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 125,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 126,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 127,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 128,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 9, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 9, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 139,
                column: "role_id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 140,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 141,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 142,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 143,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 144,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 10, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 10, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 156,
                column: "role_id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 157,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 158,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 159,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 160,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 11, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 11, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 11, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 173,
                column: "role_id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 174,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 175,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 176,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 12, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 12, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 12, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 190,
                column: "role_id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 192,
                column: "role_id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 13, 1 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 13, 2 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "permission_type", "project_module_id", "role_id" },
                values: new object[] { 2, 13, 4 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 5 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 6 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 7 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 8 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 9 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 10 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 11 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "project_module_id", "role_id" },
                values: new object[] { 13, 12 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 207,
                column: "role_id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "permission_type", "role_id" },
                values: new object[] { 1, 16 });
        }
    }
}
