using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class CostOverViewRNAController : BaseController<CostOverViewRNA>
    {
        public CostOverViewRNAController(TsaContext context, ILogger<CostOverViewRNAController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<CostOverViewRNA> DbSet => db.CostOverViewRNA.OrderBy(s => s.PositionId);

        public override bool CanAdd(CostOverViewRNA model) => false;

        public override bool CanUpdate(int id, CostOverViewRNA model) => false;

    }
}
