using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGRE.TSA.DataStore.API.Models
{
    public class SarStudy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Enter Data as DateTime")]
        public DateTime RecordInsertDTM { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Enter Data as DateTime")]
        public DateTime LastUpdateDTM { get; set; }
    }
}
