using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class ProjectConstraint : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Foreign key to Project
        public Project Project { get; set; }
        [Required]
        public int ProjectId { get; set; }
        public PermitsSalesConstraint PermitsSalesConstraint { get; set; }
        public LogisticConstraint LogisticConstraint { get; set; }
        public ConstructionConstraint ConstructionConstraint { get; set; }
        public SpecialRequirementsSalesConstraint SpecialRequirementsSalesConstraint { get; set; }
    }
}