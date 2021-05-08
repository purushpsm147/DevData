using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class DesignEvaluationSummaryController : BaseController<Summary>
    {
        public DesignEvaluationSummaryController(TsaContext context, ILogger<DesignEvaluationSummaryController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Summary> DbSet => db.SummaryView;

        public override bool CanAdd(Summary model) => false;

        public override bool CanUpdate(int id, Summary model) => false;

        [Route("{ID:int}")]
        [HttpGet]
        public override IQueryable<Summary> GetData(int id)
        {
            return DbSet.Where($"SstTowerId == {id}");
        }

    }
}