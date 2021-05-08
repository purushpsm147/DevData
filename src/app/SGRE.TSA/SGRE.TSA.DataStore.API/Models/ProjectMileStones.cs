using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class ProjectMileStones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Project Project { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public MileStone MileStone { get; set; }
        [Required]
        public int MileStoneId { get; set; }

        [Required]
        public DateTime MileStoneDate { get; set; }

        public string MileStoneOfferStatus { get; set; }

    }
}
