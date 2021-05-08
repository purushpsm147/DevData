using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class GenericMarketBoundaryController : BaseController<GenericMarketBoundary>
    {
        public GenericMarketBoundaryController(TsaContext context, ILogger<GenericMarketBoundaryController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<GenericMarketBoundary> DbSet => db.GenericMarketBoundaries.OrderBy(s => s.Id);

        public override bool CanAdd(GenericMarketBoundary model) => false;


        public override bool CanUpdate(int id, GenericMarketBoundary model) => false;
    }
}
