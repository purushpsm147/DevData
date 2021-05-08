using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Models
{
    public class NoiseMode : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Noise Mode is Required", MinimumLength = 1)]
        public string NoiseModeNo { get; set; }

        [Required]
        public decimal NoiseLevelDecibels { get; set; }

        [Required]
        public decimal NoiseModeDescription { get; set; }       

        public TowerType TowerType { get; set; }
        [Required]
        public int TowerTypeId { get; set; }
    }
}
