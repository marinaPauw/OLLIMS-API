using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public class MeasurementDTO
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double? LowerLimit { get; set; }
        public double? UpperLimit { get; set; }
        [Required]
        public int InstrumentId { get; set; }
        public InstrumentDTO Instrument { get; set; }
    }
}
