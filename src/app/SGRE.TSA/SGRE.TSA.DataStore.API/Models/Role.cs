﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Role : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Role Name is Required", MinimumLength = 3)]
        public string RoleName { get; set; }

        [StringLength(64, MinimumLength = 3)]
        public string RoleDescription { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Created by User is Required", MinimumLength = 3)]
        public string CreatedBy { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Updated by User is Required", MinimumLength = 3)]
        public string UpdatedBy { get; set; }

        [StringLength(1)]
        public string ActiveRecordIndicator { get; set; }

    }
}
