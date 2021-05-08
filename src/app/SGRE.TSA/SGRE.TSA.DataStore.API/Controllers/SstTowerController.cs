using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Enums;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class SstTowerController : BaseController<SstTower>
    {
        public SstTowerController(TsaContext context, ILogger<SstTowerController> logger) : base(context, logger)
        {
            afterUpdateEvent += AfterUpdate;
        }
        protected override IQueryable<SstTower> DbSet => db.SstTower.OrderBy(s => s.Id);

        public override bool CanAdd(SstTower model) => true;

        public override bool CanUpdate(int id, SstTower model) => true;

        public void AfterUpdate(SstTower model)
        {
            var scenarioData = db.Scenarios.Where(s => s.QuoteId == model.QuoteId && s.WindfarmConfigurationId == model.WindfarmConfigurationId && s.ItemId == model.Id).FirstOrDefault();

            var costFeedbackData = db.CostFeedBack.Include(r => r.CostsTowerSuppliers)
                                                  .Include(r => r.CostsTowerLogistics)
                                                  .Include(r => r.CostsTowerCustoms)
                                                  .Include(r => r.CostsTowerExWorks)
                                                  .Include(r => r.CostsTowerConstructions)
                                                  .Include(r => r.CostsTechnologies)
                                                  .Where(c => c.ScenarioId == scenarioData.Id ).FirstOrDefault();


            if (scenarioData != null)
            {
                bool stepProgressState = false;

                switch (scenarioData.Progress)
                {
                    case ScenarioProgress.Nomination:
                        if (isAepValueAvailable(scenarioData, ScenarioProgress.Nomination, scenarioData.ScenarioType) && isCostFeedbackStageComplete(costFeedbackData, ScenarioProgress.Nomination))
                            stepProgressState = true;
                        break;

                    case ScenarioProgress.Offer:
                        if (isAepValueAvailable(scenarioData, ScenarioProgress.Offer, scenarioData.ScenarioType) && isCostFeedbackStageComplete(costFeedbackData, ScenarioProgress.Offer))
                            stepProgressState = true;
                        break;


                    case ScenarioProgress.Signature:
                        if (isAepValueAvailable(scenarioData, ScenarioProgress.Signature, scenarioData.ScenarioType) && isCostFeedbackStageComplete(costFeedbackData, ScenarioProgress.Signature))
                            stepProgressState = true;
                        break;

                }

                scenarioData.StepProgress = stepProgressState;
                scenarioData.LastModifiedDateTime = DateTime.UtcNow;

                db.Update(scenarioData);
                db.SaveChanges();

            }
        }

        public bool isAepValueAvailable(Scenario scenarioData, ScenarioProgress _scenarioProgress, ScenarioTypes scenarioTypes)
        {
            bool isPresent = false;

            if (scenarioTypes == ScenarioTypes.SST)
            {
                var AepData = db.SstTower.Include(r => r.SstPredesignProposedHubHeights).Include(r => r.SstPredesignExistingHubHeights).Where(s => s.QuoteId == scenarioData.QuoteId && s.WindfarmConfigurationId == scenarioData.WindfarmConfigurationId && s.Id == scenarioData.ItemId).FirstOrDefault();
                if (AepData == null)
                    return isPresent;
                if (AepData.IsProposeHubHeight)
                {
                    switch (_scenarioProgress)
                    {
                        case ScenarioProgress.Nomination:
                            isPresent = (AepData.SstPredesignProposedHubHeights?.AepNominationGross ?? 0) > 0 ? true : false;
                            break;

                        case ScenarioProgress.Offer:
                            isPresent = (AepData.SstPredesignProposedHubHeights?.AepBindingOfferNet ?? 0) > 0 ? true : false;
                            break;

                        case ScenarioProgress.Signature:
                            isPresent = (AepData.SstPredesignProposedHubHeights?.AepSignatureNet ?? 0) > 0 ? true : false;
                            break;
                    }
                }
                else
                {
                    switch (_scenarioProgress)
                    {
                        case ScenarioProgress.Nomination:
                            isPresent = (AepData.SstPredesignExistingHubHeights?.AepNominationGross ?? 0) > 0 ? true : false;
                            break;

                        case ScenarioProgress.Offer:
                            isPresent = (AepData.SstPredesignExistingHubHeights?.AepBindingOfferNet ?? 0) > 0 ? true : false;
                            break;

                        case ScenarioProgress.Signature:
                            isPresent = (AepData.SstPredesignExistingHubHeights?.AepSignatureNet ?? 0) > 0 ? true : false;
                            break;
                    }
                }
            }

            return isPresent;
        }

        public bool isCostFeedbackStageComplete(CostFeedback model, ScenarioProgress scenarioProgress)
        {

            IList<bool> Progress = new List<bool>();
            if (model == null)
                return false;
            Progress.Add(model.CostsTowerSuppliers.FirstOrDefault().IsPhaseComplete && model.CostsTowerSuppliers.FirstOrDefault().ScenarioProgress == scenarioProgress);
            Progress.Add(model.CostsTowerLogistics.FirstOrDefault().IsPhaseComplete && model.CostsTowerLogistics.FirstOrDefault().ScenarioProgress == scenarioProgress);
            Progress.Add(model.CostsTowerCustoms.FirstOrDefault().IsPhaseComplete && model.CostsTowerCustoms.FirstOrDefault().ScenarioProgress == scenarioProgress);

            Progress.Add(model.CostsTowerExWorks.IsPhaseComplete && model.CostsTowerExWorks.ScenarioProgress == scenarioProgress);
            Progress.Add(model.CostsTowerConstructions.IsPhaseComplete && model.CostsTowerConstructions.ScenarioProgress == scenarioProgress);

            if (model.ScenarioType == ScenarioTypes.SST)
                Progress.Add(model.CostsTechnologies.IsPhaseComplete && model.CostsTechnologies.ScenarioProgress == scenarioProgress);

            if (!Progress.All(r => r))
                return false;
            else
                return true;

        }


    }
}
