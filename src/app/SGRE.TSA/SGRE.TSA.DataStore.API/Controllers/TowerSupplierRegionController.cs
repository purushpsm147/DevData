using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class TowerSupplierRegionController : BaseController<TowerSupplierRegion>
    {
        public TowerSupplierRegionController(TsaContext context, ILogger<TowerSupplierRegionController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<TowerSupplierRegion> DbSet => db.TowerSupplierRegions.OrderBy(s => s.Id);

        public override bool CanAdd(TowerSupplierRegion model) => false;


        public override bool CanUpdate(int id, TowerSupplierRegion model) => false;

    }
}