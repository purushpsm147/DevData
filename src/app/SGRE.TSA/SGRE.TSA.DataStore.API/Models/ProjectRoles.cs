using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class ProjectRoles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public Role Role { get; set; }

        [Required]
        public int RoleId { get; set; }

        // Contains email
        public string userId { get; set; }

    }
}
