using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class WtgThreshold
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Minimum Windfarm size in mw to create a configuration
        [Required]
        public decimal WindFarmSize { get; set; }

        // Minimum number of turbines required to create a configuration
        [Required]
        public int TurbineQuantity { get; set; }
    }
}
