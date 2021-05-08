using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class RegionController : BaseController<Region>
    {
        public RegionController(TsaContext context, ILogger<RegionController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Region> DbSet => db.Regions.OrderBy( s=> s.Id);

        public override bool CanAdd(Region model) => false;


        public override bool CanUpdate(int id, Region model) => false;

    }
}
