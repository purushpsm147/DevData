using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerCustomsLineItem : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public CostsTowerCustomsSupplier CostsTowerCustomsSupplier { get; set; }

        [Required]
        public int CostsTowerCustomsSupplierId { get; set; }

        public CostsTowerCustomsMeta CostsTowerCustomsMeta { get; set; }

        [Required]
        public int CostsTowerCustomsMetaId { get; set; }

        public Nullable<decimal> Nomination { get; set; }

        public Nullable<decimal> Offer { get; set; }

        public Nullable<decimal> Signature { get; set; }

    }
}
