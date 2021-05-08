using SGRE.TSA.DataStore.API.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerSupplier : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public CostFeedback CostFeedback { get; set; }

        [Required]
        public int CostFeedbackId { get; set; }

        [Required]
        public ScenarioProgress ScenarioProgress { get; set; }

        public bool IsPhaseComplete { get; set; }

        public ICollection<Suppliers> Suppliers { get; set; }
    }
}
