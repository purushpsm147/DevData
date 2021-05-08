using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostOverViewMetaController : BaseController<CostOverViewMeta>
    {
        public CostOverViewMetaController(TsaContext context, ILogger<CostOverViewMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostOverViewMeta> DbSet => db.CostOverViewMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostOverViewMeta model) => false;

        public override bool CanUpdate(int id, CostOverViewMeta model) => false;

    }
}
