using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class updateModalAndSegmentDimensionsSummaryView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "design_life_time",
                table: "sst_design_evaluation",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "hub_height_m",
                table: "sst_design_evaluation",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "is_design_success",
                table: "sst_design_evaluation",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "risks",
                table: "sst_design_evaluation",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "tower_height_m",
                table: "sst_design_evaluation",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "tower_weight_t",
                table: "sst_design_evaluation",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            var sql = @"CREATE OR REPLACE VIEW segment_dimensions_summary_view AS
                       with sst_predesign_inputs as
                        (select st.id, sst_uuid, spd.tower_foundation_height, nd.distance_bottom_to_center_hub as rna
                        from public.sst_tower st 
                        join public.sst_predesign_dimesions spd 
                        on st.id = spd.sst_tower_id
                        join public.wtg_catalogues wc 
                        on st.wtg_catalogue_id  = wc.id 
                        join public.nacelle_distances nd 
                        on wc.id = nd.wtg_catalogue_id 
                        )
                        select spi.id as sst_tower_id, spi.sst_uuid, 
                        round(COALESCE((ts.length_m + (spi.rna/ 1000))::numeric, 0.0), 3) AS hub_height,
                        round((ts.length_m - coalesce (spi.tower_foundation_height/1000,0.0)),3) as tower_height, 
                        ts.number_of_sections
                        from sst_predesign_inputs as spi
                        left join 
                        (
	                        select trtsd.sst_uuid ,trtsd.length_m , trsd.section_nr as number_of_sections
	                        from public.towersite_report_total_sections_data trtsd 
	                        left join
	                        (
		                        select sst_uuid , max(section_nr) as section_nr
		                        from public.towersite_report_sections_data  
		                        group by sst_uuid
	                        ) trsd
	                        on trtsd.sst_uuid = trsd.sst_uuid
                        ) ts
                        on spi.sst_uuid = ts.sst_uuid
                        ";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "design_life_time",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "hub_height_m",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "is_design_success",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "risks",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "tower_height_m",
                table: "sst_design_evaluation");

            migrationBuilder.DropColumn(
                name: "tower_weight_t",
                table: "sst_design_evaluation");
        }
    }
}
