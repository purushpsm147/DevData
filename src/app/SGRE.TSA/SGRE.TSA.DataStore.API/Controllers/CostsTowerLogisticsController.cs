using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerLogisticsController : BaseController<CostsTowerLogistics>
    {
        public CostsTowerLogisticsController(TsaContext context, ILogger<CostsTowerLogisticsController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerLogistics> DbSet => db.CostsTowerLogistics.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerLogistics model) => true;

        public override bool CanUpdate(int id, CostsTowerLogistics model) => true;

    }
}
