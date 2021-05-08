using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : BaseController<Currency>
    {
        public CurrencyController(TsaContext context, ILogger<CurrencyController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Currency> DbSet => db.Currencies.OrderBy(s => s.Id);

        public override bool CanAdd(Currency model) => false;


        public override bool CanUpdate(int id, Currency model) => false;
    }
}
