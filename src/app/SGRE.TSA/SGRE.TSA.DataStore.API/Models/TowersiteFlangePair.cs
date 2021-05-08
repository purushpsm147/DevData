using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowersiteFlangePair : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        [Required]
        public int FlangePairNrTopToBottom { get; set; }

        [Required]
        public int FlangePairNrBottomToTop { get; set; }

        [Column("z_mm")]
        public decimal? Z { get; set; }

        [Column("tf_mm")]
        public decimal? Tf { get; set; }

        [Column("wf_mm")]
        public decimal? Wf { get; set; }

        [Column("nh_mm")]
        public decimal? Nh { get; set; }

        [Column("ts_upper_mm")]
        public decimal? TsUpper { get; set; }

        [Column("ts_lower_mm")]
        public decimal? TsLower { get; set; }

        [Column("rc_mm")]
        public decimal? Rc { get; set; }

        [Column("dso_mm")]
        public decimal? Dso { get; set; }

        [Column("db_mm")]
        public decimal? Db { get; set; }

        [Column("lb_mm")]
        public decimal? Lb { get; set; }

        public decimal? Nb { get; set; }

        [Column("dcb_mm")]
        public decimal? Dcb { get; set; }

        [Column("dh_mm")]
        public decimal? Dh { get; set; }

        [Column("lbe_mm")]
        public decimal? Lbe { get; set; }

        [Column("dbeo_mm")]
        public decimal? Dbeo { get; set; }

        [Column("dbei_mm")]
        public decimal? Dbei { get; set; }

        [Column("mass_kg")]
        public decimal? Mass { get; set; }

        [Column("totalmass_kg")]
        public decimal? Totalmass { get; set; }

        public decimal? Price { get; set; }

        [StringLength(16, ErrorMessage = "PriceCurrency exceeded length")]
        public string PriceCurrency { get; set; }

        public decimal? FlangeType { get; set; }

        public decimal? TfType { get; set; }

        [Column("dbco_mm")]
        public decimal? Dbco { get; set; }

        [Column("dfo_mm")]
        public decimal? Dfo { get; set; }

        [Column("fb_pt_nom_kn")]
        public decimal? FbPtNom { get; set; }

        [Column("tfa_mm")]
        public decimal? Tfa { get; set; }

        [Column("wfa_mm")]
        public decimal? Wfa { get; set; }

        [Column("tbp_mm")]
        public decimal? Tbp { get; set; }

        [Column("wbp_mm")]
        public decimal? Wbp { get; set; }        
    }
}
