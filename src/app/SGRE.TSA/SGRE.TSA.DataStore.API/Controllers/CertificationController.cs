using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationController : BaseController<Certification>
    {
        public CertificationController(TsaContext context, ILogger<CertificationController> logger) : base(context, logger)
        {
        }

        protected override IQueryable<Certification> DbSet => db.Certifications.OrderBy(c => c.Id);

        public override bool CanAdd(Certification model) => false;

        public override bool CanUpdate(int id, Certification model) => false;
    }
}
