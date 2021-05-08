using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostsTowerSupplierMetaController : BaseController<CostsTowerSupplierMeta>
    {
        public CostsTowerSupplierMetaController(TsaContext context, ILogger<CostsTowerSupplierMetaController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<CostsTowerSupplierMeta> DbSet => db.CostsTowerSupplierMeta.OrderBy( s=> s.Id);

        public override bool CanAdd(CostsTowerSupplierMeta model) => false;

        public override bool CanUpdate(int id, CostsTowerSupplierMeta model) => false;

    }
}
