using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class MileStoneController : BaseController<MileStone>
    {
        public MileStoneController(TsaContext context, ILogger<MileStoneController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<MileStone> DbSet => db.MileStones.OrderBy(s => s.Id);

        public override bool CanAdd(MileStone model) => false;


        public override bool CanUpdate(int id, MileStone model) => false;
    }
}
