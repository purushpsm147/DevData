using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class addedpresetusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 42,
                column: "user_name",
                value: "stefan.penner@siemensgamesa.com");

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 48,
                column: "user_name",
                value: "stefan.penner@siemensgamesa.com");

            migrationBuilder.InsertData(
                table: "preset_roles",
                columns: new[] { "id", "region_id", "role_id", "user_name" },
                values: new object[,]
                {
                    { 90, 2, 17, "VANESSA.CAMARA@siemensgamesa.com" },
                    { 91, 3, 17, "srikrishnan.jalendiran@siemensgamesa.com" },
                    { 92, 4, 17, "miguel.leizagoyen@siemensgamesa.com" },
                    { 93, 6, 17, "kevin.kern@siemensgamesa.com" },
                    { 94, 7, 17, "JULIO.ROYO@siemensgamesa.com" },
                    { 95, 5, 17, "stefan.penner@siemensgamesa.com" },
                    { 96, 1, 17, "Benedetto.Gallina@siemensgamesa.com" },
                    { 97, 1, 2, "Benedetto.Gallina@siemensgamesa.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 42,
                column: "user_name",
                value: "oliver.kohn@siemensgamesa.com");

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 48,
                column: "user_name",
                value: "oliver.kohn@siemensgamesa.com");
        }
    }
}
