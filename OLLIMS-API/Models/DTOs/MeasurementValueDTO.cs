using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public class MeasurementValueDTO
    {
        public int Id { get; set; }
        [Required]
        public float Value { get; set; }
        [Required]
        public int MeasurementId { get; set; }
        public MeasurementDTO Measurement { get; set; }
        [Required]
        public DateTime MeasuredDatetime { get; set; }
    }
}
