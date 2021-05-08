using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SwatLoad : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "SarCode is Required")]
        public string SarCode { get; set; }

        [Required]
        public decimal SiteLatitude { get; set; }

        [Required]
        public decimal SiteLongitude { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "SarCode is Required")]
        public string ConfigurationId { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "LoadClusterId is Required")]
        public string LoadClusterId { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "CloeTowerId is Required")]
        public string CloeTowerId { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "TurbineTypeLoadsConfig is Required")]
        public string TurbineTypeLoadsConfig { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "TurbineTypeSmkMain is Required")]
        public string TurbineTypeSmkMain { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "TurbineTypeSmkVariant is Required")]
        public string TurbineTypeSmkVariant { get; set; }

        [Required]
        public int TurbineQuantity { get; set; }       

        [Required]
        public decimal TowerHubHeightM { get; set; }

        [Required]
        public decimal LoadsetHubHeightM { get; set; }

        [Required]
        public decimal PedestalHeightM { get; set; }

        [Required]
        public decimal[] AepStepsInM { get; set; }

        [Required]
        public decimal[] AepGrossInPercent { get; set; }

        [Required]
        public decimal[] AepGrossInGwh { get; set; }

        public decimal[] AepNetInPercent { get; set; }

        public decimal[] AepNetInGwh { get; set; }

        [Required]
        public bool Acs2xEnabled { get; set; }

        [Required]
        public int[] ApplicationModes { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "TowerTypeSwat is Required")]
        public string TowerTypeSwat { get; set; }

        [Required]
        public decimal RnaLifetime { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "RnaSuitability is Required")]
        public string RnaSuitability { get; set; }

        [Required]
        public decimal TowerLoadsMargin { get; set; }

        [Required]
        public decimal RnaLoadsMargin { get; set; }

        [Required]
        public decimal AvgShear { get; set; }

        [Required]
        public decimal MaxShear { get; set; }

        [Required]
        public decimal ElsaFilesize { get; set; }

        [Required]
        public decimal SafalFilesize { get; set; }

        [Required]
        public JsonDocument JsonPayload { get; set; }

        [Required]
        public string ElsaFileName { get; set; }

        [Required]
        public string LinkToElsaFile { get; set; }

        [Required]
        public string SafalFileName { get; set; }

        [Required]
        public string LinkToSafalFile { get; set; }
    }
}
