using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController<Role>
    {
        public RoleController(TsaContext context, ILogger<RoleController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Role> DbSet => db.Roles.OrderBy(s => s.Id);

        public override bool CanAdd(Role model) => false;

        public override bool CanUpdate(int id, Role model) => false;
    }
}
