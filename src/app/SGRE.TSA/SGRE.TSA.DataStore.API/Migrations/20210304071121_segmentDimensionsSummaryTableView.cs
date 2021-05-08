using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class segmentDimensionsSummaryTableView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE OR REPLACE VIEW segment_dimensions_summary_detail_view AS select trsd.sst_uuid, trsd.section_nr as section_number, trsd.section_type,
						concat_ws(' ', trsd.section_nr , concat('(',coalesce(trsd.section_type,''),')')) as tower_section ,
						(trsd.section_length_m * 1000)::int  as section_length,
						(trsd.upper_flange_external_diameter_m * 1000)::int as outer_diameter_top ,
						(trsd.lower_flange_external_diameter_m * 1000 )::int  as outer_diameter_bottom,
						tpl.max_plate_thickness, tpl.weight_plates,
						tfl.weight_flanges_top, tfl.weight_flanges_bottom,
						round(coalesce(trsd.section_weight_kg,0.0)/1000,1) as transport_weight
						from public.towersite_report_sections_data as trsd
						left join 
						(
							select tp.sst_uuid, tp.section_nr, tp.section_type, tp.max_plate_thickness, tps.weight_plates from
							(select * from (
								select sst_uuid , section_nr , section_type, round(a,1)  as max_plate_thickness, 
								row_number() over (partition by sst_uuid,section_nr order by section_nr desc, a desc) as rn
								from public.towersite_plates 
								) plts
								where rn=1
							) as tp
							left join
							(
								select sst_uuid , section_nr , section_type, round((nwght_total / 1000 ),1) as weight_plates
								from public.towersite_plates_summary
							) as tps
							on tp.sst_uuid = tps.sst_uuid and tp.section_nr = tps.section_nr 
						) as tpl
						on trsd.sst_uuid = tpl.sst_uuid and trsd.section_nr = tpl.section_nr
						left join 
						(
							select sst_uuid , section_nr , (array_agg(mass_kg_cleaned))[1] as weight_flanges_top, 
							(array_agg(mass_kg_cleaned))[2] as weight_flanges_bottom 
							from 
							(   select sst_uuid ,section_nr, flange_nr_bottom_to_top, coalesce (mass_kg,0.0) as mass_kg_cleaned,
								row_number() over (partition by section_nr order by flange_nr_bottom_to_top desc) as rn
								from public.towersite_flanges tf
							) f
							group by sst_uuid , section_nr	
						) tfl
						on tpl.sst_uuid = tfl.sst_uuid and tpl.section_nr = tfl.section_nr
						where trsd.section_nr = tpl.section_nr and trsd.section_nr = tfl.section_nr
						order by trsd.sst_uuid ,trsd.section_nr desc;
					";

            migrationBuilder.Sql(sql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
