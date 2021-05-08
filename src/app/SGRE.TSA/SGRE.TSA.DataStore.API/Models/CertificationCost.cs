using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CertificationCost : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Currency Currency { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        public Certification Certification { get; set; }

        [Required]
        public int CertificationId { get; set; }

        [Required]
        public decimal CostKilo { get; set; }
    }
}
