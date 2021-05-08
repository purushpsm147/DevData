using Microsoft.EntityFrameworkCore;
using SGRE.TSA.DataStore.API;
using System;
using Xunit;
using System.Linq;
using SGRE.TSA.DataStore.API.Controllers;
using SGRE.TSA.DataStore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace SGRE.TSA.Test
{
    public class DataStoreAPITest
    {
        private readonly DbContextOptions<TsaContext> options;
        private readonly TsaContext dbContext;
        private readonly OpportunitiesController opportunity;
        public DataStoreAPITest()
        {
            options = new DbContextOptionsBuilder<TsaContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            dbContext = new TsaContext(options);
            CreateOpportunities(dbContext);
            opportunity = new OpportunitiesController(dbContext, null);

        }
        [Fact]
        public void GetAllOpportunitiesData()
        {

            var projects = opportunity.GetData();
            Assert.True(projects.Any());

            //Assert.Null(projects.ErrorMesage);
            //Assert.True(projects.IsSucess);

        }

        [Fact]
        public void GetAllTest()
        {
            var results = opportunity.GetData();
            Assert.IsAssignableFrom<IQueryable<Project>>(results);

            Assert.Equal(10, results.Count());
        }

        [Theory]
        [InlineData(7, Int32.MaxValue)]
        public void GetOpportunityByUserNameTest(int user1, int user2)
        {
            //arrange
            var validUserName = user1;
            var inValidUserName = user2;

            //act
            var notFoundResult = opportunity.GetData(user2);
            var foundResult = opportunity.GetData(user1);

            Assert.Null(notFoundResult.FirstOrDefault());
            Assert.NotNull(foundResult.FirstOrDefault());
        }


        [Fact]
        public void PutOpportunityProjectData()
        {
            //arrange
            var opportunityProject = new Project
            {
                ActiveRecordIndicator = "A",
                ContractStatus = "active",
                CountryId = 4,
                CreatedBy = "purushottam.p@siemensgamesa.com",
                CustomerName = "unit test Put",
                Id = 404,
                LastModifiedDateTime = DateTime.UtcNow,
                OpportunityId = "3",
                ProjectName = "P-unit",
                RecordEndDateTime = DateTime.UtcNow,
                RecordInsertDateTime = DateTime.UtcNow,
                SSTRequestSimilarProjects = "unit-test",
                UpdatedBy = "purushottam.p@siemensgamesa.com"
            };
            //act
            var createdResponse = opportunity.AddData(opportunityProject);

            //assert
            //Assert.IsType<CreatedAtActionResult>(createdResponse);

            // Assert.IsType<OkResult>(createdResponse.Result); // TODO : will address it

            //var item = createdResponse as CreatedAtActionResult;
            //Assert.IsType<Project>(createdResponse.Value);

            //var projectItem = createdResponse.Value as Project;
            //Assert.Equal(opportunityProject.Id, createdResponse.Value.Id);
            //Assert.Equal(opportunityProject.ProjectName, createdResponse.Value.ProjectName);
            //Assert.Equal(opportunityProject.UpdatedBy, createdResponse.Value.UpdatedBy);




            //arrange
            var IncompleteopportunityProject = new Project
            {
                ActiveRecordIndicator = "A",
                ContractStatus = "active",
                CreatedBy = "purushottam.p@siemensgamesa.com",
                CustomerName = "unit test Put",
                LastModifiedDateTime = DateTime.UtcNow,
                ProjectName = "P-unit",
                RecordEndDateTime = DateTime.UtcNow,
                RecordInsertDateTime = DateTime.UtcNow,
                SSTRequestSimilarProjects = "unit-test",
                UpdatedBy = "purushottam.p@siemensgamesa.com"
            };
            //act
            opportunity.ModelState.AddModelError("DataModelError", "Data Columns Validations failed.");
            var badResponse = opportunity.AddData(IncompleteopportunityProject);
            //assert

            //Assert.IsType<BadRequestObjectResult>(badResponse.Result);


        }

        #region HelperMethod
        private void CreateOpportunities(TsaContext dbContext)
        {
            Random rnd = new Random();
            //Feeding 10 dummy roles to roles database
            for (int i = 1; i <= 10; i++)
            {
                dbContext.Roles.Add(new DataStore.API.Models.Role()
                {
                    CreatedBy = Guid.NewGuid().ToString().Substring(1, 10),
                    UpdatedBy = Guid.NewGuid().ToString().Substring(1, 10),
                    Id = rnd.Next(20, 10000),
                    RoleName = Guid.NewGuid().ToString().Substring(1, 10),
                });
                dbContext.SaveChanges();
            }

            //Countries table
            for (int i = 1; i <= 10; i++)
            {

                dbContext.Countries.Add(new DataStore.API.Models.Country()
                {
                    CountryName = Guid.NewGuid().ToString().Substring(1, 15),
                    Id = rnd.Next(1, 10000),
                    RegionId = i
                });
                dbContext.SaveChanges();
            }

            //Regions Table
            for (int i = 1; i <= 10; i++)
            {

                dbContext.Regions.Add(new DataStore.API.Models.Region()
                {
                    Id = rnd.Next(1, 1000),
                    RegionName = Guid.NewGuid().ToString().Substring(1, 6)
                });
                dbContext.SaveChanges();
            }

            //Projects Table
            for (int i = 1; i <= 10; i++)
            {
                dbContext.Projects.Add(new DataStore.API.Models.Project()
                {
                    ActiveRecordIndicator = "A",
                    ContractStatus = "activated",
                    CountryId = i,
                    Id = i,
                    CustomerName = Guid.NewGuid().ToString().Substring(1, 10),
                    CreatedBy = Guid.NewGuid().ToString().Substring(1, 10),
                    UpdatedBy = Guid.NewGuid().ToString().Substring(1, 10),
                    LastModifiedDateTime = DateTime.UtcNow,
                    ProjectName = Guid.NewGuid().ToString().Substring(1, 10),
                    RecordEndDateTime = DateTime.UtcNow,
                    RecordInsertDateTime = DateTime.UtcNow,
                    OpportunityId = Guid.NewGuid().ToString().Substring(1, 15)

                }); ;
                dbContext.SaveChanges();
            }


        }

        #endregion
    }
}