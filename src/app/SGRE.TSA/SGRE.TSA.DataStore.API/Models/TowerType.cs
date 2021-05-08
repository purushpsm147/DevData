using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowerType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "Tower is Required")]
        public string Tower { get; set; }

        public WtgCatalogue WtgCatalogue { get; set; }
        [Required]
        public int WtgCatalogueId { get; set; }

        public decimal HubHeightM { get; set; }

        public ICollection<NoiseMode> NoiseModes { get; set; }

        public ICollection<TowerSections> TowerSections { get; set; }
    }
}
