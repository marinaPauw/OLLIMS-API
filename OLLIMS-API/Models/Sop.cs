using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("SOP")]
    public partial class Sop
    {
        public Sop()
        {
            Instruments = new HashSet<Instruments>();
            SopTrainees = new HashSet<SopTrainees>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("version")]
        [StringLength(255)]
        public string Version { get; set; }
        [Column("instructionURL")]
        [StringLength(255)]
        public string InstructionUrl { get; set; }
        [Column("documentURL")]
        [StringLength(255)]
        public string DocumentUrl { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("Sop")]
        public virtual ICollection<Instruments> Instruments { get; set; }
        [InverseProperty("Sop")]
        public virtual ICollection<SopTrainees> SopTrainees { get; set; }
    }
}
