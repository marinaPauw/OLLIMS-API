using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{ 
    public partial class InstrumentDTO
    {
        public int Id { get; set; }
        public int? LaboratoryId { get; set; }
        public int? MeasurementId { get; set; }
        public int? Sopid { get; set; }
    }
}
