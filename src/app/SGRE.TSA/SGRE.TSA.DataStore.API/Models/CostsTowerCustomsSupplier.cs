using SGRE.TSA.DataStore.API.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerCustomsSupplier : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public CostsTowerCustoms CostsTowerCustoms { get; set; }

        [Required]
        public int CostsTowerCustomsId { get; set; }

        public string Comments { get; set; }

        public ICollection<CostsTowerCustomsLineItem> CostsTowerCustomsLineItems { get; set; }

    }
}
