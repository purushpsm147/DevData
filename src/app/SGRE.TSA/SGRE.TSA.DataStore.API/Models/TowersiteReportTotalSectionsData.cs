using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowersiteReportTotalSectionsData : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [Required]
        public decimal LengthM { get; set; }

        [Required]
        public decimal LengthNominalPercentage { get; set; }

        [Required]
        public decimal WeightKg { get; set; }

        [Required]
        public decimal weightNominalPercentage { get; set; }
        
    }
}
