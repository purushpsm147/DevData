using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerConstructionLeadTimeMetaController : BaseController<CostsTowerConstructionLeadTimeMeta>
    {
        public CostsTowerConstructionLeadTimeMetaController(TsaContext context, ILogger<CostsTowerConstructionLeadTimeMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerConstructionLeadTimeMeta> DbSet => db.CostsTowerConstructionLeadTimeMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerConstructionLeadTimeMeta model) => false;

        public override bool CanUpdate(int id, CostsTowerConstructionLeadTimeMeta model) => false;

    }
}
