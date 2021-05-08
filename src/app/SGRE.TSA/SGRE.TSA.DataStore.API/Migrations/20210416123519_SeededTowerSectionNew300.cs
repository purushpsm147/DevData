using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class SeededTowerSectionNew300 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tower_sections",
                columns: new[] { "id", "external_diameter_lower_flange_m", "external_diameter_upper_flange_m", "last_modified_date_time", "record_insert_date_time", "section_height_m", "section_number", "section_type", "total_weight_kg", "tower_type_id" },
                values: new object[,]
                {
                    { 1, 4.262m, 4.199m, null, null, 18.5m, 1, null, 70160.09637m, 14 },
                    { 204, 4.68m, 4.4243m, null, null, 19.22m, 1, null, 66305.3824430877m, 39 },
                    { 203, 4.017m, 3.503m, null, null, 28.85m, 4, null, 50785.5791836895m, 49 },
                    { 202, 4.42m, 4.017m, null, null, 26.29m, 3, null, 50124.8997642959m, 49 },
                    { 201, 4.424m, 4.42m, null, null, 21.115m, 2, null, 53232.9710482851m, 49 },
                    { 200, 4.67m, 4.424m, null, null, 19.245m, 1, null, 66396.1334452749m, 49 },
                    { 199, 4.017m, 3.503m, null, null, 28.85m, 4, null, 49483.7241236153m, 38 },
                    { 205, 4.4243m, 4.4195m, null, null, 21.09m, 2, null, 53794.85m, 39 },
                    { 198, 4.422m, 4.017m, null, null, 26.26m, 3, null, 53955.8730315744m, 38 },
                    { 196, 4.68m, 4.4265m, null, null, 19.245m, 1, null, 72204.0953826459m, 38 },
                    { 195, 3.9677m, 3.503m, null, null, 25.12m, 4, null, 42060.1897122255m, 37 },
                    { 194, 4.4933m, 3.9677m, null, null, 25.897m, 3, null, 48339.3747381074m, 37 },
                    { 193, 4.4987m, 4.4933m, null, null, 24.545m, 2, null, 60834.1143942121m, 37 },
                    { 192, 4.5m, 4.4987m, null, null, 17.94m, 1, null, 63177.6783549432m, 37 },
                    { 191, 3.9607m, 3.503m, null, null, 25.08m, 4, null, 42970.7592045565m, 36 },
                    { 197, 4.4265m, 4.422m, null, null, 21.115m, 2, null, 56613.2646016834m, 38 },
                    { 206, 4.4195m, 4.0159m, null, null, 26.29m, 3, null, 51346.75m, 39 },
                    { 207, 4.0159m, 3.503m, null, null, 28.9m, 4, null, 47361.9m, 39 },
                    { 208, 4.7m, 4.7m, null, null, 14.3m, 1, null, 84033.4947944777m, 15 },
                    { 223, 4.8m, 4.8m, null, null, 11.78m, 1, null, 86803.6350635777m, 17 },
                    { 222, 4.021m, 3.503m, null, null, 29.97m, 5, null, 63863.1m, 1 },
                    { 221, 4.427m, 4.021m, null, null, 26.88m, 4, null, 71770.5m, 1 },
                    { 220, 4.436m, 4.427m, null, null, 23.8m, 3, null, 84548.3m, 1 },
                    { 219, 4.7m, 4.436m, null, null, 18.2m, 2, null, 84327.8m, 1 },
                    { 218, 4.7m, 4.7m, null, null, 13.564m, 1, null, 84958.3m, 1 },
                    { 217, 4.1m, 3.503m, null, null, 21.85m, 6, null, 49717.4066320377m, 16 },
                    { 216, 4.495m, 4.1m, null, null, 21m, 5, null, 48049.1739479351m, 16 },
                    { 215, 4.495m, 4.495m, null, null, 17.64m, 4, null, 53453.9855480734m, 16 },
                    { 214, 4.5m, 4.495m, null, null, 15.12m, 3, null, 57634.6886985659m, 16 },
                    { 213, 4.2958m, 4.5m, null, null, 14.84m, 2, null, 69796.9764825352m, 16 },
                    { 212, 4.5m, 4.2966m, null, null, 8.464m, 1, null, 61269.3138433361m, 16 },
                    { 211, 4.493m, 3.503m, null, null, 34.45m, 4, null, 75793.067628854m, 15 },
                    { 210, 4.493m, 4.493m, null, null, 26.88m, 3, null, 76060.2080594602m, 15 },
                    { 209, 4.7m, 4.493m, null, null, 21.56m, 2, null, 79745.6992286253m, 15 },
                    { 190, 4.494m, 3.9607m, null, null, 25.897m, 3, null, 49500.9413040166m, 36 },
                    { 189, 4.499m, 4.494m, null, null, 24.465m, 2, null, 61419.5343414767m, 36 },
                    { 188, 4.488m, 4.499m, null, null, 18.075m, 1, null, 64128.9600164969m, 36 },
                    { 187, 3.4805m, 3.503m, null, null, 34.5m, 3, null, 57133.5m, 35 },
                    { 167, 4.03m, 4.021m, null, null, 23.3m, 2, null, 60418.619823543m, 33 },
                    { 166, 4.115m, 4.03m, null, null, 16.18m, 1, null, 63639.7299890897m, 33 },
                    { 165, 4.016m, 3.503m, null, null, 36m, 3, null, 59751.3269603374m, 46 },
                    { 164, 4.023m, 4.016m, null, null, 25m, 2, null, 51615.5812938536m, 46 },
                    { 163, 4.27m, 4.023m, null, null, 25m, 1, null, 74771.4611494705m, 46 },
                    { 162, 3.718m, 3.503m, null, null, 30.136m, 3, null, 50320.1m, 5 },
                    { 161, 4.023m, 3.718m, null, null, 25.908m, 2, null, 53782.6m, 5 },
                    { 160, 4.115m, 4.0225m, null, null, 21.456m, 1, null, 66008.5m, 5 },
                    { 159, 3.918m, 3.503m, null, null, 27m, 2, null, 45195.8603005768m, 55 },
                    { 158, 4.424m, 3.918m, null, null, 27m, 1, null, 58359.7185850936m, 55 },
                    { 157, 4.02m, 3.503m, null, null, 29.5m, 8, null, 51645.4m, 10 },
                    { 156, 4.623m, 4.02m, null, null, 22.885m, 7, null, 51385.5m, 10 },
                    { 155, 4.628m, 4.623m, null, null, 21.89m, 6, null, 64304m, 10 },
                    { 154, 4.634m, 4.628m, null, null, 18.18m, 5, null, 68070.3m, 10 },
                    { 153, 5.134m, 4.634m, null, null, 16.8m, 4, null, 70475.5m, 10 },
                    { 168, 4.021m, 4.016m, null, null, 23.52m, 3, null, 45225.0396496481m, 33 },
                    { 224, 4.8m, 4.793m, null, null, 17.92m, 2, null, 84643.7394897317m, 17 },
                    { 169, 4.016m, 3.503m, null, null, 25m, 4, null, 43367.4964621935m, 33 },
                    { 171, 4.03m, 4.023m, null, null, 23.96m, 2, null, 65562.9877836514m, 47 },
                    { 186, 4.2235m, 3.4805m, null, null, 29.26m, 2, null, 62966.5m, 35 },
                    { 185, 4.47m, 4.2235m, null, null, 25.072m, 1, null, 78556.7m, 35 },
                    { 184, 3.481m, 3.503m, null, null, 34.5m, 3, null, 58854.6295949268m, 34 },
                    { 183, 4.224m, 3.481m, null, null, 29.26m, 2, null, 65774.3134468638m, 34 },
                    { 182, 4.47m, 4.224m, null, null, 25.072m, 1, null, 79335.3375567185m, 34 },
                    { 181, 4.0167m, 3.503m, null, null, 25m, 4, null, 41491.5666858333m, 6 },
                    { 180, 4.1m, 4.0167m, null, null, 23.52m, 3, null, 44807.6526008422m, 6 },
                    { 179, 4.1065m, 4.1m, null, null, 23.3m, 2, null, 57553.4559157892m, 6 },
                    { 178, 4.115m, 4.1065m, null, null, 16.18m, 1, null, 60050.0704076508m, 6 },
                    { 177, 4.017m, 3.503m, null, null, 26.65m, 4, null, 46946.6174713076m, 48 },
                    { 176, 4.02m, 4.017m, null, null, 21.1m, 3, null, 39418.7407352051m, 48 },
                    { 175, 4.026m, 4.02m, null, null, 21m, 2, null, 51482.2975777187m, 48 },
                    { 174, 4.27m, 4.026m, null, null, 19.25m, 1, null, 64407.3720298972m, 48 },
                    { 173, 4.017m, 3.503m, null, null, 25m, 4, null, 44174.9829034144m, 47 },
                    { 172, 4.023m, 4.017m, null, null, 21m, 3, null, 41116.4960012798m, 47 },
                    { 170, 4.278m, 4.03m, null, null, 18.04m, 1, null, 70837.1383408913m, 47 },
                    { 152, 5.533m, 5.134m, null, null, 16.485m, 3, null, 74094.4m, 10 },
                    { 225, 4.793m, 4.793m, null, null, 21.84m, 3, null, 81555.6325105242m, 17 },
                    { 227, 4.793m, 3.503m, null, null, 32.77m, 5, null, 72511.7998306351m, 17 },
                    { 279, 4.5m, 4.4m, null, null, 23.8m, 3, null, 89933.2343573664m, 28 },
                    { 278, 4.5m, 4.5m, null, null, 19.04m, 2, null, 90738.2418588968m, 28 },
                    { 277, 4.5m, 4.5m, null, null, 13.18m, 1, null, 89293.0347345852m, 28 },
                    { 276, 4.3m, 3.503m, null, null, 29.97m, 5, null, 60725.344691474m, 27 },
                    { 275, 4.493m, 4.3m, null, null, 29.96m, 4, null, 73543.0481950945m, 27 },
                    { 274, 4.493m, 4.493m, null, null, 23.52m, 3, null, 81159.1932835383m, 27 },
                    { 280, 4.4m, 4.4m, null, null, 29.96m, 4, null, 79262.1578360013m, 28 },
                    { 273, 4.3005m, 4.493m, null, null, 18.48m, 2, null, 80482.3936020138m, 27 },
                    { 271, 4.418m, 3.503m, null, null, 26.035m, 5, null, 52302.763422907m, 26 },
                    { 270, 4.792m, 4.418m, null, null, 26.6m, 4, null, 64534.2240527795m, 26 },
                    { 269, 4.798m, 4.792m, null, null, 24.36m, 3, null, 75953.0104706682m, 26 },
                    { 268, 4.8m, 4.798m, null, null, 19.88m, 2, null, 80331.5980756746m, 26 },
                    { 267, 4.8m, 4.8m, null, null, 14.039m, 1, null, 80500.9400227107m, 26 },
                    { 266, 4.8m, 3.503m, null, null, 35.85m, 4, null, 74744.2052296635m, 25 },
                    { 272, 4.5m, 4.3075m, null, null, 12.91m, 1, null, 79517.061653161m, 27 },
                    { 281, 4.4m, 3.503m, null, null, 32.21m, 5, null, 65218.8593310267m, 28 },
                    { 282, 4.8m, 4.8m, null, null, 14.342m, 1, null, 84512.9720195517m, 4 },
                    { 283, 4.8m, 4.8m, null, null, 19.368m, 2, null, 81456.6195681442m, 4 },
                    { 298, 4.493m, 4.493m, null, null, 22.68m, 2, null, 69556.9930113774m, 23 },
                    { 297, 4.7m, 4.493m, null, null, 14.86m, 1, null, 70416.8186489412m, 23 },
                    { 296, 4.018m, 3.503m, null, null, 27m, 3, null, 50776.7330337871m, 32 },
                    { 295, 4.2945m, 4.018m, null, null, 23.335m, 2, null, 51182.8594250054m, 32 },
                    { 294, 4.3m, 4.2945m, null, null, 21.075m, 1, null, 63073.1577528424m, 32 },
                    { 293, 8.8675m, 4.5275m, null, null, 89.09m, 0, null, 0m, 32 },
                    { 292, 9.8m, 3.503m, null, null, 120.214m, 0, null, 0m, 31 },
                    { 291, 4.691m, 3.503m, null, null, 29.97m, 5, null, 63505.1130089599m, 30 },
                    { 290, 4.691m, 4.691m, null, null, 29.96m, 4, null, 73648.1220461621m, 30 },
                    { 289, 4.69m, 4.691m, null, null, 26.04m, 3, null, 88386.7504356758m, 30 },
                    { 288, 4.4912m, 4.69m, null, null, 20.72m, 2, null, 89339.6508417695m, 30 },
                    { 287, 4.6999m, 4.4912m, null, null, 13.18m, 1, null, 83703.4276702223m, 30 },
                    { 286, 4.099m, 3.574m, null, null, 30m, 5, null, 56744.1481886194m, 4 },
                    { 285, 4.7925m, 4.099m, null, null, 29.977m, 4, null, 70462.435506686m, 4 },
                    { 284, 4.8m, 4.7925m, null, null, 26.832m, 3, null, 84754.193220052m, 4 },
                    { 265, 4.8m, 4.5m, null, null, 30.24m, 3, null, 79213.5242030428m, 25 },
                    { 264, 4.8m, 4.8m, null, null, 22.4m, 2, null, 78524.4940327805m, 25 },
                    { 263, 4.8m, 4.8m, null, null, 16.24m, 1, null, 80488.9464547731m, 25 },
                    { 262, 4.3m, 3.503m, null, null, 35.85m, 4, null, 72484.8480468829m, 24 },
                    { 242, 5.1m, 4.45m, null, null, 18.48m, 7, null, 50400m, 20 },
                    { 241, 5.75m, 5.1m, null, null, 18.48m, 6, null, 62220m, 20 },
                    { 240, 6.4m, 5.75m, null, null, 18.48m, 5, null, 73260m, 20 },
                    { 239, 6.4m, 6.4m, null, null, 18.2m, 4, null, 83910m, 20 },
                    { 238, 6.4m, 6.4m, null, null, 15.68m, 3, null, 83110m, 20 },
                    { 237, 6.4m, 6.4m, null, null, 14m, 2, null, 82480m, 20 },
                    { 236, 6.4m, 6.4m, null, null, 12.32m, 1, null, 83350m, 20 },
                    { 235, 9.8m, 3.503m, null, null, 132.714m, 0, null, 0m, 19 },
                    { 234, 4.42m, 3.503m, null, null, 26.134m, 6, null, 58393.1812491416m, 2 },
                    { 233, 4.4245m, 4.42m, null, null, 26.88m, 5, null, 68370.7227605146m, 2 },
                    { 232, 4.8285m, 4.4245m, null, null, 24.92m, 4, null, 81538.3639815086m, 2 },
                    { 231, 5.678m, 4.8285m, null, null, 21.28m, 3, null, 84470.304594301m, 2 },
                    { 230, 5.682m, 5.678m, null, null, 18.2m, 2, null, 84192.4713934607m, 2 },
                    { 229, 6m, 5.682m, null, null, 15m, 1, null, 91066.3100295192m, 2 },
                    { 228, 8.36m, 3.503m, null, null, 112.714m, 0, null, 0m, 18 },
                    { 243, 4.45m, 3.503m, null, null, 26.89m, 8, null, 64480m, 20 },
                    { 226, 4.793m, 4.793m, null, null, 28m, 4, null, 77286.0411902622m, 17 },
                    { 244, 6.6m, 6.575m, null, null, 12.32m, 1, null, 83980m, 21 },
                    { 246, 6.575m, 6.575m, null, null, 14.56m, 3, null, 82350m, 21 },
                    { 261, 4.3m, 4.3m, null, null, 29.96m, 3, null, 81066.7088325924m, 24 },
                    { 260, 4.355m, 4.3m, null, null, 20.72m, 2, null, 79695.7011241759m, 24 },
                    { 259, 4.3691m, 4.355m, null, null, 13.18m, 1, null, 82880.3038918576m, 24 },
                    { 258, 3.5566m, 3.574m, null, null, 33.61m, 4, null, 66933.010559683m, 3 },
                    { 257, 4.427m, 3.5566m, null, null, 27.16m, 3, null, 68693.0094576569m, 3 },
                    { 256, 4.433m, 4.427m, null, null, 22.68m, 2, null, 76299.2963693753m, 3 },
                    { 255, 4.7m, 4.433m, null, null, 16.464m, 1, null, 79354.8890943096m, 3 },
                    { 254, 4.289m, 3.503m, null, null, 36m, 3, null, 72291.1653659468m, 22 },
                    { 253, 4.3m, 4.289m, null, null, 27.77m, 2, null, 83158.0668577359m, 22 },
                    { 252, 9.2875m, 4.5275m, null, null, 98.944m, 0, null, 0m, 22 },
                    { 251, 4.44m, 3.503m, null, null, 29.97m, 8, null, 70760m, 21 },
                    { 250, 5.376m, 4.44m, null, null, 28.84m, 7, null, 83270m, 21 },
                    { 249, 5.975m, 5.376m, null, null, 18.48m, 6, null, 70170m, 21 },
                    { 248, 6.575m, 6.575m, null, null, 18.48m, 5, null, 80910m, 21 },
                    { 247, 6.575m, 6.575m, null, null, 16.24m, 4, null, 82980m, 21 },
                    { 245, 6.575m, 6.575m, null, null, 13.44m, 2, null, 82320m, 21 },
                    { 151, 5.77m, 5.533m, null, null, 16.48m, 2, null, 78193.4m, 10 },
                    { 150, 5.77m, 5.77m, null, null, 13.28m, 1, null, 80912.7m, 10 },
                    { 149, 4.287m, 3.503m, null, null, 32.42m, 3, null, 59248.2567088075m, 54 },
                    { 53, 4.0182m, 3.503m, null, null, 29.485m, 4, null, 52736.5238022118m, 69 },
                    { 52, 4.4222m, 4.0182m, null, null, 27.46m, 3, null, 59567.7112101046m, 69 },
                    { 51, 4.4297m, 4.4222m, null, null, 24.09m, 2, null, 70365.0974274015m, 69 },
                    { 50, 4.68m, 4.4297m, null, null, 19.465m, 1, null, 79304.2207846251m, 69 },
                    { 49, 3.598m, 3.395m, null, null, 32.25m, 3, null, 48381.3m, 66 },
                    { 48, 4.0225m, 3.598m, null, null, 30m, 2, null, 58971m, 66 },
                    { 54, 4.678m, 4.645m, null, null, 16.62m, 1, null, 77484.4826088329m, 59 },
                    { 47, 4.27m, 4.0225m, null, null, 29.75m, 1, null, 84879m, 66 },
                    { 45, 4.27m, 4.267m, null, null, 26.98m, 4, null, 50409.5541382303m, 68 },
                    { 44, 4.275m, 4.27m, null, null, 26.42m, 3, null, 64327.8423988724m, 68 },
                    { 43, 4.281m, 4.275m, null, null, 24.18m, 2, null, 76535.2184249788m, 68 },
                    { 42, 4.5m, 4.281m, null, null, 18.58m, 1, null, 80926.8655968548m, 68 },
                    { 41, 3.598m, 3.395m, null, null, 31.383m, 4, null, 47074.9987794463m, 67 },
                    { 40, 4.25m, 3.598m, null, null, 27m, 3, null, 49109.3424374901m, 67 },
                    { 46, 4.267m, 3.395m, null, null, 29.34m, 5, null, 48333.6642076774m, 68 },
                    { 55, 4.645m, 4.427m, null, null, 20.54m, 2, null, 71489.0704483512m, 59 },
                    { 56, 4.427m, 4.4205m, null, null, 20.82m, 3, null, 56712.3598603607m, 59 },
                    { 57, 4.4205m, 4.015m, null, null, 22.78m, 4, null, 45698.1919607363m, 59 },
                    { 72, 4.0215m, 3.6174m, null, null, 20.82m, 3, null, 39652.4m, 57 },
                    { 71, 4.0302m, 4.0215m, null, null, 20.82m, 2, null, 54284.1m, 57 },
                    { 70, 4.278m, 4.0302m, null, null, 16.62m, 1, null, 64077.2m, 57 },
                    { 69, 3.6174m, 3.503m, null, null, 23.74m, 4, null, 39526.4565551635m, 11 },
                    { 68, 4.0221m, 3.6174m, null, null, 20.82m, 3, null, 40944.2928282642m, 11 },
                    { 67, 4.0305m, 4.0221m, null, null, 20.82m, 2, null, 56614.9899728068m, 11 },
                    { 66, 4.278m, 4.032m, null, null, 16.62m, 1, null, 64903.8064636172m, 11 },
                    { 65, 3.617m, 3.503m, null, null, 23.74m, 4, null, 41590.645453645m, 56 },
                    { 64, 4.023m, 3.617m, null, null, 20.82m, 3, null, 42107.8551723855m, 56 },
                    { 63, 4.032m, 4.023m, null, null, 20.82m, 2, null, 59192.004867504m, 56 },
                    { 62, 4.278m, 4.032m, null, null, 16.62m, 1, null, 68538.1527158438m, 56 },
                    { 61, 3.6196m, 3.503m, null, null, 29.5m, 3, null, 50002.1044804811m, 58 },
                    { 60, 4.026m, 3.6196m, null, null, 25.73m, 2, null, 57516.5372370362m, 58 },
                    { 59, 4.68m, 4.026m, null, null, 21.77m, 1, null, 71717.9794037245m, 58 },
                    { 58, 4.015m, 3.503m, null, null, 23.74m, 5, null, 40953.0928427819m, 59 },
                    { 39, 4.435m, 4.25m, null, null, 20m, 2, null, 52473.665523135m, 67 },
                    { 38, 4.68m, 4.435m, null, null, 20m, 1, null, 70751.6172964368m, 67 },
                    { 37, 3.7155m, 3.395m, null, null, 26.66m, 4, null, 41138.5466141124m, 13 },
                    { 36, 4.02m, 3.7155m, null, null, 23.62m, 3, null, 43041.6182663396m, 13 },
                    { 16, 4.675m, 4.4335m, null, null, 18.805m, 2, null, 75629.5520237498m, 64 },
                    { 15, 4.68m, 4.675m, null, null, 14.685m, 1, null, 79873.2065903408m, 64 },
                    { 14, 3.928m, 3.395m, null, null, 29m, 5, null, 48491.1257999243m, 63 },
                    { 13, 4.422m, 3.928m, null, null, 24m, 4, null, 50004.9526003036m, 63 },
                    { 12, 4.427m, 4.422m, null, null, 21.115m, 3, null, 58383.4531819233m, 63 },
                    { 11, 4.436m, 4.427m, null, null, 20.94m, 2, null, 76993.3915643459m, 63 },
                    { 10, 4.678m, 4.436m, null, null, 16.945m, 1, null, 83749.9994512532m, 63 },
                    { 9, 3.928m, 3.395m, null, null, 27.345m, 5, null, 44460.825m, 62 },
                    { 8, 4.4185m, 3.928m, null, null, 23.14m, 4, null, 44320.3m, 62 },
                    { 7, 4.422m, 4.4185m, null, null, 21.1m, 3, null, 49666.6m, 62 },
                    { 6, 4.43m, 4.422m, null, null, 18.155m, 2, null, 54725.375m, 62 },
                    { 5, 4.678m, 4.43m, null, null, 16.26m, 1, null, 67400.6562m, 62 },
                    { 4, 3.617m, 3.395m, null, null, 29.5m, 4, null, 44546.9183001487m, 14 },
                    { 3, 4.021m, 3.617m, null, null, 26m, 3, null, 48034.3002290754m, 14 },
                    { 2, 4.199m, 4.021m, null, null, 25.5m, 2, null, 65000.0382281152m, 14 },
                    { 17, 4.4335m, 4.131m, null, null, 20.33m, 3, null, 71395.49987894m, 64 },
                    { 73, 3.6174m, 3.503m, null, null, 23.74m, 4, null, 39427.1m, 57 },
                    { 18, 4.131m, 3.712m, null, null, 22.86m, 4, null, 69970.7862593915m, 64 },
                    { 20, 3.3725m, 3.395m, null, null, 29.5m, 6, null, 48927.5428520448m, 64 },
                    { 35, 4.0285m, 4.02m, null, null, 25.035m, 2, null, 62142.3284516878m, 13 },
                    { 34, 4.27m, 4.0285m, null, null, 19.715m, 1, null, 71264.2092980532m, 13 },
                    { 33, 3.3665m, 3.395m, null, null, 29.5m, 3, null, 43501.5358851085m, 60 },
                    { 32, 4.02m, 3.3665m, null, null, 29.4m, 2, null, 51510.2859937298m, 60 },
                    { 31, 4.25m, 4.02m, null, null, 23.1m, 1, null, 61411.1449455023m, 60 },
                    { 30, 4.017m, 3.395m, null, null, 23.53m, 4, null, 42467.522416899m, 65 },
                    { 29, 4.024m, 4.017m, null, null, 20.935m, 3, null, 43002.4447877913m, 65 },
                    { 28, 4.031m, 4.024m, null, null, 20.92m, 2, null, 58746.2080302979m, 65 },
                    { 27, 4.278m, 4.031m, null, null, 16.615m, 1, null, 66996.798789125m, 65 },
                    { 26, 3.369m, 3.395m, null, null, 29.5m, 3, null, 44269.27434724m, 12 },
                    { 25, 4.023m, 3.369m, null, null, 29.5m, 2, null, 55748.7283933678m, 12 },
                    { 24, 4.25m, 4.023m, null, null, 23m, 1, null, 69271.0919942961m, 12 },
                    { 23, 3.599m, 3.395m, null, null, 35m, 3, null, 54381.2908135302m, 61 },
                    { 22, 4.2425m, 3.599m, null, null, 26.88m, 2, null, 53858.9494767659m, 61 },
                    { 21, 4.49m, 4.2425m, null, null, 20.12m, 1, null, 59540.3319378491m, 61 },
                    { 19, 3.712m, 3.3725m, null, null, 25.82m, 5, null, 69651.0650992417m, 64 },
                    { 74, 4.678m, 4.43m, null, null, 19.7m, 1, null, 79730.4361332054m, 7 },
                    { 75, 4.43m, 4.422m, null, null, 25.299929199m, 2, null, 71971.7332403929m, 7 },
                    { 76, 4.422m, 4.017m, null, null, 28.1m, 3, null, 59627.7130020409m, 7 },
                    { 129, 4.78m, 4.732m, null, null, 17m, 1, null, 78186.1698m, 43 },
                    { 128, 3.8175m, 3.503m, null, null, 23m, 7, null, 39061.2997829452m, 42 },
                    { 127, 4.0915m, 3.8175m, null, null, 24.8m, 6, null, 49836.9233683762m, 42 },
                    { 126, 4.4735m, 4.0915m, null, null, 22.205m, 5, null, 56593.8772064106m, 42 },
                    { 125, 4.48m, 4.4735m, null, null, 18.55m, 4, null, 58895.6423236105m, 42 },
                    { 124, 4.489m, 4.48m, null, null, 15.095m, 3, null, 59598.6056194428m, 42 },
                    { 123, 4.5m, 4.489m, null, null, 11.845m, 2, null, 59975.5465890712m, 42 },
                    { 122, 4.5m, 4.5m, null, null, 10.005m, 1, null, 64351.0287646177m, 42 },
                    { 121, 3.819m, 3.503m, null, null, 27m, 6, null, 47561.0111134595m, 41 },
                    { 120, 4.1235m, 3.819m, null, null, 24.44m, 5, null, 53089.9366190828m, 41 },
                    { 119, 4.4255m, 4.1235m, null, null, 22.98m, 4, null, 62727.6300579583m, 41 },
                    { 118, 4.43m, 4.4255m, null, null, 19.97m, 3, null, 65240.6562303674m, 41 },
                    { 117, 4.586m, 4.43m, null, null, 17.595m, 2, null, 69161.6349644553m, 41 },
                    { 116, 4.68m, 4.586m, null, null, 13.515m, 1, null, 74860.9263300897m, 41 },
                    { 115, 3.817m, 3.503m, null, null, 27m, 6, null, 47394.3202815814m, 9 },
                    { 130, 4.732m, 4.725m, null, null, 22.505m, 2, null, 76918.725m, 43 },
                    { 114, 4.121m, 3.817m, null, null, 22.99m, 5, null, 43088.5641487181m, 9 },
                    { 131, 4.725m, 4.422m, null, null, 25.995m, 3, null, 70815.575m, 43 },
                    { 133, 3.917m, 3.503m, null, null, 30m, 5, null, 49962.7m, 43 },
                    { 148, 4.296m, 4.287m, null, null, 28.82m, 2, null, 71675.369346111m, 54 },
                    { 147, 4.3m, 4.296m, null, null, 15.77m, 1, null, 54828.2689234584m, 54 },
                    { 146, 3.8167m, 3.503m, null, null, 23m, 7, null, 37803.1306506526m, 45 },
                    { 145, 4.09m, 3.8167m, null, null, 24.845m, 6, null, 46081.9296749903m, 45 },
                    { 144, 4.4728m, 4.09m, null, null, 22.205m, 5, null, 53404.6467927066m, 45 },
                    { 143, 4.477m, 4.4728m, null, null, 18.568m, 4, null, 55508.357012348m, 45 },
                    { 142, 4.486m, 4.477m, null, null, 15.095m, 3, null, 55293.6316256135m, 45 },
                    { 141, 4.485m, 4.486m, null, null, 11.785m, 2, null, 52478.7282534175m, 45 },
                    { 140, 4.5m, 4.485m, null, null, 10.005m, 1, null, 57739.0748677168m, 45 },
                    { 139, 3.9167m, 3.503m, null, null, 27m, 6, null, 44796.2228456208m, 44 },
                    { 138, 4.2698m, 3.9167m, null, null, 24.4353m, 5, null, 47252.2458423526m, 44 },
                    { 137, 4.4838m, 4.2698m, null, null, 22.98m, 4, null, 57992.5944581537m, 44 },
                    { 136, 4.49m, 4.4838m, null, null, 19.955m, 3, null, 63115.49311524m, 44 },
                    { 135, 4.655m, 4.49m, null, null, 17.62m, 2, null, 65570.8144003539m, 44 },
                    { 134, 4.68m, 4.655m, null, null, 13.51m, 1, null, 68164.2062920547m, 44 },
                    { 132, 4.422m, 3.917m, null, null, 30m, 4, null, 63615.5m, 43 },
                    { 299, 4.493m, 4.493m, null, null, 24.08m, 3, null, 54286.4973437201m, 23 },
                    { 113, 4.423m, 4.121m, null, null, 22.88m, 4, null, 56262.8941796336m, 9 },
                    { 111, 4.67m, 4.433m, null, null, 18.18m, 2, null, 68793.4201020805m, 9 },
                    { 91, 4.423m, 4.0185m, null, null, 24.5m, 4, null, 52302.8452990142m, 51 },
                    { 90, 4.7265m, 4.423m, null, null, 20.395m, 3, null, 56451.0711264643m, 51 },
                    { 89, 5.03m, 4.7265m, null, null, 17.47m, 2, null, 60646.9377866795m, 51 },
                    { 88, 5.275m, 5.03m, null, null, 16.14m, 1, null, 70308.6468302345m, 51 },
                    { 87, 4.417m, 3.503m, null, null, 27m, 5, null, 49413.1191377123m, 50 },
                    { 86, 4.4215m, 4.417m, null, null, 27m, 4, null, 57571.4897875719m, 50 },
                    { 85, 4.429m, 4.4215m, null, null, 19.995m, 3, null, 57496.5743579628m, 50 },
                    { 84, 4.4365m, 4.429m, null, null, 18.18m, 2, null, 69609.4845043342m, 50 },
                    { 83, 4.678m, 4.4365m, null, null, 13.325m, 1, null, 70694.8126862531m, 50 },
                    { 82, 4.416m, 3.503m, null, null, 24.434m, 5, null, 43464.4702787122m, 8 },
                    { 81, 4.419m, 4.416m, null, null, 25.3m, 4, null, 50217.588592868m, 8 },
                    { 80, 4.424m, 4.419m, null, null, 19.7m, 3, null, 49732.7753793405m, 8 },
                    { 79, 4.431m, 4.424m, null, null, 16.9m, 2, null, 55264.0949134258m, 8 },
                    { 78, 4.481m, 4.431m, null, null, 14.1m, 1, null, 62627.4938667841m, 8 },
                    { 77, 4.017m, 3.503m, null, null, 27.336m, 4, null, 47562.5989351092m, 7 },
                    { 92, 4.0185m, 3.503m, null, null, 27m, 5, null, 47416.3840783022m, 51 },
                    { 112, 4.433m, 4.423m, null, null, 18.185m, 3, null, 57775.0799467561m, 9 },
                    { 93, 4.5m, 4.4985m, null, null, 10.77m, 1, null, 60904.0508263166m, 52 },
                    { 95, 4.4915m, 4.4845m, null, null, 15.165m, 3, null, 50659.1509696883m, 52 },
                    { 110, 4.67m, 4.67m, null, null, 16.265m, 1, null, 75128.6057072243m, 9 },
                    { 109, 3.819m, 3.503m, null, null, 27m, 6, null, 47561.0111134595m, 40 },
                    { 108, 4.125m, 3.819m, null, null, 24.44m, 5, null, 53371.0219613343m, 40 },
                    { 107, 4.429m, 4.125m, null, null, 22.98m, 4, null, 66182.0180716568m, 40 },
                    { 106, 4.4325m, 4.429m, null, null, 19.975m, 3, null, 70675.2459856983m, 40 },
                    { 105, 4.605m, 4.4325m, null, null, 17.595m, 2, null, 75005.0441592252m, 40 },
                    { 104, 4.68m, 4.605m, null, null, 13.51m, 1, null, 78578.2481667944m, 40 },
                    { 103, 4.017m, 3.503m, null, null, 29.09m, 5, null, 51164.7865159465m, 53 },
                    { 102, 4.122m, 4.017m, null, null, 26.8m, 4, null, 52699.5836199914m, 53 },
                    { 101, 4.13m, 4.122m, null, null, 24.095m, 3, null, 65523.3070653022m, 53 },
                    { 100, 4.137m, 4.13m, null, null, 19.255m, 2, null, 66685.4784204689m, 53 },
                    { 99, 4.37m, 4.137m, null, null, 16.26m, 1, null, 73532.6020836594m, 53 },
                    { 98, 4.217m, 3.503m, null, null, 24.41m, 6, null, 43525.6231373441m, 52 },
                    { 97, 4.22m, 4.217m, null, null, 20.52m, 5, null, 41821.374536937m, 52 },
                    { 96, 4.4845m, 4.22m, null, null, 19.83m, 4, null, 49490.7941740463m, 52 },
                    { 94, 4.4985m, 4.4915m, null, null, 14.805m, 2, null, 61914.2767947004m, 52 },
                    { 300, 4.493m, 3.503m, null, null, 25.77m, 4, null, 56143.2878091947m, 23 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "tower_sections",
                keyColumn: "id",
                keyValue: 300);
        }
    }
}
