using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Models
{
    public class LoadsCluster : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(1, ErrorMessage = "ClusterName is Required")]
        public string ClusterName { get; set; }
    }
}
