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
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class PresetRolesController : BaseController<PresetRoles>
    {
        public PresetRolesController(TsaContext context, ILogger<PresetRolesController> logger) : base(context, logger)
        {
        }
        protected override IQueryable<PresetRoles> DbSet => db.PresetRoles.OrderBy(s => s.Id);

        public override bool CanAdd(PresetRoles model) => false;

        public override bool CanUpdate(int id, PresetRoles model) => false;
    }
}
