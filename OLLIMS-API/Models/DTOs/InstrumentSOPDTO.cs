using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public class InstrumentSOPDTO
    {

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
        public InstrumentDTO Instrument { get; set; }

    }
}
