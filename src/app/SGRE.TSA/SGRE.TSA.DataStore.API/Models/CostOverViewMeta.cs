using SGRE.TSA.DataStore.API.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class CostOverViewMeta : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string SubSectionName { get; set; }

        public string LineItemSource { get; set; }

        [Required]
        public TypeOfTower TypeOfTower { get; set; }
        public bool IsMandatory { get; set; }

    }
}
