
using System;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowerSiteResponse
    {
        public int SstTowerId { get; set; }
        public int ScenarioId { get; set; }
        public bool IsDesignEvaluationComplete { get; set; }
        public string TowersiteDesignOutputFileLink { get; set; }
        public int TowersiteDesignOutputFileSizeBytes { get; set; }
        public Guid UuidId { get; set; }
        public string ErrorCode { get; set; }
    }
}
