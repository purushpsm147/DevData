using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerCustomsController : BaseController<CostsTowerCustoms>
    {
        public CostsTowerCustomsController(TsaContext context, ILogger<CostsTowerCustomsController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerCustoms> DbSet => db.CostsTowerCustoms.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerCustoms model) => true;

        public override bool CanUpdate(int id, CostsTowerCustoms model) => true;

    }
}
