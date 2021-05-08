using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class ScenarioDesign : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public Scenario Scenario { get; set; }
        [Required]
        public int ScenarioId { get; set; }
        
        public string Risks { get; set; }
        public bool DesignEvaluation { get; set; }
    }
}