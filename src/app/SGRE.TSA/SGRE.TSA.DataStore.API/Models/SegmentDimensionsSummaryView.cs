using System;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SegmentDimensionsSummaryView
    {
        public int SstTowerId { get; set; }

        public Guid SstUuid { get; set; }        

        public decimal HubHeight { get; set; }

        public decimal TowerHeight { get; set; }

        public int NumberOfSections { get; set; }
    }
}
