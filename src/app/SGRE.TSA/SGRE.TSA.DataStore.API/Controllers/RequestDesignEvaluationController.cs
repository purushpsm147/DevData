using Microsoft.AspNetCore.Mvc;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestDesignEvaluationController : ControllerBase
    {
        private readonly TsaContext context;
        public RequestDesignEvaluationController(TsaContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("{sstId:int}")]
        public IActionResult GetRequestDesignData(int sstId)
        {
            if (sstId <= 0)
                return BadRequest("Scenario id doesnot exist!");

            var res = from s in context.SstTower
                      where s.Id == sstId
                      join sd in context.SstPredesignDimesions on s.Id equals sd.SstTowerId into mma
                      from sd1 in mma.DefaultIfEmpty()
                      join q in context.Quotes on s.QuoteId equals q.Id
                      join it in context.InitialTowers on s.InitialTowerId equals it.Id
                      join wc in context.WtgCatalogues on it.WtgCatalogueId equals wc.Id
                      join p in context.Proposals on q.ProposalId equals p.Id
                      join o in context.Projects on p.ProjectId equals o.Id
                      join c in context.Countries on o.CountryId equals c.Id
                      join r in context.Regions on c.RegionId equals r.Id
                      select new RequestDesignEvaluation
                      {
                          DesignAuthor = "TowerSelect",
                          Region = r.RegionName,
                          DesignDescription = $"{o.Id}-{p.Id}-{q.Id}",
                          SafalFilePath = s.SafalLoadEnvelopLink,
                          ElsaFilePath = s.ElsaLoadEnvelopLink,
                          DesignDate = DateTime.UtcNow,
                          SectionWeight_max = (sd1 == null) ? 0 : sd1.MaxSectionWeight,
                          SectionLength_max = (sd1 == null) ? 0 : sd1.MaxSectionLength,
                          BottomDiameter_max = (sd1 == null) ? 0 : sd1.MaxTowerBaseDiameter,
                          HubHeight = (s.IsProposeHubHeight) ? ((s.ProposedHubHeight == null) ? 0 : Convert.ToDecimal(s.ProposedHubHeight)) : s.LoadsetHubHeight,
                          Tower = it.Tower,
                          Platform = wc.Platform,
                      };

            if (res != null && res.Any())
                return Ok(res);
            else
                return BadRequest("Scenario data missing!");
        }
    }
}

