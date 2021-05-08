using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Enums;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]

    public class CostFeedbackController : BaseController<CostFeedback>
    {
        private readonly ILogger<CostFeedbackController> _logger;
        public CostFeedbackController(TsaContext context, ILogger<CostFeedbackController> logger) : base(context, logger)
        {
            afterAddEvent += AfterUpdate;
            afterUpdateEvent += AfterUpdate;
        }
        protected override IQueryable<CostFeedback> DbSet => db.CostFeedBack.OrderBy(s => s.Id);

        public override bool CanAdd(CostFeedback model) => true;

        public override bool CanUpdate(int id, CostFeedback model) => true;


        public void AfterUpdate(CostFeedback model)
        {
            var scenarioData = db.Scenarios.Find(model.ScenarioId);

            if (scenarioData != null)
            {
                bool stepProgressState = false;

                switch (scenarioData.Progress)
                {
                    case ScenarioProgress.Nomination:
                        if (isAepValueAvailable(scenarioData, ScenarioProgress.Nomination, scenarioData.ScenarioType) && isCostFeedbackStageComplete(model, ScenarioProgress.Nomination))
                            stepProgressState = true;
                        break;

                    case ScenarioProgress.Offer:
                        if (isAepValueAvailable(scenarioData, ScenarioProgress.Offer, scenarioData.ScenarioType) && isCostFeedbackStageComplete(model, ScenarioProgress.Offer))
                            stepProgressState = true;
                        break;


                    case ScenarioProgress.Signature:
                        if (isAepValueAvailable(scenarioData, ScenarioProgress.Signature, scenarioData.ScenarioType) && isCostFeedbackStageComplete(model, ScenarioProgress.Signature))
                            stepProgressState = true;
                        break;

                }

                scenarioData.StepProgress = stepProgressState;
                updateCostFeedbackModel(model.Id, scenarioData);
                scenarioData.LastModifiedDateTime = DateTime.UtcNow;

                db.SaveChanges();

            }
        }

        private void updateCostFeedbackModel(int costFeedbackId, Scenario scenario)
        {
            var costFeedbackData = db.CostFeedBack.Find(costFeedbackId);

            costFeedbackData.CostsTowerExWorks.ScenarioProgress = scenario.Progress;
            costFeedbackData.CostsTowerConstructions.ScenarioProgress = scenario.Progress;
            costFeedbackData.CostsTowerCustoms.FirstOrDefault().ScenarioProgress = scenario.Progress;
            costFeedbackData.CostsTowerLogistics.FirstOrDefault().ScenarioProgress = scenario.Progress;
            costFeedbackData.CostsTowerSuppliers.FirstOrDefault().ScenarioProgress = scenario.Progress;
            if(costFeedbackData.ScenarioType == ScenarioTypes.SST)
                costFeedbackData.CostsTechnologies.ScenarioProgress = scenario.Progress;

            db.Update(costFeedbackData);
        }

        public bool isAepValueAvailable(Scenario scenarioData, ScenarioProgress _scenarioProgress, ScenarioTypes scenarioTypes)
        {
            bool isPresent = false;

            if (scenarioTypes == ScenarioTypes.SST)
            {
                var AepData = db.SstTower.Include(r => r.SstPredesignProposedHubHeights).Include(r => r.SstPredesignExistingHubHeights).Where(s => s.QuoteId == scenarioData.QuoteId && s.WindfarmConfigurationId == scenarioData.WindfarmConfigurationId && s.Id == scenarioData.ItemId).FirstOrDefault();

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

            if (scenarioTypes == ScenarioTypes.STPETP)
            {

                var AepData = db.BaseTower.Include(r => r.BaseTowerAepHubheight).Where(s => s.QuoteId == scenarioData.QuoteId && s.WindfarmConfigurationId == scenarioData.WindfarmConfigurationId && s.Id == scenarioData.ItemId).FirstOrDefault();

                switch (_scenarioProgress)
                {
                    case ScenarioProgress.Nomination:
                        isPresent = (AepData.BaseTowerAepHubheight?.AepNominationGross ?? 0) > 0 ? true : false;
                        break;

                    case ScenarioProgress.Offer:
                        isPresent = (AepData.BaseTowerAepHubheight?.AepBindingOfferNet ?? 0) > 0 ? true : false;
                        break;

                    case ScenarioProgress.Signature:
                        isPresent = (AepData.BaseTowerAepHubheight?.AepSignatureNet ?? 0) > 0 ? true : false;
                        break;
                }

            }

            return isPresent;

        }


        public bool isCostFeedbackStageComplete(CostFeedback model, ScenarioProgress scenarioProgress)
        {

            IList<bool> Progress = new List<bool>();

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

        [Route("{ID:int}")]
        [HttpGet]
        public override IQueryable<CostFeedback> GetData(int id)
        {
            try
            {
                var res1 = db.CostFeedBack.Include(s => s.CostsTowerSuppliers).ThenInclude(r => r.Suppliers).ThenInclude(r1 => r1.CostsTowerSupplierLineItems)
                                 .Include(s => s.CostsTowerExWorks).ThenInclude(r => r.CostsTowerExWorksLineItems).Where(t => t.ScenarioId == id);

                if (!res1.Any())
                    return Enumerable.Empty<CostFeedback>().AsQueryable();

                var res2 = db.CostFeedBack.Include(s => s.CostsTowerLogistics).ThenInclude(r => r.CostsTowerLogisticsSuppliers).ThenInclude(r1 => r1.CostsTowerLogisticsLineItems)
                                     .Include(s => s.CostsTowerLogistics).ThenInclude(r => r.CostsTowerLogisticsSuppliers).ThenInclude(r1 => r1.CostsTowerLogisticsLeadTimeLineitems).Where(t => t.ScenarioId == id);


                var res3 = db.CostFeedBack.Include(s => s.CostsTechnologies)
                                      .Include(s => s.CostsTowerConstructions)
                                      .Include(s => s.CostsTowerCustoms).ThenInclude(r => r.CostsTowerCustomsSuppliers).ThenInclude(r1 => r1.CostsTowerCustomsLineItems)
                    .Where(t => t.ScenarioId == id);

                res3.FirstOrDefault().CostsTowerLogistics = res2.FirstOrDefault().CostsTowerLogistics;
                res3.FirstOrDefault().CostsTowerExWorks = res1.FirstOrDefault().CostsTowerExWorks;
                res3.FirstOrDefault().CostsTowerSuppliers = res1.FirstOrDefault().CostsTowerSuppliers;

                return res3;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());
                return Enumerable.Empty<CostFeedback>().AsQueryable();
            }
        }

    }
}
