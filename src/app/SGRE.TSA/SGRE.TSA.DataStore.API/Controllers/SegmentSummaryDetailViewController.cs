using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class SegmentSummaryDetailViewController : BaseController<SegmentDimensionsSummaryDetailView>
    {
        public SegmentSummaryDetailViewController(TsaContext context, ILogger<SegmentSummaryDetailViewController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<SegmentDimensionsSummaryDetailView> DbSet => db.SegmentDimensionsSummaryDetailView.OrderBy(s => s.SstUuid);

        public override bool CanAdd(SegmentDimensionsSummaryDetailView model) => false;

        public override bool CanUpdate(int id, SegmentDimensionsSummaryDetailView model) => false;

    }
}
