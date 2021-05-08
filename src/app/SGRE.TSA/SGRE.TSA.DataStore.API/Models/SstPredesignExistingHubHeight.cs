﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SstPredesignExistingHubHeight : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public SstTower SstTower { get; set; }

        [Required]
        public int SstTowerId { get; set; }

        public decimal? AepNominationGross { get; set; }

        public decimal? AepBindingOfferNet { get; set; }

        public decimal? AepSignatureNet { get; set; }
        

    }
}
