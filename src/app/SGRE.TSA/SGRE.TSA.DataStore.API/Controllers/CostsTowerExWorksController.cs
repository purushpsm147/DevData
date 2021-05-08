using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerExWorksController : BaseController<CostsTowerExWorks>
    {
        public CostsTowerExWorksController(TsaContext context, ILogger<CostsTowerExWorksController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerExWorks> DbSet => db.CostsTowerExWorks.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerExWorks model) => true;

        public override bool CanUpdate(int id, CostsTowerExWorks model) => true;

    }
}
