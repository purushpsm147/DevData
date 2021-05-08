using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SstPredesignProposedHubHeight : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public SstTower SstTower { get; set; }
        [Required]
        public int SstTowerId { get; set; }

        [Required]
        public decimal AepNominationGross { get; set; }

        [Required]
        public decimal AepBindingOfferNet { get; set; }

        [Required]
        public decimal AepSignatureNet { get; set; }

        public bool isAepLookupDone { get; set; }
    }
}
