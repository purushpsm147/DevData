using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Models
{
    public class BaseTowerDesignDimension : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public BaseTower BaseTower { get; set; }

        public int BaseTowerId { get; set; }

        [Required]
        public decimal ConcretePedestal { get; set; }

        [Required]
        public decimal GroutHeight { get; set; }

        [Required]
        public decimal UpperTemplate { get; set; }

        [Required]
        public decimal TotalFoundationHeight { get; set; }

        [Required]
        public decimal GroundLevel { get; set; }

        [Required]
        public decimal? TowerWeight { get; set; }

        [Required]
        public decimal TowerHeight { get; set; }

        [Required]
        public decimal TowerNacelleDistance { get; set; }


        public decimal FoundationHeight { get; set; }

        [Required]
        public decimal TowerHubHeight { get; set; }
    }
}
