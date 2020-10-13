using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("MeasurementValues")]
    public class MeasurementValue
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Value { get; set; }
        [Required]
        public int MeasurementId { get; set; }

        [ForeignKey("MeasurementId")]
        public Measurement Measurement { get; set; }
        [Required]
        public DateTime MeasuredDatetime { get; set; }

        public DateTime LoggedDateTime { get; set; }
    }
}
