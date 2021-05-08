using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Enums;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class ScenarioController : BaseController<Scenario>
    {
        private readonly ILogger<ScenarioController> _logger;
        private bool reverse;
        private bool isStepProgressChanged;

        public ScenarioController(TsaContext context, ILogger<ScenarioController> logger) : base(context, logger)
        {
            _logger = logger;
            beforeUpdateEvent += BeforeUpdate;
            afterUpdateEvent += AfterUpdate;

        }

        public void BeforeUpdate(Scenario FromFrontEnd)
        {
            var dbExistingScenario = db.Scenarios.Find(FromFrontEnd.Id);

            if (!HttpContext.Request.Headers.ContainsKey("TriggerAfterEvent"))
                return;

            var costFeedbackData = db.CostFeedBack.Include(r => r.CostsTowerSuppliers)
                                      .Include(r => r.CostsTowerLogistics)
                                      .Include(r => r.CostsTowerCustoms)
                                      .Include(r => r.CostsTowerExWorks)
                                      .Include(r => r.CostsTowerConstructions)
                                      .Include(r => r.CostsTechnologies)
                                      .Where(c => c.ScenarioId == FromFrontEnd.Id).FirstOrDefault();


            if (dbExistingScenario.Progress > FromFrontEnd.Progress)
            {
                reverse = true;
                costFeedbackData.CostsTowerExWorks.IsPhaseComplete = true;
                costFeedbackData.CostsTowerConstructions.IsPhaseComplete = true;
                costFeedbackData.CostsTowerCustoms.FirstOrDefault().IsPhaseComplete = true;
                costFeedbackData.CostsTowerLogistics.FirstOrDefault().IsPhaseComplete = true;
                costFeedbackData.CostsTowerSuppliers.FirstOrDefault().IsPhaseComplete = true;

                if (costFeedbackData.ScenarioType == ScenarioTypes.SST)
                {
                    costFeedbackData.CostsTechnologies.IsPhaseComplete = true;
                }

                FromFrontEnd.LastModifiedDateTime = DateTime.UtcNow;

                db.Update(costFeedbackData);

            }
            else
                reverse = false;

            if (dbExistingScenario.StepProgress == FromFrontEnd.StepProgress)
                isStepProgressChanged = false;
            else
                isStepProgressChanged = true;

        }

        protected override IQueryable<Scenario> DbSet => db.Scenarios.OrderBy(s => s.Id);

        public override bool CanAdd(Scenario model) => true;

        public override bool CanUpdate(int id, Scenario model) => true;

        public override ActionResult AddData(Scenario entityToAdd)
        {
            try
            {
                if (beforeAddEvent != null && beforeAddEvent.GetInvocationList().Length > 0)
                {
                    beforeAddEvent(entityToAdd);
                }

                var scenarioResult = DbSet.Where(x => x.QuoteId == entityToAdd.QuoteId && x.WindfarmConfigurationId == entityToAdd.WindfarmConfigurationId);
                entityToAdd.ScenarioNo = scenarioResult.Count() + 1;

                var addedEntry = db.Add(entityToAdd);
                db.SaveChanges();
                addedEntry.Reload();

                if (afterAddEvent != null && afterAddEvent.GetInvocationList().Length > 0)
                    afterAddEvent(addedEntry.Entity);

                return new OkObjectResult(entityToAdd);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());
                return StatusCode(500, ex?.InnerException?.Message);
            }
        }

        public void AfterUpdate(Scenario scenarioInDB)
        {
            if (!HttpContext.Request.Headers.ContainsKey("TriggerAfterEvent"))
                return;

            if (!isStepProgressChanged && !reverse)
                return;

            var costFeedbackData = db.CostFeedBack.Include(r => r.CostsTowerSuppliers)
                                      .Include(r => r.CostsTowerLogistics)
                                      .Include(r => r.CostsTowerCustoms)
                                      .Include(r => r.CostsTowerExWorks)
                                      .Include(r => r.CostsTowerConstructions)
                                      .Include(r => r.CostsTechnologies)
                                      .Where(c => c.ScenarioId == scenarioInDB.Id).FirstOrDefault();
            switch (scenarioInDB.Progress)
            {
                case ScenarioProgress.Nomination:
                    if (scenarioInDB.StepProgress)
                    {
                        costFeedbackData.CostsTowerExWorks.ScenarioProgress = ScenarioProgress.Nomination;
                        costFeedbackData.CostsTowerConstructions.ScenarioProgress = ScenarioProgress.Nomination;
                        costFeedbackData.CostsTowerCustoms.FirstOrDefault().ScenarioProgress = ScenarioProgress.Nomination;
                        costFeedbackData.CostsTowerLogistics.FirstOrDefault().ScenarioProgress = ScenarioProgress.Nomination;
                        costFeedbackData.CostsTowerSuppliers.FirstOrDefault().ScenarioProgress = ScenarioProgress.Nomination;

                        if (!reverse)
                        {
                            costFeedbackData.CostsTowerExWorks.IsPhaseComplete = false;
                            costFeedbackData.CostsTowerConstructions.IsPhaseComplete = false;
                            costFeedbackData.CostsTowerCustoms.FirstOrDefault().IsPhaseComplete = false;
                            costFeedbackData.CostsTowerLogistics.FirstOrDefault().IsPhaseComplete = false;
                            costFeedbackData.CostsTowerSuppliers.FirstOrDefault().IsPhaseComplete = false;
                            if (costFeedbackData.ScenarioType == ScenarioTypes.SST)
                            {
                                costFeedbackData.CostsTechnologies.IsPhaseComplete = false;
                                costFeedbackData.CostsTechnologies.ScenarioProgress = ScenarioProgress.Nomination;
                            }
                        }




                    }
                    break;
                case ScenarioProgress.Offer:
                    if (isCostFeedbackStageComplete(costFeedbackData, ScenarioProgress.Nomination) || reverse)
                    {
                        costFeedbackData.CostsTowerExWorks.ScenarioProgress = ScenarioProgress.Offer;
                        costFeedbackData.CostsTowerConstructions.ScenarioProgress = ScenarioProgress.Offer;
                        costFeedbackData.CostsTowerCustoms.FirstOrDefault().ScenarioProgress = ScenarioProgress.Offer;
                        costFeedbackData.CostsTowerLogistics.FirstOrDefault().ScenarioProgress = ScenarioProgress.Offer;
                        costFeedbackData.CostsTowerSuppliers.FirstOrDefault().ScenarioProgress = ScenarioProgress.Offer;

                        if (!reverse)
                        {
                            costFeedbackData.CostsTowerExWorks.IsPhaseComplete = false;
                            costFeedbackData.CostsTowerConstructions.IsPhaseComplete = false;
                            costFeedbackData.CostsTowerCustoms.FirstOrDefault().IsPhaseComplete = false;
                            costFeedbackData.CostsTowerLogistics.FirstOrDefault().IsPhaseComplete = false;
                            costFeedbackData.CostsTowerSuppliers.FirstOrDefault().IsPhaseComplete = false;

                            if (costFeedbackData.ScenarioType == ScenarioTypes.SST)
                            {
                                costFeedbackData.CostsTechnologies.IsPhaseComplete = false;
                                costFeedbackData.CostsTechnologies.ScenarioProgress = ScenarioProgress.Offer;
                            }
                        }

                    }
                    break;
                case ScenarioProgress.Signature:
                    if (isCostFeedbackStageComplete(costFeedbackData, ScenarioProgress.Offer))
                    {

                        costFeedbackData.CostsTowerExWorks.ScenarioProgress = ScenarioProgress.Signature;
                        costFeedbackData.CostsTowerConstructions.ScenarioProgress = ScenarioProgress.Signature;
                        costFeedbackData.CostsTowerCustoms.FirstOrDefault().ScenarioProgress = ScenarioProgress.Signature;
                        costFeedbackData.CostsTowerLogistics.FirstOrDefault().ScenarioProgress = ScenarioProgress.Signature;
                        costFeedbackData.CostsTowerSuppliers.FirstOrDefault().ScenarioProgress = ScenarioProgress.Signature;
                        costFeedbackData.CostsTowerExWorks.IsPhaseComplete = false;

                        costFeedbackData.CostsTowerConstructions.IsPhaseComplete = false;
                        costFeedbackData.CostsTowerCustoms.FirstOrDefault().IsPhaseComplete = false;
                        costFeedbackData.CostsTowerLogistics.FirstOrDefault().IsPhaseComplete = false;
                        costFeedbackData.CostsTowerSuppliers.FirstOrDefault().IsPhaseComplete = false;

                        if (costFeedbackData.ScenarioType == ScenarioTypes.SST)
                        {
                            costFeedbackData.CostsTechnologies.ScenarioProgress = ScenarioProgress.Signature;
                            costFeedbackData.CostsTechnologies.IsPhaseComplete = false;
                        }

                    }
                    break;
            }
            scenarioInDB.LastModifiedDateTime = DateTime.UtcNow;

            db.Update(scenarioInDB);
            db.Update(costFeedbackData);
            db.SaveChanges();
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

        [HttpPatch]
        [Route("updateScenarioStatus/scenarioId={scenarioId:int}&scenarioStatus={scenarioStatus}")]
        public async Task<IActionResult> PatchScenarioStatusAsync(int scenarioId, ScenarioStatus scenarioStatus)
        {
            try
            {
                var scenario = await db.Scenarios.FindAsync(scenarioId);

                scenario.Status = scenarioStatus;

                db.SaveChanges();

                return new OkObjectResult(scenario);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());

                return StatusCode(500, ex?.InnerException?.Message);
            }

        }

    }
}
