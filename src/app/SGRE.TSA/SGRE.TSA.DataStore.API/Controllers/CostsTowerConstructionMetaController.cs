using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerConstructionMetaController: BaseController<CostsTowerConstructionMeta>
    {
        public CostsTowerConstructionMetaController(TsaContext context, ILogger<CostsTowerConstructionMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerConstructionMeta> DbSet => db.CostsTowerConstructionMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerConstructionMeta model) => false;

        public override bool CanUpdate(int id, CostsTowerConstructionMeta model) => false;

    }
}
