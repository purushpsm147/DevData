using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class RnaCost : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Currency Currency { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        public WtgCatalogue WtgCatalogue { get; set; }

        [Required]
        public int WtgCatalogueId { get; set; }

        [Required]
        public decimal CostKilo { get; set; }
    }
}
