using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("SOP_trainees")]
    public class SOPTrainee
    {
        [Key]
        public int Id { get; set; }
        public string CertificateUrl { get; set; }
        [Required]
        public DateTime TrainedAt { get; set; }
        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        [Required]
        public int SOPId { get; set; }

        [ForeignKey("SOPId")]
        public InstrumentSOP SOP { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
