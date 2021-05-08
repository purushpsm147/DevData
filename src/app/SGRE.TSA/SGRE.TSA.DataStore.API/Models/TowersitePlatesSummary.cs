using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    [Table("towersite_plates_summary")]
    public class TowersitePlatesSummary : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [Required]
        public int SectionNr { get; set; }

        [StringLength(64, ErrorMessage = "SectionType field exceeded maximum length")]
        public string SectionType { get; set; }

        public decimal? DTotal { get; set; }

        public decimal? SurfTotal { get; set; }

        public decimal? NwghtTotal { get; set; }

        public decimal? GwghtTotal { get; set; }        

    }
}
