using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationCostController : BaseController<CertificationCost>
    {
        public CertificationCostController(TsaContext context, ILogger<CertificationCostController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<CertificationCost> DbSet => db.CertificationCosts.OrderBy(c => c.Id);

        public override bool CanAdd(CertificationCost model) => false;

        public override bool CanUpdate(int id, CertificationCost model) => false;
    }
}
