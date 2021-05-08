﻿using SGRE.TSA.DataStore.API.Enums;
using System.Collections.Generic;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostOverView
    {
        public int PositionId { get; set; }

        public int ScenarioId { get; set; }

        public string Position { get; set; }

        public decimal Nomination { get; set; }

        public decimal Offer { get; set; }

        public decimal Signature { get; set; }

        public decimal NominationWindfarm { get; set; }

        public decimal OfferWindfarm { get; set; }

        public decimal SignatureWindfarm { get; set; }

    }
}