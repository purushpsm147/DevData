using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class RemovedSeedPresetRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "preset_roles",
                keyColumn: "id",
                keyValue: 54);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "preset_roles",
                columns: new[] { "id", "region_id", "role_id", "user_name" },
                values: new object[,]
                {
                    { 1, 5, 3, "georg.bischof@siemensgamesa.com" },
                    { 30, 4, 14, "ana.hoyo@siemensgamesa.com" },
                    { 31, 7, 14, "maria.iturralde@siemensgamesa.com" },
                    { 32, 6, 14, "justo.tirado@siemensgamesa.com" },
                    { 33, 2, 14, "justo.tirado@siemensgamesa.com" },
                    { 34, 3, 14, "shanmuga.palanisamy@siemensgamesa.com" },
                    { 35, 5, 8, "tanja.stahmer@siemensgamesa.com" },
                    { 36, 1, 8, "liqiang.xu@siemensgamesa.com" },
                    { 37, 4, 8, "juliana.diniz@siemensgamesa.com" },
                    { 38, 7, 8, "carlos.vildosola@siemensgamesa.com" },
                    { 39, 6, 8, "charles.keyser@siemensgamesa.com" },
                    { 40, 2, 8, "rodrigo.xambre@siemensgamesa.com" },
                    { 41, 3, 8, "velmurugan.sundaram@siemensgamesa.com" },
                    { 42, 5, 9, "oliver.kohn@siemensgamesa.com" },
                    { 43, 4, 9, "urko.sarasola@siemensgamesa.com" },
                    { 44, 7, 9, "miguel.diaz@siemensgamesa.com" },
                    { 45, 6, 9, "charles.keyser@siemensgamesa.com" },
                    { 46, 2, 9, "rodrigo.xambre@siemensgamesa.com" },
                    { 47, 3, 9, "karthik.arumugam@siemensgamesa.com" },
                    { 48, 5, 10, "oliver.kohn@siemensgamesa.com" },
                    { 49, 1, 10, "waqar.hussain@siemensgamesa.com" },
                    { 50, 4, 10, "enrique.carballo@siemensgamesa.com" },
                    { 51, 7, 10, "ines.zalacain@siemensgamesa.com" },
                    { 52, 6, 10, "paul.smith@siemensgamesa.com" },
                    { 29, 1, 14, "tongbo.zhang@siemensgamesa.com" },
                    { 28, 5, 14, "lars.nissen@siemensgamesa.com" },
                    { 27, 2, 7, "domenico.barger@siemensgamesa.com" },
                    { 26, 6, 7, "elizabet.zaharieva@siemensgamesa.com" },
                    { 2, 1, 3, "carlos.sastre@siemensgamesa.com" },
                    { 3, 4, 3, "brenda.rodriguez@siemensgamesa.com" },
                    { 4, 7, 3, "jason.saizar@siemensgamesa.com" },
                    { 5, 6, 3, "luisa.vidal@siemensgamesa.com" },
                    { 6, 2, 3, "renan.venturini@siemensgamesa.com" },
                    { 7, 3, 3, "teddy.chandrakumar@siemensgamesa.com" },
                    { 8, 5, 4, "henning.mentz@siemensgamesa.com" },
                    { 9, 1, 4, "shi.xiujuan@siemensgamesa.com" },
                    { 10, 4, 4, "rene.hernandez@siemensgamesa.com" },
                    { 11, 7, 4, "maged.mostafa@siemensgamesa.com" },
                    { 12, 6, 4, "roberto.lozano@siemensgamesa.com" },
                    { 53, 2, 10, "sandro.patella@siemensgamesa.com" },
                    { 13, 2, 4, "lucas.oyamada@siemensgamesa.com" },
                    { 15, 5, 6, "ingelise.nielsen@siemensgamesa.com" },
                    { 16, 1, 6, "fernando.vital@siemensgamesa.com" },
                    { 17, 4, 6, "mikel.cenoz@siemensgamesa.com" },
                    { 18, 7, 6, "cristina.valencia.r@siemensgamesa.com" },
                    { 19, 6, 6, "eddie.rijo@siemensgamesa.com" },
                    { 20, 2, 6, "mikel.cenoz@siemensgamesa.com" },
                    { 21, 3, 6, "fernando.vital@siemensgamesa.com" },
                    { 22, 5, 7, "julieelaine.lherbier@siemensgamesa.com" },
                    { 23, 1, 7, "shuofei.cai@siemensgamesa.com" },
                    { 24, 4, 7, "carlos.mendez@siemensgamesa.com" },
                    { 25, 7, 7, "carlos.sanabria@siemensgamesa.com" },
                    { 14, 3, 4, "teddy.chandrakumar@siemensgamesa.com" },
                    { 54, 3, 10, "manikandan.gurumoorthy@siemensgamesa.com" }
                });
        }
    }
}
