using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Providers
{
    public class AssignRoles : IAssignRoles
    {
        private readonly TsaContext context;
        private readonly ILogger<AssignRoles> logger;


        public AssignRoles(TsaContext context, ILogger<AssignRoles> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task<bool> DeleteRolesAsync(IEnumerable<ProjectRoles> projectRoles)
        {
            try
            {
                if (projectRoles.Any())
                {
                    context.ProjectRoles.RemoveRange(projectRoles);
                    await context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return false;
            }
        }

        private ProjectRoles UpdateRole(ProjectRoles dbRole, ProjectRoles updatedRole)
        {
            dbRole.RoleId = updatedRole.RoleId;
            dbRole.userId = updatedRole.userId;
            return dbRole;
        }

        public async Task<(bool IsSuccess, IEnumerable<ProjectRoles> projectRoles, string ErrorMessage)> PostRolesAsync(IEnumerable<ProjectRoles> projectRoles)
        {
            try
            {
                //logic
                if (projectRoles != null && projectRoles.Any())
                {
                    var existingRoleInDB = await context.ProjectRoles.Where(s => s.ProjectId == projectRoles.FirstOrDefault().ProjectId).ToListAsync();

                    var newlyAddedRoles = projectRoles.Where(s => s.Id == 0);

                    var notReq = from erl in existingRoleInDB
                                 join rl in projectRoles
                                   on erl.Id equals rl.Id
                                 where !erl.Equals(rl)
                                 select UpdateRole(erl, rl);


                    await context.ProjectRoles.AddRangeAsync(newlyAddedRoles);
                    await context.SaveChangesAsync();
                    return (true, projectRoles, string.Empty);

                }
                return (false, null, "Project Roles are empty");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex?.InnerException?.Message);
            }
        }

    }
}
