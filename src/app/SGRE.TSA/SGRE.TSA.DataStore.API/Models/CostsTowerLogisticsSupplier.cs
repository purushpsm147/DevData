using SGRE.TSA.DataStore.API.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerLogisticsSupplier : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public CostsTowerLogistics CostsTowerLogistics { get; set; }

        [Required]
        public int CostsTowerLogisticsId { get; set; }

        public ICollection<CostsTowerLogisticsLeadTimeLineitem> CostsTowerLogisticsLeadTimeLineitems { get; set; }
        public ICollection<CostsTowerLogisticsLineItem> CostsTowerLogisticsLineItems { get; set; }

    }
}
