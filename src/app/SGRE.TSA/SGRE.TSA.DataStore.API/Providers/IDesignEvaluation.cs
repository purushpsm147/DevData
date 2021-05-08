using SGRE.TSA.DataStore.API.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Providers
{
    public interface IDesignEvaluation
    {
        Task<(bool IsSuccess, SstDesignEvaluation sstDesignEvaluation, string ErrorMessage)> PutDEAsync(SstDesignEvaluation sstDesignEvaluation);
        Task<(bool IsSuccess, SstDesignEvaluation sstDesignEvaluation, string ErrorMessage)> PatchDEAsync(SstDesignEvaluation sstDesignEvaluation);
        Task<(bool IsSuccess, IQueryable<SstDesignEvaluation> sstDesignEvaluation, string ErrorMessage)> GetDEAsync(int sstTowerId);
    }
}
