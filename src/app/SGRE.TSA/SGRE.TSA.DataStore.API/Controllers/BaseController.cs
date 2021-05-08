using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGRE.TSA.DataStore.API.Models;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace SGRE.TSA.DataStore.API.Controllers
{
    [ApiController]
    public abstract class BaseController<DbEntity> : ControllerBase where DbEntity : class
    {
        protected readonly TsaContext db;
        private readonly ILogger<BaseController<DbEntity>> logger;

        protected abstract IQueryable<DbEntity> DbSet { get; }

        protected delegate void AddUpdateDeleteDelegate(DbEntity entity);

        protected AddUpdateDeleteDelegate beforeAddEvent { get; set; }
        protected AddUpdateDeleteDelegate afterAddEvent { get; set; }

        protected AddUpdateDeleteDelegate beforeUpdateEvent { get; set; }
        protected AddUpdateDeleteDelegate afterUpdateEvent { get; set; }

        public BaseController(TsaContext context, ILogger<BaseController<DbEntity>> logger)
        {
            db = context;
            this.logger = logger;
        }

        [HttpGet, EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All, MaxExpansionDepth = 5)]
        public virtual IQueryable<DbEntity> GetData()
        {
            return DbSet;
        }

        [Route("{ID:int}")]
        [HttpGet, EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All, MaxExpansionDepth = 5)]
        public virtual IQueryable<DbEntity> GetData(int id)
        {
            return DbSet.Where($"Id == {id}");
        }

        [HttpPut]
        public virtual ActionResult AddData(DbEntity entityToAdd)
        {
            if (!CanAdd(entityToAdd))
            {
                return StatusCode(203);
            }
            try
            {
                if (beforeAddEvent != null && beforeAddEvent.GetInvocationList().Length > 0)
                {
                    beforeAddEvent(entityToAdd);
                }
                if (entityToAdd is Audit)
                {
                    var adtObj = entityToAdd as Audit;
                    adtObj.RecordInsertDateTime = DateTime.UtcNow;
                    adtObj.LastModifiedDateTime = DateTime.UtcNow;

                }
                var addedEntry = db.Add(entityToAdd);
                db.SaveChanges();
                addedEntry.Reload();

                if (afterAddEvent != null && afterAddEvent.GetInvocationList().Length > 0)
                    afterAddEvent(addedEntry.Entity);

                return new OkObjectResult(entityToAdd);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return StatusCode(500, ex?.InnerException?.Message);
            }
        }

        [Route("{ID:int}")]
        [HttpPatch]
        public virtual ActionResult<DbEntity> UpdateData(int id, DbEntity modelToUpdate)
        {
            var delta = new Utilities.Delta<DbEntity>();
            try
            {
                var entityToUpdate = DbSet.Where($"ID == {id}").FirstOrDefault();
                if (entityToUpdate == null)
                {
                    return StatusCode(403);
                }

                if (!CanUpdate(id, modelToUpdate))
                {
                    return StatusCode(403);

                }
                if (beforeUpdateEvent != null && beforeUpdateEvent.GetInvocationList().Length > 0)
                    beforeUpdateEvent(modelToUpdate);
                if (modelToUpdate is Audit)
                {
                    var adtObj = modelToUpdate as Audit;
                    adtObj.LastModifiedDateTime = DateTime.UtcNow;
                }
                delta.LoadFrom(modelToUpdate, entityToUpdate);
                delta.Patch(entityToUpdate);
                
                db.SaveChanges();
                if (afterUpdateEvent != null && afterUpdateEvent.GetInvocationList().Length > 0)
                    afterUpdateEvent(entityToUpdate);
                return Ok();
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return StatusCode(500, ex?.InnerException?.Message);
            }
        }

        [Route("{ID:int}")]
        [HttpDelete]
        public virtual StatusCodeResult Delete(int id)
        {
            try
            {
                var entitytoRemove = DbSet.Where($"ID == {id}").FirstOrDefault();
                if (entitytoRemove == null)
                {
                    return StatusCode(400);
                }
                db.Remove(entitytoRemove);
                db.SaveChanges();
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        public abstract bool CanAdd(DbEntity model);

        public abstract bool CanUpdate(int id, DbEntity model);
    }
}

