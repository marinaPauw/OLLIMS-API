using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("SOP_trainees")]
    public partial class SopTrainee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("SOPId")]
        public int? Sopid { get; set; }
        [Column("personId")]
        public int? PersonId { get; set; }
        [Column("certificateURL")]
        [StringLength(255)]
        public string CertificateUrl { get; set; }
        [Column("trainedAt", TypeName = "datetime")]
        public DateTime? TrainedAt { get; set; }

        [ForeignKey(nameof(PersonId))]
        [InverseProperty(nameof(Employee.SopTrainees))]
        public virtual Employee Person { get; set; }
        [ForeignKey(nameof(Sopid))]
        [InverseProperty("SopTrainees")]
        public virtual Sop Sop { get; set; }
    }
}
