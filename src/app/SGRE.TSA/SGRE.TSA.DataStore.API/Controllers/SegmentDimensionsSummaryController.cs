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
    public class SegmentDimensionsSummaryController : BaseController<SegmentDimensionsSummaryView>
    {

        public SegmentDimensionsSummaryController(TsaContext context, ILogger<SegmentDimensionsSummaryController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<SegmentDimensionsSummaryView> DbSet => db.SegmentDimensionsSummaryView;

        public override bool CanAdd(SegmentDimensionsSummaryView model) => false;

        public override bool CanUpdate(int id, SegmentDimensionsSummaryView model) => false;

        [Route("{ID:int}")]
        [HttpGet]
        public override IQueryable<SegmentDimensionsSummaryView> GetData(int id)
        {
            return DbSet.Where($"SstTowerId == {id}");
        }
    }
}
