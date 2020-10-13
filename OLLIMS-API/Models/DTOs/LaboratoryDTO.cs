using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public class LaboratoryDTO
    {
        public int Id { get; set; }
        [Required]
        public string LaboratoryName { get; set; }
        public string Description { get; set; }

    }
}
