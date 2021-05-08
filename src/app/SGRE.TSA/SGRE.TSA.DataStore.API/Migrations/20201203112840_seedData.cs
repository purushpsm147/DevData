using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "record_insert_date_time",
                table: "roles",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_modified_date_time",
                table: "roles",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "mile_stones",
                columns: new[] { "id", "last_modified_date_time", "mile_stone_name", "record_insert_date_time" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM020 - Bid decision", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM070 - Contract signature", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM080 - Notice to proceed", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Certification Target", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM650 - Take-over to customer", null }
                });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "region_name" },
                values: new object[,]
                {
                    { 1, "APAC" },
                    { 2, "BRAZIL" },
                    { 3, "INDIA" },
                    { 4, "LATAM" },
                    { 5, "NE&ME" },
                    { 6, "NORTH AMERICA" },
                    { 7, "SE&A" }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time", "role_name" },
                values: new object[] { null, null, "Opportunity Owner / Sales Manger" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "country_name", "region_id" },
                values: new object[,]
                {
                    { 1, "China", 1 },
                    { 96, "USA", 6 },
                    { 95, "Bahrain", 5 },
                    { 94, "Faroe Islands", 5 },
                    { 93, "Montenegro", 5 },
                    { 92, "Armenia", 5 },
                    { 91, "Latvia", 5 },
                    { 90, "Estonia", 5 },
                    { 89, "Iceland", 5 },
                    { 88, "Lithuania", 5 },
                    { 87, "Belarus", 5 },
                    { 86, "Yemen", 5 },
                    { 85, "Czech Republic", 5 },
                    { 84, "Kuwait", 5 },
                    { 83, "Luxembourg", 5 },
                    { 82, "Macedonia", 5 },
                    { 81, "Syrian Arab Republic", 5 },
                    { 80, "Georgia", 5 },
                    { 79, "Switzerland", 5 },
                    { 78, "Oman", 5 },
                    { 77, "Austria", 5 },
                    { 76, "Albania", 5 },
                    { 75, "Hungary", 5 },
                    { 74, "Netherlands", 5 },
                    { 73, "Slovenia", 5 },
                    { 72, "Kazakhstan", 5 },
                    { 71, "Lebanon", 5 },
                    { 70, "Israel", 5 },
                    { 69, "Bosnia-Herz.", 5 },
                    { 68, "Russian Fed.", 5 },
                    { 97, "Canada", 6 },
                    { 67, "Iran Islamic Republic of", 5 },
                    { 98, "France", 7 },
                    { 100, "Greece", 7 },
                    { 129, "Libya", 7 },
                    { 128, "Nigeria", 7 },
                    { 127, "Uganda", 7 },
                    { 126, "Guinea", 7 },
                    { 125, "Ivory Coast", 7 },
                    { 124, "Tanzania", 7 },
                    { 123, "Tunisia", 7 },
                    { 122, "Algeria", 7 },
                    { 121, "Mozambique", 7 },
                    { 120, "Sudan", 7 },
                    { 119, "Mauritania", 7 },
                    { 118, "Djibouti", 7 },
                    { 117, "Portugal", 7 },
                    { 116, "Gambia", 7 },
                    { 115, "Namibia", 7 },
                    { 114, "Cyprus", 7 },
                    { 113, "Ethiopia", 7 },
                    { 112, "Senegal", 7 },
                    { 111, "Zambia", 7 },
                    { 110, "Jordan", 7 },
                    { 109, "Togo", 7 },
                    { 108, "Angola", 7 },
                    { 107, "Kenya", 7 },
                    { 106, "Mauritius", 7 },
                    { 105, "Ghana", 7 },
                    { 104, "Italy", 7 },
                    { 103, "South Africa", 7 },
                    { 102, "Egypt", 7 },
                    { 101, "Morocco", 7 },
                    { 99, "Spain", 7 },
                    { 130, "Cabo Verde", 7 },
                    { 66, "Moldovia", 5 },
                    { 64, "Turkey", 5 },
                    { 30, "Belize", 4 },
                    { 29, "Colombia", 4 },
                    { 28, "Uruguay", 4 },
                    { 27, "Chile", 4 },
                    { 26, "Panama", 4 },
                    { 25, "Argentina", 4 },
                    { 24, "Dominican Rep.", 4 },
                    { 23, "Peru", 4 },
                    { 22, "Mexico", 4 },
                    { 21, "Brazil", 4 },
                    { 20, "Bangladesh", 3 },
                    { 19, "Sri Lanka", 3 },
                    { 18, "India", 3 },
                    { 17, "Brazil", 2 },
                    { 16, "Laos", 1 },
                    { 15, "Cambodia", 1 },
                    { 14, "New Caledonia", 1 },
                    { 13, "Myanmar", 1 },
                    { 12, "Thailand", 1 },
                    { 11, "Mongolia", 1 },
                    { 10, "Pakistan", 1 },
                    { 9, "Taiwan", 1 },
                    { 8, "Indonesia", 1 },
                    { 7, "Philippines", 1 },
                    { 6, "New Zealand", 1 },
                    { 5, "Vietnam", 1 },
                    { 4, "Australia", 1 },
                    { 3, "South Korea", 1 },
                    { 2, "Japan", 1 },
                    { 31, "Nicaragua", 4 },
                    { 65, "Norway", 5 },
                    { 32, "Jamaica", 4 },
                    { 34, "Honduras", 4 },
                    { 63, "Azerbaijan", 5 },
                    { 62, "Bulgaria", 5 },
                    { 61, "Ukraine", 5 },
                    { 60, "Utd Arab Emir.", 5 },
                    { 59, "Denmark", 5 },
                    { 58, "Saudi Arabia", 5 },
                    { 57, "Poland", 5 },
                    { 56, "United Kingdom", 5 },
                    { 55, "Serbia", 5 },
                    { 54, "Uzbekistan", 5 },
                    { 53, "Belgium", 5 },
                    { 52, "Finland", 5 },
                    { 51, "Croatia", 5 },
                    { 50, "Romania", 5 },
                    { 49, "Germany", 5 },
                    { 48, "Sweden", 5 },
                    { 47, "Ireland", 5 },
                    { 46, "Barbados", 4 },
                    { 45, "Bolivia", 4 },
                    { 44, "Bahamas", 4 },
                    { 43, "Trinidad Tobago", 4 },
                    { 42, "Puerto Rico", 4 },
                    { 41, "Guadeloupe", 4 },
                    { 40, "Ecuador", 4 },
                    { 39, "Guyana", 4 },
                    { 38, "Dominica", 4 },
                    { 37, "Cuba", 4 },
                    { 36, "El Salvador", 4 },
                    { 35, "Costa Rica", 4 },
                    { 33, "Guatemala", 4 },
                    { 131, "Lesotho", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "mile_stones",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "record_insert_date_time",
                table: "roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_modified_date_time",
                table: "roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "last_modified_date_time", "record_insert_date_time", "role_name" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales Manger" });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "last_modified_date_time", "record_insert_date_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
