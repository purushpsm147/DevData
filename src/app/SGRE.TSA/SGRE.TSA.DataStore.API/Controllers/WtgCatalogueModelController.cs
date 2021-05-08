using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class WtgCatalogueModelController : BaseController<WtgCatalogueModel>
    {
        public WtgCatalogueModelController(TsaContext context, ILogger<WtgCatalogueModelController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<WtgCatalogueModel> DbSet => db.WtgCatalogueModels.OrderBy(t => t.Id);

        public override bool CanAdd(WtgCatalogueModel model) => false;

        public override bool CanUpdate(int id, WtgCatalogueModel model) => false;
    }
}
