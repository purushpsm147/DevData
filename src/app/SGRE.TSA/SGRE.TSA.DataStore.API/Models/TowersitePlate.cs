using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowersitePlate : Audit
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

        public decimal? A { get; set; }
        public decimal? B { get; set; }
        public decimal? C { get; set; }
        public decimal? D { get; set; }
        public decimal? Surf { get; set; }
        public decimal? E { get; set; }
        public decimal? F { get; set; }
        public decimal? G { get; set; }
        public decimal? H { get; set; }
        public decimal? I { get; set; }
        public decimal? J { get; set; }
        public decimal? K { get; set; }
        public decimal? L { get; set; }
        public decimal? M { get; set; }
        public decimal? Nwght { get; set; }
        public decimal? N { get; set; }
        public decimal? O { get; set; }
        public decimal? Gwght { get; set; }

        [StringLength(64, ErrorMessage = "mat field exceeded maximum length")]
        public string Mat { get; set; }
    }
}