using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
   
    public class CountryController : BaseController<Country>
    {
        public CountryController(TsaContext context, ILogger<CountryController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Country> DbSet => db.Countries.OrderBy( s => s.CountryName);

        public override bool CanAdd(Country model) => false;


        public override bool CanUpdate(int id, Country model) => false;
    }
}
