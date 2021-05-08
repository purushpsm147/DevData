using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    [Table("towersite_viv_windspeed")]
    public class TowersiteVivWindspeed : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Guid SstUuid { get; set; }
        [Required]
        public int StageNr { get; set; }
        [Required]
        [StringLength(128, ErrorMessage = "StageDescription exceeded maximum character length")]
        public string StageDescription { get; set; }
        [Column("crit10min_tmean_wind_m_s")]
        [StringLength(16, ErrorMessage = "Critical10minTmeanWindMs exceeded maximum character length")]
        public string Critical10minTmeanWindMs { get; set; }
        [Column("maxallowed10min_mean_wind_m_s")]
        [StringLength(16, ErrorMessage = "Maxallowed10minMeanWindMs exceeded maximum character length")]
        public string Maxallowed10minMeanWindMs { get; set; }
        [StringLength(255, ErrorMessage = "PreventiveMeasure exceeded maximum character length")]
        public string PreventiveMeasure { get; set; }
        [StringLength(64, ErrorMessage = "MaxallowedVivDuration exceeded maximum character length")]
        public string MaxallowedVivDuration { get; set; }
    }
}
