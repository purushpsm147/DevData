using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerSupplierController : BaseController<CostsTowerSupplier>
    {
        public CostsTowerSupplierController(TsaContext context, ILogger<CostsTowerSupplierController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerSupplier> DbSet => db.CostsTowerSupplier.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerSupplier model) => true;

        public override bool CanUpdate(int id, CostsTowerSupplier model) => true;

    }
}
