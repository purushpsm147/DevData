using Microsoft.EntityFrameworkCore;
using SGRE.TSA.DataStore.API.Context;
using SGRE.TSA.DataStore.API.Models;

namespace SGRE.TSA.DataStore.API
{
    public class TsaContext : DbContext
    {
        #region Application
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<ConstructionConstraint> ConstructionConstraints { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<GenericMarketBoundary> GenericMarketBoundaries { get; set; }
        public DbSet<LogisticConstraint> LogisticConstraints { get; set; }
        public DbSet<LogisticStatus> LogisticStatuses { get; set; }
        public DbSet<MileStone> MileStones { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermitsSalesConstraint> PermitsSalesConstraints { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectConstraint> ProjectConstraints { get; set; }
        public DbSet<ProjectMileStones> ProjectMileStones { get; set; }
        public DbSet<ProjectModule> ProjectModules { get; set; }
        public DbSet<ProjectRoles> ProjectRoles { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<ProposalTasks> ProposalTasks { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SarStudy> SarStudies { get; set; }

        // Scenario
        public DbSet<Scenario> Scenarios { get; set; }
        public DbSet<ScenarioCostsKpi> scenarioCostsKpis { get; set; }
        public DbSet<ScenarioDesign> ScenarioDesigns { get; set; }

        public DbSet<SpecialRequirementsSalesConstraint> SpecialRequirementsSalesConstraints { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public DbSet<TransportMode> TransportModes { get; set; }
        public DbSet<WtgCatalogue> WtgCatalogues { get; set; }
        public DbSet<QuoteLine> QuoteLines { get; set; }
        public DbSet<WtgThreshold> WtgThresholds { get; set; }
        public DbSet<PresetRoles> PresetRoles { get; set; }

        public DbSet<LoadsCluster> LoadsClusters { get; set; }
        public DbSet<TowerType> TowerTypes { get; set; }
        public DbSet<ApplicationMode> ApplicationModes { get; set; }
        public DbSet<ApplicationReason> ApplicationReasons { get; set; }
        public DbSet<NoiseMode> NoiseModes { get; set; }

        public DbSet<SstTower> SstTower { get; set; }
        public DbSet<SstPredesignProposedHubHeight> SstPredesignProposedHubHeights { get; set; }
        public DbSet<SstPredesignDimesions> SstPredesignDimesions { get; set; }
        public DbSet<NacelleDistance> NacelleDistances { get; set; }

        public DbSet<SSTAepLookupGross> SstAepLookupGross { get; set; }

        public DbSet<BaseTower> BaseTower { get; set; }
        public DbSet<BaseTowerDesignDimension> BaseTowerDesignDimension { get; set; }

        public DbSet<ScenarioOverView> ScenarioOverView { get; set; }

        public DbSet<SstDesignEvaluation> SstDesignEvaluation { get; set; }
        public DbSet<SstDesignSeismicAssessment> SstDesignSeismicAssessment { get; set; }

        public DbSet<Summary> SummaryView { get; set; }
        public DbSet<SegmentDimensionsSummaryDetailView> SegmentDimensionsSummaryDetailView { get; set; }
        public DbSet<SegmentDimensionsSummaryView> SegmentDimensionsSummaryView { get; set; }
        public DbSet<InitialTower> InitialTowers { get; set; }
        public DbSet<SstPredesignExistingHubHeight> SstPredesignExistingHubHeights { get; set; }


        public DbSet<TowerSections> TowerSections { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<RnaCost> RnaCosts { get; set; }
        public DbSet<TowerDesignCost> TowerDesignCosts { get; set; }
        public DbSet<TowerSupplierSource> TowerSupplierSources { get; set; }
        public DbSet<TowerSupplierRegion> TowerSupplierRegions { get; set; }
        public DbSet<InterfaceTools> InterfaceTools { get; set; }
        public DbSet<WtgCatalogueModel> WtgCatalogueModels { get; set; }
        public DbSet<CertificationCost> CertificationCosts { get; set; }
        public DbSet<SstDesignRequest>  SstDesignRequests { get; set; }


        #endregion

        #region Application CostAndFeedBack

        public DbSet<CostFeedback> CostFeedBack { get; set; }
        public DbSet<CostOverView> CostOverView { get; set; }
        public DbSet<CostOverViewRNA> CostOverViewRNA { get; set; }
        public DbSet<CostOverViewMeta> CostOverViewMeta { get; set; }
        public DbSet<CostsTowerConstruction> CostsTowerConstruction { get; set; }
        public DbSet<CostsTowerConstructionMeta> CostsTowerConstructionMeta { get; set; }
        public DbSet<CostsTowerConstructionLeadTimeMeta> CostsTowerConstructionLeadTimeMeta { get; set; }
        public DbSet<CostsTowerCustomsLineItem> CostsTowerCustomsLineItem { get; set; }
        public DbSet<CostsTowerCustoms> CostsTowerCustoms { get; set; }
        public DbSet<CostsTowerCustomsSupplier> CostsTowerCustomsSupplier { get; set; }
        public DbSet<CostsTowerCustomsMeta> CostsTowerCustomsMeta { get; set; }
        public DbSet<CostsTowerExWorksLineItem> CostsTowerExWorksLineItem { get; set; }
        public DbSet<CostsTowerExWorksMeta> CostsTowerExWorksMeta { get; set; }
        public DbSet<CostsTowerExWorks> CostsTowerExWorks { get; set; }

        public DbSet<CostsTowerLogistics> CostsTowerLogistics { get; set; }
        public DbSet<CostsTowerLogisticsSupplier> CostsTowerLogisticsSupplier { get; set; }
        public DbSet<CostsTowerLogisticsMeta> CostsTowerLogisticsMeta { get; set; }
        public DbSet<CostsTowerLogisticsLeadTimeLineitem> CostsTowerLogisticsLeadTime { get; set; }
        public DbSet<CostsTowerLogisticsLeadTimeMeta> CostsTowerLogisticsLeadTimeMeta { get; set; }
        public DbSet<CostsTowerSupplier> CostsTowerSupplier { get; set; }
        public DbSet<CostsTowerSupplierLineItem> CostsTowerSupplierLineItem { get; set; }
        public DbSet<CostsTowerSupplierMeta> CostsTowerSupplierMeta { get; set; }

        public DbSet<CostsTechnology> CostsTechnology { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

        #endregion



        #region Interfaces

        // tables belong to other interfaces
        // SWAT
        public DbSet<SwatLoad> SwatLoads { get; set; }

        // Towersite
        public DbSet<TowersiteListRegion> TowersiteListRegions { get; set; }
        public DbSet<TowersiteListTower> TowersiteListTowers { get; set; }
        public DbSet<TowersiteBevel> TowersiteBevels { get; set; }
        public DbSet<TowersiteFlange> TowersiteFlanges { get; set; }
        public DbSet<TowersiteGeoDoor> TowersiteGeoDoors { get; set; }
        public DbSet<TowersiteGeoMain> TowersiteGeoMains { get; set; }
        public DbSet<TowersitePlate> TowersitePlates { get; set; }
        public DbSet<TowersitePlatesSummary> TowersitePlatesSummaries { get; set; }
        public DbSet<TowersiteVivBolt> TowersiteVivBolts { get; set; }
        public DbSet<TowersiteVivWindspeed> TowersiteVivWindspeeds { get; set; }
        public DbSet<EtlJobAudit> EtlJobAudit { get; set; }
        public DbSet<TowersitePlatesTowerSummary> TowersitePlatesTowerSummaries { get; set; }
        public DbSet<TowersiteMasses> TowersiteMasses { get; set; }
        public DbSet<TowersiteReportGeneralData> TowersiteReportGeneralData { get; set; }
        public DbSet<TowersiteCloeReport> TowersiteCloeReports { get; set; }
        public DbSet<TowersiteReportSectionsData> TowersiteReportSectionsData { get; set; }
        public DbSet<TowersiteReportTotalSectionsData> TowersiteReportTotalSectionsData { get; set; }
        public DbSet<TowersiteFlangePair> TowersiteFlangePairs { get; set; }
        public DbSet<TowersiteVmList> TowersiteVmList { get; set; }
        public DbSet<TowersiteReportDesignStatus> TowersiteReportDesignStatus { get; set; }
        #endregion

        public DbSet<LogisticProjectBoundary> LogisticProjectBoundaries { get; set; }

        public TsaContext(DbContextOptions<TsaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Application
            modelBuilder.Entity<Certification>().Property(c => c.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<ConstructionConstraint>().Property(cc => cc.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Country>().Property(c => c.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<GenericMarketBoundary>().Property(gmb => gmb.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<LogisticConstraint>().Property(lc => lc.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<LogisticStatus>().Property(ls => ls.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<MileStone>().Property(ms => ms.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Permission>().HasIndex(pms => new { pms.RoleId, pms.ProjectModuleId });
            modelBuilder.Entity<Permission>().Property(pms => pms.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<PermitsSalesConstraint>().Property(prmt => prmt.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Project>().HasIndex(p => p.OpportunityId).IsUnique();
            modelBuilder.Entity<Project>().HasIndex(p => p.ProjectName).IsUnique();
            modelBuilder.Entity<Project>().Property(p => p.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<ProjectConstraint>().HasIndex(pc => new { pc.Id, pc.ProjectId }).IsUnique();
            modelBuilder.Entity<ProjectConstraint>().HasIndex(pc => new { pc.ProjectId }).IsUnique();

            modelBuilder.Entity<ProjectModule>().Property(pm => pm.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Proposal>().HasIndex(ps => ps.ProposalId).IsUnique();
            modelBuilder.Entity<Proposal>().Property(ps => ps.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Quote>().HasIndex(qt => new { qt.ProposalId, qt.QuotationId }).IsUnique();
            modelBuilder.Entity<Quote>().Property(q => q.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Region>().Property(rg => rg.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Role>().Property(r => r.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Scenario>().HasIndex(sc => new { sc.ScenarioType, sc.ItemId });
            modelBuilder.Entity<Scenario>().Property(s => s.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<ScenarioCostsKpi>().Property(sck => sck.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<ScenarioDesign>().Property(sd => sd.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<SpecialRequirementsSalesConstraint>().Property(srsc => srsc.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<Task>().Property(t => t.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<TransportMode>().Property(tm => tm.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<WtgCatalogue>().Property(wc => wc.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<WtgCatalogue>().Property(wc => wc.WtgSizeMW).HasPrecision(10, 5);

            modelBuilder.Entity<QuoteLine>().Property(ql => ql.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<QuoteLine>().Property(ql => ql.WindfarmSize).HasPrecision(10, 2);

            modelBuilder.Entity<WtgThreshold>().Property(wt => wt.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<WtgThreshold>().Property(wt => wt.WindFarmSize).HasPrecision(10, 2);
            modelBuilder.Entity<LoadsCluster>().Property(lc => lc.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowerType>().Property(twr => twr.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TowerType>().HasIndex(twr => new { twr.WtgCatalogueId, twr.Tower }).IsUnique();

            modelBuilder.Entity<ApplicationMode>().Property(amd => amd.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<ApplicationMode>().HasIndex(amd => new { amd.WtgCatalogueId, amd.ApplicationModeNo, amd.PowerRating }).IsUnique();
            modelBuilder.Entity<NoiseMode>().Property(nm => nm.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<ApplicationReason>().Property(ar => ar.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<PresetRoles>().Property(c => c.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SstTower>().Property(ssti => ssti.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SstPredesignDimesions>().Property(sstp => sstp.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SstPredesignProposedHubHeight>().Property(sstph => sstph.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<NacelleDistance>().Property(nd => nd.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SSTAepLookupGross>().Property(aep => aep.aepInputFile).HasColumnType("jsonb");
            modelBuilder.Entity<BaseTower>().Property(bt => bt.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<BaseTowerDesignDimension>().Property(btdd => btdd.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<ScenarioOverView>(sv => { sv.HasNoKey(); sv.ToView("scenario_overview"); });
            modelBuilder.Entity<CostOverView>(sv => { sv.HasNoKey(); sv.ToView("cost_overview"); });
            modelBuilder.Entity<CostOverViewRNA>(sv => { sv.HasNoKey(); sv.ToView("cost_overview_rna"); });

            modelBuilder.Entity<SstDesignEvaluation>().Property(de => de.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SstDesignEvaluation>().HasIndex(de => de.sstTowerId).IsUnique();
            modelBuilder.Entity<SstDesignSeismicAssessment>().Property(dsa => dsa.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SstDesignSeismicAssessment>().HasIndex(sa => sa.SstDesignEvaluationId).IsUnique();
            modelBuilder.Entity<Summary>(s => { s.HasNoKey(); s.ToView("design_confirmation_summary_view"); });
            modelBuilder.Entity<SegmentDimensionsSummaryDetailView>(sdst => { sdst.HasNoKey(); sdst.ToView("segment_dimensions_summary_detail_view"); });
            modelBuilder.Entity<SegmentDimensionsSummaryView>(sdsv => { sdsv.HasNoKey(); sdsv.ToView("segment_dimensions_summary_view"); });
            modelBuilder.Entity<TowerSections>().Property(ts => ts.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowerSections>().HasIndex(ts => new { ts.TowerTypeId, ts.SectionNumber }).IsUnique();

            modelBuilder.Entity<InitialTower>().Property(twr => twr.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<InitialTower>().HasIndex(twr => new { twr.WtgCatalogueId, twr.Tower, twr.Model }).IsUnique();

            modelBuilder.Entity<SstPredesignExistingHubHeight>().Property(sstehh => sstehh.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<Currency>().Property(c => c.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<RnaCost>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowerDesignCost>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowerSupplierRegion>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowerSupplierSource>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<InterfaceTools>().Property(r => r.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<WtgCatalogueModel>().Property(wcm => wcm.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CertificationCost>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SstDesignRequest>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SstDesignRequest>().Property(sst => sst.JsonServiceBusPayload).HasColumnType("jsonb");


            #endregion

            #region Application CostAndFeedBack

            modelBuilder.Entity<CostFeedback>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostFeedback>().HasIndex(cf => new { cf.ScenarioId }).IsUnique();
            modelBuilder.Entity<CostOverViewMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerConstruction>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerConstructionMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerConstructionLeadTimeMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerCustomsLineItem>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerCustoms>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerCustomsSupplier>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerCustomsMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerExWorksLineItem>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerExWorksMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerExWorks>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerLogistics>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerLogisticsSupplier>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerLogisticsMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerLogisticsLeadTimeLineitem>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerLogisticsLeadTimeMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerSupplierLineItem>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerSupplierMeta>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<CostsTowerSupplier>().Property(r => r.Id).UseIdentityAlwaysColumn();

            modelBuilder.Entity<CostsTechnology>().Property(r => r.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<Suppliers>().Property(r => r.Id).UseIdentityAlwaysColumn();


            #endregion


            #region Interfaces

            // Models for Interfaces
            modelBuilder.Entity<SwatLoad>().Property(sw => sw.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteListRegion>().Property(tr => tr.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteListTower>().Property(ts => ts.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteBevel>().Property(tb => tb.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteFlange>().Property(tf => tf.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteGeoDoor>().Property(tgdr => tgdr.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteGeoMain>().Property(tgm => tgm.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersitePlate>().Property(tp => tp.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersitePlatesSummary>().Property(tps => tps.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteVivBolt>().Property(tvb => tvb.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteVivBolt>().Property(tvb => tvb.TightenedBoltsPercentage).HasPrecision(10, 5);
            modelBuilder.Entity<TowersiteVivWindspeed>().Property(tvw => tvw.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<EtlJobAudit>().Property(ejb => ejb.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersitePlatesTowerSummary>().Property(tpts => tpts.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteMasses>().Property(tms => tms.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteReportGeneralData>().Property(trgd => trgd.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteCloeReport>().Property(tcr => tcr.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteReportSectionsData>().Property(trs => trs.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteReportTotalSectionsData>().Property(trts => trts.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteFlangePair>().Property(tfp => tfp.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteVmList>().Property(tvml => tvml.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<TowersiteReportDesignStatus>().Property(trds => trds.Id).UseIdentityAlwaysColumn();

            #endregion

            modelBuilder.Entity<LogisticProjectBoundary>().Property(lpb => lpb.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<LogisticProjectBoundary>().HasIndex(lpb => new { lpb.LogisticConstraintId, lpb.TransportModeId }).IsUnique();

            modelBuilder.Seed();

        }
    }

}
