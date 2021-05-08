using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : BaseController<Task>
    {
        public TaskController(TsaContext context, ILogger<TaskController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Task> DbSet => db.Tasks.OrderBy(t => t.Id);

        public override bool CanAdd(Task model) => false;

        public override bool CanUpdate(int id, Task model) => false;
    }
}
