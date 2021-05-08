using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowersiteListRegion : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "RegionName is Required")]
        public string RegionName { get; set; }

        [Required]
        public Decimal Price { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "Unit is Required")]
        public string Units { get; set; }
    }
}
