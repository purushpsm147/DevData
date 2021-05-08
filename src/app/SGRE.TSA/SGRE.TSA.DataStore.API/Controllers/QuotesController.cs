using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : BaseController<Quote>
    {
        public QuotesController(TsaContext context, ILogger<QuotesController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Quote> DbSet => db.Quotes.OrderBy(s => s.Id);

        public override bool CanAdd(Quote model) => true;

        public override bool CanUpdate(int id, Quote model) => true;
    }
}
