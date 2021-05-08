using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using SGRE.TSA.DataStore.API.Models;
using SGRE.TSA.DataStore.API.Providers;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignEvaluationController : ControllerBase
    {
        private readonly IDesignEvaluation designEvaluation;

        public DesignEvaluationController(IDesignEvaluation designEvaluation)
        {
            this.designEvaluation = designEvaluation;
        }

        [HttpPut]
        public async Task<IActionResult> PutDesignEvaluation(SstDesignEvaluation sstDesignEvaluation)
        {
            var result = await designEvaluation.PutDEAsync(sstDesignEvaluation);
            if (result.IsSuccess)
            {
                return Ok(result.sstDesignEvaluation);
            }

            return StatusCode(500, result.ErrorMessage);

        }

        [HttpPatch]
        public async Task<IActionResult> PatchDesignEvaluation(SstDesignEvaluation sstDesignEvaluation)
        {
            var result = await designEvaluation.PatchDEAsync(sstDesignEvaluation);
            if (result.IsSuccess)
            {
                return Ok(result.sstDesignEvaluation);
            }

            return StatusCode(500, result.ErrorMessage);
        }

        [HttpGet, EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
        [Route("{sstTowerId:int}")]
        public async Task<IActionResult> GetDesignEvaluation(int sstTowerId)
        {
            var result = await designEvaluation.GetDEAsync(sstTowerId);
            if (result.IsSuccess)
            {
                return Ok(result.sstDesignEvaluation);
            }

            return NotFound(result.ErrorMessage);

        }
    }
}
