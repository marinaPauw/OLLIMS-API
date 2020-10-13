using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("InstrumentSOPs")]
    public class InstrumentSOP
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Version { get; set; }
        public string InstructionUrl { get; set; }
        [Required]
        public string DocumentUrl { get; set; }
        [Required]
        public int InstrumentId { get; set; }
        [ForeignKey("Instrument")]
        public Instrument Instrument { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
