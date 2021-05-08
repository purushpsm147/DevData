using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class LogisticConstraint : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public ProjectConstraint ProjectConstraint { get; set; }
        [Required]
        public int ProjectConstraintId { get; set; }
        
        public LogisticStatus LogisticStatus { get; set; }

        [Required]
        public int LogisticStatusId { get; set; }
        public string PreliminaryLogisticsDocumentLink { get; set; }
        public string RoadSurveyDocumentLink { get; set; }
        
        public bool UsingProjectSpecificBoundary { get; set; }

        public TransportMode TransportMode { get; set; }
        [Required]
        public int TransportModeId { get; set; }

        public ICollection<LogisticProjectBoundary> logisticProjectBoundaries { get; set; }
    }
}
