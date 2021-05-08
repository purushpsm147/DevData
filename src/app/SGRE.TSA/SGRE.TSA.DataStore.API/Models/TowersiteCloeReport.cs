using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    [Table("towersite_cloe_report")]
    public class TowersiteCloeReport : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [Required]
        public int LifetimeYears { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "RnaStatus exceeded maximum character length")]
        public string RnaStatus { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "RnaStatusSimplified exceeded maximum character length")]
        public string RnaStatusSimplified { get; set; }

        public string WarningMessage { get; set; }

        [Required]
        public decimal RnaLoadMargin { get; set; }
    }
}
