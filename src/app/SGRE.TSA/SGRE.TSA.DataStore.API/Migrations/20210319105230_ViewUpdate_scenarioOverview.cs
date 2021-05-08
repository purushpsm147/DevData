using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ViewUpdate_scenarioOverview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tower_hub_height",
                table: "sst_predesign_dimesions");

            var sql = @"CREATE OR REPLACE VIEW scenario_overview AS
                                (with tower as(
                                -- base tower
                                select bt.id as tower_id, bt.quote_id , bt.windfarm_configuration_id, bt.loads_cluster_id, 
                                bt.wtg_catalogue_id , bt.tower_type_id , COALESCE(bt.hub_height,0.0) as hub_height, bt.rna_life_time as life_time ,btdd.total_weight as tower_weight, 
                                scenario_type
                                from public.base_tower bt
                                left join public.base_tower_design_dimension btdd
                                on bt.id = btdd.base_tower_id
                                UNION ALL
                                -- sst tower
                                select st.id as tower_id, st.quote_id , st.windfarm_configuration_id , st.loads_cluster_id,
                                st.wtg_catalogue_id , st.tower_type_id , 
								COALESCE(case when is_propose_hub_height is true then st.proposed_hub_height 
										 else st.loadset_hub_height end, 0.0)  as hub_height, st.target_life_time as life_time, COALESCE(de.tower_weight_t,0.0) as tower_weight, 
                                1 as scenario_type
                                from public.sst_tower st
                                left join public.sst_design_evaluation de
                                on st.id = de.sst_tower_id ),

                                scenario_agg as(
                                select s.id as scenario_id, s.quote_id , s.windfarm_configuration_id , s.scenario_no , s.item_id , s.status , s.progress , s.""options"",
                                 s.step_progress, s.scenario_type, sd.id as scenario_design_id,
                                sck.id as scenario_cost_kpi_id
                                from public.scenarios s
                                left join public.scenario_designs sd
                                on s.id = sd.scenario_id
                                left join public.scenario_costs_kpis sck
                                on s.id = sck.scenario_id)

                                select s.scenario_id, s.scenario_no , s.item_id , s.status , s.progress , s.""options"",
                                 s.step_progress, scenario_design_id,
                                 scenario_cost_kpi_id, t.*
                                from scenario_agg s join tower t
                                on (s.quote_id = t.quote_id
                                AND s.windfarm_configuration_id = t.windfarm_configuration_id
                                AND s.item_id = t.tower_id
                                AND s.scenario_type  = t.scenario_type))
                                ";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "tower_hub_height",
                table: "sst_predesign_dimesions",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
