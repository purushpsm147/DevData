using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerLogisticsLeadTimeMetaController : BaseController<CostsTowerLogisticsLeadTimeMeta>
    {
        public CostsTowerLogisticsLeadTimeMetaController(TsaContext context, ILogger<CostsTowerLogisticsLeadTimeMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerLogisticsLeadTimeMeta> DbSet => db.CostsTowerLogisticsLeadTimeMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerLogisticsLeadTimeMeta model) => false;

        public override bool CanUpdate(int id, CostsTowerLogisticsLeadTimeMeta model) => false;

    }
}
