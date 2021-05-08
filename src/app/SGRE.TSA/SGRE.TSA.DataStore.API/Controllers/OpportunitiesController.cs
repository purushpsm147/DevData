using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Linq;
using Task = System.Threading.Tasks.Task;
using Microsoft.EntityFrameworkCore;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class OpportunitiesController : BaseController<Project>
    {
        public OpportunitiesController(TsaContext context, ILogger<OpportunitiesController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<Project> DbSet => db.Projects.OrderByDescending(s => s.Id);

        public override bool CanAdd(Project model) => true;

        public override bool CanUpdate(int id, Project model) => true;

        [HttpGet]
        [Route("IsCostFeedbackAvailable/{ProjectId:int}")]
        public object IsCostFeedbackAvailable(int ProjectId)
        {
            try
            {
                var result = from c in db.CostFeedBack
                             join s in db.Scenarios on c.ScenarioId equals s.Id
                             join q in db.Quotes on s.QuoteId equals q.Id
                             join prop in db.Proposals on q.ProposalId equals prop.Id
                             join proj in db.Projects on prop.ProjectId equals proj.Id
                             where proj.Id == ProjectId
                             select new { costFeedbackID = c.Id, proposalId = prop.Id };

                return result.Any() ? result: null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
