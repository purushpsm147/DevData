using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{    
    public class TowersiteMasses : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [Required]
        public int SectionNr { get; set; }

        [Required]
        public decimal LengthMm { get; set; }
        
        public decimal MassKg { get; set; }

        [Required]
        public decimal LcogMm { get; set; }

        [Required]
        public decimal RaKg { get; set; }

        [Required]
        public decimal RbKg { get; set; }
    }
}
