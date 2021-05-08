using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    [Table("towersite_geo_main")]
    public class TowersiteGeoMain : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [StringLength(64, ErrorMessage = "object_type exceeded maximum character length")]
        public string ObjectType { get; set; }

        public int? ObjectNr { get; set; }

        public int? SectionPartNr { get; set; }

        [Column("h_mm")]
        public decimal? H { get; set; }

        [Column("t_mm")]
        public decimal? T { get; set; }

        [Column("dtop_mm")]
        public decimal? Dtop { get; set; }

        [Column("dbot_mm")]
        public decimal? Dbot { get; set; }

        public decimal? SCFtop { get; set; }

        public int? Matrid { get; set; }
    }
}
