using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("Instruments")]
    public class Instrument
    {
        [Key]
        public int Id { get; set; }
           
        [Required]
        public int LaboratoryId { get; set; }

        [ForeignKey("LaboratoryId")]
        public Laboratory Laboratory { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
