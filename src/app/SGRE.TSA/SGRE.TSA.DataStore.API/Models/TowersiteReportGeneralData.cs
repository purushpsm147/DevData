using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{    
    public class TowersiteReportGeneralData : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "InitialTower exceeded maximum length")]
        public string InitialTower { get; set; }

        [Required]
        public decimal BottomExtremeLoadsKnm { get; set; }

        [Required]
        public decimal BottomFatigueLoadsKnm { get; set; }

        [Required]
        public decimal BottomExtremeLoadsVsNominalPercentage { get; set; }

        [Required]
        public decimal BottomFatigueLoadsVsNominalPercentage { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Region exceeded maximum length")]
        public string Region { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "NominalTower exceeded maximum length")]
        public string NominalTower { get; set; }

    }
}
