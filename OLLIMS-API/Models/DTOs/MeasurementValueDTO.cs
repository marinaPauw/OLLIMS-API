using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public partial class MeasurementValueDTO
    {
        public int Id { get; set; }
        public int? MeasurementId { get; set; }
        public double? Value { get; set; }
        public DateTime? MeasuredDatetime { get; set; }
        public DateTime? LoggedDateTime { get; set; }
        public virtual MeasurementDTO Measurement { get; set; }
    }
}
