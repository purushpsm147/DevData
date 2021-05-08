using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectConstraintController : BaseController<ProjectConstraint>
    {
        public ProjectConstraintController(TsaContext context, ILogger<ProjectConstraintController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<ProjectConstraint> DbSet => db.ProjectConstraints.OrderBy(c => c.Id);

        public override bool CanAdd(ProjectConstraint model) => true;

        public override bool CanUpdate(int id, ProjectConstraint model) => true;
    }
}
