using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("personel")]
    public partial class Personel
    {
        public Personel()
        {
            SopTrainees = new HashSet<SopTrainees>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string Firstname { get; set; }
        [Column("lastname")]
        [StringLength(255)]
        public string Lastname { get; set; }
        [Column("position")]
        [StringLength(255)]
        public string Position { get; set; }
        [Column("accessLevelId")]
        public int? AccessLevelId { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<SopTrainees> SopTrainees { get; set; }
    }
}
