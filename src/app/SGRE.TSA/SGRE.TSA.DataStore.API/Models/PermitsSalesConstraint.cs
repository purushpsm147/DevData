﻿using SGRE.TSA.DataStore.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class PermitsSalesConstraint : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign key to ProjectConstraints
        public ProjectConstraint ProjectConstraints { get; set; }

        [Required]
        public int ProjectConstraintId { get; set; }

        // Building permit
        [Required]
        public BuildingPermits BuildingPermits { get; set; }

        // Permit Max Tip Height ( m )
        [Required]
        public decimal MaxTipHeightMtrs { get; set; }
        public MaturityOptions MaxTipHeightStatus { get; set; }

        // Permit Max Hub Hegith ( m )
        [Required]
        public decimal MaxHubHeightMtrs { get; set; }
        public MaturityOptions MaxHubHeightStatus { get; set; }

        // Permit Max Ground clearance ( m )
        [Required]
        public decimal MaxGroundClearanceMtrs { get; set; }
        public MaturityOptions MaxGroundClearanceStatus { get; set; }

        // Permit Elevation Foundation status
        [Required]
        public bool ElevationFoundationStatus { get; set; }

        // Permit Max Elevation Allowed
        public decimal? MaxElevationFoundationMtrs { get; set; }
    }
}
