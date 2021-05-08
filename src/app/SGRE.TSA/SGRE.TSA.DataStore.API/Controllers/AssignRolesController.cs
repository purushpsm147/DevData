using Microsoft.AspNetCore.Mvc;
using SGRE.TSA.DataStore.API.Models;
using SGRE.TSA.DataStore.API.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class AssignRolesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostMyRoles(IEnumerable<ProjectRoles> projectRoles, [FromServices] IAssignRoles assignRoles)
        {
            var result = await assignRoles.PostRolesAsync(projectRoles);
            if (result.IsSuccess)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPost, Route("DeleteRoles")]
        public async Task<IActionResult> DeleteMyRoles(IEnumerable<ProjectRoles> projectRoles, [FromServices] IAssignRoles assignRoles)
        {
            var result = await assignRoles.DeleteRolesAsync(projectRoles);
            if (result)
            {
                return Ok();
            }

            return NotFound();
        }


    }
}