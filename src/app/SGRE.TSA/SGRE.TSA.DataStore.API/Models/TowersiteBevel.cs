using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    [Table("towersite_bevel")]
    public class TowersiteBevel : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [Required]
        public int SectionNr { get; set; }

        [StringLength(64, ErrorMessage = "SectionType field exceeded maximum length")]
        public string SectionType { get; set; }

        [StringLength(64, ErrorMessage = "Pos field exceeded maximum length")]
        public string Pos { get; set; }

        public decimal? T { get; set; }

        [StringLength(64, ErrorMessage = "mat field exceeded maximum length")]
        public string Mat { get; set; }

        [Column("b1_detail")]
        [StringLength(64, ErrorMessage = "b1_detail field exceeded maximum length")]
        public string B1Detail { get; set; }

        [Column("b1_a")]
        public decimal? B1a { get; set; }

        [Column("b1_r")]
        public decimal? B1r { get; set; }

        [Column("b1_di")]
        public decimal? B1Di { get; set; }

        [Column("b1_de")]
        public decimal? B1De { get; set; }

        [Column("b2_detail")]
        [StringLength(16, ErrorMessage = "b2_detail field exceeded maximum length")]
        public string B2Detail { get; set; }

        [Column("b2_a")]
        public decimal? B2a { get; set; }

        [Column("b2_r")]
        public decimal? B2r { get; set; }

        [Column("b2_di")]
        public decimal? B2Di { get; set; }

        [Column("b2_de")]
        public decimal? B2De { get; set; }

        [Column("b3_detail")]
        [StringLength(16, ErrorMessage = "b3_detail field exceeded maximum length")]
        public string B3Detail { get; set; }

        [Column("b3_a")]
        public decimal? B3a { get; set; }

        [Column("b3_r")]
        public decimal? B3r { get; set; }

        [Column("b3_di")]
        public decimal? B3Di { get; set; }

        [Column("b3_de")]
        public decimal? B3De { get; set; }

    }
}
