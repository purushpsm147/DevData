using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Enums;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Providers
{
    public class DesignEvaluation : IDesignEvaluation
    {
        private readonly TsaContext context;
        private readonly ILogger<DesignEvaluation> logger;

        public DesignEvaluation(TsaContext context, ILogger<DesignEvaluation> logger)
        {
            this.context = context;
            this.logger = logger; 
        }
        public async Task<(bool IsSuccess, SstDesignEvaluation sstDesignEvaluation, string ErrorMessage)> PatchDEAsync(SstDesignEvaluation sstDesignEvaluation)
        {
            try
            {
               
                context.Update(sstDesignEvaluation);

                await context.SaveChangesAsync();

                return (true, sstDesignEvaluation, "sucessfully updated");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex?.InnerException?.Message);
            }

        }

        public async Task<(bool IsSuccess, SstDesignEvaluation sstDesignEvaluation, string ErrorMessage)> PutDEAsync(SstDesignEvaluation sstDesignEvaluation)
        {
            try
            {
                if (sstDesignEvaluation != null)
                {
                    sstDesignEvaluation.IsSeismicConstraint = checkForSeismicAssessment(sstDesignEvaluation);
                    var response = await context.SstDesignEvaluation.AddAsync(sstDesignEvaluation);
                    await context.SaveChangesAsync();
                    return (true, response.Entity, string.Empty);
                }

                return (false, null, "SstDesignEvaluation is empty");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex?.InnerException?.Message);
            }

        }

        private bool checkForSeismicAssessment(SstDesignEvaluation sstDesignEvaluation)
        {
            ScenarioProgress isScenarioOffer = (from sc in context.Scenarios
                                                where sc.ItemId == sstDesignEvaluation.sstTowerId && sc.ScenarioType == ScenarioTypes.SST
                                                join qt in context.Quotes on sc.QuoteId equals qt.Id
                                                join pro in context.Proposals on qt.ProposalId equals pro.Id
                                                join cons in context.ProjectConstraints on pro.ProjectId equals cons.ProjectId
                                                join splrco in context.SpecialRequirementsSalesConstraints on pro.Id equals splrco.ProjectConstraintId
                                                where splrco.SesimicRequirements
                                                select sc.Progress).SingleOrDefault();
            if (isScenarioOffer == ScenarioProgress.Offer)
            {
                return true;
            }
            return false;
        }

        public async Task<(bool IsSuccess, IQueryable<SstDesignEvaluation> sstDesignEvaluation, string ErrorMessage)> GetDEAsync(int sstTowerId)
        {
            try
            {
                IQueryable<SstDesignEvaluation> sstDesignEvaluation = null;
                sstDesignEvaluation = context.SstDesignEvaluation.Include("SstDesignSeismicAssessment").Where(s => s.sstTowerId == sstTowerId);
                if (sstDesignEvaluation.Any())
                {
                    return (true, sstDesignEvaluation, string.Empty);
                }

                return (false, null, "SstDesignEvaluation is empty");

            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex?.InnerException?.Message);
            }
        }
    }
}
