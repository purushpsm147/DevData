using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    [Table("towersite_geo_door")]
    public class TowersiteGeoDoor : Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid SstUuid { get; set; }

        public decimal? ScfDoorTopBending { get; set; }

        public decimal? ScfDoorBottomBending { get; set; }

        public decimal? ScfDoorTorsion { get; set; }

        public decimal? DoorThicknessEffectExponent { get; set; }

        [Column("dist_bottom_to_upper_door_frame_mm")]
        public decimal? DistBottomToUpperDoorFrame { get; set; }

        [Column("dist_bottom_to_lower_door_frame_mm")]
        public decimal? DistBottomToLowerDoorFrame { get; set; }

        [Column("thickness_of_door_frame_mm")]
        public decimal? ThicknessOfDoorFrame { get; set; }

        [Column("width_of_door_frame_mm")]
        public decimal? WidthOfDoorFrame { get; set; }

        [Column("total_width_of_door_way_mm")]
        public decimal? TotalWidthOfDoorWay { get; set; }

        [Column("dist_outer_shell_to_frame_at_top_mm")]
        public decimal? DistOuterShellToFrameAtTop { get; set; }

        public decimal? DoorWeldClass { get; set; }

        // which holds the file path
        public string DoorFrameHolesScfFile { get; set; }

    }
}