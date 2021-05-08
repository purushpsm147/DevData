using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerLogisticsLeadTimeLineitem : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public CostsTowerLogisticsSupplier CostsTowerLogisticsSuppliers { get; set; }

        [Required]
        public int CostsTowerLogisticsSuppliersId { get; set; }

        public CostsTowerLogisticsLeadTimeMeta CostsTowerLogisticsLeadTimeMeta { get; set; }

        [Required]
        public int CostsTowerLogisticsLeadTimeMetaId { get; set; }

        public Nullable<decimal> Nomination { get; set; }

        public Nullable<decimal> Offer { get; set; }

        public Nullable<decimal> Signature { get; set; }
    }
}
