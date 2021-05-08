using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class ProposalTasks
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign key to Proposal
        public Proposal Proposal { get; set; }
        [Required]
        public int ProposalId { get; set; }

        // Foreign key to Task
        public Task Task { get; set; }
        [Required]
        public int TaskId { get; set; }
        [Required]
        public bool IsCustomer { get; set; }
    }
}
