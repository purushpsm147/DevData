using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerCustomsMetaController : BaseController<CostsTowerCustomsMeta>
    {
        public CostsTowerCustomsMetaController(TsaContext context, ILogger<CostsTowerCustomsMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerCustomsMeta> DbSet => db.CostsTowerCustomsMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerCustomsMeta model) => false;

        public override bool CanUpdate(int id, CostsTowerCustomsMeta model) => false;

    }
}
