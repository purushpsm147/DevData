using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Certification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CertificationName { get; set; }
        public ICollection<CertificationCost> CertificationCost { get; set; }
    }
}
