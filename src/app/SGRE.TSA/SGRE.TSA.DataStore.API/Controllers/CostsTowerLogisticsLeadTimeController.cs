using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerLogisticsLeadTimeController : BaseController<CostsTowerLogisticsLeadTimeLineitem>
    {
        public CostsTowerLogisticsLeadTimeController(TsaContext context, ILogger<CostsTowerLogisticsLeadTimeController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerLogisticsLeadTimeLineitem> DbSet => db.CostsTowerLogisticsLeadTime.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerLogisticsLeadTimeLineitem model) => true;

        public override bool CanUpdate(int id, CostsTowerLogisticsLeadTimeLineitem model) => true;

    }
}
