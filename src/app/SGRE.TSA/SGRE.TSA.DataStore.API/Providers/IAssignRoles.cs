using SGRE.TSA.DataStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Providers
{
    public interface IAssignRoles
    {
        Task<(bool IsSuccess, IEnumerable<ProjectRoles> projectRoles, string ErrorMessage)> PostRolesAsync(IEnumerable<ProjectRoles> projectRoles);
        Task<bool> DeleteRolesAsync(IEnumerable<ProjectRoles> projectRoles);
    }
}
