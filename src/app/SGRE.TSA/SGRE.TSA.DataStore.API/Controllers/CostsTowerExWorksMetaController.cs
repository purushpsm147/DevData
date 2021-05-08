using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerExWorksMetaController : BaseController<CostsTowerExWorksMeta>
    {
        public CostsTowerExWorksMetaController(TsaContext context, ILogger<CostsTowerExWorksMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerExWorksMeta> DbSet => db.CostsTowerExWorksMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerExWorksMeta model) => false;

        public override bool CanUpdate(int id, CostsTowerExWorksMeta model) => false;

    }
}
