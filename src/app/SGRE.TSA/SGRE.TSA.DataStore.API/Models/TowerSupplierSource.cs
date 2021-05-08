using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class TowerSupplierSource : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public TowerSupplierRegion TowerSupplierRegion { get; set; }
        public int TowerSupplierRegionId { get; set; }

        public string SourcingName { get; set; }

    }
}
