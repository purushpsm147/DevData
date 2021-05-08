using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowersiteVmList : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public Guid? SstUuid { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "ImageName field exceeded maximum length")]
        public string ImageName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "ImageName field exceeded maximum length")]
        public string VmName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "VmStatus field exceeded maximum length")]
        public string VmStatus { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "JobStatus field exceeded maximum length")]
        public string JobStatus { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "VmUsername field exceeded maximum length")]
        public string VmUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(300, ErrorMessage = "VmPassword field exceeded maximum length")]
        public string VmPassword { get; set; }
               
        public JsonDocument Payload { get; set; }
    }
}
