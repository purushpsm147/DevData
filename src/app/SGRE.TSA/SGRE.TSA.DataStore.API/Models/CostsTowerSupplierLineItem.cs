using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostsTowerSupplierLineItem : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Suppliers Suppliers { get; set; }

        [Required]
        public int SuppliersId { get; set; }

        public CostsTowerSupplierMeta CostsTowerSupplierMeta { get; set; }

        [Required]
        public int CostsTowerSupplierMetaId { get; set; }

        public string Nomination { get; set; }

        public string Offer { get; set; }

        public string Signature { get; set; }

    }
}
