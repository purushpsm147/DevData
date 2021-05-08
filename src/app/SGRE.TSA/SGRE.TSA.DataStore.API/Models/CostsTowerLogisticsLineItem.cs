using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerLogisticsLineItem : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public CostsTowerLogisticsMeta CostsTowerLogisticsMeta { get; set; }

        [Required]
        public int CostsTowerLogisticsMetaId { get; set; }

        public CostsTowerLogisticsSupplier CostsTowerLogisticsSupplier { get; set; }

        [Required]
        public int CostsTowerLogisticsSupplierId { get; set; }

        public Nullable<decimal> Nomination { get; set; }

        public Nullable<decimal> Offer { get; set; }

        public Nullable<decimal> Signature { get; set; }

    }
}
