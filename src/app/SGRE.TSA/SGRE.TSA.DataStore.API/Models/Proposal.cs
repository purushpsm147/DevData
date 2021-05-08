using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Proposal : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Project Project { get; set; }
        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string ProposalId { get; set; }

        [Required]
        public bool IsMain { get; set; }

        public Certification Certification { get; set; }
        [Required]
        public int CertificationId { get; set; }

        public Nullable<DateTime> CertificationDate { get; set; }
        public Nullable<DateTime> RecordEndDateTime { get; set; }

        [StringLength(1)]
        public string ActiveRecordIndicator { get; set; }

        public ICollection<ProposalTasks> ProposalTasks { get; set; }
        public ICollection<Quote> Quotes { get; set; }
    }
}
