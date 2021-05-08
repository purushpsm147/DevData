using SGRE.TSA.DataStore.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class Permission : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Role Role { get; set; }

        [Required]
        public int RoleId { get; set; }
        public ProjectModule ProjectModule { get; set; }

        [Required]
        public int ProjectModuleId { get; set; }
        public PermissionTypes PermissionType { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Created by User is Required", MinimumLength = 3)]
        public string CreatedBy { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Updated by User is Required", MinimumLength = 3)]
        public string UpdatedBy { get; set; }

    }
}
