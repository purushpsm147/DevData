using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Country Name is Required", MinimumLength = 3)]
        public string CountryName { get; set; }

        public Region Region { get; set; }
        public int RegionId { get; set; }

        public Currency Currency { get; set; }

        public int CurrencyId { get; set; }
    }
}
