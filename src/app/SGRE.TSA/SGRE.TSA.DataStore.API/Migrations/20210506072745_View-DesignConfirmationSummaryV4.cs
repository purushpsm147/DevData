using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ViewDesignConfirmationSummaryV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var createAndDropViewsql = @"DROP VIEW IF EXISTS  design_confirmation_summary_view;
                        CREATE OR REPLACE VIEW design_confirmation_summary_view AS with design_confirmation as
                        (select st.sst_uuid, st.id as sst_tower_id, q.quotation_id, lc.cluster_name, st.turbine_quantity, wtg.wtg_type,
                        it.tower as initial_tower, st.towersite_design_output_file_link, 
                        round(COALESCE(st.towersite_design_output_file_size_bytes/1048576.0,0),1) as file_size,
                        st.target_life_time as sst_target_lifetime, st.error_code
                        from public.sst_tower st
                        join public.quotes q
                        on st.quote_id = q.id
                        join public.loads_clusters lc
                        on st.loads_cluster_id = lc.id
                        join public.wtg_catalogues wtg
                        on st.wtg_catalogue_id = wtg.id
                        join public.initial_towers it
                        on st.initial_tower_id = it.id
                        join public.towersite_cloe_report tcr
                        on st.sst_uuid = tcr.sst_uuid
                        )
                        select dc.*,tcr.lifetime_years as design_lifetime, tcr.rna_load_margin,
						case when trds.is_error
						then false
						else true
						end
						AS is_tower_design_status_success 
                        from design_confirmation as dc
                        left join public.towersite_report_design_status trds
                        on dc.sst_uuid = trds.sst_uuid
                        left join public.towersite_cloe_report tcr
                        on trds.sst_uuid = tcr.sst_uuid
                        ";

            migrationBuilder.Sql(createAndDropViewsql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            var createAndDropViewsql = @"
                        CREATE OR REPLACE VIEW design_confirmation_summary_view AS with design_confirmation as
                        (select st.sst_uuid, st.id as sst_tower_id, q.quotation_id, lc.cluster_name, st.turbine_quantity, wtg.wtg_type,
                        it.tower as initial_tower, st.towersite_design_output_file_link, 
                        round(COALESCE(st.towersite_design_output_file_size_bytes/1048576.0,0),1) as file_size,
                        st.target_life_time as sst_target_lifetime, st.error_code
                        from public.sst_tower st
                        join public.quotes q
                        on st.quote_id = q.id
                        join public.loads_clusters lc
                        on st.loads_cluster_id = lc.id
                        join public.wtg_catalogues wtg
                        on st.wtg_catalogue_id = wtg.id
                        join public.initial_towers it
                        on st.initial_tower_id = it.id
                        join public.towersite_cloe_report tcr
                        on st.sst_uuid = tcr.sst_uuid
                        )
                        select dc.*,tcr.lifetime_years as design_lifetime, tcr.rna_load_margin
                        from design_confirmation as dc
                        left join public.towersite_cloe_report tcr
                        on dc.sst_uuid = tcr.sst_uuid
                        ";

            migrationBuilder.Sql(createAndDropViewsql);

        }
    }
}
