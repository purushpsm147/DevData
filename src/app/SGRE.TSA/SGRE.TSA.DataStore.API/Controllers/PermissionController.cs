using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : BaseController<Permission>
    {
        public PermissionController(TsaContext context, ILogger<PermissionController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Permission> DbSet => db.Permissions.OrderBy(s => s.Id);

        public override bool CanAdd(Permission model) => false;

        public override bool CanUpdate(int id, Permission model) => false;
    }
}
