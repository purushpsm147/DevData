using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalsController : BaseController<Proposal>
    {
        public ProposalsController(TsaContext context, ILogger<ProposalsController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<Proposal> DbSet => db.Proposals.OrderBy(s => s.Id);

        public override bool CanAdd(Proposal model) => true;

        public override bool CanUpdate(int id, Proposal model) => true;


        [HttpPatch]
        [Route("UpdateCertficationCost/projectId={ProjectId:int}&certificationId={certificationId}")]
        public async Task<object> UpdateCertficationCost(int projectId, int certificationId)
        {
            try
            {
                var result = from c in db.CostFeedBack
                             join s in db.Scenarios on c.ScenarioId equals s.Id
                             join skpi in db.scenarioCostsKpis on s.Id equals skpi.ScenarioId
                             join ct in db.CostsTechnology on c.Id equals ct.CostFeedbackId
                             join q in db.Quotes on s.QuoteId equals q.Id
                             join prop in db.Proposals on q.ProposalId equals prop.Id
                             join proj in db.Projects on prop.ProjectId equals proj.Id
                             join certcost in db.CertificationCosts on proj.CurrencyId equals certcost.CurrencyId
                             where proj.Id == projectId && certcost.CertificationId == certificationId
                             select new { ct, skpi, certcost };

                foreach (var item in result)
                {
                    var absdiff = Math.Abs(item.ct.TowerComponentCertificateWindfarmClusterNomination - (item.certcost.CostKilo * 1000));

                    if(item.ct.TowerComponentCertificateWindfarmClusterNomination < (item.certcost.CostKilo * 1000))
                    {
                        item.skpi.TotalCostNomination = item.skpi.TotalCostNomination + absdiff;
                    }
                    else
                    {
                        item.skpi.TotalCostNomination = item.skpi.TotalCostNomination - absdiff;
                    }
                    item.ct.TowerComponentCertificateWindfarmClusterNomination = (item.certcost.CostKilo * 1000);
                }

                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
