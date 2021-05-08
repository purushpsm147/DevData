using Microsoft.AspNetCore.Mvc;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TowerSiteController : ControllerBase
    {
        private readonly TsaContext context;
        public TowerSiteController(TsaContext context)
        {
            this.context = context;
        }

        [HttpPatch]
        [Route("towerSiteCalculationDone")]
        public IActionResult patchTowerSiteData(TowerSiteResponse towerSiteResponse)
        {
            if (towerSiteResponse.SstTowerId <= 0)
                return BadRequest("Tower id doesnot exist!");

            var result = context.SstTower.FirstOrDefault(b => b.Id == towerSiteResponse.SstTowerId);
            if (result != null)
            {
                result.IsDesignEvaluationComplete = towerSiteResponse.IsDesignEvaluationComplete;
                result.SstUuid = Guid.Parse(towerSiteResponse.UuidId.ToString());
                result.TowersiteDesignOutputFileLink = towerSiteResponse.TowersiteDesignOutputFileLink;
                result.TowersiteDesignOutputFileSizeBytes = towerSiteResponse.TowersiteDesignOutputFileSizeBytes;
                result.RequestDesignEvaluationEndDatetime = DateTime.UtcNow;
                result.ErrorCode = towerSiteResponse.ErrorCode;
                context.SaveChanges();

                return Ok(result);
            }
            else
                return BadRequest("Tower id data missing!");
        }

    }
}

