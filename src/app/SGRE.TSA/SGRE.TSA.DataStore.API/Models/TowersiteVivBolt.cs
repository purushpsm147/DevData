using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowersiteVivBolt : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Guid SstUuid { get; set; }
        [Required]
        [StringLength(64, ErrorMessage = "from_section exceeded maximum character length")]
        public string FromSection { get; set; }
        [Required]
        [StringLength(64, ErrorMessage = "to_section exceeded maximum character length")]
        public string ToSection { get; set; }
        [Required]
        public decimal TightenedBoltsPercentage { get; set; }
    }
}
