using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public partial class SOPDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string InstructionUrl { get; set; }
        public string DocumentUrl { get; set; }

        public int InstrumentId { get; set; }

        public virtual ICollection<SopTrainee> SopTrainees { get; set; }
    }
}
