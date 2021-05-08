using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ViewscenarioOverviewV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var createAndDropViewsql = @"DROP VIEW IF EXISTS scenario_overview;
                                CREATE OR REPLACE VIEW scenario_overview AS
                                (with tower as(
                                -- base tower
                                select bt.id as tower_id, bt.quote_id , bt.windfarm_configuration_id, bt.loads_cluster_id, 
                                bt.wtg_catalogue_id , bt.tower_type_id , COALESCE(bt.hub_height,0.0) as hub_height, bt.rna_life_time as life_time ,
                                COALESCE(round(btdd.tower_weight,1),0.0) tower_weight, 
                                scenario_type, '-' as design_evaluation_risk, COALESCE(btaep.aep_nomination_Gross,0.0) as aep_nomination_gross, COALESCE(btaep.aep_binding_offer_Net,0.0) as aep_offer_net, 
                                COALESCE(btaep.aep_signature_net,0.0) as aep_signature_net
                                from public.base_tower bt
                                left join public.base_tower_design_dimension btdd
                                on bt.id = btdd.base_tower_id
                                Left join public.base_tower_aep_hubheight btaep
                                on bt.id = btaep.base_tower_id
                                UNION ALL
                                -- sst tower
                                select st.id as tower_id, st.quote_id , st.windfarm_configuration_id , st.loads_cluster_id,
                                st.wtg_catalogue_id , st.tower_type_id , 
								COALESCE(case when is_propose_hub_height is true then st.proposed_hub_height 
										 else st.loadset_hub_height end, 0.0)  as hub_height, 
                                st.target_life_time as life_time, 
                                CASE
                                    WHEN st.is_design_evaluation_request IS FALSE THEN 0::numeric 
                                    WHEN st.is_design_evaluation_request IS TRUE AND st.is_design_evaluation_complete IS FALSE THEN 0::numeric
                                    WHEN st.is_design_evaluation_request IS TRUE AND st.is_design_evaluation_complete IS TRUE then COALESCE(ROUND(trtsd.weight_kg/1000,1), 0.0)::numeric 
                                    ELSE 0::numeric 
                                END AS tower_weight, 
                                1 as scenario_type, 
                                CASE WHEN st.is_design_evaluation_request IS FALSE THEN '-'
                                WHEN (st.is_design_evaluation_request IS TRUE AND st.is_design_evaluation_complete IS False) THEN  '-' 
                                WHEN (st.is_design_evaluation_request IS TRUE AND st.is_design_evaluation_complete IS TRUE) 
                                AND ( (COALESCE(srsc.sesimic_requirements,FALSE) IS True AND sdsa.seismic_assessment_result_types = 1) OR COALESCE(srsc.sesimic_requirements,FALSE) IS FALSE )
                                    AND (tcr.rna_load_margin < 1 AND trds.is_error IS False  AND (st.target_life_time = tcr.lifetime_years) ) THEN '0'
                                ELSE '1' END as design_evaluation_risk, 
                                CASE WHEN Is_propose_hub_height is true  THEN COALESCE(spphh.aep_nomination_gross,0.0)
                                WHEN Is_propose_hub_height is false THEN COALESCE(spehh.aep_nomination_gross,0.0) END as aep_nomination_gross,
                                CASE WHEN Is_propose_hub_height is true  THEN COALESCE(spphh.aep_binding_offer_net,0.0)
                                WHEN Is_propose_hub_height is false THEN COALESCE(spehh.aep_binding_offer_net,0.0) END as aep_offer_net,
                                CASE WHEN Is_propose_hub_height is true  THEN  COALESCE(spphh.aep_signature_net,0.0)
                                WHEN Is_propose_hub_height is false THEN COALESCE(spehh.aep_signature_net,0.0) END as aep_signature_net


                                from public.sst_tower st
                                left join public.sst_design_evaluation de
                                on st.id = de.sst_tower_id
                                left join public.sst_predesign_proposed_hub_heights spphh
                                ON spphh.sst_tower_id = st.id
                                left join public.sst_predesign_existing_hub_heights spehh
                                ON spehh.sst_tower_id = st.id

                                left join public.sst_design_Seismic_assessment sdsa
                                on de.id = sdsa.sst_Design_evaluation_id 
                                left join public.towersite_cloe_report tcr
                                on st.sst_uuid = tcr.sst_uuid
                                left join public.towersite_report_design_status trds
                                on st.sst_uuid = trds.sst_uuid                                
                                left join public.towersite_report_total_sections_data trtsd 
                                on st.sst_uuid = trtsd.sst_uuid 
                                join quotes q on st.quote_id = q.id
                                join proposals p on q.proposal_id = p.id
                                join projects proj on p.project_id = proj.id
                                LEFT JOIN project_constraints pc on pc.project_id = proj.id
                                LEFT JOIN special_requirements_sales_constraints srsc ON srsc.project_constraint_id =  pc.id
                                ),

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

            migrationBuilder.Sql(createAndDropViewsql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
