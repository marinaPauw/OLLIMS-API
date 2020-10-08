using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("measurementValues")]
    public partial class MeasurementValues
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("measurementId")]
        public int? MeasurementId { get; set; }
        [Column("value")]
        public double? Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MeasuredDatetime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LoggedDateTime { get; set; }

        [ForeignKey(nameof(MeasurementId))]
        [InverseProperty(nameof(Measurements.MeasurementValues))]
        public virtual Measurements Measurement { get; set; }
    }
}
