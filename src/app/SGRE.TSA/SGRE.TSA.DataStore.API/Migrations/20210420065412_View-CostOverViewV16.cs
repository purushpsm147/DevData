using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ViewCostOverViewV16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var createAndDropViewsql = @"DROP VIEW IF EXISTS cost_overview;
                                CREATE OR REPLACE VIEW cost_overview AS
                                    (with final_data as (with tower as (select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, scenario_type, wtg_catalogue_id from base_tower bt 
                                    UNION ALL select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, 1 as scenario_type, wtg_catalogue_id from sst_tower st),
                                    total as (with components as(
                                    SELECT scenario_id, 1 as ""position"", SUM(nomination/1000) as nomination, SUM(offer/1000) as offer, SUM(signature/1000) as signature,
                                    case when sum(nomination) <= 0 THEN 1 ELSE 0 END as nomination_check,
                                    case when sum(offer) <= 0 THEN 1 ELSE 0 END as offer_check,
                                    case when sum(signature) <= 0 THEN 1 ELSE 0 END as signature_check
                                     FROM cost_feed_back cfb
                                    LEFT JOIN costs_tower_ex_works ctew 
                                    on ctew.cost_feedback_id = cfb.id
                                    LEFT JOIN costs_tower_ex_works_line_item ctewli
                                    ON ctewli.costs_tower_ex_works_id = ctew.id
                                    GROUP BY scenario_id
                                    UNION ALL
                                    SELECT scenario_id, 2 as ""position"", SUM(ctllt.nomination/1000) as nomination, SUM(ctllt.offer/1000) as offer, SUM(ctllt.signature/1000) as signature,
                                    case when sum(nomination) <= 0 THEN 1 ELSE 0 END as nomination_check,
                                    case when sum(offer) <= 0 THEN 1 ELSE 0 END as offer_check,
                                    case when sum(signature) <= 0 THEN 1 ELSE 0 END as signature_check
                                    FROM cost_feed_back cfb
                                    LEFT JOIN costs_tower_logistics ctl 
                                    on ctl.cost_feedback_id = cfb.id
                                    LEFT JOIN costs_tower_logistics_supplier ctls 
                                    on ctls.costs_tower_logistics_id = ctl.id
                                    LEFT JOIN costs_tower_logistics_line_item ctllt
                                    ON ctllt.costs_tower_logistics_supplier_id = ctls.id
                                    GROUP BY scenario_id
                                    UNION ALL
                                    SELECT scenario_id, 3 as ""position"", SUM(ctc.cost_nomination/1000) as nomination, SUM(ctc.cost_offer/1000) as offer, SUM(ctc.cost_signature/1000) as signature,
                                    case when sum(cost_nomination) <= 0 THEN 1 ELSE 0 END as nomination_check,
                                    case when sum(cost_offer) <= 0 THEN 1 ELSE 0 END as offer_check,
                                    case when sum(cost_signature) <= 0 THEN 1 ELSE 0 END as signature_check
                                    FROM cost_feed_back cfb
                                    LEFT JOIN costs_tower_construction ctc 
                                    on ctc.cost_feedback_id = cfb.id
                                    GROUP BY scenario_id
                                    UNION ALL
                                    SELECT scenario_id, 4 as ""position"", SUM(ctclt.nomination/1000) as nomination, SUM(ctclt.offer/1000) as offer, SUM(ctclt.signature/1000) as signature,
                                    case when sum(nomination) <= 0 THEN 1 ELSE 0 END as nomination_check,
                                    case when sum(offer) <= 0 THEN 1 ELSE 0 END as offer_check,
                                    case when sum(signature) <= 0 THEN 1 ELSE 0 END as signature_check
                                    FROM cost_feed_back cfb
                                    LEFT JOIN costs_tower_customs ctcs 
                                    on ctcs.cost_feedback_id = cfb.id
                                    LEFT JOIN costs_tower_customs_supplier ctcss
                                    on ctcss.costs_tower_customs_id = ctcs.id
                                    LEFT JOIN costs_tower_customs_line_item ctclt
                                    ON ctclt.costs_tower_customs_supplier_id = ctcss.id 
                                    AND ctclt.costs_tower_customs_meta_id != 1
                                    GROUP BY scenario_id
                                    UNION ALL
                                    SELECT scenario_id, 5 as ""position"", CASE WHEN s.scenario_type = 0 THEN 0 ELSE tdc.cost_kilo/t.turbine_quantity END  as nomination, CASE WHEN s.scenario_type = 0 THEN 0 ELSE tdc.cost_kilo/t.turbine_quantity END as offer, 
                                    CASE WHEN s.scenario_type = 0 THEN 0 ELSE tdc.cost_kilo/t.turbine_quantity END as signature,
                                    1 as nomination_check,
                                    1 as offer_check,
                                    1 as signature_check
                                     FROM cost_feed_back cfb,Tower_design_costs tdc,
                                    (select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, scenario_type, wtg_catalogue_id from base_tower bt 
                                    UNION ALL select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, 1 as scenario_type, wtg_catalogue_id from sst_tower st) t,  scenarios s, quotes q, proposals prop, projects p
                                    WHERE s.id = cfb.scenario_id 
                                    AND q.id = s.quote_id
                                    AND (s.quote_id = t.quote_id
                                                    AND s.windfarm_configuration_id = t.windfarm_configuration_id
                                                    AND s.item_id = t.tower_id
                                                    AND s.scenario_type  = t.scenario_type
                                                    AND prop.id = q.proposal_id
                                                    AND p.id = prop.project_id)
                                    AND tdc.currency_id = p.currency_id


                                    UNION ALL
                                    SELECT scenario_id, 6 as ""position"", CASE WHEN s.scenario_type = 0 THEN 0 ELSE SUM((ct.tower_component_certificate_windfarm_cluster_nomination/t.turbine_quantity)/1000) END as nomination, 
                                    CASE WHEN s.scenario_type = 0 THEN 0 ELSE SUM((ct.tower_component_certificate_windfarm_cluster_offer/t.turbine_quantity)/1000) END as offer,
                                     CASE WHEN s.scenario_type = 0 THEN 0 ELSE SUM((ct.tower_component_certificate_windfarm_cluster_signature/t.turbine_quantity)/1000) END as signature,
                                    1 as nomination_check,
                                    1 as offer_check,
                                    1 as signature_check
                                     FROM cost_feed_back cfb
                                    LEFT JOIN costs_technology ct 
                                    on ct.cost_feedback_id = cfb.id,
                                    
                                    (select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, scenario_type, wtg_catalogue_id from base_tower bt 
                                    UNION ALL select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, 1 as scenario_type, wtg_catalogue_id from sst_tower st) t,  scenarios s, quotes q 
                                    WHERE s.id = cfb.scenario_id 
                                    AND q.id = s.quote_id
                                    AND (s.quote_id = t.quote_id
                                                    AND s.windfarm_configuration_id = t.windfarm_configuration_id
                                                    AND s.item_id = t.tower_id
                                                    AND s.scenario_type  = t.scenario_type)

                                    GROUP BY scenario_id, s.scenario_type
                                    
                                    ) SELECT c1.scenario_id, c1.""position"", round(c1.nomination,3) as nomination , round(c1.offer,3) as offer, round(c1.signature,3) as signature, nomination_check, offer_check, signature_check FROM components c1 
                                    UNION ALL SELECT c2.scenario_id, 7 as ""position"", 
                                    case WHEN SUM(nomination_check) > 2 THEN 0  ELSE round(sum(nomination),3) END  as nomination, 
                                    case WHEN SUM(offer_check) > 2 THEN 0 ELSE round(sum(offer),3) END as offer, 
                                    case WHEN SUM(signature_check) > 2 THEN 0 ELSE round(sum(signature),3) END as signature,
                                    0 as nomination_check,
                                    0 as offer_check,
                                    0 as signature_check  
                                     FROM components c2  GROUP BY c2.scenario_id
                                    ),
                                    rnatotal as (

                                    SELECT scenario_id, ""position"", nomination, offer, signature FROM total t1
                                    UNION ALL
                                    SELECT s.id as scenario_id, 8 as ""position"", rc.cost_kilo as nomination, rc.cost_kilo as offer, rc.cost_kilo as signature 
                                    FROM rna_costs rc 
                                    JOIN tower t ON rc.wtg_catalogue_id = t.wtg_catalogue_id
                                    JOIN scenarios s ON s.item_id = t.tower_id 
                                    JOIN quotes q ON q.id = s.quote_id
                                    JOIN proposals prop ON prop.id = q.proposal_id
                                    JOIN projects p ON p.id = prop.project_id
                                    AND rc.currency_id = p.currency_id
                                    AND s.windfarm_configuration_id = t.windfarm_configuration_id
                                    AND s.scenario_type  = t.scenario_type
                                    UNION ALL 
                                    SELECT t2.scenario_id, 9 as ""position"", 
                                    case WHEN SUM(nomination_check) > 2 THEN 0  ELSE round(sum(nomination/2)+sum(cost_kilo)/Count(*),3)
                                    END  as nomination, 
                                    case WHEN SUM(offer_check) > 2 THEN 0 ELSE round(sum(offer/2)+sum(cost_kilo)/Count(*),3) END as offer, 
                                    case WHEN SUM(signature_check) > 2 THEN 0 ELSE round(sum(signature/2)+sum(cost_kilo)/Count(*),3) END as signature
                                    FROM total t2 JOIN scenarios s ON s.id = t2.scenario_id 
                                    JOIN tower t ON s.item_id = t.tower_id 
                                    JOIN rna_costs rc ON rc.wtg_catalogue_id = t.wtg_catalogue_id 
                                    JOIN quotes q ON q.id = s.quote_id
                                    JOIN proposals prop ON prop.id = q.proposal_id
                                    JOIN projects p ON p.id = prop.project_id
                                    AND rc.currency_id = p.currency_id
                                    AND s.windfarm_configuration_id = t.windfarm_configuration_id
                                    AND s.scenario_type  = t.scenario_type
                                    GROUP BY t2.scenario_id

                                    )

                                         SELECT rt.scenario_id, rt.""position"",
                                              
                                        nomination,
                                        CASE WHEN rt.""position"" = 6 THEN ROUND(ct.tower_component_certificate_windfarm_cluster_nomination/1000,3) ELSE round(rt.nomination * t.turbine_quantity,3) END as nomination_windfarm, 
                                        offer,
                                        CASE WHEN rt.""position"" = 6 THEN ROUND(ct.tower_component_certificate_windfarm_cluster_offer/1000,3) ELSE round(rt.offer * t.turbine_quantity,3) END offer_windfarm, 
                                        signature,
                                        CASE WHEN rt.""position"" = 6 THEN ROUND(ct.tower_component_certificate_windfarm_cluster_signature/1000,3) ELSE round(rt.signature * t.turbine_quantity,3) END as signature_windfarm, s.scenario_type

                                    FROM rnatotal rt 
                                    JOIN scenarios s ON s.id = rt.scenario_id 
                                    JOIN quotes q ON q.id = s.quote_id
                                    JOIN tower t ON (s.quote_id = t.quote_id
                                                    AND s.windfarm_configuration_id = t.windfarm_configuration_id
                                                    AND s.item_id = t.tower_id
                                                    AND s.scenario_type  = t.scenario_type)
                                    JOIN cost_feed_back cfb ON cfb.scenario_id = s.id
                                    LEFT JOIN costs_technology ct 
                                    on ct.cost_feedback_id = cfb.id)
                                    SELECT cv1.id as position_id, COALESCE(final_data.scenario_id,0) as scenario_id, cv1.sub_section_name as position, COALESCE(final_data.nomination,0.00) as  nomination, 
                                    COALESCE(final_data.nomination_windfarm,0.00) as nomination_windfarm,
                                    COALESCE(final_data.offer,0.00) as offer, COALESCE(final_data.offer_windfarm,0.00) as offer_windfarm, 
                                    COALESCE(final_data.signature,0.00) as signature, COALESCE(final_data.signature_windfarm,0.00)  as signature_windfarm 
                                    FROM cost_over_view_meta cv1
                                    JOIN final_data ON final_data.""position"" = cv1.id AND cv1.type_of_tower in (2,final_data.scenario_type))";

            migrationBuilder.Sql(createAndDropViewsql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
