using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public partial class LaboratoryDTO
    {
            
        public int Id { get; set; }
        public string LaboratoryName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Instrument> Instruments { get; set; }
    }
}
