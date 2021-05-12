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

        
    }
}
