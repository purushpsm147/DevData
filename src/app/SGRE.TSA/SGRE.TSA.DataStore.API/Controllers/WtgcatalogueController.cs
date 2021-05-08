using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class WtgcatalogueController : BaseController<WtgCatalogue>
    {
        public WtgcatalogueController(TsaContext context, ILogger<WtgcatalogueController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<WtgCatalogue> DbSet => db.WtgCatalogues.OrderBy(t => t.Id);

        public override bool CanAdd(WtgCatalogue model) => false;

        public override bool CanUpdate(int id, WtgCatalogue model) => false;
    }
}
