using Microsoft.EntityFrameworkCore;
using SGRE.TSA.DataStore.API.Enums;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Context
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedRoles();
            builder.SeedCurrencies();
            builder.SeedTowerDesignCost();
            builder.SeedRegionCountries();
            builder.SeedMileStones();
            builder.SeedTasks();
            builder.SeedCertification();
            builder.SeedTurbineTypes();
            builder.SeedLogisticStatus();
            builder.SeedWtgThreshold();
            builder.SeedTransportModes();
            builder.SeedGeneralMarketBoundaries();
            builder.SeedProjectModules();
            builder.SeedPermissions();
            builder.SeedLoadClusters();
            builder.SeedTowerTypes();
            builder.SeedTowerSections();
            builder.SeedApplicationModes();
            builder.SeedApplicationReasons();
            builder.SeedPresetRoles();
            builder.SeedNacelleDistance();
            builder.SeedNoiseModes();
            builder.SeedInitialTower();
            builder.SeedRnaCosts();
            builder.SeedTowerSupplierRegionCountries();
            builder.SeedTowerSupplierInterfaceTools();

            builder.SeedTowerCostOverViewMeta();
            builder.SeedTowerSupplier();
            builder.SeedTowerExWorks();
            builder.SeedTowerLogisticCost();
            builder.SeedTowerLogisticLeadTimes();
            builder.SeedTowerCostCustoms();
            builder.SeedTowerConstruction();
            builder.SeedTowerConstructionLead();

            builder.SeedCatalogueModel();
            builder.SeedCertificationCosts();
        }

        #region CostAndFeedBack
        private static void SeedTowerCostOverViewMeta(this ModelBuilder builder)
        {
            builder.Entity<CostOverViewMeta>().HasData(
                new CostOverViewMeta { Id = 1, SubSectionName = "Tower EXW", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostOverViewMeta { Id = 2, SubSectionName = "Logistics", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostOverViewMeta { Id = 3, SubSectionName = "Construction", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostOverViewMeta { Id = 4, SubSectionName = "Customs", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostOverViewMeta { Id = 5, SubSectionName = "Tower Design", TypeOfTower = TypeOfTower.SST, IsMandatory = true },
                new CostOverViewMeta { Id = 6, SubSectionName = "Certification", TypeOfTower = TypeOfTower.SST, IsMandatory = true },
                new CostOverViewMeta { Id = 7, SubSectionName = "Total Cost", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostOverViewMeta { Id = 8, SubSectionName = "RNA*", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostOverViewMeta { Id = 9, SubSectionName = "Cost incl. RNA", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true }
                );
        }

        private static void SeedTowerSupplier(this ModelBuilder builder)
        {
            builder.Entity<CostsTowerSupplierMeta>().HasData(
                new CostsTowerSupplierMeta { Id = 1, LineItemName = "No. of towers", LineItemType = "int", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerSupplierMeta { Id = 2, LineItemName = "Supplier name", LineItemType = "string", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerSupplierMeta { Id = 3, LineItemName = "Supplier region", LineItemType = "string", TypeOfTower = TypeOfTower.BOTH, LineItemSource = "TowerSupplierRegion", IsMandatory = true },
                new CostsTowerSupplierMeta { Id = 4, LineItemName = "Country", LineItemType = "string", TypeOfTower = TypeOfTower.BOTH, LineItemSource = "TowerSupplierSource", IsMandatory = true },
                new CostsTowerSupplierMeta { Id = 5, LineItemName = "Lead time est. (wks)", LineItemType = "int", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerSupplierMeta { Id = 6, LineItemName = "Lead time (wks)", LineItemType = "int", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true }
                );
        }

        private static void SeedTowerExWorks(this ModelBuilder builder)
        {
            builder.Entity<CostsTowerExWorksMeta>().HasData(
                new CostsTowerExWorksMeta { Id = 1, LineItemName = "Tower Flanges", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 2, LineItemName = "Paint", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 3, LineItemName = "Tower Shell", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 4, LineItemName = "Tower Conversion", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 5, LineItemName = "Doorframe", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 6, LineItemName = "Elevator", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 7, LineItemName = "Internals", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 8, LineItemName = "Others", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 9, LineItemName = "Tarps & Plugs", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 10, LineItemName = "Mounting kit", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 11, LineItemName = "Structural Bolt", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 12, LineItemName = "Flanges - anchor cage", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 13, LineItemName = "Anchor Cage System", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 14, LineItemName = "Handling fee", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerExWorksMeta { Id = 15, LineItemName = "Tower Transport(if not EXW)", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = false },
                new CostsTowerExWorksMeta { Id = 16, LineItemName = "Customs raw material (if in scope)", LineItemType = "decimal ", TypeOfTower = TypeOfTower.BOTH, IsMandatory = false }
                );
        }

        private static void SeedTowerLogisticCost(this ModelBuilder builder)
        {
            builder.Entity<CostsTowerLogisticsMeta>().HasData(
                new CostsTowerLogisticsMeta { Id = 1, LineItemName = "1.2.1 - Logistic Costs - Origin", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerLogisticsMeta { Id = 2, LineItemName = "1.2.2 - Logistic Costs - Sea freight", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerLogisticsMeta { Id = 3, LineItemName = "1.2.3 - Logistic Costs - Destination", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerLogisticsMeta { Id = 4, LineItemName = "1.2.4 - Costs out of EXWss scope", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true }

                );
        }

        private static void SeedTowerLogisticLeadTimes(this ModelBuilder builder)
        {
            builder.Entity<CostsTowerLogisticsLeadTimeMeta>().HasData(
                new CostsTowerLogisticsLeadTimeMeta { Id = 1, LineItemName = "Transport at origin", LineItemType = "int", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerLogisticsLeadTimeMeta { Id = 2, LineItemName = "Sea freight", LineItemType = "int", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerLogisticsLeadTimeMeta { Id = 3, LineItemName = "Transport at destination to site", LineItemType = "int", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true }

                );
        }

        private static void SeedTowerCostCustoms(this ModelBuilder builder)
        {
            builder.Entity<CostsTowerCustomsMeta>().HasData(
                new CostsTowerCustomsMeta { Id = 1, LineItemName = "Customs rate on Tower EXW and LOG(%)", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true },
                new CostsTowerCustomsMeta { Id = 2, LineItemName = "Customs cost per WTG on Tower EXW and LOG", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true }

                );
        }

        private static void SeedTowerConstructionLead(this ModelBuilder builder)
        {
            builder.Entity<CostsTowerConstructionLeadTimeMeta>().HasData(
                new CostsTowerConstructionLeadTimeMeta { Id = 1, LineItemName = "Total erection(dys)", LineItemType = "decimal", TypeOfTower = TypeOfTower.BOTH, IsMandatory = true }

                );
        }

        private static void SeedTowerConstruction(this ModelBuilder builder)
        {
            builder.Entity<CostsTowerConstructionMeta>().HasData(
                new CostsTowerConstructionMeta { Id = 1, LineItemName = "Total per WTG", LineItemType = "decimal", TypeOfTower = TypeOfTower.SST, IsMandatory = true },
                new CostsTowerConstructionMeta { Id = 2, LineItemName = "Total", LineItemType = "decimal", TypeOfTower = TypeOfTower.STPETP, IsMandatory = true }
                );
        }





        #endregion

        private static void SeedRoles(this ModelBuilder builder)
        {
            const string CreatedByUser = "admin@siemensgamesa.com";
            const string UpdatedByUser = "admin@siemensgamesa.com";
            var rolesList = new List<string>()
            {
                "Opportunity Owner",
                "Proposal Manager",
                "Siting Engineer",
                "Technical Project Manager",
                "Global Project Engineering",
                "Planning Towers",
                "Procurement Manager",
                "Logistic Pre Sales Road Engineer",
                "PR Pre-Sales Logistic",
                "PR Pre-Sales Construction",
                "Construction Technical Office",
                "Tower Development Structure",
                "Tower Development Internals / Drawings/BOM",
                "Customs Tower",
                "Certification Tower Component Certificate",
                "Certification  SSA",
                "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning"
            };

            var rolesDescriptionList = new List<string>()
            {
                "Sales Manager",
                "Proposal Manager",
                "Siting Engineer",
                "Technical Project Manager",
                "Global Project Engineering",
                "Planning Towers",
                "Procurement Manager",
                "Logistic Pre Sales Road Engineer",
                "PR Pre-Sales Logistic",
                "PR Pre-Sales Construction",
                "Construction Technical Office",
                "Tower Development",
                "",
                "",
                "Certification Engineering",
                "",
                ""
            };

            var roles = rolesList.Select((ri, idx) => new Role { Id = idx + 1, RoleName = ri, CreatedBy = CreatedByUser, UpdatedBy = UpdatedByUser, RoleDescription = rolesDescriptionList[idx] });
            builder.Entity<Role>().HasData(roles);
        }

        private static void SeedCurrencies(this ModelBuilder builder)
        {
            builder.Entity<Currency>().HasData(
                new Currency { Id = 1, Code = "CNY/RNB", Description = "Chinese Yuan/Renminbi - CNY/RMB (¥)", Name = "Chinese Yuan/Renminbi", DisplayName = "CNY/RMB (¥)" },
                new Currency { Id = 2, Code = "USD", Description = "US Dollar - USD ($)", Name = "United States dollar", DisplayName = "USD ($)" },
                new Currency { Id = 3, Code = "BRL", Description = "Brazilian Real - BRL (R$)", Name = "Brazilian Real", DisplayName = "BRL (R$)" },
                new Currency { Id = 4, Code = "INR", Description = "Indian Rupee - INR (₹)", Name = "Indian Rupee", DisplayName = "INR (₹)" },
                new Currency { Id = 5, Code = "EUR", Description = "Euro - EUR (€)", Name = "Euro", DisplayName = "EUR (€)" }
                );
        }

        private static void SeedTowerDesignCost(this ModelBuilder builder)
        {
            builder.Entity<TowerDesignCost>().HasData(
                new TowerDesignCost { Id = 1, CurrencyId = 5, CostKilo = 25 },
                new TowerDesignCost { Id = 2, CurrencyId = 2, CostKilo = 30M },
                new TowerDesignCost { Id = 3, CurrencyId = 1, CostKilo = 213M },
                new TowerDesignCost { Id = 4, CurrencyId = 3, CostKilo = 156M },
                new TowerDesignCost { Id = 5, CurrencyId = 4, CostKilo = 2323M }

                );
        }

        private static void SeedRegionCountries(this ModelBuilder builder)
        {
            // Create static dictionary of region, list of countries
            Dictionary<string, List<string>> regionCountriesStaticDict = new Dictionary<string, List<string>>();
            regionCountriesStaticDict.Add(
                 "APAC,1", new List<string> {
                     "China", "Japan", "South Korea", "Australia", "Vietnam", "New Zealand", "Philippines", "Indonesia", "Taiwan", "Pakistan",
                     "Mongolia", "Thailand", "Myanmar", "New Caledonia", "Cambodia", "Laos"}
             );
            regionCountriesStaticDict.Add(
                 "BRAZIL,3", new List<string> { "Brazil" }
             );
            regionCountriesStaticDict.Add(
                 "INDIA,4", new List<string> { "India", "Sri Lanka", "Bangladesh" }
             );
            regionCountriesStaticDict.Add(
                 "LATAM,2", new List<string> { "Brazil", "Mexico", "Peru", "Dominican Rep.", "Argentina", "Panama", "Chile", "Uruguay", "Colombia", "Belize",
                     "Nicaragua", "Jamaica", "Guatemala", "Honduras", "Costa Rica", "El Salvador", "Cuba", "Dominica", "Guyana", "Ecuador", "Guadeloupe",
                     "Puerto Rico", "Trinidad Tobago", "Bahamas", "Bolivia", "Barbados" }
             );
            regionCountriesStaticDict.Add(
                 "NE&ME,5", new List<string> { "Ireland", "Sweden", "Germany", "Romania", "Croatia", "Finland", "Belgium", "Uzbekistan", "Serbia", "United Kingdom",
                     "Poland", "Saudi Arabia", "Denmark", "Utd Arab Emir.", "Ukraine", "Bulgaria", "Azerbaijan", "Turkey", "Norway", "Moldovia",
                     "Iran Islamic Republic of", "Russian Fed.", "Bosnia-Herz.", "Israel", "Lebanon", "Kazakhstan", "Slovenia", "Netherlands", "Hungary",
                     "Albania", "Austria", "Oman", "Switzerland", "Georgia", "Syrian Arab Republic", "Macedonia", "Luxembourg", "Kuwait", "Czech Republic",
                     "Yemen", "Belarus", "Lithuania", "Iceland", "Estonia", "Latvia", "Armenia", "Montenegro", "Faroe Islands", "Bahrain" }
             );
            regionCountriesStaticDict.Add(
                 "NORTH AMERICA,2", new List<string> { "USA", "Canada" }
             );
            regionCountriesStaticDict.Add(
                 "SE&A,5", new List<string> { "France", "Spain", "Greece", "Morocco", "Egypt", "South Africa", "Italy", "Ghana", "Mauritius", "Kenya", "Angola",
                     "Togo", "Jordan", "Zambia", "Senegal", "Ethiopia", "Cyprus", "Namibia", "Gambia", "Portugal", "Djibouti", "Mauritania", "Sudan", "Mozambique",
                     "Algeria", "Tunisia", "Tanzania", "Ivory Coast", "Guinea", "Uganda", "Nigeria", "Libya", "Cabo Verde", "Lesotho" }
             );


            int regionCounter = 0;
            int countryCounter = 1;
            foreach (KeyValuePair<string, List<string>> entry in regionCountriesStaticDict)
            {
                regionCounter++;
                string regionName = entry.Key.Split(',')[0];
                builder.Entity<Region>().HasData(new Region { Id = regionCounter, RegionName = regionName });

                List<string> countryStaticList = entry.Value;

                foreach (string cntry in countryStaticList)
                {
                    var Currency = Convert.ToInt32(entry.Key.Split(',')[1]);
                    if (cntry.Equals("China"))
                    {
                        Currency = 1;
                    }
                    else if (cntry.Equals("Australia"))
                    {
                        Currency = 2;
                    }

                    builder.Entity<Country>().HasData(new Country { Id = countryCounter, CountryName = cntry, RegionId = regionCounter, CurrencyId = Currency });
                    countryCounter++;
                }

            }


        }

        private static void SeedTowerSupplierRegionCountries(this ModelBuilder builder)
        {
            // Create static dictionary of region, list of countries
            Dictionary<string, List<string>> regionCountriesStaticDict = new Dictionary<string, List<string>>();
            regionCountriesStaticDict.Add(
                 "APAC,1,1", new List<string> {
                     "China", "Indonesia (Kenertec)","Vietnam (CS WIND)"}
             );
            regionCountriesStaticDict.Add(
                 "BRA,1,2", new List<string> { "Brazil" }
             );
            regionCountriesStaticDict.Add(
                 "IN,1,3", new List<string> { "India - GJ", "India - MH", "India - TN" }
             );
            regionCountriesStaticDict.Add(
                 "LATAM,1,4", new List<string> { "Mexico - East", "Mexico - North" }
             );
            regionCountriesStaticDict.Add(
                 "NA,1,6", new List<string> { "USA - North", "USA - South" }
             );
            regionCountriesStaticDict.Add(
                 "NEME,1,5", new List<string> { "Denmark (Valmont SM)", "Poland (GSG)", "Turkey" }
             );
            regionCountriesStaticDict.Add(
                 "SEA,1,7", new List<string> { "Egypt (NSF)", "Egypt (SIAG)", "Greece (EMEK)", "Italy (Pugliese)", "Spain/Portugal" }
             );

            regionCountriesStaticDict.Add(
                 "EUROPE,2,5", new List<string> { "SPAIN", "DENMARK", "ITALY" }
             );
            regionCountriesStaticDict.Add(
                 "APAC,2,1", new List<string> { "CHINA", "VIETNAM" }
             );

            regionCountriesStaticDict.Add(
                 "China,3,1", new List<string> { }
             );
            regionCountriesStaticDict.Add(
                 "BRAZIL,3,2", new List<string> { }
             );
            regionCountriesStaticDict.Add(
                 "INDIA,3,3", new List<string> { }
             );
            regionCountriesStaticDict.Add(
                 "LATAM,3,4", new List<string> { }
             );
            regionCountriesStaticDict.Add(
                 "NA,3,6", new List<string> { }
             );
            regionCountriesStaticDict.Add(
                 "NEME,3,5", new List<string> { }
             );
            regionCountriesStaticDict.Add(
                 "SE&A,3,7", new List<string> { }
             );

            int regionCounter = 0;
            int countryCounter = 1;
            foreach (KeyValuePair<string, List<string>> entry in regionCountriesStaticDict)
            {
                regionCounter++;
                string regionName = entry.Key.Split(',')[0];
                int InterfaceID = Convert.ToInt32(entry.Key.Split(',')[1]);
                int regionId = Convert.ToInt32(entry.Key.Split(',')[2]);
                builder.Entity<TowerSupplierRegion>().HasData(new TowerSupplierRegion { Id = regionCounter, InterfaceToolsId = InterfaceID, RegionName = regionName, RegionId = regionId });

                List<string> countryStaticList = entry.Value;

                foreach (string cntry in countryStaticList)
                {
                    builder.Entity<TowerSupplierSource>().HasData(new TowerSupplierSource { Id = countryCounter, SourcingName = cntry, TowerSupplierRegionId = regionCounter });
                    countryCounter++;
                }

            }


        }

        private static void SeedTowerSupplierInterfaceTools(this ModelBuilder builder)
        {
            builder.Entity<InterfaceTools>().HasData(
                new InterfaceTools { Id = 1, ToolName = "TowerCubo", Description = "Towersite Interface" },
                new InterfaceTools { Id = 2, ToolName = "SST", Description = "SST Interface" },
                new InterfaceTools { Id = 3, ToolName = "TowerSite", Description = "Towersite Interface" }
                );

        }

        // seed mile stones
        private static void SeedMileStones(this ModelBuilder builder)
        {
            var mileStoneList = new List<string>()
             {
                 "PM020 - Bid decision",
                 "PM040 - Binding offer",
                 "PM070 - Contract signature",
                 "PM080 - Notice to proceed",
                 "Certification Target Date",
                 "PM650 - Take-over to customer"
             };

            var mileStones = mileStoneList.Select((ms, idx) => new MileStone { Id = idx + 1, MileStoneName = ms });
            builder.Entity<MileStone>().HasData(mileStones);
        }


        // Seed Project scope Tasks
        private static void SeedTasks(this ModelBuilder builder)
        {
            var taskList = new List<string>()
            {
                "Tower design",
                "Foundation design",
                "Anchor Cage design",
                "Preliminary Logistic Assessment",
                "Road Survey",
                "Transport oversea",
                "Transport inland",
                "Anchor cage delivery",
                "Foundation construction",
                "Tower installation"
            };

            var tasks = taskList.Select((task, idx) => new Task { Id = idx + 1, TaskName = task });
            builder.Entity<Task>().HasData(tasks);

        }

        // Seed Certifications
        private static void SeedCertification(this ModelBuilder builder)
        {
            var certificationList = new List<string>()
            {
                "Tower component certificate",
                "Site Suitability Design Assessment (SSDA)",
                "Tower component certificate & Site Suitability Design Assessment (SSDA)",
                "None"
            };

            var certifications = certificationList.Select((cf, idx) => new Certification { Id = idx + 1, CertificationName = cf });
            builder.Entity<Certification>().HasData(certifications);

        }

        // Seed Turbine Types
        private static void SeedTurbineTypes(this ModelBuilder builder)
        {
            builder.Entity<WtgCatalogue>().HasData(
                new WtgCatalogue { Id = 1, Platform = "SG5.X", WtgType = "SG 6.0-170", WtgSizeMW = 6.2M },
                new WtgCatalogue { Id = 2, Platform = "SG5.X", WtgType = "SG 6.0-155", WtgSizeMW = 6.6M },
                new WtgCatalogue { Id = 3, Platform = "SG4.X", WtgType = "SG 5.0-145", WtgSizeMW = 5M },
                new WtgCatalogue { Id = 4, Platform = "SG4.X", WtgType = "SG 5.0-132", WtgSizeMW = 5M },
                new WtgCatalogue { Id = 5, Platform = "SG3.X", WtgType = "SG 3.4-145", WtgSizeMW = 3.6M },
                new WtgCatalogue { Id = 6, Platform = "SG3.X", WtgType = "SG 3.4-132", WtgSizeMW = 3.65M },
                new WtgCatalogue { Id = 7, Platform = "SG4.X", WtgType = "SG 4.7-155", WtgSizeMW = 5M }

            );
        }

        private static void SeedRnaCosts(this ModelBuilder builder)
        {
            builder.Entity<RnaCost>().HasData(
                new RnaCost { Id = 1, WtgCatalogueId = 1, CurrencyId = 5, CostKilo = 2120 },
                new RnaCost { Id = 2, WtgCatalogueId = 2, CurrencyId = 5, CostKilo = 2019 },
                new RnaCost { Id = 3, WtgCatalogueId = 4, CurrencyId = 5, CostKilo = 1363 },
                new RnaCost { Id = 4, WtgCatalogueId = 3, CurrencyId = 5, CostKilo = 1419 },
                new RnaCost { Id = 5, WtgCatalogueId = 7, CurrencyId = 5, CostKilo = 1531 },
                new RnaCost { Id = 6, WtgCatalogueId = 5, CurrencyId = 5, CostKilo = 1206 },
                new RnaCost { Id = 7, WtgCatalogueId = 6, CurrencyId = 5, CostKilo = 1150 },

                new RnaCost { Id = 8, WtgCatalogueId = 1, CurrencyId = 2, CostKilo = 2523 },
                new RnaCost { Id = 9, WtgCatalogueId = 2, CurrencyId = 2, CostKilo = 2403 },
                new RnaCost { Id = 10, WtgCatalogueId = 4, CurrencyId = 2, CostKilo = 1622 },
                new RnaCost { Id = 11, WtgCatalogueId = 3, CurrencyId = 2, CostKilo = 1689 },
                new RnaCost { Id = 12, WtgCatalogueId = 7, CurrencyId = 2, CostKilo = 1822 },
                new RnaCost { Id = 13, WtgCatalogueId = 5, CurrencyId = 2, CostKilo = 1435 },
                new RnaCost { Id = 14, WtgCatalogueId = 6, CurrencyId = 2, CostKilo = 1369 },

                new RnaCost { Id = 15, WtgCatalogueId = 1, CurrencyId = 1, CostKilo = 18041 },
                new RnaCost { Id = 16, WtgCatalogueId = 2, CurrencyId = 1, CostKilo = 17182 },
                new RnaCost { Id = 17, WtgCatalogueId = 4, CurrencyId = 1, CostKilo = 11599 },
                new RnaCost { Id = 18, WtgCatalogueId = 3, CurrencyId = 1, CostKilo = 12076 },
                new RnaCost { Id = 19, WtgCatalogueId = 7, CurrencyId = 1, CostKilo = 13029 },
                new RnaCost { Id = 20, WtgCatalogueId = 5, CurrencyId = 1, CostKilo = 10263 },
                new RnaCost { Id = 21, WtgCatalogueId = 6, CurrencyId = 1, CostKilo = 9787 },

                new RnaCost { Id = 22, WtgCatalogueId = 1, CurrencyId = 3, CostKilo = 13250 },
                new RnaCost { Id = 23, WtgCatalogueId = 2, CurrencyId = 3, CostKilo = 12619 },
                new RnaCost { Id = 24, WtgCatalogueId = 4, CurrencyId = 3, CostKilo = 8519 },
                new RnaCost { Id = 25, WtgCatalogueId = 3, CurrencyId = 3, CostKilo = 8869 },
                new RnaCost { Id = 26, WtgCatalogueId = 7, CurrencyId = 3, CostKilo = 9569 },
                new RnaCost { Id = 27, WtgCatalogueId = 5, CurrencyId = 3, CostKilo = 7538 },
                new RnaCost { Id = 28, WtgCatalogueId = 6, CurrencyId = 3, CostKilo = 7188 },

                new RnaCost { Id = 29, WtgCatalogueId = 1, CurrencyId = 4, CostKilo = 196948 },
                new RnaCost { Id = 30, WtgCatalogueId = 2, CurrencyId = 4, CostKilo = 187565 },
                new RnaCost { Id = 31, WtgCatalogueId = 4, CurrencyId = 4, CostKilo = 126623 },
                new RnaCost { Id = 32, WtgCatalogueId = 3, CurrencyId = 4, CostKilo = 131825 },
                new RnaCost { Id = 33, WtgCatalogueId = 7, CurrencyId = 4, CostKilo = 142230 },
                new RnaCost { Id = 34, WtgCatalogueId = 5, CurrencyId = 4, CostKilo = 112037 },
                new RnaCost { Id = 35, WtgCatalogueId = 6, CurrencyId = 4, CostKilo = 106835 }
                );
        }

        private static void SeedCertificationCosts(this ModelBuilder builder)
        {
            builder.Entity<CertificationCost>().HasData(
                    new CertificationCost { Id = 1, CertificationId = 1, CurrencyId = 5, CostKilo = 20 },
                    new CertificationCost { Id = 2, CertificationId = 1, CurrencyId = 2, CostKilo = 24 },
                    new CertificationCost { Id = 3, CertificationId = 1, CurrencyId = 1, CostKilo = 170 },
                    new CertificationCost { Id = 4, CertificationId = 1, CurrencyId = 4, CostKilo = 1858 },
                    new CertificationCost { Id = 5, CertificationId = 1, CurrencyId = 3, CostKilo = 125 },

                    new CertificationCost { Id = 6, CertificationId = 2, CurrencyId = 5, CostKilo = 50 },
                    new CertificationCost { Id = 7, CertificationId = 2, CurrencyId = 2, CostKilo = 60 },
                    new CertificationCost { Id = 8, CertificationId = 2, CurrencyId = 1, CostKilo = 426 },
                    new CertificationCost { Id = 9, CertificationId = 2, CurrencyId = 4, CostKilo = 4645 },
                    new CertificationCost { Id = 10, CertificationId = 2, CurrencyId = 3, CostKilo = 313 },

                    new CertificationCost { Id = 11, CertificationId = 3, CurrencyId = 5, CostKilo = 70 },
                    new CertificationCost { Id = 12, CertificationId = 3, CurrencyId = 2, CostKilo = 83 },
                    new CertificationCost { Id = 13, CertificationId = 3, CurrencyId = 1, CostKilo = 596 },
                    new CertificationCost { Id = 14, CertificationId = 3, CurrencyId = 4, CostKilo = 6503 },
                    new CertificationCost { Id = 15, CertificationId = 3, CurrencyId = 3, CostKilo = 438 },

                    new CertificationCost { Id = 16, CertificationId = 4, CurrencyId = 5, CostKilo = 0 },
                    new CertificationCost { Id = 17, CertificationId = 4, CurrencyId = 2, CostKilo = 0 },
                    new CertificationCost { Id = 18, CertificationId = 4, CurrencyId = 1, CostKilo = 0 },
                    new CertificationCost { Id = 19, CertificationId = 4, CurrencyId = 4, CostKilo = 0 },
                    new CertificationCost { Id = 20, CertificationId = 4, CurrencyId = 3, CostKilo = 0 }

                 );
        }


        private static void SeedLogisticStatus(this ModelBuilder builder)
        {
            var lgxStatusList = new List<string>()
            {
                "not available (use generic market boundaries)",
                "order received for Preliminary Logistics Assessment",
                "Preliminary Logistics Assessment available (for project-specific boundaries)",
                "order received for Road Survey",
                "Road Survey available"
            };

            var lgxStatuses = lgxStatusList.Select((s, idx) => new LogisticStatus { Id = idx + 1, Status = s });
            builder.Entity<LogisticStatus>().HasData(lgxStatuses);
        }

        private static void SeedWtgThreshold(this ModelBuilder builder)
        {
            builder.Entity<WtgThreshold>().HasData(
                new WtgThreshold { Id = 1, WindFarmSize = 100, TurbineQuantity = 20 }
                );
        }

        private static void SeedTransportModes(this ModelBuilder builder)
        {
            var transportModeList = new List<string>()
            {
               "Road",
               "Rail"
            };

            var transportModes = transportModeList.Select((tmode, idx) => new TransportMode { Id = idx + 1, Name = tmode });
            builder.Entity<TransportMode>().HasData(transportModes);
        }

        private static void SeedGeneralMarketBoundaries(this ModelBuilder builder)
        {
            builder.Entity<GenericMarketBoundary>().HasData(
             new GenericMarketBoundary { Id = 1, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 48, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 2, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 49, MaxTowerBaseDiameterMtrs = 4.3M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 3, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 65, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 4, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 74, MaxTowerBaseDiameterMtrs = 4.3M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 5, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 64, MaxTowerBaseDiameterMtrs = 4.8M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 6, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 98, MaxTowerBaseDiameterMtrs = 4.68M, MaxSegmentWeightTon = 80, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 7, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 99, MaxTowerBaseDiameterMtrs = 4.68M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 8, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 104, MaxTowerBaseDiameterMtrs = 4.68M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 9, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 22, MaxTowerBaseDiameterMtrs = 4.8M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 30 },
             new GenericMarketBoundary { Id = 10, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 27, MaxTowerBaseDiameterMtrs = 4.8M, MaxSegmentWeightTon = 90, MaxSegmentLengthMtrs = 30 },
             new GenericMarketBoundary { Id = 11, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 29, MaxTowerBaseDiameterMtrs = 4.7M, MaxSegmentWeightTon = 90, MaxSegmentLengthMtrs = 30 },
             new GenericMarketBoundary { Id = 12, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 25, MaxTowerBaseDiameterMtrs = 4.8M, MaxSegmentWeightTon = 90, MaxSegmentLengthMtrs = 30 },
             new GenericMarketBoundary { Id = 13, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 21, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 14, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 97, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 72.57M, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 15, TransportModeId = (int)Enums.LogisticTransportModes.Rail, CountryId = 97, MaxTowerBaseDiameterMtrs = 4.115M, MaxSegmentWeightTon = 72.57M, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 16, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 1, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 18, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 18, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 70, MaxSegmentLengthMtrs = 30 },
             new GenericMarketBoundary { Id = 19, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 56, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 20, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 47, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 85, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 21, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 102, MaxTowerBaseDiameterMtrs = 4.7M, MaxSegmentWeightTon = 80, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 22, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 101, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 80, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 23, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 103, MaxTowerBaseDiameterMtrs = 4.68M, MaxSegmentWeightTon = 80, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 24, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 96, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 72.57M, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 25, TransportModeId = (int)Enums.LogisticTransportModes.Rail, CountryId = 96, MaxTowerBaseDiameterMtrs = 4.115M, MaxSegmentWeightTon = 72.57M, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 26, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 4, MaxTowerBaseDiameterMtrs = 4.3M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 50 },
             new GenericMarketBoundary { Id = 27, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 2, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 28, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 3, MaxTowerBaseDiameterMtrs = 4.3M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 29, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 5, MaxTowerBaseDiameterMtrs = 4.7M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 30, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 7, MaxTowerBaseDiameterMtrs = 4.5M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 31, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 8, MaxTowerBaseDiameterMtrs = 4.3M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 },
             new GenericMarketBoundary { Id = 32, TransportModeId = (int)Enums.LogisticTransportModes.Road, CountryId = 12, MaxTowerBaseDiameterMtrs = 4.3M, MaxSegmentWeightTon = 95, MaxSegmentLengthMtrs = 36 }

        );
        }

        private static void SeedProjectModules(this ModelBuilder builder)
        {

            var projectModuleList = new List<string>()
            {
                "Create new opportunity",
                "Opporutinty information",
                "Opportunity key milestones",
                "Roles & Responsiblities",
                "Project Constraints",
                "Logistics constraints",
                "Construction constraints",
                "Scope & Responsibility",
                "Certification",
                "Quote",
                "Add turbine type",
                "Add baseline scenario",
                "Add SST scenario"
            };

            var modules = projectModuleList.Select((pm, idx) => new ProjectModule { Id = idx + 1, ModuleName = pm });
            builder.Entity<ProjectModule>().HasData(modules);
        }

        private static void SeedPermissions(this ModelBuilder builder)
        {
            const string CreatedByUser = "admin@siemensgamesa.com";
            const string UpdatedByUser = "admin@siemensgamesa.com";

            const int canRead = (int)PermissionTypes.Read;
            const int canWrite = (int)PermissionTypes.Write;
            const int canDelegate = (int)PermissionTypes.Delegate;

            Dictionary<string, Dictionary<string, int>> permissionDict = new Dictionary<string, Dictionary<string, int>>()
            {
                { "Create new opportunity" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Opporutinty information" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Opportunity key milestones" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Roles & Responsiblities" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canDelegate },
                        { "Technical Project Manager", canDelegate },
                        { "Global Project Engineering", canDelegate },
                        { "Planning Towers", canDelegate },
                        { "Procurement Manager", canDelegate },
                        { "Logistic Pre-Sales Road Engineer", canDelegate },
                        { "PR Pre-Sales (Logistic)", canDelegate },
                        { "PR Pre-Sales (Construction)", canDelegate },
                        { "Construction Technical Office", canDelegate },
                        { "Tower Development Structure", canDelegate },
                        { "Tower Development Internals / Drawings / BOM", canDelegate },
                        { "Customs Tower", canDelegate },
                        { "Certification Tower Component Certificate", canDelegate },
                        { "Certification SSA", canDelegate },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canDelegate }
                    }
                },
                { "Project Constraints" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Logistics constraints" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canWrite },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Construction constraints" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canWrite },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Scope & Responsibility" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Certification" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canWrite },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Quote" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Add turbine type" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canRead },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Add baseline scenario" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canWrite },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                },
                { "Add SST scenario" , new Dictionary<string, int>
                    {
                        { "Sales Manger", canWrite },
                        { "Proposal Manager", canWrite },
                        { "Siting Engineer", canRead },
                        { "Technical Project Manager", canWrite },
                        { "Global Project Engineering", canRead },
                        { "Planning Towers", canRead },
                        { "Procurement Manager", canRead },
                        { "Logistic Pre-Sales Road Engineer", canRead },
                        { "PR Pre-Sales (Logistic)", canRead },
                        { "PR Pre-Sales (Construction)", canRead },
                        { "Construction Technical Office", canRead },
                        { "Tower Development Structure", canRead },
                        { "Tower Development Internals / Drawings / BOM", canRead },
                        { "Customs Tower", canRead },
                        { "Certification Tower Component Certificate", canRead },
                        { "Certification SSA", canRead },
                        { "Pre-Sales (S&MK) / Cost Proposal Office / CRO Planning", canRead }
                    }
                }

            };

            int idx = 0;
            int pmCounter = 0;
            foreach (var projectModule in permissionDict)
            {
                pmCounter++;
                int roleCounter = 0;

                foreach (var rolePermission in projectModule.Value)
                {
                    idx++;
                    roleCounter++;
                    builder.Entity<Permission>().HasData(
                         new Permission
                         {
                             Id = idx,
                             RoleId = roleCounter,
                             ProjectModuleId = pmCounter,
                             PermissionType = (PermissionTypes)rolePermission.Value,
                             CreatedBy = CreatedByUser,
                             UpdatedBy = UpdatedByUser
                         }
                    );
                }
            }
        }


        // Seed LoadClusters
        private static void SeedLoadClusters(this ModelBuilder builder)
        {
            var loadClusterList = new List<string>()
             {
                 "A", "B", "C", "D", "E", "F"

             };

            var loadClusters = loadClusterList.Select((cluster, idx) => new LoadsCluster { Id = idx + 1, ClusterName = cluster });
            builder.Entity<LoadsCluster>().HasData(loadClusters);
        }

        // Seed Application Modes
        private static void SeedApplicationModes(this ModelBuilder builder)
        {
            Dictionary<string, Dictionary<int, decimal>> applicationModeDict = new Dictionary<string, Dictionary<int, decimal>>()
           {
               { "SG 6.0-170" , new Dictionary<int, decimal>
                   {
                       {0, 6.2M},  {1, 6.1M}, {2, 6M}, {3, 5.9M}, {4, 5.8M}, {5, 5.7M}, {6, 5.6M}
                   }
               },
               { "SG 6.0-155" , new Dictionary<int, decimal>
                   {
                       {0, 6.6M},  {1, 6.5M}, {2, 6.4M}, {3, 6.3M}, {4, 6.2M}, {5, 6.1M}, {6, 6M}, {7, 5.8M}, {8, 5.6M}
                   }
               },
               { "SG 5.0-145" , new Dictionary<int, decimal>
                   {
                       {0, 5M},  {1, 4.9M}, {2, 4.8M}, {3, 4.7M}, {4, 4.6M}, {5, 4.5M}, {6, 4.2M}, {7, 4M}
                   }
               },
               { "SG 5.0-132" , new Dictionary<int, decimal>
                   {
                       {0, 5M},  {1, 4.9M}, {2, 4.8M}, {3, 4.7M}, {4, 4.6M}, {5, 4.5M}, {6, 4.2M}, {7, 4M}
                   }
               },
               { "SG 3.4-145" , new Dictionary<int, decimal>
                   {
                       {0, 3.465M},  {1, 3.6M}
                   }
               },
               { "SG 3.4-132" , new Dictionary<int, decimal>
                   {
                       {-1, 3.3M}, {0, 3.465M},  {1, 3.55M}, {2, 3.65M}, {3, 3.75M}
                   }
               },
               { "SG 4.7-155" , new Dictionary<int, decimal>
                   {
                       {3, 5M},  {2, 4.9M}, {1, 4.8M}, {0, 4.7M}, {-1, 4.6M}, {-2, 4.5M}, {-3, 4.2M}, {-4, 4M}
                   }
               },
           };

            int wtgCounter = 0;
            int applModeCounter = 1;
            foreach (var item in applicationModeDict)
            {
                wtgCounter++;

                foreach (var tbn in item.Value)
                {

                    builder.Entity<ApplicationMode>().HasData(
                         new ApplicationMode
                         {
                             Id = applModeCounter,
                             ApplicationModeNo = tbn.Key,
                             PowerRating = tbn.Value,
                             WtgCatalogueId = wtgCounter
                         }
                    );
                    applModeCounter++;
                }
            }
        }

        // Seed TowerTypes
        private static void SeedTowerTypes(this ModelBuilder builder)
        {
            // SG 3.4-145 - missing in the input file - Later add it upon getting
            builder.Entity<TowerType>().HasData(
                new TowerType { Id = 1, Tower = "T115-50A", HubHeightM = 115, WtgCatalogueId = 1 },
                new TowerType { Id = 2, Tower = "T135-50A", HubHeightM = 135, WtgCatalogueId = 1 },
                new TowerType { Id = 3, Tower = "T102.5-50A", HubHeightM = 102.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 4, Tower = "T122.5-50A", HubHeightM = 122.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 5, Tower = "T79.5.40", HubHeightM = 79.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 6, Tower = "T90.41", HubHeightM = 90, WtgCatalogueId = 3 },
                new TowerType { Id = 7, Tower = "T102.5.42", HubHeightM = 102.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 8, Tower = "T102.5.43", HubHeightM = 102.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 9, Tower = "T127.5.40L2", HubHeightM = 127.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 10, Tower = "T157.5.40L2", HubHeightM = 157.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 11, Tower = "T84.41", HubHeightM = 84, WtgCatalogueId = 4 },
                new TowerType { Id = 12, Tower = "T84.36", HubHeightM = 84, WtgCatalogueId = 6 },
                new TowerType { Id = 13, Tower = "T97.31", HubHeightM = 97, WtgCatalogueId = 6 },
                new TowerType { Id = 14, Tower = "T101.5.31", HubHeightM = 101.5M, WtgCatalogueId = 6 },

                new TowerType { Id = 15, Tower = "T100-51A", HubHeightM = 100, WtgCatalogueId = 1 },
                new TowerType { Id = 16, Tower = "T101.5-50A", HubHeightM = 101.5M, WtgCatalogueId = 1 },
                new TowerType { Id = 17, Tower = "T115-51A", HubHeightM = 115, WtgCatalogueId = 1 },
                new TowerType { Id = 18, Tower = "T115-52A-WTC", HubHeightM = 115, WtgCatalogueId = 1 },
                new TowerType { Id = 19, Tower = "T135-51A-WTC", HubHeightM = 135, WtgCatalogueId = 1 },
                new TowerType { Id = 20, Tower = "T145-50A", HubHeightM = 145, WtgCatalogueId = 1 },
                new TowerType { Id = 21, Tower = "T155-50A", HubHeightM = 155, WtgCatalogueId = 1 },
                new TowerType { Id = 22, Tower = "T165-51A-MB", HubHeightM = 165, WtgCatalogueId = 1 },

                new TowerType { Id = 23, Tower = "T90-50A", HubHeightM = 90, WtgCatalogueId = 2 },
                new TowerType { Id = 24, Tower = "T102.5-51A", HubHeightM = 102.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 25, Tower = "T107.5-50A", HubHeightM = 107.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 26, Tower = "T113.5-50A", HubHeightM = 113.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 27, Tower = "T117.5-50A", HubHeightM = 117.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 28, Tower = "T120.5-50A", HubHeightM = 120.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 29, Tower = "T122.5-51A", HubHeightM = 122.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 30, Tower = "T122.5-52A", HubHeightM = 122.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 31, Tower = "T122.5-53A-WTC", HubHeightM = 122.5M, WtgCatalogueId = 2 },
                new TowerType { Id = 32, Tower = "T165-50A-MB", HubHeightM = 165, WtgCatalogueId = 2 },

                new TowerType { Id = 33, Tower = "T90.40", HubHeightM = 90, WtgCatalogueId = 3 },
                new TowerType { Id = 34, Tower = "T91.40", HubHeightM = 91, WtgCatalogueId = 3 },
                new TowerType { Id = 35, Tower = "T91.41", HubHeightM = 91, WtgCatalogueId = 3 },
                new TowerType { Id = 36, Tower = "T95.5.40", HubHeightM = 95.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 37, Tower = "T95.5.41", HubHeightM = 95.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 38, Tower = "T97.5.40", HubHeightM = 97.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 39, Tower = "T97.5.41", HubHeightM = 97.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 40, Tower = "T127.5.40", HubHeightM = 127.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 41, Tower = "T127.5.41", HubHeightM = 127.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 42, Tower = "T127.5.43", HubHeightM = 127.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 43, Tower = "T127.5.44", HubHeightM = 127.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 44, Tower = "T127.5.45", HubHeightM = 127.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 45, Tower = "T127.5.46", HubHeightM = 127.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 46, Tower = "T86.40L1", HubHeightM = 86, WtgCatalogueId = 3 },
                new TowerType { Id = 47, Tower = "T90.40L1", HubHeightM = 90, WtgCatalogueId = 3 },
                new TowerType { Id = 48, Tower = "T90.40L2", HubHeightM = 90, WtgCatalogueId = 3 },
                new TowerType { Id = 49, Tower = "T97.5.40L2", HubHeightM = 97.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 50, Tower = "T107.5.40", HubHeightM = 107.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 51, Tower = "T107.5.41", HubHeightM = 107.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 52, Tower = "T107.5.42", HubHeightM = 107.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 53, Tower = "T117.5.40L1", HubHeightM = 117.5M, WtgCatalogueId = 3 },
                new TowerType { Id = 54, Tower = "T144.41-MB", HubHeightM = 144, WtgCatalogueId = 3 },
                new TowerType { Id = 55, Tower = "T165.40", HubHeightM = 165, WtgCatalogueId = 3 },

                new TowerType { Id = 56, Tower = "T84.40", HubHeightM = 84, WtgCatalogueId = 4 },
                new TowerType { Id = 57, Tower = "T84.43", HubHeightM = 84, WtgCatalogueId = 4 },
                new TowerType { Id = 58, Tower = "T79.40", HubHeightM = 79, WtgCatalogueId = 4 },
                new TowerType { Id = 59, Tower = "T106.5.40", HubHeightM = 106.5M, WtgCatalogueId = 4 },

                new TowerType { Id = 60, Tower = "T84.39", HubHeightM = 84, WtgCatalogueId = 6 },
                new TowerType { Id = 61, Tower = "T84.310", HubHeightM = 84, WtgCatalogueId = 6 },
                new TowerType { Id = 62, Tower = "T108.30", HubHeightM = 108, WtgCatalogueId = 6 },
                new TowerType { Id = 63, Tower = "T114.30", HubHeightM = 114, WtgCatalogueId = 6 },
                new TowerType { Id = 64, Tower = "T134.30", HubHeightM = 134, WtgCatalogueId = 6 },
                new TowerType { Id = 65, Tower = "T84.38", HubHeightM = 84, WtgCatalogueId = 6 },

                new TowerType { Id = 66, Tower = "T94.31", HubHeightM = 94, WtgCatalogueId = 5 },
                new TowerType { Id = 67, Tower = "T100.5.31", HubHeightM = 100.5M, WtgCatalogueId = 5 },
                new TowerType { Id = 68, Tower = "T127.5.31", HubHeightM = 127.5M, WtgCatalogueId = 5 },

                new TowerType { Id = 69, Tower = "T102.5.44", HubHeightM = 102.5M, WtgCatalogueId = 7 }

            );

        }

        //Seed TowerSections
        private static void SeedTowerSections(this ModelBuilder builder)
        {
            builder.Entity<TowerSections>().HasData(
                    new TowerSections { Id = 1, SectionNumber = 1, SectionHeightM = 18.5M, ExternalDiameterUpperFlangeM = 4.199M, ExternalDiameterLowerFlangeM = 4.262M, TotalWeightKg = 70160.09637M, TowerTypeId = 14 },
                    new TowerSections { Id = 2, SectionNumber = 2, SectionHeightM = 25.5M, ExternalDiameterUpperFlangeM = 4.021M, ExternalDiameterLowerFlangeM = 4.199M, TotalWeightKg = 65000.0382281152M, TowerTypeId = 14 },
                    new TowerSections { Id = 3, SectionNumber = 3, SectionHeightM = 26M, ExternalDiameterUpperFlangeM = 3.617M, ExternalDiameterLowerFlangeM = 4.021M, TotalWeightKg = 48034.3002290754M, TowerTypeId = 14 },
                    new TowerSections { Id = 4, SectionNumber = 4, SectionHeightM = 29.5M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.617M, TotalWeightKg = 44546.9183001487M, TowerTypeId = 14 },

                    new TowerSections { Id = 5, SectionNumber = 1, SectionHeightM = 16.26M, ExternalDiameterUpperFlangeM = 4.43M, ExternalDiameterLowerFlangeM = 4.678M, TotalWeightKg = 67400.6562M, TowerTypeId = 62 },
                    new TowerSections { Id = 6, SectionNumber = 2, SectionHeightM = 18.155M, ExternalDiameterUpperFlangeM = 4.422M, ExternalDiameterLowerFlangeM = 4.43M, TotalWeightKg = 54725.375M, TowerTypeId = 62 },
                    new TowerSections { Id = 7, SectionNumber = 3, SectionHeightM = 21.1M, ExternalDiameterUpperFlangeM = 4.4185M, ExternalDiameterLowerFlangeM = 4.422M, TotalWeightKg = 49666.6M, TowerTypeId = 62 },
                    new TowerSections { Id = 8, SectionNumber = 4, SectionHeightM = 23.14M, ExternalDiameterUpperFlangeM = 3.928M, ExternalDiameterLowerFlangeM = 4.4185M, TotalWeightKg = 44320.3M, TowerTypeId = 62 },
                    new TowerSections { Id = 9, SectionNumber = 5, SectionHeightM = 27.345M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.928M, TotalWeightKg = 44460.825M, TowerTypeId = 62 },

                    new TowerSections { Id = 10, SectionNumber = 1, SectionHeightM = 16.945M, ExternalDiameterUpperFlangeM = 4.436M, ExternalDiameterLowerFlangeM = 4.678M, TotalWeightKg = 83749.9994512532M, TowerTypeId = 63 },
                    new TowerSections { Id = 11, SectionNumber = 2, SectionHeightM = 20.94M, ExternalDiameterUpperFlangeM = 4.427M, ExternalDiameterLowerFlangeM = 4.436M, TotalWeightKg = 76993.3915643459M, TowerTypeId = 63 },
                    new TowerSections { Id = 12, SectionNumber = 3, SectionHeightM = 21.115M, ExternalDiameterUpperFlangeM = 4.422M, ExternalDiameterLowerFlangeM = 4.427M, TotalWeightKg = 58383.4531819233M, TowerTypeId = 63 },
                    new TowerSections { Id = 13, SectionNumber = 4, SectionHeightM = 24M, ExternalDiameterUpperFlangeM = 3.928M, ExternalDiameterLowerFlangeM = 4.422M, TotalWeightKg = 50004.9526003036M, TowerTypeId = 63 },
                    new TowerSections { Id = 14, SectionNumber = 5, SectionHeightM = 29M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.928M, TotalWeightKg = 48491.1257999243M, TowerTypeId = 63 },

                    new TowerSections { Id = 15, SectionNumber = 1, SectionHeightM = 14.685M, ExternalDiameterUpperFlangeM = 4.675M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 79873.2065903408M, TowerTypeId = 64 },
                    new TowerSections { Id = 16, SectionNumber = 2, SectionHeightM = 18.805M, ExternalDiameterUpperFlangeM = 4.4335M, ExternalDiameterLowerFlangeM = 4.675M, TotalWeightKg = 75629.5520237498M, TowerTypeId = 64 },
                    new TowerSections { Id = 17, SectionNumber = 3, SectionHeightM = 20.33M, ExternalDiameterUpperFlangeM = 4.131M, ExternalDiameterLowerFlangeM = 4.4335M, TotalWeightKg = 71395.49987894M, TowerTypeId = 64 },
                    new TowerSections { Id = 18, SectionNumber = 4, SectionHeightM = 22.86M, ExternalDiameterUpperFlangeM = 3.712M, ExternalDiameterLowerFlangeM = 4.131M, TotalWeightKg = 69970.7862593915M, TowerTypeId = 64 },
                    new TowerSections { Id = 19, SectionNumber = 5, SectionHeightM = 25.82M, ExternalDiameterUpperFlangeM = 3.3725M, ExternalDiameterLowerFlangeM = 3.712M, TotalWeightKg = 69651.0650992417M, TowerTypeId = 64 },
                    new TowerSections { Id = 20, SectionNumber = 6, SectionHeightM = 29.5M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.3725M, TotalWeightKg = 48927.5428520448M, TowerTypeId = 64 },

                    new TowerSections { Id = 21, SectionNumber = 1, SectionHeightM = 20.12M, ExternalDiameterUpperFlangeM = 4.2425M, ExternalDiameterLowerFlangeM = 4.49M, TotalWeightKg = 59540.3319378491M, TowerTypeId = 61 },
                    new TowerSections { Id = 22, SectionNumber = 2, SectionHeightM = 26.88M, ExternalDiameterUpperFlangeM = 3.599M, ExternalDiameterLowerFlangeM = 4.2425M, TotalWeightKg = 53858.9494767659M, TowerTypeId = 61 },
                    new TowerSections { Id = 23, SectionNumber = 3, SectionHeightM = 35M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.599M, TotalWeightKg = 54381.2908135302M, TowerTypeId = 61 },

                    new TowerSections { Id = 24, SectionNumber = 1, SectionHeightM = 23M, ExternalDiameterUpperFlangeM = 4.023M, ExternalDiameterLowerFlangeM = 4.25M, TotalWeightKg = 69271.0919942961M, TowerTypeId = 12 },
                    new TowerSections { Id = 25, SectionNumber = 2, SectionHeightM = 29.5M, ExternalDiameterUpperFlangeM = 3.369M, ExternalDiameterLowerFlangeM = 4.023M, TotalWeightKg = 55748.7283933678M, TowerTypeId = 12 },
                    new TowerSections { Id = 26, SectionNumber = 3, SectionHeightM = 29.5M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.369M, TotalWeightKg = 44269.27434724M, TowerTypeId = 12 },

                    new TowerSections { Id = 27, SectionNumber = 1, SectionHeightM = 16.615M, ExternalDiameterUpperFlangeM = 4.031M, ExternalDiameterLowerFlangeM = 4.278M, TotalWeightKg = 66996.798789125M, TowerTypeId = 65 },
                    new TowerSections { Id = 28, SectionNumber = 2, SectionHeightM = 20.92M, ExternalDiameterUpperFlangeM = 4.024M, ExternalDiameterLowerFlangeM = 4.031M, TotalWeightKg = 58746.2080302979M, TowerTypeId = 65 },
                    new TowerSections { Id = 29, SectionNumber = 3, SectionHeightM = 20.935M, ExternalDiameterUpperFlangeM = 4.017M, ExternalDiameterLowerFlangeM = 4.024M, TotalWeightKg = 43002.4447877913M, TowerTypeId = 65 },
                    new TowerSections { Id = 30, SectionNumber = 4, SectionHeightM = 23.53M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 4.017M, TotalWeightKg = 42467.522416899M, TowerTypeId = 65 },

                    new TowerSections { Id = 31, SectionNumber = 1, SectionHeightM = 23.1M, ExternalDiameterUpperFlangeM = 4.02M, ExternalDiameterLowerFlangeM = 4.25M, TotalWeightKg = 61411.1449455023M, TowerTypeId = 60 },
                    new TowerSections { Id = 32, SectionNumber = 2, SectionHeightM = 29.4M, ExternalDiameterUpperFlangeM = 3.3665M, ExternalDiameterLowerFlangeM = 4.02M, TotalWeightKg = 51510.2859937298M, TowerTypeId = 60 },
                    new TowerSections { Id = 33, SectionNumber = 3, SectionHeightM = 29.5M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.3665M, TotalWeightKg = 43501.5358851085M, TowerTypeId = 60 },

                    new TowerSections { Id = 34, SectionNumber = 1, SectionHeightM = 19.715M, ExternalDiameterUpperFlangeM = 4.0285M, ExternalDiameterLowerFlangeM = 4.27M, TotalWeightKg = 71264.2092980532M, TowerTypeId = 13 },
                    new TowerSections { Id = 35, SectionNumber = 2, SectionHeightM = 25.035M, ExternalDiameterUpperFlangeM = 4.02M, ExternalDiameterLowerFlangeM = 4.0285M, TotalWeightKg = 62142.3284516878M, TowerTypeId = 13 },
                    new TowerSections { Id = 36, SectionNumber = 3, SectionHeightM = 23.62M, ExternalDiameterUpperFlangeM = 3.7155M, ExternalDiameterLowerFlangeM = 4.02M, TotalWeightKg = 43041.6182663396M, TowerTypeId = 13 },
                    new TowerSections { Id = 37, SectionNumber = 4, SectionHeightM = 26.66M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.7155M, TotalWeightKg = 41138.5466141124M, TowerTypeId = 13 },

                    new TowerSections { Id = 38, SectionNumber = 1, SectionHeightM = 20M, ExternalDiameterUpperFlangeM = 4.435M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 70751.6172964368M, TowerTypeId = 67 },
                    new TowerSections { Id = 39, SectionNumber = 2, SectionHeightM = 20M, ExternalDiameterUpperFlangeM = 4.25M, ExternalDiameterLowerFlangeM = 4.435M, TotalWeightKg = 52473.665523135M, TowerTypeId = 67 },
                    new TowerSections { Id = 40, SectionNumber = 3, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.598M, ExternalDiameterLowerFlangeM = 4.25M, TotalWeightKg = 49109.3424374901M, TowerTypeId = 67 },
                    new TowerSections { Id = 41, SectionNumber = 4, SectionHeightM = 31.383M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.598M, TotalWeightKg = 47074.9987794463M, TowerTypeId = 67 },

                    new TowerSections { Id = 42, SectionNumber = 1, SectionHeightM = 18.58M, ExternalDiameterUpperFlangeM = 4.281M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 80926.8655968548M, TowerTypeId = 68 },
                    new TowerSections { Id = 43, SectionNumber = 2, SectionHeightM = 24.18M, ExternalDiameterUpperFlangeM = 4.275M, ExternalDiameterLowerFlangeM = 4.281M, TotalWeightKg = 76535.2184249788M, TowerTypeId = 68 },
                    new TowerSections { Id = 44, SectionNumber = 3, SectionHeightM = 26.42M, ExternalDiameterUpperFlangeM = 4.27M, ExternalDiameterLowerFlangeM = 4.275M, TotalWeightKg = 64327.8423988724M, TowerTypeId = 68 },
                    new TowerSections { Id = 45, SectionNumber = 4, SectionHeightM = 26.98M, ExternalDiameterUpperFlangeM = 4.267M, ExternalDiameterLowerFlangeM = 4.27M, TotalWeightKg = 50409.5541382303M, TowerTypeId = 68 },
                    new TowerSections { Id = 46, SectionNumber = 5, SectionHeightM = 29.34M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 4.267M, TotalWeightKg = 48333.6642076774M, TowerTypeId = 68 },

                    new TowerSections { Id = 47, SectionNumber = 1, SectionHeightM = 29.75M, ExternalDiameterUpperFlangeM = 4.0225M, ExternalDiameterLowerFlangeM = 4.27M, TotalWeightKg = 84879M, TowerTypeId = 66 },
                    new TowerSections { Id = 48, SectionNumber = 2, SectionHeightM = 30M, ExternalDiameterUpperFlangeM = 3.598M, ExternalDiameterLowerFlangeM = 4.0225M, TotalWeightKg = 58971M, TowerTypeId = 66 },
                    new TowerSections { Id = 49, SectionNumber = 3, SectionHeightM = 32.25M, ExternalDiameterUpperFlangeM = 3.395M, ExternalDiameterLowerFlangeM = 3.598M, TotalWeightKg = 48381.3M, TowerTypeId = 66 },

                    new TowerSections { Id = 50, SectionNumber = 1, SectionHeightM = 19.465M, ExternalDiameterUpperFlangeM = 4.4297M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 79304.2207846251M, TowerTypeId = 69 },
                    new TowerSections { Id = 51, SectionNumber = 2, SectionHeightM = 24.09M, ExternalDiameterUpperFlangeM = 4.4222M, ExternalDiameterLowerFlangeM = 4.4297M, TotalWeightKg = 70365.0974274015M, TowerTypeId = 69 },
                    new TowerSections { Id = 52, SectionNumber = 3, SectionHeightM = 27.46M, ExternalDiameterUpperFlangeM = 4.0182M, ExternalDiameterLowerFlangeM = 4.4222M, TotalWeightKg = 59567.7112101046M, TowerTypeId = 69 },
                    new TowerSections { Id = 53, SectionNumber = 4, SectionHeightM = 29.485M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.0182M, TotalWeightKg = 52736.5238022118M, TowerTypeId = 69 },

                    new TowerSections { Id = 54, SectionNumber = 1, SectionHeightM = 16.62M, ExternalDiameterUpperFlangeM = 4.645M, ExternalDiameterLowerFlangeM = 4.678M, TotalWeightKg = 77484.4826088329M, TowerTypeId = 59 },
                    new TowerSections { Id = 55, SectionNumber = 2, SectionHeightM = 20.54M, ExternalDiameterUpperFlangeM = 4.427M, ExternalDiameterLowerFlangeM = 4.645M, TotalWeightKg = 71489.0704483512M, TowerTypeId = 59 },
                    new TowerSections { Id = 56, SectionNumber = 3, SectionHeightM = 20.82M, ExternalDiameterUpperFlangeM = 4.4205M, ExternalDiameterLowerFlangeM = 4.427M, TotalWeightKg = 56712.3598603607M, TowerTypeId = 59 },
                    new TowerSections { Id = 57, SectionNumber = 4, SectionHeightM = 22.78M, ExternalDiameterUpperFlangeM = 4.015M, ExternalDiameterLowerFlangeM = 4.4205M, TotalWeightKg = 45698.1919607363M, TowerTypeId = 59 },
                    new TowerSections { Id = 58, SectionNumber = 5, SectionHeightM = 23.74M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.015M, TotalWeightKg = 40953.0928427819M, TowerTypeId = 59 },

                    new TowerSections { Id = 59, SectionNumber = 1, SectionHeightM = 21.77M, ExternalDiameterUpperFlangeM = 4.026M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 71717.9794037245M, TowerTypeId = 58 },
                    new TowerSections { Id = 60, SectionNumber = 2, SectionHeightM = 25.73M, ExternalDiameterUpperFlangeM = 3.6196M, ExternalDiameterLowerFlangeM = 4.026M, TotalWeightKg = 57516.5372370362M, TowerTypeId = 58 },
                    new TowerSections { Id = 61, SectionNumber = 3, SectionHeightM = 29.5M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.6196M, TotalWeightKg = 50002.1044804811M, TowerTypeId = 58 },

                    new TowerSections { Id = 62, SectionNumber = 1, SectionHeightM = 16.62M, ExternalDiameterUpperFlangeM = 4.032M, ExternalDiameterLowerFlangeM = 4.278M, TotalWeightKg = 68538.1527158438M, TowerTypeId = 56 },
                    new TowerSections { Id = 63, SectionNumber = 2, SectionHeightM = 20.82M, ExternalDiameterUpperFlangeM = 4.023M, ExternalDiameterLowerFlangeM = 4.032M, TotalWeightKg = 59192.004867504M, TowerTypeId = 56 },
                    new TowerSections { Id = 64, SectionNumber = 3, SectionHeightM = 20.82M, ExternalDiameterUpperFlangeM = 3.617M, ExternalDiameterLowerFlangeM = 4.023M, TotalWeightKg = 42107.8551723855M, TowerTypeId = 56 },
                    new TowerSections { Id = 65, SectionNumber = 4, SectionHeightM = 23.74M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.617M, TotalWeightKg = 41590.645453645M, TowerTypeId = 56 },

                    new TowerSections { Id = 66, SectionNumber = 1, SectionHeightM = 16.62M, ExternalDiameterUpperFlangeM = 4.032M, ExternalDiameterLowerFlangeM = 4.278M, TotalWeightKg = 64903.8064636172M, TowerTypeId = 11 },
                    new TowerSections { Id = 67, SectionNumber = 2, SectionHeightM = 20.82M, ExternalDiameterUpperFlangeM = 4.0221M, ExternalDiameterLowerFlangeM = 4.0305M, TotalWeightKg = 56614.9899728068M, TowerTypeId = 11 },
                    new TowerSections { Id = 68, SectionNumber = 3, SectionHeightM = 20.82M, ExternalDiameterUpperFlangeM = 3.6174M, ExternalDiameterLowerFlangeM = 4.0221M, TotalWeightKg = 40944.2928282642M, TowerTypeId = 11 },
                    new TowerSections { Id = 69, SectionNumber = 4, SectionHeightM = 23.74M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.6174M, TotalWeightKg = 39526.4565551635M, TowerTypeId = 11 },

                    new TowerSections { Id = 70, SectionNumber = 1, SectionHeightM = 16.62M, ExternalDiameterUpperFlangeM = 4.0302M, ExternalDiameterLowerFlangeM = 4.278M, TotalWeightKg = 64077.2M, TowerTypeId = 57 },
                    new TowerSections { Id = 71, SectionNumber = 2, SectionHeightM = 20.82M, ExternalDiameterUpperFlangeM = 4.0215M, ExternalDiameterLowerFlangeM = 4.0302M, TotalWeightKg = 54284.1M, TowerTypeId = 57 },
                    new TowerSections { Id = 72, SectionNumber = 3, SectionHeightM = 20.82M, ExternalDiameterUpperFlangeM = 3.6174M, ExternalDiameterLowerFlangeM = 4.0215M, TotalWeightKg = 39652.4M, TowerTypeId = 57 },
                    new TowerSections { Id = 73, SectionNumber = 4, SectionHeightM = 23.74M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.6174M, TotalWeightKg = 39427.1M, TowerTypeId = 57 },

                    new TowerSections { Id = 74, SectionNumber = 1, SectionHeightM = 19.7M, ExternalDiameterUpperFlangeM = 4.43M, ExternalDiameterLowerFlangeM = 4.678M, TotalWeightKg = 79730.4361332054M, TowerTypeId = 7 },
                    new TowerSections { Id = 75, SectionNumber = 2, SectionHeightM = 25.299929199M, ExternalDiameterUpperFlangeM = 4.422M, ExternalDiameterLowerFlangeM = 4.43M, TotalWeightKg = 71971.7332403929M, TowerTypeId = 7 },
                    new TowerSections { Id = 76, SectionNumber = 3, SectionHeightM = 28.1M, ExternalDiameterUpperFlangeM = 4.017M, ExternalDiameterLowerFlangeM = 4.422M, TotalWeightKg = 59627.7130020409M, TowerTypeId = 7 },
                    new TowerSections { Id = 77, SectionNumber = 4, SectionHeightM = 27.336M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.017M, TotalWeightKg = 47562.5989351092M, TowerTypeId = 7 },

                    new TowerSections { Id = 78, SectionNumber = 1, SectionHeightM = 14.1M, ExternalDiameterUpperFlangeM = 4.431M, ExternalDiameterLowerFlangeM = 4.481M, TotalWeightKg = 62627.4938667841M, TowerTypeId = 8 },
                    new TowerSections { Id = 79, SectionNumber = 2, SectionHeightM = 16.9M, ExternalDiameterUpperFlangeM = 4.424M, ExternalDiameterLowerFlangeM = 4.431M, TotalWeightKg = 55264.0949134258M, TowerTypeId = 8 },
                    new TowerSections { Id = 80, SectionNumber = 3, SectionHeightM = 19.7M, ExternalDiameterUpperFlangeM = 4.419M, ExternalDiameterLowerFlangeM = 4.424M, TotalWeightKg = 49732.7753793405M, TowerTypeId = 8 },
                    new TowerSections { Id = 81, SectionNumber = 4, SectionHeightM = 25.3M, ExternalDiameterUpperFlangeM = 4.416M, ExternalDiameterLowerFlangeM = 4.419M, TotalWeightKg = 50217.588592868M, TowerTypeId = 8 },
                    new TowerSections { Id = 82, SectionNumber = 5, SectionHeightM = 24.434M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.416M, TotalWeightKg = 43464.4702787122M, TowerTypeId = 8 },

                    new TowerSections { Id = 83, SectionNumber = 1, SectionHeightM = 13.325M, ExternalDiameterUpperFlangeM = 4.4365M, ExternalDiameterLowerFlangeM = 4.678M, TotalWeightKg = 70694.8126862531M, TowerTypeId = 50 },
                    new TowerSections { Id = 84, SectionNumber = 2, SectionHeightM = 18.18M, ExternalDiameterUpperFlangeM = 4.429M, ExternalDiameterLowerFlangeM = 4.4365M, TotalWeightKg = 69609.4845043342M, TowerTypeId = 50 },
                    new TowerSections { Id = 85, SectionNumber = 3, SectionHeightM = 19.995M, ExternalDiameterUpperFlangeM = 4.4215M, ExternalDiameterLowerFlangeM = 4.429M, TotalWeightKg = 57496.5743579628M, TowerTypeId = 50 },
                    new TowerSections { Id = 86, SectionNumber = 4, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 4.417M, ExternalDiameterLowerFlangeM = 4.4215M, TotalWeightKg = 57571.4897875719M, TowerTypeId = 50 },
                    new TowerSections { Id = 87, SectionNumber = 5, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.417M, TotalWeightKg = 49413.1191377123M, TowerTypeId = 50 },

                    new TowerSections { Id = 88, SectionNumber = 1, SectionHeightM = 16.14M, ExternalDiameterUpperFlangeM = 5.03M, ExternalDiameterLowerFlangeM = 5.275M, TotalWeightKg = 70308.6468302345M, TowerTypeId = 51 },
                    new TowerSections { Id = 89, SectionNumber = 2, SectionHeightM = 17.47M, ExternalDiameterUpperFlangeM = 4.7265M, ExternalDiameterLowerFlangeM = 5.03M, TotalWeightKg = 60646.9377866795M, TowerTypeId = 51 },
                    new TowerSections { Id = 90, SectionNumber = 3, SectionHeightM = 20.395M, ExternalDiameterUpperFlangeM = 4.423M, ExternalDiameterLowerFlangeM = 4.7265M, TotalWeightKg = 56451.0711264643M, TowerTypeId = 51 },
                    new TowerSections { Id = 91, SectionNumber = 4, SectionHeightM = 24.5M, ExternalDiameterUpperFlangeM = 4.0185M, ExternalDiameterLowerFlangeM = 4.423M, TotalWeightKg = 52302.8452990142M, TowerTypeId = 51 },
                    new TowerSections { Id = 92, SectionNumber = 5, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.0185M, TotalWeightKg = 47416.3840783022M, TowerTypeId = 51 },

                    new TowerSections { Id = 93, SectionNumber = 1, SectionHeightM = 10.77M, ExternalDiameterUpperFlangeM = 4.4985M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 60904.0508263166M, TowerTypeId = 52 },
                    new TowerSections { Id = 94, SectionNumber = 2, SectionHeightM = 14.805M, ExternalDiameterUpperFlangeM = 4.4915M, ExternalDiameterLowerFlangeM = 4.4985M, TotalWeightKg = 61914.2767947004M, TowerTypeId = 52 },
                    new TowerSections { Id = 95, SectionNumber = 3, SectionHeightM = 15.165M, ExternalDiameterUpperFlangeM = 4.4845M, ExternalDiameterLowerFlangeM = 4.4915M, TotalWeightKg = 50659.1509696883M, TowerTypeId = 52 },
                    new TowerSections { Id = 96, SectionNumber = 4, SectionHeightM = 19.83M, ExternalDiameterUpperFlangeM = 4.22M, ExternalDiameterLowerFlangeM = 4.4845M, TotalWeightKg = 49490.7941740463M, TowerTypeId = 52 },
                    new TowerSections { Id = 97, SectionNumber = 5, SectionHeightM = 20.52M, ExternalDiameterUpperFlangeM = 4.217M, ExternalDiameterLowerFlangeM = 4.22M, TotalWeightKg = 41821.374536937M, TowerTypeId = 52 },
                    new TowerSections { Id = 98, SectionNumber = 6, SectionHeightM = 24.41M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.217M, TotalWeightKg = 43525.6231373441M, TowerTypeId = 52 },

                    new TowerSections { Id = 99, SectionNumber = 1, SectionHeightM = 16.26M, ExternalDiameterUpperFlangeM = 4.137M, ExternalDiameterLowerFlangeM = 4.37M, TotalWeightKg = 73532.6020836594M, TowerTypeId = 53 },
                    new TowerSections { Id = 100, SectionNumber = 2, SectionHeightM = 19.255M, ExternalDiameterUpperFlangeM = 4.13M, ExternalDiameterLowerFlangeM = 4.137M, TotalWeightKg = 66685.4784204689M, TowerTypeId = 53 },
                    new TowerSections { Id = 101, SectionNumber = 3, SectionHeightM = 24.095M, ExternalDiameterUpperFlangeM = 4.122M, ExternalDiameterLowerFlangeM = 4.13M, TotalWeightKg = 65523.3070653022M, TowerTypeId = 53 },
                    new TowerSections { Id = 102, SectionNumber = 4, SectionHeightM = 26.8M, ExternalDiameterUpperFlangeM = 4.017M, ExternalDiameterLowerFlangeM = 4.122M, TotalWeightKg = 52699.5836199914M, TowerTypeId = 53 },
                    new TowerSections { Id = 103, SectionNumber = 5, SectionHeightM = 29.09M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.017M, TotalWeightKg = 51164.7865159465M, TowerTypeId = 53 },

                    new TowerSections { Id = 104, SectionNumber = 1, SectionHeightM = 13.51M, ExternalDiameterUpperFlangeM = 4.605M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 78578.2481667944M, TowerTypeId = 40 },
                    new TowerSections { Id = 105, SectionNumber = 2, SectionHeightM = 17.595M, ExternalDiameterUpperFlangeM = 4.4325M, ExternalDiameterLowerFlangeM = 4.605M, TotalWeightKg = 75005.0441592252M, TowerTypeId = 40 },
                    new TowerSections { Id = 106, SectionNumber = 3, SectionHeightM = 19.975M, ExternalDiameterUpperFlangeM = 4.429M, ExternalDiameterLowerFlangeM = 4.4325M, TotalWeightKg = 70675.2459856983M, TowerTypeId = 40 },
                    new TowerSections { Id = 107, SectionNumber = 4, SectionHeightM = 22.98M, ExternalDiameterUpperFlangeM = 4.125M, ExternalDiameterLowerFlangeM = 4.429M, TotalWeightKg = 66182.0180716568M, TowerTypeId = 40 },
                    new TowerSections { Id = 108, SectionNumber = 5, SectionHeightM = 24.44M, ExternalDiameterUpperFlangeM = 3.819M, ExternalDiameterLowerFlangeM = 4.125M, TotalWeightKg = 53371.0219613343M, TowerTypeId = 40 },
                    new TowerSections { Id = 109, SectionNumber = 6, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.819M, TotalWeightKg = 47561.0111134595M, TowerTypeId = 40 },

                    new TowerSections { Id = 110, SectionNumber = 1, SectionHeightM = 16.265M, ExternalDiameterUpperFlangeM = 4.67M, ExternalDiameterLowerFlangeM = 4.67M, TotalWeightKg = 75128.6057072243M, TowerTypeId = 9 },
                    new TowerSections { Id = 111, SectionNumber = 2, SectionHeightM = 18.18M, ExternalDiameterUpperFlangeM = 4.433M, ExternalDiameterLowerFlangeM = 4.67M, TotalWeightKg = 68793.4201020805M, TowerTypeId = 9 },
                    new TowerSections { Id = 112, SectionNumber = 3, SectionHeightM = 18.185M, ExternalDiameterUpperFlangeM = 4.423M, ExternalDiameterLowerFlangeM = 4.433M, TotalWeightKg = 57775.0799467561M, TowerTypeId = 9 },
                    new TowerSections { Id = 113, SectionNumber = 4, SectionHeightM = 22.88M, ExternalDiameterUpperFlangeM = 4.121M, ExternalDiameterLowerFlangeM = 4.423M, TotalWeightKg = 56262.8941796336M, TowerTypeId = 9 },
                    new TowerSections { Id = 114, SectionNumber = 5, SectionHeightM = 22.99M, ExternalDiameterUpperFlangeM = 3.817M, ExternalDiameterLowerFlangeM = 4.121M, TotalWeightKg = 43088.5641487181M, TowerTypeId = 9 },
                    new TowerSections { Id = 115, SectionNumber = 6, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.817M, TotalWeightKg = 47394.3202815814M, TowerTypeId = 9 },

                    new TowerSections { Id = 116, SectionNumber = 1, SectionHeightM = 13.515M, ExternalDiameterUpperFlangeM = 4.586M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 74860.9263300897M, TowerTypeId = 41 },
                    new TowerSections { Id = 117, SectionNumber = 2, SectionHeightM = 17.595M, ExternalDiameterUpperFlangeM = 4.43M, ExternalDiameterLowerFlangeM = 4.586M, TotalWeightKg = 69161.6349644553M, TowerTypeId = 41 },
                    new TowerSections { Id = 118, SectionNumber = 3, SectionHeightM = 19.97M, ExternalDiameterUpperFlangeM = 4.4255M, ExternalDiameterLowerFlangeM = 4.43M, TotalWeightKg = 65240.6562303674M, TowerTypeId = 41 },
                    new TowerSections { Id = 119, SectionNumber = 4, SectionHeightM = 22.98M, ExternalDiameterUpperFlangeM = 4.1235M, ExternalDiameterLowerFlangeM = 4.4255M, TotalWeightKg = 62727.6300579583M, TowerTypeId = 41 },
                    new TowerSections { Id = 120, SectionNumber = 5, SectionHeightM = 24.44M, ExternalDiameterUpperFlangeM = 3.819M, ExternalDiameterLowerFlangeM = 4.1235M, TotalWeightKg = 53089.9366190828M, TowerTypeId = 41 },
                    new TowerSections { Id = 121, SectionNumber = 6, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.819M, TotalWeightKg = 47561.0111134595M, TowerTypeId = 41 },

                    new TowerSections { Id = 122, SectionNumber = 1, SectionHeightM = 10.005M, ExternalDiameterUpperFlangeM = 4.5M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 64351.0287646177M, TowerTypeId = 42 },
                    new TowerSections { Id = 123, SectionNumber = 2, SectionHeightM = 11.845M, ExternalDiameterUpperFlangeM = 4.489M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 59975.5465890712M, TowerTypeId = 42 },
                    new TowerSections { Id = 124, SectionNumber = 3, SectionHeightM = 15.095M, ExternalDiameterUpperFlangeM = 4.48M, ExternalDiameterLowerFlangeM = 4.489M, TotalWeightKg = 59598.6056194428M, TowerTypeId = 42 },
                    new TowerSections { Id = 125, SectionNumber = 4, SectionHeightM = 18.55M, ExternalDiameterUpperFlangeM = 4.4735M, ExternalDiameterLowerFlangeM = 4.48M, TotalWeightKg = 58895.6423236105M, TowerTypeId = 42 },
                    new TowerSections { Id = 126, SectionNumber = 5, SectionHeightM = 22.205M, ExternalDiameterUpperFlangeM = 4.0915M, ExternalDiameterLowerFlangeM = 4.4735M, TotalWeightKg = 56593.8772064106M, TowerTypeId = 42 },
                    new TowerSections { Id = 127, SectionNumber = 6, SectionHeightM = 24.8M, ExternalDiameterUpperFlangeM = 3.8175M, ExternalDiameterLowerFlangeM = 4.0915M, TotalWeightKg = 49836.9233683762M, TowerTypeId = 42 },
                    new TowerSections { Id = 128, SectionNumber = 7, SectionHeightM = 23M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.8175M, TotalWeightKg = 39061.2997829452M, TowerTypeId = 42 },

                    new TowerSections { Id = 129, SectionNumber = 1, SectionHeightM = 17M, ExternalDiameterUpperFlangeM = 4.732M, ExternalDiameterLowerFlangeM = 4.78M, TotalWeightKg = 78186.1698M, TowerTypeId = 43 },
                    new TowerSections { Id = 130, SectionNumber = 2, SectionHeightM = 22.505M, ExternalDiameterUpperFlangeM = 4.725M, ExternalDiameterLowerFlangeM = 4.732M, TotalWeightKg = 76918.725M, TowerTypeId = 43 },
                    new TowerSections { Id = 131, SectionNumber = 3, SectionHeightM = 25.995M, ExternalDiameterUpperFlangeM = 4.422M, ExternalDiameterLowerFlangeM = 4.725M, TotalWeightKg = 70815.575M, TowerTypeId = 43 },
                    new TowerSections { Id = 132, SectionNumber = 4, SectionHeightM = 30M, ExternalDiameterUpperFlangeM = 3.917M, ExternalDiameterLowerFlangeM = 4.422M, TotalWeightKg = 63615.5M, TowerTypeId = 43 },
                    new TowerSections { Id = 133, SectionNumber = 5, SectionHeightM = 30M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.917M, TotalWeightKg = 49962.7M, TowerTypeId = 43 },

                    new TowerSections { Id = 134, SectionNumber = 1, SectionHeightM = 13.51M, ExternalDiameterUpperFlangeM = 4.655M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 68164.2062920547M, TowerTypeId = 44 },
                    new TowerSections { Id = 135, SectionNumber = 2, SectionHeightM = 17.62M, ExternalDiameterUpperFlangeM = 4.49M, ExternalDiameterLowerFlangeM = 4.655M, TotalWeightKg = 65570.8144003539M, TowerTypeId = 44 },
                    new TowerSections { Id = 136, SectionNumber = 3, SectionHeightM = 19.955M, ExternalDiameterUpperFlangeM = 4.4838M, ExternalDiameterLowerFlangeM = 4.49M, TotalWeightKg = 63115.49311524M, TowerTypeId = 44 },
                    new TowerSections { Id = 137, SectionNumber = 4, SectionHeightM = 22.98M, ExternalDiameterUpperFlangeM = 4.2698M, ExternalDiameterLowerFlangeM = 4.4838M, TotalWeightKg = 57992.5944581537M, TowerTypeId = 44 },
                    new TowerSections { Id = 138, SectionNumber = 5, SectionHeightM = 24.4353M, ExternalDiameterUpperFlangeM = 3.9167M, ExternalDiameterLowerFlangeM = 4.2698M, TotalWeightKg = 47252.2458423526M, TowerTypeId = 44 },
                    new TowerSections { Id = 139, SectionNumber = 6, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.9167M, TotalWeightKg = 44796.2228456208M, TowerTypeId = 44 },

                    new TowerSections { Id = 140, SectionNumber = 1, SectionHeightM = 10.005M, ExternalDiameterUpperFlangeM = 4.485M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 57739.0748677168M, TowerTypeId = 45 },
                    new TowerSections { Id = 141, SectionNumber = 2, SectionHeightM = 11.785M, ExternalDiameterUpperFlangeM = 4.486M, ExternalDiameterLowerFlangeM = 4.485M, TotalWeightKg = 52478.7282534175M, TowerTypeId = 45 },
                    new TowerSections { Id = 142, SectionNumber = 3, SectionHeightM = 15.095M, ExternalDiameterUpperFlangeM = 4.477M, ExternalDiameterLowerFlangeM = 4.486M, TotalWeightKg = 55293.6316256135M, TowerTypeId = 45 },
                    new TowerSections { Id = 143, SectionNumber = 4, SectionHeightM = 18.568M, ExternalDiameterUpperFlangeM = 4.4728M, ExternalDiameterLowerFlangeM = 4.477M, TotalWeightKg = 55508.357012348M, TowerTypeId = 45 },
                    new TowerSections { Id = 144, SectionNumber = 5, SectionHeightM = 22.205M, ExternalDiameterUpperFlangeM = 4.09M, ExternalDiameterLowerFlangeM = 4.4728M, TotalWeightKg = 53404.6467927066M, TowerTypeId = 45 },
                    new TowerSections { Id = 145, SectionNumber = 6, SectionHeightM = 24.845M, ExternalDiameterUpperFlangeM = 3.8167M, ExternalDiameterLowerFlangeM = 4.09M, TotalWeightKg = 46081.9296749903M, TowerTypeId = 45 },
                    new TowerSections { Id = 146, SectionNumber = 7, SectionHeightM = 23M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.8167M, TotalWeightKg = 37803.1306506526M, TowerTypeId = 45 },

                    new TowerSections { Id = 147, SectionNumber = 1, SectionHeightM = 15.77M, ExternalDiameterUpperFlangeM = 4.296M, ExternalDiameterLowerFlangeM = 4.3M, TotalWeightKg = 54828.2689234584M, TowerTypeId = 54 },
                    new TowerSections { Id = 148, SectionNumber = 2, SectionHeightM = 28.82M, ExternalDiameterUpperFlangeM = 4.287M, ExternalDiameterLowerFlangeM = 4.296M, TotalWeightKg = 71675.369346111M, TowerTypeId = 54 },
                    new TowerSections { Id = 149, SectionNumber = 3, SectionHeightM = 32.42M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.287M, TotalWeightKg = 59248.2567088075M, TowerTypeId = 54 },

                    new TowerSections { Id = 150, SectionNumber = 1, SectionHeightM = 13.28M, ExternalDiameterUpperFlangeM = 5.77M, ExternalDiameterLowerFlangeM = 5.77M, TotalWeightKg = 80912.7M, TowerTypeId = 10 },
                    new TowerSections { Id = 151, SectionNumber = 2, SectionHeightM = 16.48M, ExternalDiameterUpperFlangeM = 5.533M, ExternalDiameterLowerFlangeM = 5.77M, TotalWeightKg = 78193.4M, TowerTypeId = 10 },
                    new TowerSections { Id = 152, SectionNumber = 3, SectionHeightM = 16.485M, ExternalDiameterUpperFlangeM = 5.134M, ExternalDiameterLowerFlangeM = 5.533M, TotalWeightKg = 74094.4M, TowerTypeId = 10 },
                    new TowerSections { Id = 153, SectionNumber = 4, SectionHeightM = 16.8M, ExternalDiameterUpperFlangeM = 4.634M, ExternalDiameterLowerFlangeM = 5.134M, TotalWeightKg = 70475.5M, TowerTypeId = 10 },
                    new TowerSections { Id = 154, SectionNumber = 5, SectionHeightM = 18.18M, ExternalDiameterUpperFlangeM = 4.628M, ExternalDiameterLowerFlangeM = 4.634M, TotalWeightKg = 68070.3M, TowerTypeId = 10 },
                    new TowerSections { Id = 155, SectionNumber = 6, SectionHeightM = 21.89M, ExternalDiameterUpperFlangeM = 4.623M, ExternalDiameterLowerFlangeM = 4.628M, TotalWeightKg = 64304M, TowerTypeId = 10 },
                    new TowerSections { Id = 156, SectionNumber = 7, SectionHeightM = 22.885M, ExternalDiameterUpperFlangeM = 4.02M, ExternalDiameterLowerFlangeM = 4.623M, TotalWeightKg = 51385.5M, TowerTypeId = 10 },
                    new TowerSections { Id = 157, SectionNumber = 8, SectionHeightM = 29.5M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.02M, TotalWeightKg = 51645.4M, TowerTypeId = 10 },

                    new TowerSections { Id = 158, SectionNumber = 1, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.918M, ExternalDiameterLowerFlangeM = 4.424M, TotalWeightKg = 58359.7185850936M, TowerTypeId = 55 },
                    new TowerSections { Id = 159, SectionNumber = 2, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.918M, TotalWeightKg = 45195.8603005768M, TowerTypeId = 55 },

                    new TowerSections { Id = 160, SectionNumber = 1, SectionHeightM = 21.456M, ExternalDiameterUpperFlangeM = 4.0225M, ExternalDiameterLowerFlangeM = 4.115M, TotalWeightKg = 66008.5M, TowerTypeId = 5 },
                    new TowerSections { Id = 161, SectionNumber = 2, SectionHeightM = 25.908M, ExternalDiameterUpperFlangeM = 3.718M, ExternalDiameterLowerFlangeM = 4.023M, TotalWeightKg = 53782.6M, TowerTypeId = 5 },
                    new TowerSections { Id = 162, SectionNumber = 3, SectionHeightM = 30.136M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.718M, TotalWeightKg = 50320.1M, TowerTypeId = 5 },

                    new TowerSections { Id = 163, SectionNumber = 1, SectionHeightM = 25M, ExternalDiameterUpperFlangeM = 4.023M, ExternalDiameterLowerFlangeM = 4.27M, TotalWeightKg = 74771.4611494705M, TowerTypeId = 46 },
                    new TowerSections { Id = 164, SectionNumber = 2, SectionHeightM = 25M, ExternalDiameterUpperFlangeM = 4.016M, ExternalDiameterLowerFlangeM = 4.023M, TotalWeightKg = 51615.5812938536M, TowerTypeId = 46 },
                    new TowerSections { Id = 165, SectionNumber = 3, SectionHeightM = 36M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.016M, TotalWeightKg = 59751.3269603374M, TowerTypeId = 46 },

                    new TowerSections { Id = 166, SectionNumber = 1, SectionHeightM = 16.18M, ExternalDiameterUpperFlangeM = 4.03M, ExternalDiameterLowerFlangeM = 4.115M, TotalWeightKg = 63639.7299890897M, TowerTypeId = 33 },
                    new TowerSections { Id = 167, SectionNumber = 2, SectionHeightM = 23.3M, ExternalDiameterUpperFlangeM = 4.021M, ExternalDiameterLowerFlangeM = 4.03M, TotalWeightKg = 60418.619823543M, TowerTypeId = 33 },
                    new TowerSections { Id = 168, SectionNumber = 3, SectionHeightM = 23.52M, ExternalDiameterUpperFlangeM = 4.016M, ExternalDiameterLowerFlangeM = 4.021M, TotalWeightKg = 45225.0396496481M, TowerTypeId = 33 },
                    new TowerSections { Id = 169, SectionNumber = 4, SectionHeightM = 25M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.016M, TotalWeightKg = 43367.4964621935M, TowerTypeId = 33 },

                    new TowerSections { Id = 170, SectionNumber = 1, SectionHeightM = 18.04M, ExternalDiameterUpperFlangeM = 4.03M, ExternalDiameterLowerFlangeM = 4.278M, TotalWeightKg = 70837.1383408913M, TowerTypeId = 47 },
                    new TowerSections { Id = 171, SectionNumber = 2, SectionHeightM = 23.96M, ExternalDiameterUpperFlangeM = 4.023M, ExternalDiameterLowerFlangeM = 4.03M, TotalWeightKg = 65562.9877836514M, TowerTypeId = 47 },
                    new TowerSections { Id = 172, SectionNumber = 3, SectionHeightM = 21M, ExternalDiameterUpperFlangeM = 4.017M, ExternalDiameterLowerFlangeM = 4.023M, TotalWeightKg = 41116.4960012798M, TowerTypeId = 47 },
                    new TowerSections { Id = 173, SectionNumber = 4, SectionHeightM = 25M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.017M, TotalWeightKg = 44174.9829034144M, TowerTypeId = 47 },

                    new TowerSections { Id = 174, SectionNumber = 1, SectionHeightM = 19.25M, ExternalDiameterUpperFlangeM = 4.026M, ExternalDiameterLowerFlangeM = 4.27M, TotalWeightKg = 64407.3720298972M, TowerTypeId = 48 },
                    new TowerSections { Id = 175, SectionNumber = 2, SectionHeightM = 21M, ExternalDiameterUpperFlangeM = 4.02M, ExternalDiameterLowerFlangeM = 4.026M, TotalWeightKg = 51482.2975777187M, TowerTypeId = 48 },
                    new TowerSections { Id = 176, SectionNumber = 3, SectionHeightM = 21.1M, ExternalDiameterUpperFlangeM = 4.017M, ExternalDiameterLowerFlangeM = 4.02M, TotalWeightKg = 39418.7407352051M, TowerTypeId = 48 },
                    new TowerSections { Id = 177, SectionNumber = 4, SectionHeightM = 26.65M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.017M, TotalWeightKg = 46946.6174713076M, TowerTypeId = 48 },

                    new TowerSections { Id = 178, SectionNumber = 1, SectionHeightM = 16.18M, ExternalDiameterUpperFlangeM = 4.1065M, ExternalDiameterLowerFlangeM = 4.115M, TotalWeightKg = 60050.0704076508M, TowerTypeId = 6 },
                    new TowerSections { Id = 179, SectionNumber = 2, SectionHeightM = 23.3M, ExternalDiameterUpperFlangeM = 4.1M, ExternalDiameterLowerFlangeM = 4.1065M, TotalWeightKg = 57553.4559157892M, TowerTypeId = 6 },
                    new TowerSections { Id = 180, SectionNumber = 3, SectionHeightM = 23.52M, ExternalDiameterUpperFlangeM = 4.0167M, ExternalDiameterLowerFlangeM = 4.1M, TotalWeightKg = 44807.6526008422M, TowerTypeId = 6 },
                    new TowerSections { Id = 181, SectionNumber = 4, SectionHeightM = 25M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.0167M, TotalWeightKg = 41491.5666858333M, TowerTypeId = 6 },

                    new TowerSections { Id = 182, SectionNumber = 1, SectionHeightM = 25.072M, ExternalDiameterUpperFlangeM = 4.224M, ExternalDiameterLowerFlangeM = 4.47M, TotalWeightKg = 79335.3375567185M, TowerTypeId = 34 },
                    new TowerSections { Id = 183, SectionNumber = 2, SectionHeightM = 29.26M, ExternalDiameterUpperFlangeM = 3.481M, ExternalDiameterLowerFlangeM = 4.224M, TotalWeightKg = 65774.3134468638M, TowerTypeId = 34 },
                    new TowerSections { Id = 184, SectionNumber = 3, SectionHeightM = 34.5M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.481M, TotalWeightKg = 58854.6295949268M, TowerTypeId = 34 },

                    new TowerSections { Id = 185, SectionNumber = 1, SectionHeightM = 25.072M, ExternalDiameterUpperFlangeM = 4.2235M, ExternalDiameterLowerFlangeM = 4.47M, TotalWeightKg = 78556.7M, TowerTypeId = 35 },
                    new TowerSections { Id = 186, SectionNumber = 2, SectionHeightM = 29.26M, ExternalDiameterUpperFlangeM = 3.4805M, ExternalDiameterLowerFlangeM = 4.2235M, TotalWeightKg = 62966.5M, TowerTypeId = 35 },
                    new TowerSections { Id = 187, SectionNumber = 3, SectionHeightM = 34.5M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.4805M, TotalWeightKg = 57133.5M, TowerTypeId = 35 },

                    new TowerSections { Id = 188, SectionNumber = 1, SectionHeightM = 18.075M, ExternalDiameterUpperFlangeM = 4.499M, ExternalDiameterLowerFlangeM = 4.488M, TotalWeightKg = 64128.9600164969M, TowerTypeId = 36 },
                    new TowerSections { Id = 189, SectionNumber = 2, SectionHeightM = 24.465M, ExternalDiameterUpperFlangeM = 4.494M, ExternalDiameterLowerFlangeM = 4.499M, TotalWeightKg = 61419.5343414767M, TowerTypeId = 36 },
                    new TowerSections { Id = 190, SectionNumber = 3, SectionHeightM = 25.897M, ExternalDiameterUpperFlangeM = 3.9607M, ExternalDiameterLowerFlangeM = 4.494M, TotalWeightKg = 49500.9413040166M, TowerTypeId = 36 },
                    new TowerSections { Id = 191, SectionNumber = 4, SectionHeightM = 25.08M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.9607M, TotalWeightKg = 42970.7592045565M, TowerTypeId = 36 },

                    new TowerSections { Id = 192, SectionNumber = 1, SectionHeightM = 17.94M, ExternalDiameterUpperFlangeM = 4.4987M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 63177.6783549432M, TowerTypeId = 37 },
                    new TowerSections { Id = 193, SectionNumber = 2, SectionHeightM = 24.545M, ExternalDiameterUpperFlangeM = 4.4933M, ExternalDiameterLowerFlangeM = 4.4987M, TotalWeightKg = 60834.1143942121M, TowerTypeId = 37 },
                    new TowerSections { Id = 194, SectionNumber = 3, SectionHeightM = 25.897M, ExternalDiameterUpperFlangeM = 3.9677M, ExternalDiameterLowerFlangeM = 4.4933M, TotalWeightKg = 48339.3747381074M, TowerTypeId = 37 },
                    new TowerSections { Id = 195, SectionNumber = 4, SectionHeightM = 25.12M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 3.9677M, TotalWeightKg = 42060.1897122255M, TowerTypeId = 37 },

                    new TowerSections { Id = 196, SectionNumber = 1, SectionHeightM = 19.245M, ExternalDiameterUpperFlangeM = 4.4265M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 72204.0953826459M, TowerTypeId = 38 },
                    new TowerSections { Id = 197, SectionNumber = 2, SectionHeightM = 21.115M, ExternalDiameterUpperFlangeM = 4.422M, ExternalDiameterLowerFlangeM = 4.4265M, TotalWeightKg = 56613.2646016834M, TowerTypeId = 38 },
                    new TowerSections { Id = 198, SectionNumber = 3, SectionHeightM = 26.26M, ExternalDiameterUpperFlangeM = 4.017M, ExternalDiameterLowerFlangeM = 4.422M, TotalWeightKg = 53955.8730315744M, TowerTypeId = 38 },
                    new TowerSections { Id = 199, SectionNumber = 4, SectionHeightM = 28.85M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.017M, TotalWeightKg = 49483.7241236153M, TowerTypeId = 38 },

                    new TowerSections { Id = 200, SectionNumber = 1, SectionHeightM = 19.245M, ExternalDiameterUpperFlangeM = 4.424M, ExternalDiameterLowerFlangeM = 4.67M, TotalWeightKg = 66396.1334452749M, TowerTypeId = 49 },
                    new TowerSections { Id = 201, SectionNumber = 2, SectionHeightM = 21.115M, ExternalDiameterUpperFlangeM = 4.42M, ExternalDiameterLowerFlangeM = 4.424M, TotalWeightKg = 53232.9710482851M, TowerTypeId = 49 },
                    new TowerSections { Id = 202, SectionNumber = 3, SectionHeightM = 26.29M, ExternalDiameterUpperFlangeM = 4.017M, ExternalDiameterLowerFlangeM = 4.42M, TotalWeightKg = 50124.8997642959M, TowerTypeId = 49 },
                    new TowerSections { Id = 203, SectionNumber = 4, SectionHeightM = 28.85M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.017M, TotalWeightKg = 50785.5791836895M, TowerTypeId = 49 },

                    new TowerSections { Id = 204, SectionNumber = 1, SectionHeightM = 19.22M, ExternalDiameterUpperFlangeM = 4.4243M, ExternalDiameterLowerFlangeM = 4.68M, TotalWeightKg = 66305.3824430877M, TowerTypeId = 39 },
                    new TowerSections { Id = 205, SectionNumber = 2, SectionHeightM = 21.09M, ExternalDiameterUpperFlangeM = 4.4195M, ExternalDiameterLowerFlangeM = 4.4243M, TotalWeightKg = 53794.85M, TowerTypeId = 39 },
                    new TowerSections { Id = 206, SectionNumber = 3, SectionHeightM = 26.29M, ExternalDiameterUpperFlangeM = 4.0159M, ExternalDiameterLowerFlangeM = 4.4195M, TotalWeightKg = 51346.75M, TowerTypeId = 39 },
                    new TowerSections { Id = 207, SectionNumber = 4, SectionHeightM = 28.9M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.0159M, TotalWeightKg = 47361.9M, TowerTypeId = 39 },

                    //===========Anil changes.......
                    //SG 6.0-170

                    new TowerSections { Id = 208, SectionNumber = 1, SectionHeightM = 14.3M, ExternalDiameterUpperFlangeM = 4.7M, ExternalDiameterLowerFlangeM = 4.7M, TotalWeightKg = 84033.4947944777M, TowerTypeId = 15 },
                    new TowerSections { Id = 209, SectionNumber = 2, SectionHeightM = 21.56M, ExternalDiameterUpperFlangeM = 4.493M, ExternalDiameterLowerFlangeM = 4.7M, TotalWeightKg = 79745.6992286253M, TowerTypeId = 15 },
                    new TowerSections { Id = 210, SectionNumber = 3, SectionHeightM = 26.88M, ExternalDiameterUpperFlangeM = 4.493M, ExternalDiameterLowerFlangeM = 4.493M, TotalWeightKg = 76060.2080594602M, TowerTypeId = 15 },
                    new TowerSections { Id = 211, SectionNumber = 4, SectionHeightM = 34.45M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.493M, TotalWeightKg = 75793.067628854M, TowerTypeId = 15 },

                    new TowerSections { Id = 212, SectionNumber = 1, SectionHeightM = 8.464M, ExternalDiameterUpperFlangeM = 4.2966M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 61269.3138433361M, TowerTypeId = 16 },
                    new TowerSections { Id = 213, SectionNumber = 2, SectionHeightM = 14.84M, ExternalDiameterUpperFlangeM = 4.5M, ExternalDiameterLowerFlangeM = 4.2958M, TotalWeightKg = 69796.9764825352M, TowerTypeId = 16 },
                    new TowerSections { Id = 214, SectionNumber = 3, SectionHeightM = 15.12M, ExternalDiameterUpperFlangeM = 4.495M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 57634.6886985659M, TowerTypeId = 16 },
                    new TowerSections { Id = 215, SectionNumber = 4, SectionHeightM = 17.64M, ExternalDiameterUpperFlangeM = 4.495M, ExternalDiameterLowerFlangeM = 4.495M, TotalWeightKg = 53453.9855480734M, TowerTypeId = 16 },
                    new TowerSections { Id = 216, SectionNumber = 5, SectionHeightM = 21M, ExternalDiameterUpperFlangeM = 4.1M, ExternalDiameterLowerFlangeM = 4.495M, TotalWeightKg = 48049.1739479351M, TowerTypeId = 16 },
                    new TowerSections { Id = 217, SectionNumber = 6, SectionHeightM = 21.85M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.1M, TotalWeightKg = 49717.4066320377M, TowerTypeId = 16 },

                    new TowerSections { Id = 218, SectionNumber = 1, SectionHeightM = 13.564M, ExternalDiameterUpperFlangeM = 4.7M, ExternalDiameterLowerFlangeM = 4.7M, TotalWeightKg = 84958.3M, TowerTypeId = 1 },
                    new TowerSections { Id = 219, SectionNumber = 2, SectionHeightM = 18.2M, ExternalDiameterUpperFlangeM = 4.436M, ExternalDiameterLowerFlangeM = 4.7M, TotalWeightKg = 84327.8M, TowerTypeId = 1 },
                    new TowerSections { Id = 220, SectionNumber = 3, SectionHeightM = 23.8M, ExternalDiameterUpperFlangeM = 4.427M, ExternalDiameterLowerFlangeM = 4.436M, TotalWeightKg = 84548.3M, TowerTypeId = 1 },
                    new TowerSections { Id = 221, SectionNumber = 4, SectionHeightM = 26.88M, ExternalDiameterUpperFlangeM = 4.021M, ExternalDiameterLowerFlangeM = 4.427M, TotalWeightKg = 71770.5M, TowerTypeId = 1 },
                    new TowerSections { Id = 222, SectionNumber = 5, SectionHeightM = 29.97M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.021M, TotalWeightKg = 63863.1M, TowerTypeId = 1 },

                    new TowerSections { Id = 223, SectionNumber = 1, SectionHeightM = 11.78M, ExternalDiameterUpperFlangeM = 4.8M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 86803.6350635777M, TowerTypeId = 17 },
                    new TowerSections { Id = 224, SectionNumber = 2, SectionHeightM = 17.92M, ExternalDiameterUpperFlangeM = 4.793M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 84643.7394897317M, TowerTypeId = 17 },
                    new TowerSections { Id = 225, SectionNumber = 3, SectionHeightM = 21.84M, ExternalDiameterUpperFlangeM = 4.793M, ExternalDiameterLowerFlangeM = 4.793M, TotalWeightKg = 81555.6325105242M, TowerTypeId = 17 },
                    new TowerSections { Id = 226, SectionNumber = 4, SectionHeightM = 28M, ExternalDiameterUpperFlangeM = 4.793M, ExternalDiameterLowerFlangeM = 4.793M, TotalWeightKg = 77286.0411902622M, TowerTypeId = 17 },
                    new TowerSections { Id = 227, SectionNumber = 5, SectionHeightM = 32.77M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.793M, TotalWeightKg = 72511.7998306351M, TowerTypeId = 17 },

                    new TowerSections { Id = 228, SectionNumber = 0, SectionHeightM = 112.714M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 8.36M, TotalWeightKg = 0M, TowerTypeId = 18 },  //-------------------------Weight 0-----------------

                    new TowerSections { Id = 229, SectionNumber = 1, SectionHeightM = 15M, ExternalDiameterUpperFlangeM = 5.682M, ExternalDiameterLowerFlangeM = 6M, TotalWeightKg = 91066.3100295192M, TowerTypeId = 2 },
                    new TowerSections { Id = 230, SectionNumber = 2, SectionHeightM = 18.2M, ExternalDiameterUpperFlangeM = 5.678M, ExternalDiameterLowerFlangeM = 5.682M, TotalWeightKg = 84192.4713934607M, TowerTypeId = 2 },
                    new TowerSections { Id = 231, SectionNumber = 3, SectionHeightM = 21.28M, ExternalDiameterUpperFlangeM = 4.8285M, ExternalDiameterLowerFlangeM = 5.678M, TotalWeightKg = 84470.304594301M, TowerTypeId = 2 },
                    new TowerSections { Id = 232, SectionNumber = 4, SectionHeightM = 24.92M, ExternalDiameterUpperFlangeM = 4.4245M, ExternalDiameterLowerFlangeM = 4.8285M, TotalWeightKg = 81538.3639815086M, TowerTypeId = 2 },
                    new TowerSections { Id = 233, SectionNumber = 5, SectionHeightM = 26.88M, ExternalDiameterUpperFlangeM = 4.42M, ExternalDiameterLowerFlangeM = 4.4245M, TotalWeightKg = 68370.7227605146M, TowerTypeId = 2 },
                    new TowerSections { Id = 234, SectionNumber = 6, SectionHeightM = 26.134M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.42M, TotalWeightKg = 58393.1812491416M, TowerTypeId = 2 },

                    new TowerSections { Id = 235, SectionNumber = 0, SectionHeightM = 132.714M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 9.8M, TotalWeightKg = 0M, TowerTypeId = 19 },  //-------------------------Weight 0-----------------

                    new TowerSections { Id = 236, SectionNumber = 1, SectionHeightM = 12.32M, ExternalDiameterUpperFlangeM = 6.4M, ExternalDiameterLowerFlangeM = 6.4M, TotalWeightKg = 83350M, TowerTypeId = 20 },
                    new TowerSections { Id = 237, SectionNumber = 2, SectionHeightM = 14M, ExternalDiameterUpperFlangeM = 6.4M, ExternalDiameterLowerFlangeM = 6.4M, TotalWeightKg = 82480M, TowerTypeId = 20 },
                    new TowerSections { Id = 238, SectionNumber = 3, SectionHeightM = 15.68M, ExternalDiameterUpperFlangeM = 6.4M, ExternalDiameterLowerFlangeM = 6.4M, TotalWeightKg = 83110M, TowerTypeId = 20 },
                    new TowerSections { Id = 239, SectionNumber = 4, SectionHeightM = 18.2M, ExternalDiameterUpperFlangeM = 6.4M, ExternalDiameterLowerFlangeM = 6.4M, TotalWeightKg = 83910M, TowerTypeId = 20 },
                    new TowerSections { Id = 240, SectionNumber = 5, SectionHeightM = 18.48M, ExternalDiameterUpperFlangeM = 5.75M, ExternalDiameterLowerFlangeM = 6.4M, TotalWeightKg = 73260M, TowerTypeId = 20 },
                    new TowerSections { Id = 241, SectionNumber = 6, SectionHeightM = 18.48M, ExternalDiameterUpperFlangeM = 5.1M, ExternalDiameterLowerFlangeM = 5.75M, TotalWeightKg = 62220M, TowerTypeId = 20 },
                    new TowerSections { Id = 242, SectionNumber = 7, SectionHeightM = 18.48M, ExternalDiameterUpperFlangeM = 4.45M, ExternalDiameterLowerFlangeM = 5.1M, TotalWeightKg = 50400M, TowerTypeId = 20 },
                    new TowerSections { Id = 243, SectionNumber = 8, SectionHeightM = 26.89M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.45M, TotalWeightKg = 64480M, TowerTypeId = 20 },

                    new TowerSections { Id = 244, SectionNumber = 1, SectionHeightM = 12.32M, ExternalDiameterUpperFlangeM = 6.575M, ExternalDiameterLowerFlangeM = 6.6M, TotalWeightKg = 83980M, TowerTypeId = 21 },
                    new TowerSections { Id = 245, SectionNumber = 2, SectionHeightM = 13.44M, ExternalDiameterUpperFlangeM = 6.575M, ExternalDiameterLowerFlangeM = 6.575M, TotalWeightKg = 82320M, TowerTypeId = 21 },
                    new TowerSections { Id = 246, SectionNumber = 3, SectionHeightM = 14.56M, ExternalDiameterUpperFlangeM = 6.575M, ExternalDiameterLowerFlangeM = 6.575M, TotalWeightKg = 82350M, TowerTypeId = 21 },
                    new TowerSections { Id = 247, SectionNumber = 4, SectionHeightM = 16.24M, ExternalDiameterUpperFlangeM = 6.575M, ExternalDiameterLowerFlangeM = 6.575M, TotalWeightKg = 82980M, TowerTypeId = 21 },
                    new TowerSections { Id = 248, SectionNumber = 5, SectionHeightM = 18.48M, ExternalDiameterUpperFlangeM = 6.575M, ExternalDiameterLowerFlangeM = 6.575M, TotalWeightKg = 80910M, TowerTypeId = 21 },
                    new TowerSections { Id = 249, SectionNumber = 6, SectionHeightM = 18.48M, ExternalDiameterUpperFlangeM = 5.376M, ExternalDiameterLowerFlangeM = 5.975M, TotalWeightKg = 70170M, TowerTypeId = 21 },
                    new TowerSections { Id = 250, SectionNumber = 7, SectionHeightM = 28.84M, ExternalDiameterUpperFlangeM = 4.44M, ExternalDiameterLowerFlangeM = 5.376M, TotalWeightKg = 83270M, TowerTypeId = 21 },
                    new TowerSections { Id = 251, SectionNumber = 8, SectionHeightM = 29.97M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.44M, TotalWeightKg = 70760M, TowerTypeId = 21 },

                    new TowerSections { Id = 252, SectionNumber = 0, SectionHeightM = 98.944M, ExternalDiameterUpperFlangeM = 4.5275M, ExternalDiameterLowerFlangeM = 9.2875M, TotalWeightKg = 0M, TowerTypeId = 22 },  //-------------------------Weight 0-----------------
                    new TowerSections { Id = 253, SectionNumber = 2, SectionHeightM = 27.77M, ExternalDiameterUpperFlangeM = 4.289M, ExternalDiameterLowerFlangeM = 4.3M, TotalWeightKg = 83158.0668577359M, TowerTypeId = 22 },
                    new TowerSections { Id = 254, SectionNumber = 3, SectionHeightM = 36M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.289M, TotalWeightKg = 72291.1653659468M, TowerTypeId = 22 },

                    //SG 6.0-155
                    //--T102.5-50A
                    new TowerSections { Id = 255, SectionNumber = 1, SectionHeightM = 16.464M, ExternalDiameterUpperFlangeM = 4.433M, ExternalDiameterLowerFlangeM = 4.7M, TotalWeightKg = 79354.8890943096M, TowerTypeId = 3 },
                    new TowerSections { Id = 256, SectionNumber = 2, SectionHeightM = 22.68M, ExternalDiameterUpperFlangeM = 4.427M, ExternalDiameterLowerFlangeM = 4.433M, TotalWeightKg = 76299.2963693753M, TowerTypeId = 3 },
                    new TowerSections { Id = 257, SectionNumber = 3, SectionHeightM = 27.16M, ExternalDiameterUpperFlangeM = 3.5566M, ExternalDiameterLowerFlangeM = 4.427M, TotalWeightKg = 68693.0094576569M, TowerTypeId = 3 },
                    new TowerSections { Id = 258, SectionNumber = 4, SectionHeightM = 33.61M, ExternalDiameterUpperFlangeM = 3.574M, ExternalDiameterLowerFlangeM = 3.5566M, TotalWeightKg = 66933.010559683M, TowerTypeId = 3 },

                    //T102.5-51A
                    new TowerSections { Id = 259, SectionNumber = 1, SectionHeightM = 13.18M, ExternalDiameterUpperFlangeM = 4.355M, ExternalDiameterLowerFlangeM = 4.3691M, TotalWeightKg = 82880.3038918576M, TowerTypeId = 24 },
                    new TowerSections { Id = 260, SectionNumber = 2, SectionHeightM = 20.72M, ExternalDiameterUpperFlangeM = 4.3M, ExternalDiameterLowerFlangeM = 4.355M, TotalWeightKg = 79695.7011241759M, TowerTypeId = 24 },
                    new TowerSections { Id = 261, SectionNumber = 3, SectionHeightM = 29.96M, ExternalDiameterUpperFlangeM = 4.3M, ExternalDiameterLowerFlangeM = 4.3M, TotalWeightKg = 81066.7088325924M, TowerTypeId = 24 },
                    new TowerSections { Id = 262, SectionNumber = 4, SectionHeightM = 35.85M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.3M, TotalWeightKg = 72484.8480468829M, TowerTypeId = 24 },

                    new TowerSections { Id = 263, SectionNumber = 1, SectionHeightM = 16.24M, ExternalDiameterUpperFlangeM = 4.8M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 80488.9464547731M, TowerTypeId = 25 },
                    new TowerSections { Id = 264, SectionNumber = 2, SectionHeightM = 22.4M, ExternalDiameterUpperFlangeM = 4.8M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 78524.4940327805M, TowerTypeId = 25 },
                    new TowerSections { Id = 265, SectionNumber = 3, SectionHeightM = 30.24M, ExternalDiameterUpperFlangeM = 4.5M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 79213.5242030428M, TowerTypeId = 25 },
                    new TowerSections { Id = 266, SectionNumber = 4, SectionHeightM = 35.85M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 74744.2052296635M, TowerTypeId = 25 },

                    new TowerSections { Id = 267, SectionNumber = 1, SectionHeightM = 14.039M, ExternalDiameterUpperFlangeM = 4.8M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 80500.9400227107M, TowerTypeId = 26 },
                    new TowerSections { Id = 268, SectionNumber = 2, SectionHeightM = 19.88M, ExternalDiameterUpperFlangeM = 4.798M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 80331.5980756746M, TowerTypeId = 26 },
                    new TowerSections { Id = 269, SectionNumber = 3, SectionHeightM = 24.36M, ExternalDiameterUpperFlangeM = 4.792M, ExternalDiameterLowerFlangeM = 4.798M, TotalWeightKg = 75953.0104706682M, TowerTypeId = 26 },
                    new TowerSections { Id = 270, SectionNumber = 4, SectionHeightM = 26.6M, ExternalDiameterUpperFlangeM = 4.418M, ExternalDiameterLowerFlangeM = 4.792M, TotalWeightKg = 64534.2240527795M, TowerTypeId = 26 },
                    new TowerSections { Id = 271, SectionNumber = 5, SectionHeightM = 26.035M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.418M, TotalWeightKg = 52302.763422907M, TowerTypeId = 26 },

                    new TowerSections { Id = 272, SectionNumber = 1, SectionHeightM = 12.91M, ExternalDiameterUpperFlangeM = 4.3075M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 79517.061653161M, TowerTypeId = 27 },
                    new TowerSections { Id = 273, SectionNumber = 2, SectionHeightM = 18.48M, ExternalDiameterUpperFlangeM = 4.493M, ExternalDiameterLowerFlangeM = 4.3005M, TotalWeightKg = 80482.3936020138M, TowerTypeId = 27 },
                    new TowerSections { Id = 274, SectionNumber = 3, SectionHeightM = 23.52M, ExternalDiameterUpperFlangeM = 4.493M, ExternalDiameterLowerFlangeM = 4.493M, TotalWeightKg = 81159.1932835383M, TowerTypeId = 27 },
                    new TowerSections { Id = 275, SectionNumber = 4, SectionHeightM = 29.96M, ExternalDiameterUpperFlangeM = 4.3M, ExternalDiameterLowerFlangeM = 4.493M, TotalWeightKg = 73543.0481950945M, TowerTypeId = 27 },
                    new TowerSections { Id = 276, SectionNumber = 5, SectionHeightM = 29.97M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.3M, TotalWeightKg = 60725.344691474M, TowerTypeId = 27 },

                    new TowerSections { Id = 277, SectionNumber = 1, SectionHeightM = 13.18M, ExternalDiameterUpperFlangeM = 4.5M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 89293.0347345852M, TowerTypeId = 28 },
                    new TowerSections { Id = 278, SectionNumber = 2, SectionHeightM = 19.04M, ExternalDiameterUpperFlangeM = 4.5M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 90738.2418588968M, TowerTypeId = 28 },
                    new TowerSections { Id = 279, SectionNumber = 3, SectionHeightM = 23.8M, ExternalDiameterUpperFlangeM = 4.4M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 89933.2343573664M, TowerTypeId = 28 },
                    new TowerSections { Id = 280, SectionNumber = 4, SectionHeightM = 29.96M, ExternalDiameterUpperFlangeM = 4.4M, ExternalDiameterLowerFlangeM = 4.4M, TotalWeightKg = 79262.1578360013M, TowerTypeId = 28 },
                    new TowerSections { Id = 281, SectionNumber = 5, SectionHeightM = 32.21M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.4M, TotalWeightKg = 65218.8593310267M, TowerTypeId = 28 },

                    new TowerSections { Id = 282, SectionNumber = 1, SectionHeightM = 14.342M, ExternalDiameterUpperFlangeM = 4.8M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 84512.9720195517M, TowerTypeId = 4 },
                    new TowerSections { Id = 283, SectionNumber = 2, SectionHeightM = 19.368M, ExternalDiameterUpperFlangeM = 4.8M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 81456.6195681442M, TowerTypeId = 4 },
                    new TowerSections { Id = 284, SectionNumber = 3, SectionHeightM = 26.832M, ExternalDiameterUpperFlangeM = 4.7925M, ExternalDiameterLowerFlangeM = 4.8M, TotalWeightKg = 84754.193220052M, TowerTypeId = 4 },
                    new TowerSections { Id = 285, SectionNumber = 4, SectionHeightM = 29.977M, ExternalDiameterUpperFlangeM = 4.099M, ExternalDiameterLowerFlangeM = 4.7925M, TotalWeightKg = 70462.435506686M, TowerTypeId = 4 },
                    new TowerSections { Id = 286, SectionNumber = 5, SectionHeightM = 30M, ExternalDiameterUpperFlangeM = 3.574M, ExternalDiameterLowerFlangeM = 4.099M, TotalWeightKg = 56744.1481886194M, TowerTypeId = 4 },

                    new TowerSections { Id = 287, SectionNumber = 1, SectionHeightM = 13.18M, ExternalDiameterUpperFlangeM = 4.4912M, ExternalDiameterLowerFlangeM = 4.6999M, TotalWeightKg = 83703.4276702223M, TowerTypeId = 30 },
                    new TowerSections { Id = 288, SectionNumber = 2, SectionHeightM = 20.72M, ExternalDiameterUpperFlangeM = 4.69M, ExternalDiameterLowerFlangeM = 4.4912M, TotalWeightKg = 89339.6508417695M, TowerTypeId = 30 },
                    new TowerSections { Id = 289, SectionNumber = 3, SectionHeightM = 26.04M, ExternalDiameterUpperFlangeM = 4.691M, ExternalDiameterLowerFlangeM = 4.69M, TotalWeightKg = 88386.7504356758M, TowerTypeId = 30 },
                    new TowerSections { Id = 290, SectionNumber = 4, SectionHeightM = 29.96M, ExternalDiameterUpperFlangeM = 4.691M, ExternalDiameterLowerFlangeM = 4.691M, TotalWeightKg = 73648.1220461621M, TowerTypeId = 30 },
                    new TowerSections { Id = 291, SectionNumber = 5, SectionHeightM = 29.97M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.691M, TotalWeightKg = 63505.1130089599M, TowerTypeId = 30 },

                    new TowerSections { Id = 292, SectionNumber = 0, SectionHeightM = 120.214M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 9.8M, TotalWeightKg = 0M, TowerTypeId = 31 },

                    new TowerSections { Id = 293, SectionNumber = 0, SectionHeightM = 89.09M, ExternalDiameterUpperFlangeM = 4.5275M, ExternalDiameterLowerFlangeM = 8.8675M, TotalWeightKg = 0M, TowerTypeId = 32 },
                    new TowerSections { Id = 294, SectionNumber = 1, SectionHeightM = 21.075M, ExternalDiameterUpperFlangeM = 4.2945M, ExternalDiameterLowerFlangeM = 4.3M, TotalWeightKg = 63073.1577528424M, TowerTypeId = 32 },
                    new TowerSections { Id = 295, SectionNumber = 2, SectionHeightM = 23.335M, ExternalDiameterUpperFlangeM = 4.018M, ExternalDiameterLowerFlangeM = 4.2945M, TotalWeightKg = 51182.8594250054M, TowerTypeId = 32 },
                    new TowerSections { Id = 296, SectionNumber = 3, SectionHeightM = 27M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.018M, TotalWeightKg = 50776.7330337871M, TowerTypeId = 32 },

                    new TowerSections { Id = 297, SectionNumber = 1, SectionHeightM = 14.86M, ExternalDiameterUpperFlangeM = 4.493M, ExternalDiameterLowerFlangeM = 4.7M, TotalWeightKg = 70416.8186489412M, TowerTypeId = 23 },
                    new TowerSections { Id = 298, SectionNumber = 2, SectionHeightM = 22.68M, ExternalDiameterUpperFlangeM = 4.493M, ExternalDiameterLowerFlangeM = 4.493M, TotalWeightKg = 69556.9930113774M, TowerTypeId = 23 },
                    new TowerSections { Id = 299, SectionNumber = 3, SectionHeightM = 24.08M, ExternalDiameterUpperFlangeM = 4.493M, ExternalDiameterLowerFlangeM = 4.493M, TotalWeightKg = 54286.4973437201M, TowerTypeId = 23 },
                    new TowerSections { Id = 300, SectionNumber = 4, SectionHeightM = 25.77M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.493M, TotalWeightKg = 56143.2878091947M, TowerTypeId = 23 },

                    new TowerSections { Id = 301, SectionNumber = 1, SectionHeightM = 13.180M, ExternalDiameterUpperFlangeM = 4.5M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 89293M, TowerTypeId = 29 },
                    new TowerSections { Id = 302, SectionNumber = 2, SectionHeightM = 19.040M, ExternalDiameterUpperFlangeM = 4.5M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 90738M, TowerTypeId = 29 },
                    new TowerSections { Id = 303, SectionNumber = 3, SectionHeightM = 23.8M, ExternalDiameterUpperFlangeM = 4.4M, ExternalDiameterLowerFlangeM = 4.5M, TotalWeightKg = 89933M, TowerTypeId = 29 },
                    new TowerSections { Id = 304, SectionNumber = 4, SectionHeightM = 29.960M, ExternalDiameterUpperFlangeM = 4.4M, ExternalDiameterLowerFlangeM = 4.4M, TotalWeightKg = 79262M, TowerTypeId = 29 },
                    new TowerSections { Id = 305, SectionNumber = 5, SectionHeightM = 32.210M, ExternalDiameterUpperFlangeM = 3.503M, ExternalDiameterLowerFlangeM = 4.4M, TotalWeightKg = 65219M, TowerTypeId = 29 }

                    );


        }


        // Seed SST ApplicationReasons
        private static void SeedApplicationReasons(this ModelBuilder builder)
        {
            var applReasonsList = new List<string>()
             {
                 "New hub height with potential LCoE improvement",
                 "Tower Cost out larger diameter",
                 "Tower Cost out by reduction of loads margin",
                 "Project enabler noise modes",
                 "Project enabler logistic",
                 "Lifetime extension (compared to STP/ETP)",
                 "Other:"
             };

            var applicationReasons = applReasonsList.Select((ar, idx) => new ApplicationReason { Id = idx + 1, Reason = ar });
            builder.Entity<ApplicationReason>().HasData(applicationReasons);
        }

        private static void SeedPresetRoles(this ModelBuilder builder)
        {
            List<PresetRoles> presetRoleList = new List<PresetRoles>();

            presetRoleList.Add(new PresetRoles { Id = 1, RegionId = 5, RoleId = 3, UserName = "georg.bischof@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 2, RegionId = 1, RoleId = 3, UserName = "carlos.sastre@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 3, RegionId = 4, RoleId = 3, UserName = "brenda.rodriguez@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 4, RegionId = 7, RoleId = 3, UserName = "jason.saizar@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 5, RegionId = 6, RoleId = 3, UserName = "luisa.vidal@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 6, RegionId = 2, RoleId = 3, UserName = "renan.venturini@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 7, RegionId = 3, RoleId = 3, UserName = "teddy.chandrakumar@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 8, RegionId = 5, RoleId = 4, UserName = "henning.mentz@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 9, RegionId = 1, RoleId = 4, UserName = "shi.xiujuan@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 10, RegionId = 4, RoleId = 4, UserName = "rene.hernandez@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 11, RegionId = 7, RoleId = 4, UserName = "maged.mostafa@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 12, RegionId = 6, RoleId = 4, UserName = "roberto.lozano@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 13, RegionId = 2, RoleId = 4, UserName = "lucas.oyamada@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 14, RegionId = 3, RoleId = 4, UserName = "teddy.chandrakumar@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 15, RegionId = 5, RoleId = 6, UserName = "ingelise.nielsen@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 16, RegionId = 1, RoleId = 6, UserName = "fernando.vital@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 17, RegionId = 4, RoleId = 6, UserName = "mikel.cenoz@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 18, RegionId = 7, RoleId = 6, UserName = "cristina.valencia.r@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 19, RegionId = 6, RoleId = 6, UserName = "eddie.rijo@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 20, RegionId = 2, RoleId = 6, UserName = "mikel.cenoz@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 21, RegionId = 3, RoleId = 6, UserName = "fernando.vital@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 22, RegionId = 5, RoleId = 7, UserName = "julieelaine.lherbier@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 23, RegionId = 1, RoleId = 7, UserName = "shuofei.cai@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 24, RegionId = 4, RoleId = 7, UserName = "carlos.mendez@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 25, RegionId = 7, RoleId = 7, UserName = "carlos.sanabria@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 26, RegionId = 6, RoleId = 7, UserName = "Elizabet.Zaharieva@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 27, RegionId = 2, RoleId = 7, UserName = "domenico.barger@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 28, RegionId = 5, RoleId = 14, UserName = "lars.nissen@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 29, RegionId = 1, RoleId = 14, UserName = "tongbo.zhang@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 30, RegionId = 4, RoleId = 14, UserName = "ana.hoyo@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 31, RegionId = 7, RoleId = 14, UserName = "maria.iturralde@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 32, RegionId = 6, RoleId = 14, UserName = "justo.tirado@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 33, RegionId = 2, RoleId = 14, UserName = "justo.tirado@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 34, RegionId = 3, RoleId = 14, UserName = "shanmuga.palanisamy@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 35, RegionId = 5, RoleId = 8, UserName = "tanja.stahmer@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 36, RegionId = 1, RoleId = 8, UserName = "liqiang.xu@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 37, RegionId = 4, RoleId = 8, UserName = "URKO.SARASOLA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 38, RegionId = 7, RoleId = 8, UserName = "carlos.vildosola@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 39, RegionId = 6, RoleId = 8, UserName = "Michael.Wilt@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 40, RegionId = 2, RoleId = 8, UserName = "rodrigo.xambre@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 41, RegionId = 3, RoleId = 8, UserName = "velmurugan.sundaram@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 42, RegionId = 5, RoleId = 9, UserName = "stefan.penner@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 43, RegionId = 4, RoleId = 9, UserName = "urko.sarasola@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 44, RegionId = 7, RoleId = 9, UserName = "miguel.diaz@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 45, RegionId = 6, RoleId = 9, UserName = "charles.keyser@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 46, RegionId = 2, RoleId = 9, UserName = "rodrigo.xambre@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 47, RegionId = 3, RoleId = 9, UserName = "karthik.arumugam@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 48, RegionId = 5, RoleId = 10, UserName = "stefan.penner@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 49, RegionId = 1, RoleId = 10, UserName = "waqar.hussain@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 50, RegionId = 4, RoleId = 10, UserName = "enrique.carballo@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 51, RegionId = 7, RoleId = 10, UserName = "ines.zalacain@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 52, RegionId = 6, RoleId = 10, UserName = "paul.smith@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 53, RegionId = 2, RoleId = 10, UserName = "sandro.patella@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 54, RegionId = 3, RoleId = 10, UserName = "manikandan.gurumoorthy@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 55, RegionId = 5, RoleId = 11, UserName = "JUANMA.OSORIO@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 56, RegionId = 1, RoleId = 11, UserName = "JUANMA.OSORIO@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 57, RegionId = 4, RoleId = 11, UserName = "JUANMA.OSORIO@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 58, RegionId = 7, RoleId = 11, UserName = "JUANMA.OSORIO@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 59, RegionId = 6, RoleId = 11, UserName = "JUANMA.OSORIO@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 60, RegionId = 2, RoleId = 11, UserName = "JUANMA.OSORIO@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 61, RegionId = 3, RoleId = 11, UserName = "JUANMA.OSORIO@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 62, RegionId = 5, RoleId = 12, UserName = "Steffen.Alvermann@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 63, RegionId = 1, RoleId = 12, UserName = "Steffen.Alvermann@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 64, RegionId = 4, RoleId = 12, UserName = "Steffen.Alvermann@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 65, RegionId = 7, RoleId = 12, UserName = "Steffen.Alvermann@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 66, RegionId = 6, RoleId = 12, UserName = "Steffen.Alvermann@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 67, RegionId = 2, RoleId = 12, UserName = "Steffen.Alvermann@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 68, RegionId = 3, RoleId = 12, UserName = "Steffen.Alvermann@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 69, RegionId = 5, RoleId = 13, UserName = "Jan-Hinrich.Ahrens@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 70, RegionId = 1, RoleId = 13, UserName = "Jan-Hinrich.Ahrens@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 71, RegionId = 4, RoleId = 13, UserName = "Jan-Hinrich.Ahrens@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 72, RegionId = 7, RoleId = 13, UserName = "Jan-Hinrich.Ahrens@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 73, RegionId = 6, RoleId = 13, UserName = "Jan-Hinrich.Ahrens@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 74, RegionId = 2, RoleId = 13, UserName = "Jan-Hinrich.Ahrens@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 75, RegionId = 3, RoleId = 13, UserName = "Jan-Hinrich.Ahrens@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 76, RegionId = 5, RoleId = 15, UserName = "IRENE.ALLI@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 77, RegionId = 1, RoleId = 15, UserName = "IRENE.ALLI@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 78, RegionId = 4, RoleId = 15, UserName = "IRENE.ALLI@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 79, RegionId = 7, RoleId = 15, UserName = "IRENE.ALLI@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 80, RegionId = 6, RoleId = 15, UserName = "IRENE.ALLI@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 81, RegionId = 2, RoleId = 15, UserName = "IRENE.ALLI@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 82, RegionId = 3, RoleId = 15, UserName = "IRENE.ALLI@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 83, RegionId = 5, RoleId = 16, UserName = "JULEN.ORTEGA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 84, RegionId = 1, RoleId = 16, UserName = "JULEN.ORTEGA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 85, RegionId = 4, RoleId = 16, UserName = "JULEN.ORTEGA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 86, RegionId = 7, RoleId = 16, UserName = "JULEN.ORTEGA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 87, RegionId = 6, RoleId = 16, UserName = "JULEN.ORTEGA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 88, RegionId = 2, RoleId = 16, UserName = "JULEN.ORTEGA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 89, RegionId = 3, RoleId = 16, UserName = "JULEN.ORTEGA@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 90, RegionId = 2, RoleId = 17, UserName = "VANESSA.CAMARA@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 91, RegionId = 3, RoleId = 17, UserName = "srikrishnan.jalendiran@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 92, RegionId = 4, RoleId = 17, UserName = "miguel.leizagoyen@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 93, RegionId = 6, RoleId = 17, UserName = "kevin.kern@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 94, RegionId = 7, RoleId = 17, UserName = "JULIO.ROYO@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 95, RegionId = 5, RoleId = 17, UserName = "stefan.penner@siemensgamesa.com" });
            presetRoleList.Add(new PresetRoles { Id = 96, RegionId = 1, RoleId = 17, UserName = "Benedetto.Gallina@siemensgamesa.com" });

            presetRoleList.Add(new PresetRoles { Id = 97, RegionId = 1, RoleId = 2, UserName = "Benedetto.Gallina@siemensgamesa.com" });

            builder.Entity<PresetRoles>().HasData(presetRoleList);
        }

        private static void SeedNacelleDistance(this ModelBuilder builder)
        {
            builder.Entity<NacelleDistance>().HasData(
                new NacelleDistance { Id = 1, DistanceBottomToCenterHub = 2295.909M, WtgCatalogueId = 1 },
                new NacelleDistance { Id = 2, DistanceBottomToCenterHub = 2265.941M, WtgCatalogueId = 2 },
                new NacelleDistance { Id = 3, DistanceBottomToCenterHub = 2086.56M, WtgCatalogueId = 3 },
                new NacelleDistance { Id = 4, DistanceBottomToCenterHub = 2086.56M, WtgCatalogueId = 4 },
                new NacelleDistance { Id = 5, DistanceBottomToCenterHub = 2010.98M, WtgCatalogueId = 5 },
                new NacelleDistance { Id = 6, DistanceBottomToCenterHub = 2002.61M, WtgCatalogueId = 6 },
                new NacelleDistance { Id = 7, DistanceBottomToCenterHub = 2086.56M, WtgCatalogueId = 7 }
            );
        }

        private static void SeedNoiseModes(this ModelBuilder builder)
        {
            builder.Entity<NoiseMode>().HasData(
                    new NoiseMode { Id = 1, NoiseModeNo = "﻿0", NoiseLevelDecibels = 106M, TowerTypeId = 15 },
                    new NoiseMode { Id = 2, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 15 },
                    new NoiseMode { Id = 3, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 15 },
                    new NoiseMode { Id = 4, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 15 },
                    new NoiseMode { Id = 5, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 15 },
                    new NoiseMode { Id = 6, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 15 },
                    new NoiseMode { Id = 7, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 15 },
                    new NoiseMode { Id = 8, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 15 },
                    new NoiseMode { Id = 9, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 15 },

                    new NoiseMode { Id = 10, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 16 },
                    new NoiseMode { Id = 11, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 16 },
                    new NoiseMode { Id = 12, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 16 },
                    new NoiseMode { Id = 13, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 16 },
                    new NoiseMode { Id = 14, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 16 },
                    new NoiseMode { Id = 15, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 16 },
                    new NoiseMode { Id = 16, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 16 },
                    new NoiseMode { Id = 17, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 16 },
                    new NoiseMode { Id = 18, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 16 },

                    new NoiseMode { Id = 19, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 1 },
                    new NoiseMode { Id = 20, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 1 },
                    new NoiseMode { Id = 21, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 1 },
                    new NoiseMode { Id = 22, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 1 },
                    new NoiseMode { Id = 23, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 1 },
                    new NoiseMode { Id = 24, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 1 },
                    new NoiseMode { Id = 25, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 1 },
                    new NoiseMode { Id = 26, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 1 },
                    new NoiseMode { Id = 27, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 1 },

                    new NoiseMode { Id = 28, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 17 },
                    new NoiseMode { Id = 29, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 17 },
                    new NoiseMode { Id = 30, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 17 },
                    new NoiseMode { Id = 31, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 17 },
                    new NoiseMode { Id = 32, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 17 },
                    new NoiseMode { Id = 33, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 17 },
                    new NoiseMode { Id = 34, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 17 },
                    new NoiseMode { Id = 35, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 17 },
                    new NoiseMode { Id = 36, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 17 },

                    new NoiseMode { Id = 37, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 18 },
                    new NoiseMode { Id = 38, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 18 },
                    new NoiseMode { Id = 39, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 18 },
                    new NoiseMode { Id = 40, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 18 },
                    new NoiseMode { Id = 41, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 18 },
                    new NoiseMode { Id = 42, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 18 },
                    new NoiseMode { Id = 43, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 18 },
                    new NoiseMode { Id = 44, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 18 },
                    new NoiseMode { Id = 45, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 18 },

                    new NoiseMode { Id = 46, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 2 },
                    new NoiseMode { Id = 47, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 2 },
                    new NoiseMode { Id = 48, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 2 },
                    new NoiseMode { Id = 49, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 2 },
                    new NoiseMode { Id = 50, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 2 },
                    new NoiseMode { Id = 51, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 2 },
                    new NoiseMode { Id = 52, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 2 },
                    new NoiseMode { Id = 53, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 2 },
                    new NoiseMode { Id = 54, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 2 },

                    new NoiseMode { Id = 55, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 19 },
                    new NoiseMode { Id = 56, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 19 },
                    new NoiseMode { Id = 57, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 19 },
                    new NoiseMode { Id = 58, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 19 },
                    new NoiseMode { Id = 59, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 19 },
                    new NoiseMode { Id = 60, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 19 },
                    new NoiseMode { Id = 61, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 19 },
                    new NoiseMode { Id = 62, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 19 },
                    new NoiseMode { Id = 63, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 19 },

                    new NoiseMode { Id = 64, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 20 },
                    new NoiseMode { Id = 65, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 20 },
                    new NoiseMode { Id = 66, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 20 },
                    new NoiseMode { Id = 67, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 20 },
                    new NoiseMode { Id = 68, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 20 },
                    new NoiseMode { Id = 69, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 20 },
                    new NoiseMode { Id = 70, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 20 },
                    new NoiseMode { Id = 71, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 20 },
                    new NoiseMode { Id = 72, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 20 },

                    new NoiseMode { Id = 73, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 21 },
                    new NoiseMode { Id = 74, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 21 },
                    new NoiseMode { Id = 75, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 21 },
                    new NoiseMode { Id = 76, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 21 },
                    new NoiseMode { Id = 77, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 21 },
                    new NoiseMode { Id = 78, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 21 },
                    new NoiseMode { Id = 79, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 21 },
                    new NoiseMode { Id = 80, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 21 },
                    new NoiseMode { Id = 81, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 21 },

                    new NoiseMode { Id = 82, NoiseModeNo = "0", NoiseLevelDecibels = 106M, TowerTypeId = 22 },
                    new NoiseMode { Id = 83, NoiseModeNo = "1", NoiseLevelDecibels = 105.5M, TowerTypeId = 22 },
                    new NoiseMode { Id = 84, NoiseModeNo = "2", NoiseLevelDecibels = 104.5M, TowerTypeId = 22 },
                    new NoiseMode { Id = 85, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 22 },
                    new NoiseMode { Id = 86, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 22 },
                    new NoiseMode { Id = 87, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 22 },
                    new NoiseMode { Id = 88, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 22 },
                    new NoiseMode { Id = 89, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 22 },
                    new NoiseMode { Id = 90, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 22 },

                    new NoiseMode { Id = 91, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 3 },
                    new NoiseMode { Id = 92, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 3 },
                    new NoiseMode { Id = 93, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 3 },
                    new NoiseMode { Id = 94, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 3 },
                    new NoiseMode { Id = 95, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 3 },
                    new NoiseMode { Id = 96, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 3 },
                    new NoiseMode { Id = 97, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 3 },
                    new NoiseMode { Id = 98, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 3 },
                    new NoiseMode { Id = 99, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 3 },

                    new NoiseMode { Id = 100, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 24 },
                    new NoiseMode { Id = 101, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 24 },
                    new NoiseMode { Id = 102, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 24 },
                    new NoiseMode { Id = 103, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 24 },
                    new NoiseMode { Id = 104, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 24 },
                    new NoiseMode { Id = 105, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 24 },
                    new NoiseMode { Id = 106, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 24 },
                    new NoiseMode { Id = 107, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 24 },
                    new NoiseMode { Id = 108, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 24 },

                    new NoiseMode { Id = 109, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 25 },
                    new NoiseMode { Id = 110, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 25 },
                    new NoiseMode { Id = 111, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 25 },
                    new NoiseMode { Id = 112, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 25 },
                    new NoiseMode { Id = 113, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 25 },
                    new NoiseMode { Id = 114, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 25 },
                    new NoiseMode { Id = 115, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 25 },
                    new NoiseMode { Id = 116, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 25 },
                    new NoiseMode { Id = 117, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 25 },

                    new NoiseMode { Id = 118, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 26 },
                    new NoiseMode { Id = 119, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 26 },
                    new NoiseMode { Id = 120, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 26 },
                    new NoiseMode { Id = 121, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 26 },
                    new NoiseMode { Id = 122, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 26 },
                    new NoiseMode { Id = 123, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 26 },
                    new NoiseMode { Id = 124, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 26 },
                    new NoiseMode { Id = 125, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 26 },
                    new NoiseMode { Id = 126, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 26 },

                    new NoiseMode { Id = 127, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 27 },
                    new NoiseMode { Id = 128, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 27 },
                    new NoiseMode { Id = 129, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 27 },
                    new NoiseMode { Id = 130, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 27 },
                    new NoiseMode { Id = 131, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 27 },
                    new NoiseMode { Id = 132, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 27 },
                    new NoiseMode { Id = 133, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 27 },
                    new NoiseMode { Id = 134, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 27 },
                    new NoiseMode { Id = 135, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 27 },

                    new NoiseMode { Id = 136, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 28 },
                    new NoiseMode { Id = 137, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 28 },
                    new NoiseMode { Id = 138, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 28 },
                    new NoiseMode { Id = 139, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 28 },
                    new NoiseMode { Id = 140, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 28 },
                    new NoiseMode { Id = 141, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 28 },
                    new NoiseMode { Id = 142, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 28 },
                    new NoiseMode { Id = 143, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 28 },
                    new NoiseMode { Id = 144, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 28 },

                    new NoiseMode { Id = 145, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 4 },
                    new NoiseMode { Id = 146, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 4 },
                    new NoiseMode { Id = 147, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 4 },
                    new NoiseMode { Id = 148, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 4 },
                    new NoiseMode { Id = 149, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 4 },
                    new NoiseMode { Id = 150, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 4 },
                    new NoiseMode { Id = 151, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 4 },
                    new NoiseMode { Id = 152, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 4 },
                    new NoiseMode { Id = 153, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 4 },

                    new NoiseMode { Id = 154, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 29 },
                    new NoiseMode { Id = 155, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 29 },
                    new NoiseMode { Id = 156, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 29 },
                    new NoiseMode { Id = 157, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 29 },
                    new NoiseMode { Id = 158, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 29 },
                    new NoiseMode { Id = 159, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 29 },
                    new NoiseMode { Id = 160, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 29 },
                    new NoiseMode { Id = 161, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 29 },
                    new NoiseMode { Id = 162, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 29 },

                    new NoiseMode { Id = 163, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 30 },
                    new NoiseMode { Id = 164, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 30 },
                    new NoiseMode { Id = 165, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 30 },
                    new NoiseMode { Id = 166, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 30 },
                    new NoiseMode { Id = 167, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 30 },
                    new NoiseMode { Id = 168, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 30 },
                    new NoiseMode { Id = 169, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 30 },
                    new NoiseMode { Id = 170, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 30 },
                    new NoiseMode { Id = 171, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 30 },

                    new NoiseMode { Id = 172, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 31 },
                    new NoiseMode { Id = 173, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 31 },
                    new NoiseMode { Id = 174, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 31 },
                    new NoiseMode { Id = 175, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 31 },
                    new NoiseMode { Id = 176, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 31 },
                    new NoiseMode { Id = 177, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 31 },
                    new NoiseMode { Id = 178, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 31 },
                    new NoiseMode { Id = 179, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 31 },
                    new NoiseMode { Id = 180, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 31 },

                    new NoiseMode { Id = 181, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 32 },
                    new NoiseMode { Id = 182, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 32 },
                    new NoiseMode { Id = 183, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 32 },
                    new NoiseMode { Id = 184, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 32 },
                    new NoiseMode { Id = 185, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 32 },
                    new NoiseMode { Id = 186, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 32 },
                    new NoiseMode { Id = 187, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 32 },
                    new NoiseMode { Id = 188, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 32 },
                    new NoiseMode { Id = 189, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 32 },

                    new NoiseMode { Id = 190, NoiseModeNo = "0", NoiseLevelDecibels = 105M, TowerTypeId = 23 },
                    new NoiseMode { Id = 191, NoiseModeNo = "1", NoiseLevelDecibels = 104M, TowerTypeId = 23 },
                    new NoiseMode { Id = 192, NoiseModeNo = "2", NoiseLevelDecibels = 103.5M, TowerTypeId = 23 },
                    new NoiseMode { Id = 193, NoiseModeNo = "3", NoiseLevelDecibels = 102M, TowerTypeId = 23 },
                    new NoiseMode { Id = 194, NoiseModeNo = "4", NoiseLevelDecibels = 101M, TowerTypeId = 23 },
                    new NoiseMode { Id = 195, NoiseModeNo = "5", NoiseLevelDecibels = 100M, TowerTypeId = 23 },
                    new NoiseMode { Id = 196, NoiseModeNo = "6", NoiseLevelDecibels = 99M, TowerTypeId = 23 },
                    new NoiseMode { Id = 197, NoiseModeNo = "7", NoiseLevelDecibels = 98M, TowerTypeId = 23 },
                    new NoiseMode { Id = 198, NoiseModeNo = "8", NoiseLevelDecibels = 97M, TowerTypeId = 23 },

                    new NoiseMode { Id = 199, NoiseModeNo = "0", NoiseLevelDecibels = 111.6M, TowerTypeId = 40 },
                    new NoiseMode { Id = 200, NoiseModeNo = "5", NoiseLevelDecibels = 104M, TowerTypeId = 40 },
                    new NoiseMode { Id = 201, NoiseModeNo = "6", NoiseLevelDecibels = 102.2M, TowerTypeId = 40 },
                    new NoiseMode { Id = 202, NoiseModeNo = "7", NoiseLevelDecibels = 101.3M, TowerTypeId = 40 },
                    new NoiseMode { Id = 203, NoiseModeNo = "8", NoiseLevelDecibels = 100.3M, TowerTypeId = 40 },
                    new NoiseMode { Id = 204, NoiseModeNo = "0", NoiseLevelDecibels = 109.3M, TowerTypeId = 40 },
                    new NoiseMode { Id = 205, NoiseModeNo = "5", NoiseLevelDecibels = 101.7M, TowerTypeId = 40 },
                    new NoiseMode { Id = 206, NoiseModeNo = "6", NoiseLevelDecibels = 99.9M, TowerTypeId = 40 },
                    new NoiseMode { Id = 207, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 40 },
                    new NoiseMode { Id = 208, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 40 },

                    new NoiseMode { Id = 209, NoiseModeNo = "0", NoiseLevelDecibels = 111.6M, TowerTypeId = 33 },
                    new NoiseMode { Id = 210, NoiseModeNo = "1", NoiseLevelDecibels = 108M, TowerTypeId = 33 },
                    new NoiseMode { Id = 211, NoiseModeNo = "2", NoiseLevelDecibels = 107.5M, TowerTypeId = 33 },
                    new NoiseMode { Id = 212, NoiseModeNo = "3", NoiseLevelDecibels = 106M, TowerTypeId = 33 },
                    new NoiseMode { Id = 213, NoiseModeNo = "4", NoiseLevelDecibels = 105M, TowerTypeId = 33 },
                    new NoiseMode { Id = 214, NoiseModeNo = "5", NoiseLevelDecibels = 104M, TowerTypeId = 33 },
                    new NoiseMode { Id = 215, NoiseModeNo = "6", NoiseLevelDecibels = 102.2M, TowerTypeId = 33 },
                    new NoiseMode { Id = 216, NoiseModeNo = "7", NoiseLevelDecibels = 101.3M, TowerTypeId = 33 },
                    new NoiseMode { Id = 217, NoiseModeNo = "8", NoiseLevelDecibels = 100.3M, TowerTypeId = 33 },
                    new NoiseMode { Id = 218, NoiseModeNo = "0", NoiseLevelDecibels = 109.3M, TowerTypeId = 33 },
                    new NoiseMode { Id = 219, NoiseModeNo = "1", NoiseLevelDecibels = 105.7M, TowerTypeId = 33 },
                    new NoiseMode { Id = 220, NoiseModeNo = "2", NoiseLevelDecibels = 105.2M, TowerTypeId = 33 },
                    new NoiseMode { Id = 221, NoiseModeNo = "3", NoiseLevelDecibels = 103.7M, TowerTypeId = 33 },
                    new NoiseMode { Id = 222, NoiseModeNo = "4", NoiseLevelDecibels = 102.7M, TowerTypeId = 33 },
                    new NoiseMode { Id = 223, NoiseModeNo = "5", NoiseLevelDecibels = 101.7M, TowerTypeId = 33 },
                    new NoiseMode { Id = 224, NoiseModeNo = "6", NoiseLevelDecibels = 99.9M, TowerTypeId = 33 },
                    new NoiseMode { Id = 225, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 33 },
                    new NoiseMode { Id = 226, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 33 },

                    new NoiseMode { Id = 227, NoiseModeNo = "0", NoiseLevelDecibels = 111.6M, TowerTypeId = 34 },
                    new NoiseMode { Id = 228, NoiseModeNo = "1", NoiseLevelDecibels = 108M, TowerTypeId = 34 },
                    new NoiseMode { Id = 229, NoiseModeNo = "2", NoiseLevelDecibels = 107.5M, TowerTypeId = 34 },
                    new NoiseMode { Id = 230, NoiseModeNo = "3", NoiseLevelDecibels = 106M, TowerTypeId = 34 },
                    new NoiseMode { Id = 231, NoiseModeNo = "4", NoiseLevelDecibels = 105M, TowerTypeId = 34 },
                    new NoiseMode { Id = 232, NoiseModeNo = "5", NoiseLevelDecibels = 104M, TowerTypeId = 34 },
                    new NoiseMode { Id = 233, NoiseModeNo = "6", NoiseLevelDecibels = 102.2M, TowerTypeId = 34 },
                    new NoiseMode { Id = 234, NoiseModeNo = "7", NoiseLevelDecibels = 101.3M, TowerTypeId = 34 },
                    new NoiseMode { Id = 235, NoiseModeNo = "8", NoiseLevelDecibels = 100.3M, TowerTypeId = 34 },
                    new NoiseMode { Id = 236, NoiseModeNo = "0", NoiseLevelDecibels = 109.3M, TowerTypeId = 34 },
                    new NoiseMode { Id = 237, NoiseModeNo = "1", NoiseLevelDecibels = 105.7M, TowerTypeId = 34 },
                    new NoiseMode { Id = 238, NoiseModeNo = "2", NoiseLevelDecibels = 105.2M, TowerTypeId = 34 },
                    new NoiseMode { Id = 239, NoiseModeNo = "3", NoiseLevelDecibels = 103.7M, TowerTypeId = 34 },
                    new NoiseMode { Id = 240, NoiseModeNo = "4", NoiseLevelDecibels = 102.7M, TowerTypeId = 34 },
                    new NoiseMode { Id = 241, NoiseModeNo = "5", NoiseLevelDecibels = 101.7M, TowerTypeId = 34 },
                    new NoiseMode { Id = 242, NoiseModeNo = "6", NoiseLevelDecibels = 99.9M, TowerTypeId = 34 },
                    new NoiseMode { Id = 243, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 34 },
                    new NoiseMode { Id = 244, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 34 },

                    new NoiseMode { Id = 245, NoiseModeNo = "0", NoiseLevelDecibels = 111.6M, TowerTypeId = 38 },
                    new NoiseMode { Id = 246, NoiseModeNo = "1", NoiseLevelDecibels = 108M, TowerTypeId = 38 },
                    new NoiseMode { Id = 247, NoiseModeNo = "2", NoiseLevelDecibels = 107.5M, TowerTypeId = 38 },
                    new NoiseMode { Id = 248, NoiseModeNo = "3", NoiseLevelDecibels = 106M, TowerTypeId = 38 },
                    new NoiseMode { Id = 249, NoiseModeNo = "4", NoiseLevelDecibels = 105M, TowerTypeId = 38 },
                    new NoiseMode { Id = 250, NoiseModeNo = "5", NoiseLevelDecibels = 104M, TowerTypeId = 38 },
                    new NoiseMode { Id = 251, NoiseModeNo = "6", NoiseLevelDecibels = 102.2M, TowerTypeId = 38 },
                    new NoiseMode { Id = 252, NoiseModeNo = "7", NoiseLevelDecibels = 101.3M, TowerTypeId = 38 },
                    new NoiseMode { Id = 253, NoiseModeNo = "8", NoiseLevelDecibels = 100.3M, TowerTypeId = 38 },
                    new NoiseMode { Id = 254, NoiseModeNo = "0", NoiseLevelDecibels = 109.3M, TowerTypeId = 38 },
                    new NoiseMode { Id = 255, NoiseModeNo = "1", NoiseLevelDecibels = 105.7M, TowerTypeId = 38 },
                    new NoiseMode { Id = 256, NoiseModeNo = "2", NoiseLevelDecibels = 105.2M, TowerTypeId = 38 },
                    new NoiseMode { Id = 257, NoiseModeNo = "3", NoiseLevelDecibels = 103.7M, TowerTypeId = 38 },
                    new NoiseMode { Id = 258, NoiseModeNo = "4", NoiseLevelDecibels = 102.7M, TowerTypeId = 38 },
                    new NoiseMode { Id = 259, NoiseModeNo = "5", NoiseLevelDecibels = 101.7M, TowerTypeId = 38 },
                    new NoiseMode { Id = 260, NoiseModeNo = "6", NoiseLevelDecibels = 99.9M, TowerTypeId = 38 },
                    new NoiseMode { Id = 261, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 38 },
                    new NoiseMode { Id = 262, NoiseModeNo = "8", NoiseLevelDecibels = 98M, TowerTypeId = 38 },

                    new NoiseMode { Id = 263, NoiseModeNo = "0", NoiseLevelDecibels = 108.5M, TowerTypeId = 56 },
                    new NoiseMode { Id = 264, NoiseModeNo = "1", NoiseLevelDecibels = 105.7M, TowerTypeId = 56 },
                    new NoiseMode { Id = 265, NoiseModeNo = "2", NoiseLevelDecibels = 105.3M, TowerTypeId = 56 },
                    new NoiseMode { Id = 266, NoiseModeNo = "3", NoiseLevelDecibels = 103.7M, TowerTypeId = 56 },
                    new NoiseMode { Id = 267, NoiseModeNo = "4", NoiseLevelDecibels = 102.7M, TowerTypeId = 56 },
                    new NoiseMode { Id = 268, NoiseModeNo = "5", NoiseLevelDecibels = 101.7M, TowerTypeId = 56 },
                    new NoiseMode { Id = 269, NoiseModeNo = "6", NoiseLevelDecibels = 100M, TowerTypeId = 56 },
                    new NoiseMode { Id = 270, NoiseModeNo = "7", NoiseLevelDecibels = 99M, TowerTypeId = 56 },
                    new NoiseMode { Id = 271, NoiseModeNo = "8", NoiseLevelDecibels = 98.1M, TowerTypeId = 56 },
                    new NoiseMode { Id = 272, NoiseModeNo = "0", NoiseLevelDecibels = 106.2M, TowerTypeId = 56 },
                    new NoiseMode { Id = 273, NoiseModeNo = "1", NoiseLevelDecibels = 103.4M, TowerTypeId = 56 },
                    new NoiseMode { Id = 274, NoiseModeNo = "2", NoiseLevelDecibels = 103M, TowerTypeId = 56 },
                    new NoiseMode { Id = 275, NoiseModeNo = "3", NoiseLevelDecibels = 101.4M, TowerTypeId = 56 },
                    new NoiseMode { Id = 276, NoiseModeNo = "4", NoiseLevelDecibels = 100.4M, TowerTypeId = 56 },
                    new NoiseMode { Id = 277, NoiseModeNo = "5", NoiseLevelDecibels = 99.4M, TowerTypeId = 56 },
                    new NoiseMode { Id = 278, NoiseModeNo = "6", NoiseLevelDecibels = 99.7M, TowerTypeId = 56 },
                    new NoiseMode { Id = 279, NoiseModeNo = "7", NoiseLevelDecibels = 96.7M, TowerTypeId = 56 },
                    new NoiseMode { Id = 280, NoiseModeNo = "8", NoiseLevelDecibels = 95.8M, TowerTypeId = 56 },

                    new NoiseMode { Id = 281, NoiseModeNo = "0", NoiseLevelDecibels = 108.8M, TowerTypeId = 68 },
                    new NoiseMode { Id = 282, NoiseModeNo = "0", NoiseLevelDecibels = 106.5M, TowerTypeId = 68 },

                    new NoiseMode { Id = 283, NoiseModeNo = "0", NoiseLevelDecibels = 106.3M, TowerTypeId = 14 },
                    new NoiseMode { Id = 284, NoiseModeNo = "1", NoiseLevelDecibels = 105M, TowerTypeId = 14 },
                    new NoiseMode { Id = 285, NoiseModeNo = "2", NoiseLevelDecibels = 104M, TowerTypeId = 14 },
                    new NoiseMode { Id = 286, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 14 },
                    new NoiseMode { Id = 287, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 14 },
                    new NoiseMode { Id = 288, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 14 },
                    new NoiseMode { Id = 289, NoiseModeNo = "0", NoiseLevelDecibels = 104M, TowerTypeId = 14 },
                    new NoiseMode { Id = 290, NoiseModeNo = "1", NoiseLevelDecibels = 103M, TowerTypeId = 14 },
                    new NoiseMode { Id = 291, NoiseModeNo = "2", NoiseLevelDecibels = 101.9M, TowerTypeId = 14 },
                    new NoiseMode { Id = 292, NoiseModeNo = "3", NoiseLevelDecibels = 100.8M, TowerTypeId = 14 },
                    new NoiseMode { Id = 293, NoiseModeNo = "4", NoiseLevelDecibels = 99.9M, TowerTypeId = 14 },
                    new NoiseMode { Id = 294, NoiseModeNo = "5", NoiseLevelDecibels = 98.8M, TowerTypeId = 14 },

                    new NoiseMode { Id = 295, NoiseModeNo = "0", NoiseLevelDecibels = 106.3M, TowerTypeId = 62 },
                    new NoiseMode { Id = 296, NoiseModeNo = "1", NoiseLevelDecibels = 105M, TowerTypeId = 62 },
                    new NoiseMode { Id = 297, NoiseModeNo = "2", NoiseLevelDecibels = 104M, TowerTypeId = 62 },
                    new NoiseMode { Id = 298, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 62 },
                    new NoiseMode { Id = 299, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 62 },
                    new NoiseMode { Id = 300, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 62 },
                    new NoiseMode { Id = 301, NoiseModeNo = "0", NoiseLevelDecibels = 104M, TowerTypeId = 62 },
                    new NoiseMode { Id = 302, NoiseModeNo = "1", NoiseLevelDecibels = 103M, TowerTypeId = 62 },
                    new NoiseMode { Id = 303, NoiseModeNo = "2", NoiseLevelDecibels = 101.9M, TowerTypeId = 62 },
                    new NoiseMode { Id = 304, NoiseModeNo = "3", NoiseLevelDecibels = 100.8M, TowerTypeId = 62 },
                    new NoiseMode { Id = 305, NoiseModeNo = "4", NoiseLevelDecibels = 99.9M, TowerTypeId = 62 },
                    new NoiseMode { Id = 306, NoiseModeNo = "5", NoiseLevelDecibels = 98.8M, TowerTypeId = 62 },

                    new NoiseMode { Id = 307, NoiseModeNo = "0", NoiseLevelDecibels = 106.3M, TowerTypeId = 63 },
                    new NoiseMode { Id = 308, NoiseModeNo = "1", NoiseLevelDecibels = 105M, TowerTypeId = 63 },
                    new NoiseMode { Id = 309, NoiseModeNo = "2", NoiseLevelDecibels = 104M, TowerTypeId = 63 },
                    new NoiseMode { Id = 310, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 63 },
                    new NoiseMode { Id = 311, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 63 },
                    new NoiseMode { Id = 312, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 63 },
                    new NoiseMode { Id = 313, NoiseModeNo = "0", NoiseLevelDecibels = 104M, TowerTypeId = 63 },
                    new NoiseMode { Id = 314, NoiseModeNo = "1", NoiseLevelDecibels = 103M, TowerTypeId = 63 },
                    new NoiseMode { Id = 315, NoiseModeNo = "2", NoiseLevelDecibels = 101.9M, TowerTypeId = 63 },
                    new NoiseMode { Id = 316, NoiseModeNo = "3", NoiseLevelDecibels = 100.8M, TowerTypeId = 63 },
                    new NoiseMode { Id = 317, NoiseModeNo = "4", NoiseLevelDecibels = 99.9M, TowerTypeId = 63 },
                    new NoiseMode { Id = 318, NoiseModeNo = "5", NoiseLevelDecibels = 98.8M, TowerTypeId = 63 },

                    new NoiseMode { Id = 319, NoiseModeNo = "0", NoiseLevelDecibels = 106.3M, TowerTypeId = 64 },
                    new NoiseMode { Id = 320, NoiseModeNo = "1", NoiseLevelDecibels = 105M, TowerTypeId = 64 },
                    new NoiseMode { Id = 321, NoiseModeNo = "2", NoiseLevelDecibels = 104M, TowerTypeId = 64 },
                    new NoiseMode { Id = 322, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 64 },
                    new NoiseMode { Id = 323, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 64 },
                    new NoiseMode { Id = 324, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 64 },
                    new NoiseMode { Id = 325, NoiseModeNo = "0", NoiseLevelDecibels = 104M, TowerTypeId = 64 },
                    new NoiseMode { Id = 326, NoiseModeNo = "1", NoiseLevelDecibels = 103M, TowerTypeId = 64 },
                    new NoiseMode { Id = 327, NoiseModeNo = "2", NoiseLevelDecibels = 101.9M, TowerTypeId = 64 },
                    new NoiseMode { Id = 328, NoiseModeNo = "3", NoiseLevelDecibels = 100.8M, TowerTypeId = 64 },
                    new NoiseMode { Id = 329, NoiseModeNo = "4", NoiseLevelDecibels = 99.9M, TowerTypeId = 64 },
                    new NoiseMode { Id = 330, NoiseModeNo = "5", NoiseLevelDecibels = 98.8M, TowerTypeId = 64 },
                    new NoiseMode { Id = 331, NoiseModeNo = "0", NoiseLevelDecibels = 106.3M, TowerTypeId = 64 },
                    new NoiseMode { Id = 332, NoiseModeNo = "1", NoiseLevelDecibels = 105M, TowerTypeId = 64 },
                    new NoiseMode { Id = 333, NoiseModeNo = "2", NoiseLevelDecibels = 104M, TowerTypeId = 64 },
                    new NoiseMode { Id = 334, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 64 },
                    new NoiseMode { Id = 335, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 64 },
                    new NoiseMode { Id = 336, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 64 },
                    new NoiseMode { Id = 337, NoiseModeNo = "0", NoiseLevelDecibels = 104M, TowerTypeId = 64 },
                    new NoiseMode { Id = 338, NoiseModeNo = "1", NoiseLevelDecibels = 103M, TowerTypeId = 64 },
                    new NoiseMode { Id = 339, NoiseModeNo = "2", NoiseLevelDecibels = 101.9M, TowerTypeId = 64 },
                    new NoiseMode { Id = 340, NoiseModeNo = "3", NoiseLevelDecibels = 100.8M, TowerTypeId = 64 },
                    new NoiseMode { Id = 341, NoiseModeNo = "4", NoiseLevelDecibels = 99.9M, TowerTypeId = 64 },
                    new NoiseMode { Id = 342, NoiseModeNo = "5", NoiseLevelDecibels = 98.8M, TowerTypeId = 64 },
                    new NoiseMode { Id = 343, NoiseModeNo = "0", NoiseLevelDecibels = 106.3M, TowerTypeId = 64 },
                    new NoiseMode { Id = 344, NoiseModeNo = "0", NoiseLevelDecibels = 104M, TowerTypeId = 64 },

                    new NoiseMode { Id = 345, NoiseModeNo = "0", NoiseLevelDecibels = 106.3M, TowerTypeId = 65 },
                    new NoiseMode { Id = 346, NoiseModeNo = "1", NoiseLevelDecibels = 105M, TowerTypeId = 65 },
                    new NoiseMode { Id = 347, NoiseModeNo = "2", NoiseLevelDecibels = 104M, TowerTypeId = 65 },
                    new NoiseMode { Id = 348, NoiseModeNo = "3", NoiseLevelDecibels = 103M, TowerTypeId = 65 },
                    new NoiseMode { Id = 349, NoiseModeNo = "4", NoiseLevelDecibels = 102M, TowerTypeId = 65 },
                    new NoiseMode { Id = 350, NoiseModeNo = "5", NoiseLevelDecibels = 101M, TowerTypeId = 65 },
                    new NoiseMode { Id = 351, NoiseModeNo = "0", NoiseLevelDecibels = 104M, TowerTypeId = 65 },
                    new NoiseMode { Id = 352, NoiseModeNo = "1", NoiseLevelDecibels = 103M, TowerTypeId = 65 },
                    new NoiseMode { Id = 353, NoiseModeNo = "2", NoiseLevelDecibels = 101.9M, TowerTypeId = 65 },
                    new NoiseMode { Id = 354, NoiseModeNo = "3", NoiseLevelDecibels = 100.8M, TowerTypeId = 65 },
                    new NoiseMode { Id = 355, NoiseModeNo = "4", NoiseLevelDecibels = 99.9M, TowerTypeId = 65 },
                    new NoiseMode { Id = 356, NoiseModeNo = "5", NoiseLevelDecibels = 98.8M, TowerTypeId = 65 }
            );
        }

        // Seed InitialTower
        private static void SeedInitialTower(this ModelBuilder builder)
        {
            builder.Entity<InitialTower>().HasData(
                new InitialTower { Id = 1, Tower = "T84.32L2", Model = "STD", HubHeightMinM = 84M, HubHeightMaxM = 92.75M, WtgCatalogueId = 6 },
                new InitialTower { Id = 2, Tower = "T84.32L5", Model = "STD", HubHeightMinM = 84M, HubHeightMaxM = 92.75M, WtgCatalogueId = 6 },
                new InitialTower { Id = 3, Tower = "T101.5.30L2", Model = "STD", HubHeightMinM = 92.75M, HubHeightMaxM = 107.75M, WtgCatalogueId = 6 },
                new InitialTower { Id = 4, Tower = "T114.30L2", Model = "STD", HubHeightMinM = 107.75M, HubHeightMaxM = 120M, WtgCatalogueId = 6 },
                new InitialTower { Id = 5, Tower = "T84.36", Model = "MY20", HubHeightMinM = 84M, HubHeightMaxM = 90.5M, WtgCatalogueId = 6 },
                new InitialTower { Id = 6, Tower = "T97.31", Model = "MY20", HubHeightMinM = 90.5M, HubHeightMaxM = 99.25M, WtgCatalogueId = 6 },
                new InitialTower { Id = 7, Tower = "T101.5.31", Model = "MY20", HubHeightMinM = 99.25M, HubHeightMaxM = 104.75M, WtgCatalogueId = 6 },
                new InitialTower { Id = 8, Tower = "T108.30", Model = "MY20", HubHeightMinM = 104.75M, HubHeightMaxM = 111M, WtgCatalogueId = 6 },
                new InitialTower { Id = 9, Tower = "T114.30", Model = "MY20", HubHeightMinM = 111M, HubHeightMaxM = 120M, WtgCatalogueId = 6 },
                new InitialTower { Id = 10, Tower = "T79.5.40", Model = "STD_MKII", HubHeightMinM = 79.5M, HubHeightMaxM = 84.75M, WtgCatalogueId = 3 },
                new InitialTower { Id = 11, Tower = "T90.41", Model = "STD_MKII", HubHeightMinM = 84.75M, HubHeightMaxM = 96.25M, WtgCatalogueId = 3 },
                new InitialTower { Id = 12, Tower = "T102.5.42", Model = "STD_MKII", HubHeightMinM = 96.25M, HubHeightMaxM = 115M, WtgCatalogueId = 3 },
                new InitialTower { Id = 13, Tower = "T102.5.43", Model = "STD_MKII", HubHeightMinM = 96.25M, HubHeightMaxM = 115M, WtgCatalogueId = 3 },
                new InitialTower { Id = 14, Tower = "T127.5.40L2", Model = "STD_MKII", HubHeightMinM = 115M, HubHeightMaxM = 142.5M, WtgCatalogueId = 3 },
                new InitialTower { Id = 15, Tower = "T157.5.40L2", Model = "STD_MKII", HubHeightMinM = 142.5M, HubHeightMaxM = 165M, WtgCatalogueId = 3 },
                new InitialTower { Id = 16, Tower = "T84.41", Model = "STD_MKII", HubHeightMinM = 77M, HubHeightMaxM = 110M, WtgCatalogueId = 4 },
                new InitialTower { Id = 17, Tower = "T102.5-50A", Model = "STD_CII", HubHeightMinM = 90M, HubHeightMaxM = 112.25M, WtgCatalogueId = 2 },
                new InitialTower { Id = 18, Tower = "T122.5-50A", Model = "STD_CII", HubHeightMinM = 112.25M, HubHeightMaxM = 135M, WtgCatalogueId = 2 },
                new InitialTower { Id = 19, Tower = "T115-50A", Model = "STD_CIII", HubHeightMinM = 100M, HubHeightMaxM = 125M, WtgCatalogueId = 1 },
                new InitialTower { Id = 20, Tower = "T135-50A", Model = "STD_CIII", HubHeightMinM = 125M, HubHeightMaxM = 155M, WtgCatalogueId = 1 },
                new InitialTower { Id = 21, Tower = "T91.41", Model = "MY21", HubHeightMinM = 79.5M, HubHeightMaxM = 91M, WtgCatalogueId = 3 },
                new InitialTower { Id = 22, Tower = "T102.5.42", Model = "MY21", HubHeightMinM = 91M, HubHeightMaxM = 115M, WtgCatalogueId = 3 },
                new InitialTower { Id = 23, Tower = "T102.5.43", Model = "MY21", HubHeightMinM = 91M, HubHeightMaxM = 115M, WtgCatalogueId = 3 },
                new InitialTower { Id = 24, Tower = "T127.5.45", Model = "MY21", HubHeightMinM = 115M, HubHeightMaxM = 165M, WtgCatalogueId = 3 },
                new InitialTower { Id = 25, Tower = "T84.43", Model = "MY21", HubHeightMinM = 77M, HubHeightMaxM = 91.75M, WtgCatalogueId = 4 },
                new InitialTower { Id = 26, Tower = "T97.31", Model = "MY21", HubHeightMinM = 84M, HubHeightMaxM = 99.25M, WtgCatalogueId = 6 },
                new InitialTower { Id = 27, Tower = "T101.5.31", Model = "MY21", HubHeightMinM = 99.25M, HubHeightMaxM = 104.75M, WtgCatalogueId = 6 },
                new InitialTower { Id = 28, Tower = "T108.30", Model = "MY21", HubHeightMinM = 104.75M, HubHeightMaxM = 111M, WtgCatalogueId = 6 },
                new InitialTower { Id = 29, Tower = "T114.30", Model = "MY21", HubHeightMinM = 111M, HubHeightMaxM = 120M, WtgCatalogueId = 6 },
                new InitialTower { Id = 30, Tower = "T102.5.44", Model = "MY21", HubHeightMinM = 85M, HubHeightMaxM = 165M, WtgCatalogueId = 7 }
            );

        }

        // Seed Tower model
        private static void SeedCatalogueModel(this ModelBuilder builder)
        {
            builder.Entity<WtgCatalogueModel>().HasData(
                new WtgCatalogueModel { Id = 1, Model = "STD_MKII", WtgCatalogueId = 3 },
                new WtgCatalogueModel { Id = 2, Model = "MY21", WtgCatalogueId = 3 },
                new WtgCatalogueModel { Id = 3, Model = "STD_MKII", WtgCatalogueId = 4 },
                new WtgCatalogueModel { Id = 4, Model = "MY21", WtgCatalogueId = 4 },
                new WtgCatalogueModel { Id = 5, Model = "MY21", WtgCatalogueId = 7 },
                new WtgCatalogueModel { Id = 6, Model = "MY20", WtgCatalogueId = 5 },
                new WtgCatalogueModel { Id = 7, Model = "MY21", WtgCatalogueId = 5 },
                new WtgCatalogueModel { Id = 8, Model = "MY19", WtgCatalogueId = 6 },
                new WtgCatalogueModel { Id = 9, Model = "MY20", WtgCatalogueId = 6 },
                new WtgCatalogueModel { Id = 10, Model = "MY21", WtgCatalogueId = 6 },
                new WtgCatalogueModel { Id = 11, Model = "STD_CIII", WtgCatalogueId = 1 },
                new WtgCatalogueModel { Id = 12, Model = "STD_CII", WtgCatalogueId = 2 }
            );
        }

    }
}