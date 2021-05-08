using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class MileStone : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "MileStone Name is Required", MinimumLength = 3)]
        public string MileStoneName { get; set; }
    }
}
