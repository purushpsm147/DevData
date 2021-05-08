using SGRE.TSA.DataStore.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SstDesignSeismicAssessment : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public SstDesignEvaluation SstDesignEvaluation { get; set; }
        [Required]
        public int SstDesignEvaluationId { get; set; }
       
        public SeismicAssessmentStatusTypes SeismicAssessmentStatusTypes { get; set; }
        
        public SeismicAssessmentResultTypes SeismicAssessmentResultTypes { get; set; }

        public bool IsFirstLevelAssessmentRequest { get; set; }

        public string FirstLevelAssessmentDocLink { get; set; }

        public bool IsSecondLevelAssessmentRequest { get; set; }

        public string SecondLevelAssessmentDocLink { get; set; }
    }
}
