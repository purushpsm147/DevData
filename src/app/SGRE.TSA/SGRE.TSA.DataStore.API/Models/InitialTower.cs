using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Models
{
    public class InitialTower : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public WtgCatalogue WtgCatalogue { get; set; }
        [Required]
        public int WtgCatalogueId { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "Tower is Required")]
        public string Tower { get; set; }

        public string Model { get; set; }

        [Required]
        public decimal HubHeightMinM { get; set; }

        [Required]
        public decimal HubHeightMaxM { get; set; }

    }
}
