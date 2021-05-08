using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SstPredesignDimesions : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public SstTower SstTower { get; set; }
        [Required]
        public int SstTowerId { get; set; }

        [Required]
        public decimal MaxTowerBaseDiameter { get; set; }

        [Required]
        public decimal MaxSectionWeight { get; set; }

        [Required]
        public decimal MaxSectionLength { get; set; }

        [Required]
        public decimal GroundLevel { get; set; }

        [Required]
        public decimal ConcretePedestal { get; set; }

        [Required]
        public decimal GroutHeight { get; set; }

        [Required]
        public decimal UpperTemplate { get; set; }

        [Required]
        public decimal TotalFoundationHeight { get; set; }

        [Required]
        public decimal TowerNacelleDistance { get; set; }

        [Required]
        public decimal TowerFoundationHeight { get; set; }

        [Required]
        public decimal TowerHeight { get; set; }
    }
}
