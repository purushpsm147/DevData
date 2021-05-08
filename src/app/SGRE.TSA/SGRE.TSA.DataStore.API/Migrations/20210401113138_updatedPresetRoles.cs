using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class updatedPresetRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 1, "shuofei.cai@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 4, "carlos.mendez@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 7, "carlos.sanabria@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 6, "elizabet.zaharieva@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 27,
                column: "region_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 5, 14, "lars.nissen@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 14, "tongbo.zhang@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 4, 14, "ana.hoyo@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 14, "maria.iturralde@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 14, "justo.tirado@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "justo.tirado@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "shanmuga.palanisamy@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "tanja.stahmer@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "liqiang.xu@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "juliana.diniz@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "carlos.vildosola@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "charles.keyser@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "rodrigo.xambre@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "velmurugan.sundaram@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 9, "oliver.kohn@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 4, 9, "urko.sarasola@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 9, "miguel.diaz@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 9, "charles.keyser@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 2, 9, "rodrigo.xambre@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 3, 9, "karthik.arumugam@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 5, 10, "oliver.kohn@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 10, "waqar.hussain@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 4, 10, "enrique.carballo@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 10, "ines.zalacain@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 10, "paul.smith@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 2, 10, "sandro.patella@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 3, 10, "manikandan.gurumoorthy@siemensgamesa.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 5, "roberto.decastro.c@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 1, "shuofei.cai@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 1, "zongying.zhao@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "region_id", "user_name" },
                values: new object[] { 4, "carlos.mendez@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 27,
                column: "region_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 7, "carlos.sanabria@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 7, "roberto.decastro@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 7, "elizabet.zaharieva@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 7, "domenico.barger@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 2, 7, "" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 7, "domenico.barger@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 7, "" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "lars.nissen@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "tongbo.zhang@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "ana.hoyo@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "maria.iturralde@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "justo.tirado@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "justo.tirado@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 14, "shanmuga.palanisamy@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "role_id", "user_name" },
                values: new object[] { 8, "tanja.stahmer@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 8, "guoxin.zhang.gz@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 8, "liqiang.xu@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 4, 8, "juliana.diniz@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 4, 8, "urko.sarasola@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 7, 8, "carlos.vildosola@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 8, "charles.keyser@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 8, "richard.cherry@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 6, 8, "klinton.burkett@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 2, 8, "rodrigo.xambre@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 3, 8, "velmurugan.sundaram@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 5, 9, "oliver.kohn@siemensgamesa.com" });

            migrationBuilder.UpdateData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "region_id", "role_id", "user_name" },
                values: new object[] { 1, 9, "" });

            migrationBuilder.InsertData(
                table: "preset_roles",
                columns: new[] { "id", "region_id", "role_id", "user_name" },
                values: new object[,]
                {
                    { 65, 2, 10, "sandro.patella@siemensgamesa.com" },
                    { 64, 6, 10, "paul.smith@siemensgamesa.com" },
                    { 63, 7, 10, "ines.zalacain@siemensgamesa.com" },
                    { 62, 4, 10, "enrique.carballo@siemensgamesa.com" },
                    { 61, 1, 10, "waqar.hussain@siemensgamesa.com" },
                    { 60, 5, 10, "oliver.kohn@siemensgamesa.com" },
                    { 59, 3, 9, "karthik.arumugam@siemensgamesa.com" },
                    { 58, 2, 9, "rodrigo.xambre@siemensgamesa.com" },
                    { 57, 6, 9, "charles.keyser@siemensgamesa.com" },
                    { 56, 7, 9, "miguel.diaz@siemensgamesa.com" },
                    { 66, 3, 10, "manikandan.gurumoorthy@siemensgamesa.com" },
                    { 55, 4, 9, "urko.sarasola@siemensgamesa.com" }
                });
        }
    }
}
