using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class QuoteLine : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Quote Quote { get; set; }
        [Required]
        public int QuoteId { get; set; }

        public WtgCatalogue WtgCatalogue { get; set; }
        public int WtgCatalogueId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public bool WindfarmSizeTrigger { get; set; }

        public bool QuantityTrigger { get; set; }

        public decimal WindfarmSize { get; set; }
       
    }
}
