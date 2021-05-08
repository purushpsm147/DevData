using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Models
{
    public class PresetRoles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Region Region { get; set; }

        [Required]
        public int RegionId { get; set; }

        public Role Role { get; set; }

        [Required]
        public int RoleId { get; set; }

        public string UserName { get; set; }
    }
}
