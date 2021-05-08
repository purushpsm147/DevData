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
    public class CostOverViewController : BaseController<CostOverView>
    {
        public CostOverViewController(TsaContext context, ILogger<CostOverViewController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<CostOverView> DbSet => db.CostOverView.OrderBy(s => s.PositionId);

        public override bool CanAdd(CostOverView model) => false;

        public override bool CanUpdate(int id, CostOverView model) => false;

    }
}
