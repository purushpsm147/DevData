using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class ApplicationReasonController : BaseController<ApplicationReason>
    {
        public ApplicationReasonController(TsaContext context, ILogger<ApplicationReasonController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<ApplicationReason> DbSet => db.ApplicationReasons.OrderBy( s=> s.Id);

        public override bool CanAdd(ApplicationReason model) => false;


        public override bool CanUpdate(int id, ApplicationReason model) => false;

    }
}
