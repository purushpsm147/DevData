using SGRE.TSA.DataStore.API.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class ConstructionConstraint: Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Foreign key to ProjectConstraints
        public ProjectConstraint ProjectConstraint { get; set; }
        [Required]
        public int ProjectConstraintId { get; set; }

        [Required]
        public ConstructionRestrictions Status { get; set; }

        [Required]
        public decimal CraneLiftingHeighMtrs { get; set; }

        [Required]
        public decimal CraneLiftingWeightTon { get; set; }

        public string AdditionalRequirements { get; set; }
    }
}
