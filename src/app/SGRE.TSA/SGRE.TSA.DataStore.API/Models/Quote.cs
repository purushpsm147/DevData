using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Quote : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Proposal Proposal { get; set; }
        [Required]
        public int ProposalId { get; set; }

        [Required]
        public string QuotationId { get; set; }

        public string QuotationName { get; set; }

        [Required]
        public bool QuotationType { get; set; }

        [Required]
        public string OfferType { get; set; }

        public string QuoteStatus { get; set; }

        public DateTimeOffset? OfferSubmissionDate { get; set; }

        public string SarCode { get; set; }

        public ICollection<QuoteLine> QuoteLines { get; set; }
    }
}
