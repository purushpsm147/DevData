using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SegmentDimensionsSummaryDetailView
    {
        public Guid SstUuid { get; set; }

        public int SectionNumber { get; set; }

        public string SectionType { get; set; }

        public decimal SectionLength { get; set; }

        public int OuterDiameterTop { get; set; }

        public int OuterDiameterBottom { get; set; }

        public decimal MaxPlateThickness { get; set; }

        public decimal WeightPlates { get; set; }

        public int WeightFlangesTop { get; set; }

        public int WeightFlangesBottom { get; set; }

        public decimal TransportWeight { get; set; }

    }
}
