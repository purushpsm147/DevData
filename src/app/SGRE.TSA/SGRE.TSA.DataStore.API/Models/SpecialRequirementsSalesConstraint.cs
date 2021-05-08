using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SpecialRequirementsSalesConstraint : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign key to ProjectConstraints
        public ProjectConstraint ProjectConstraint { get; set; }
        [Required]
        public int ProjectConstraintId { get; set; }

        // Requirements - Sesimic
        [Required]
        public bool SesimicRequirements { get; set; }

        // Requirements - Sesimic country code
        public string SesimicRequirementsCountryCode { get; set; }

        // Requirements - Nearshore
        [Required]
        public bool Nearshore { get; set; }

        // Requirements - Extreme Wind Condition        
        [Required]
        public string[] ExtremeWindConditions { get; set; }

        public string ExtremeWindConditionsOtherDescription { get; set; }

        // Requirements - Limit Supplier selection       
        [Required]
        public string[] ProjReqLimitSupplierSelection { get; set; }

        // Requirements - Supplier        
        public string SupplierRequirements { get; set; }

        // Requirements - Additional
        public string AdditionalRequirements { get; set; }
    }
}
