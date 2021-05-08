using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerExWorksLineItem : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public CostsTowerExWorks CostsTowerExWorks { get; set; }

        [Required]
        public int CostsTowerExWorksId { get; set; }

        public CostsTowerExWorksMeta CostsTowerExWorksMeta { get; set; }

        [Required]
        public int CostsTowerExWorksMetaId { get; set; }

        public Nullable<decimal> Nomination { get; set; }

        public Nullable<decimal> Offer { get; set; }

        public Nullable<decimal> Signature { get; set; }


    }
}
