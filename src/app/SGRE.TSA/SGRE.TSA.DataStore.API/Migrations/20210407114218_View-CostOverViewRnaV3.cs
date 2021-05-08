using Microsoft.EntityFrameworkCore.Migrations;

namespace SGRE.TSA.DataStore.API.Migrations
{
    public partial class ViewCostOverViewRnaV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var createAndDropViewsql = @"DROP VIEW IF EXISTS cost_overview_rna;
                                        CREATE OR REPLACE VIEW cost_overview_rna AS
                                                        ( with c as(
                                            SELECT 0, 1 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 2 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 3 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 4 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 5 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 6 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 7 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 8 as position, 0 as nomination,0 as offer, 0 as signature
                                            UNION ALL
                                            SELECT 0, 9 as position, 0 as nomination,0 as offer, 0 as signature
                                            )
                                            SELECT covm.id as position_id, s.id as scenario_id, 
                                            covm.sub_section_name as position, 
                                            CASE WHEN covm.id = 8 THEN rc.cost WHEN covm.id = 5 THEN round(tdc.cost_kilo/t.turbine_quantity,3) ELSE 0 END as nomination, 
                                            CASE WHEN covm.id = 8 THEN rc.cost WHEN covm.id = 5 THEN round(tdc.cost_kilo/t.turbine_quantity,3) ELSE 0 END as offer, 
                                            CASE WHEN covm.id = 8 THEN rc.cost WHEN covm.id = 5 THEN round(tdc.cost_kilo/t.turbine_quantity,3) ELSE 0 END as signature, 

                                            CASE WHEN covm.id = 8 THEN rc.cost * t.turbine_quantity WHEN covm.id = 5 THEN tdc.cost_kilo ELSE 0 END as nomination_windfarm, 
                                            CASE WHEN covm.id = 8 THEN rc.cost * t.turbine_quantity WHEN covm.id = 5 THEN tdc.cost_kilo ELSE 0 END as offer_windfarm, 
                                            CASE WHEN covm.id = 8 THEN rc.cost * t.turbine_quantity WHEN covm.id = 5 THEN tdc.cost_kilo ELSE 0 END as signature_windfarm 

                                            FROM cost_over_view_meta covm, c,
                                            (select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, scenario_type, wtg_catalogue_id from base_tower bt 
                                            UNION ALL select id as tower_id, turbine_quantity, quote_id, windfarm_configuration_id, 1 as scenario_type, wtg_catalogue_id from sst_tower st) t, 
                                            rna_costs rc, scenarios s, quotes q, Tower_design_costs tdc, proposals prop, projects p
                                            WHERE covm.id = c.position  
                                            AND rc.wtg_catalogue_id = t.wtg_catalogue_id  
                                            AND (s.item_id = t.tower_id 
                                            AND q.id = s.quote_id
                                            AND s.windfarm_configuration_id = t.windfarm_configuration_id
                                            AND s.scenario_type  = t.scenario_type
                                            AND covm.type_of_tower in (2,s.scenario_type)
                                            AND prop.id = q.proposal_id
                                            AND p.id = prop.project_id)
                                            AND rc.currency_id = p.currency_id 
                                            AND tdc.currency_id = p.currency_id)
                                ";

            migrationBuilder.Sql(createAndDropViewsql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
