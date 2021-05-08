using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;


namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class WtgThresholdController : BaseController<WtgThreshold>
    {
        public WtgThresholdController(TsaContext context, ILogger<WtgThresholdController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<WtgThreshold> DbSet => db.WtgThresholds.OrderBy(t => t.Id);

        public override bool CanAdd(WtgThreshold model) => false;

        public override bool CanUpdate(int id, WtgThreshold model) => false;
    }
}
