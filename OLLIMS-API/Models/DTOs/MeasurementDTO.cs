using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public partial class MeasurementDTO
    {
        
        public int Id { get; set; }
        public int? InstrumentId { get; set; }
        public string Name { get; set; }
        public double? LowerLimit { get; set; }
        public double? UpperLimit { get; set; }
        public virtual ICollection<InstrumentDTO> Instruments { get; set; }
        public virtual ICollection<MeasurementValueDTO> MeasurementValues { get; set; }
    }
}
