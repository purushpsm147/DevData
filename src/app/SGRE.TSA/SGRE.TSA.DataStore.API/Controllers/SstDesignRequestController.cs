using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class SstDesignRequestController : BaseController<SstDesignRequest>
    {
        public SstDesignRequestController(TsaContext context, ILogger<SstDesignRequestController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<SstDesignRequest> DbSet => db.SstDesignRequests.OrderBy(s => s.Id);

        public override bool CanAdd(SstDesignRequest model) => true;

        public override bool CanUpdate(int id, SstDesignRequest model) => true;
    }
}
