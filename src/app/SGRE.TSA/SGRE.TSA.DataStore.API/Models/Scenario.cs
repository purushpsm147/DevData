using SGRE.TSA.DataStore.API.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Scenario : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Quote Quote { get; set; }

        [Required]
        public int QuoteId { get; set; }

        [Required]
        public string WindfarmConfigurationId { get; set; }

        [Required]
        public int ScenarioNo { get; set; }

        [Required]
        public ScenarioTypes ScenarioType { get; set; }        

        [Required]
        public int ItemId { get; set; }

        [Required]
        public ScenarioStatus Status { get; set; }

        [Required]
        public ScenarioProgress Progress { get; set; }       

        [Required]
        public ScenarioOptions Options { get; set; }

        [Required]
        public bool StepProgress { get; set; }

        public ICollection<ScenarioDesign> ScenarioDesigns { get; set; }
        public ICollection<ScenarioCostsKpi> ScenarioCostsKpis { get; set; }
    }
}