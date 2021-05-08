﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowerSections : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public TowerType TowerType { get; set; }
        [Required]
        public int TowerTypeId { get; set; }

        [Required]
        public int SectionNumber { get; set; }

        [StringLength(64, ErrorMessage = "SectionType field exceeded maximum length")]
        public string SectionType { get; set; }

        [Required]
        public decimal SectionHeightM { get; set; }

        [Required]
        public decimal TotalWeightKg { get; set; }

        [Required]
        public decimal ExternalDiameterUpperFlangeM { get; set; }

        [Required]
        public decimal ExternalDiameterLowerFlangeM { get; set; }

    }
}
