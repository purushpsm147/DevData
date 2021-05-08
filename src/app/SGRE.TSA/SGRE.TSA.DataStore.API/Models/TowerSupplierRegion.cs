using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowerSupplierRegion : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Region Region { get; set; }
        public int RegionId { get; set; }

        public string RegionName { get; set; }

        public InterfaceTools InterfaceTools { get; set; }
        public int InterfaceToolsId { get; set; }

        public ICollection<TowerSupplierSource> TowerSupplierSource { get; set; }
    }
}
