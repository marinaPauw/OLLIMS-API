using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{ 
    public class InstrumentDTO
    {
        public int Id { get; set; }

        [Required]
        public int LaboratoryId { get; set; }
        public LaboratoryDTO Laboratory { get; set; }
        [Required]
        public int MeasurementId { get; set; }
        public MeasurementDTO Measurement { get; set; }
        [Required]
        public int SOPId { get; set; }
        public InstrumentSOPDTO SOP { get; set; }
    }
}
