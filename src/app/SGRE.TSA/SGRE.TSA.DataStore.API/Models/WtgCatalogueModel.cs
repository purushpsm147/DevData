using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class WtgCatalogueModel : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public WtgCatalogue WtgCatalogue { get; set; }

        [Required]
        public int WtgCatalogueId { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "Towermodel is Required")]
        public string Model { get; set; }

    }
}
