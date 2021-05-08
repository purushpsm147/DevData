using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Models
{
    [Table("towersite_plates_tower_summary")]
    public class TowersitePlatesTowerSummary : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        public decimal? DGrandTotal { get; set; }

        public decimal? SurfGrandTotal { get; set; }

        public decimal? NwghtGrandTotal { get; set; }

        public decimal? GwghtGrandTotal { get; set; }
    }
}
