using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerLogisticsMetaController : BaseController<CostsTowerLogisticsMeta>
    {
        public CostsTowerLogisticsMetaController(TsaContext context, ILogger<CostsTowerLogisticsMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerLogisticsMeta> DbSet => db.CostsTowerLogisticsMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerLogisticsMeta model) => false;

        public override bool CanUpdate(int id, CostsTowerLogisticsMeta model) => false;

    }
}
