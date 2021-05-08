using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class LogisticProjectBoundary: Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Foreign key to LogisticConstraint
        public LogisticConstraint LogisticConstraint { get; set; }
        [Required]
        public int LogisticConstraintId { get; set; }
        // Foreign key to TransportMode
        public TransportMode TransportMode { get; set; }

        [Required]
        public int TransportModeId { get; set; }

        [Required]
        public decimal MaxTowerBaseDiameterMtrs { get; set; }
        [Required]
        public decimal MaxSegmentWeightTon { get; set; }
        [Required]
        public decimal MaxSegmentLengthMtrs { get; set; }

        public string Comments { get; set; }

    }
}
