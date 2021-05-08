using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerConstructionController: BaseController<CostsTowerConstruction>
    {
        public CostsTowerConstructionController(TsaContext context, ILogger<CostsTowerConstructionController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerConstruction> DbSet => db.CostsTowerConstruction.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerConstruction model) => true;

        public override bool CanUpdate(int id, CostsTowerConstruction model) => true;

    }
}
