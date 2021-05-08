using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteLineController : BaseController<QuoteLine>
    {
        public QuoteLineController(TsaContext context, ILogger<QuoteLineController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<QuoteLine> DbSet => db.QuoteLines.OrderBy(t => t.Id);

        public override bool CanAdd(QuoteLine model) => false;

        public override bool CanUpdate(int id, QuoteLine model) => true;
    }
}