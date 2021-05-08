using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class BaseTowerAepHubheight : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public BaseTower BaseTower { get; set; }

        public int BaseTowerId { get; set; }

        public decimal? AepHubHeight { get; set; }

        public decimal? AepNominationGross { get; set; }

        public decimal? AepBindingOfferNet { get; set; }

        public decimal? AepSignatureNet { get; set; }
    }
}
