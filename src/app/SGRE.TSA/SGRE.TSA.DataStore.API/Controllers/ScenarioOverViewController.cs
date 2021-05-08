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
    public class ScenarioOverViewController : BaseController<ScenarioOverView>
    {
        public ScenarioOverViewController(TsaContext context, ILogger<ScenarioOverViewController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<ScenarioOverView> DbSet => db.ScenarioOverView.OrderBy(s => s.ScenarioId);

        public override bool CanAdd(ScenarioOverView model) => false;

        public override bool CanUpdate(int id, ScenarioOverView model) => false;

    }
}
