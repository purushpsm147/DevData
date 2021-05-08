using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class AEPLookupController : BaseController<SSTAepLookupGross>
    {
        public AEPLookupController(TsaContext context, ILogger<AEPLookupController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<SSTAepLookupGross> DbSet => db.SstAepLookupGross.OrderBy(s => s.Id);

        public override bool CanAdd(SSTAepLookupGross model) => true;

        public override bool CanUpdate(int id, SSTAepLookupGross model) => true;
    }
}
