using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowersiteListTower : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "Platform is Required")]
        public string Platform { get; set; }

        [StringLength(32, ErrorMessage = "Tower is Required")]
        public string Tower { get; set; }

        [StringLength(32, ErrorMessage = "Wtgmachine is Required")]
        public string Wtgmachine { get; set; }

        [StringLength(64, ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [StringLength(32, ErrorMessage = "Gpcode is Required")]
        public string Gpcode { get; set; }

        public decimal? HubheightM { get; set; }

        [StringLength(64, ErrorMessage = "Technology is Required")]
        public string Technology { get; set; }

        public decimal? TotaltowerweightKg { get; set; }

        public decimal? HubheightminM { get; set; }

        public decimal? HubheightmaxM { get; set; }

        public decimal? DefaulthubheightM { get; set; }

        public int? Defaultmaxsectionnumber { get; set; }

        public decimal? DefaultmaxsectiondiameterM { get; set; }

        public decimal? DefaultmaxsectionlengthM { get; set; }

        public decimal? DefaultmaxsectionweightKg { get; set; }

    }
}
