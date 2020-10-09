﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("laboratories")]
    public partial class Laboratory
    {
        public Laboratory()
        {
            Instruments = new HashSet<Instrument>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("laboratoryName")]
        [StringLength(255)]
        public string LaboratoryName { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("Laboratory")]
        public virtual ICollection<Instrument> Instruments { get; set; }
    }
}