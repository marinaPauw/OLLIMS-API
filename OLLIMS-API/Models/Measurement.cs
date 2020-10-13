using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("Measurements")]
    public class Measurement
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double? LowerLimit { get; set; }
        public double? UpperLimit { get; set; }
        [Required]
        public int InstrumentId { get; set; }
        [ForeignKey("InstrumentId")]
        public Instrument Instrument { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
