using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class LoadClusterController : BaseController<LoadsCluster>
    {
        public LoadClusterController(TsaContext context, ILogger<LoadClusterController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<LoadsCluster> DbSet => db.LoadsClusters.OrderBy( s=> s.Id);

        public override bool CanAdd(LoadsCluster model) => false;


        public override bool CanUpdate(int id, LoadsCluster model) => false;

    }
}
