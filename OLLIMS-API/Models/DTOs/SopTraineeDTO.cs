using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public class SOPTraineeDTO
    {
        public int Id { get; set; }
        [Required]
        public string CertificateUrl { get; set; }
        [Required]
        public DateTime TrainedAt { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        public EmployeeDTO Employee { get; set; }
        [Required]
        public int SOPId { get; set; }
        public InstrumentSOPDTO SOP { get; set; }
    }
}
