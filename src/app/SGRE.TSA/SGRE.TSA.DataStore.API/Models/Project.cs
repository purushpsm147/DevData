using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Project : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Project / SaleForce Opportunity ID is Required", MinimumLength = 3)]
        public string OpportunityId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Project Name is Required", MinimumLength = 3)]
        public string ProjectName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Customer Name is Required", MinimumLength = 3)]
        public string CustomerName { get; set; }

        [StringLength(20, ErrorMessage = "Contract Status is Required", MinimumLength = 3)]
        public string ContractStatus { get; set; }

        public Country Country { get; set; }
        [Required]
        public int CountryId { get; set; }

        public Currency Currency { get; set; }

        public int CurrencyId { get; set; }

        public string SSTRequestSimilarProjects { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Created by User is Required", MinimumLength = 3)]
        public string CreatedBy { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Updated by User is Required", MinimumLength = 3)]
        public string UpdatedBy { get; set; }

        public DateTimeOffset? RecordEndDateTime { get; set; }

        [StringLength(1)]
        public string ActiveRecordIndicator { get; set; }

        public ICollection<Proposal> Proposals { get; set; }

        public ICollection<ProjectMileStones> ProjectMileStones { get; set; }

        public ICollection<ProjectRoles> ProjectRoles { get; set; }

        public ICollection<ProjectConstraint> ProjectConstraints { get; set; }

    }
}
