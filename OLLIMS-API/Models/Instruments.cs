using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("instruments")]
    public partial class Instruments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("laboratoryId")]
        public int? LaboratoryId { get; set; }
        [Column("measurementId")]
        public int? MeasurementId { get; set; }
        [Column("SOPId")]
        public int? Sopid { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(LaboratoryId))]
        [InverseProperty(nameof(Laboratories.Instruments))]
        public virtual Laboratories Laboratory { get; set; }
        [ForeignKey(nameof(MeasurementId))]
        [InverseProperty(nameof(Measurements.Instruments))]
        public virtual Measurements Measurement { get; set; }
    }
}
