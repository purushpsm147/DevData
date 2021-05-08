using System;

namespace SGRE.TSA.DataStore.API.Models
{
    public class RequestDesignEvaluation
    {
        public string DesignAuthor { get; set; }
        public string DesignAuthorEmail { get; set; }
        public DateTime DesignDate { get; set; }
        public string DesignDescription { get; set; }
        public int DesignVersion { get; set; }
        public string ElsaFilePath { get; set; }
        public string SafalFilePath { get; set; }
        public string Posc2Folder { get; set; }
        public string XmlFilePath { get; set; }
        public string Region { get; set; }
        public string Platform { get; set; }
        public string Tower { get; set; }
        public decimal HubHeight { get; set; }
        public decimal SectionNumber_max { get; set; }
        public decimal BottomDiameter_max { get; set; }
        public decimal SectionLength_max { get; set; }
        public decimal SectionWeight_max { get; set; }
        public int sstTowerId { get; set; }
        public int scenarioId { get; set; }
        public string Model { get; set; }
        public decimal LoadsetHubHeight { get; set; }
        public decimal ElevatedFoundationHeight { get; set; }
    }
}
