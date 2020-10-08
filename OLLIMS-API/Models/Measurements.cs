using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    [Table("measurements")]
    public partial class Measurements
    {
        public Measurements()
        {
            Instruments = new HashSet<Instruments>();
            MeasurementValues = new HashSet<MeasurementValues>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("instrumentId")]
        public int? InstrumentId { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("lowerLimit")]
        public double? LowerLimit { get; set; }
        [Column("upperLimit")]
        public double? UpperLimit { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("Measurement")]
        public virtual ICollection<Instruments> Instruments { get; set; }
        [InverseProperty("Measurement")]
        public virtual ICollection<MeasurementValues> MeasurementValues { get; set; }
    }
}
