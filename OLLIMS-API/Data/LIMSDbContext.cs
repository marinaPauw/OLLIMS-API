using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OLLIMS_API.Models
{
    public class LIMSDbContext : DbContext
    {

        public LIMSDbContext(DbContextOptions<LIMSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessLevel> AccessLevels { get; set; }
        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<Laboratory> Laboratories { get; set; }
        public virtual DbSet<MeasurementValue> MeasurementValues { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<Employee> Personel { get; set; }
        public virtual DbSet<InstrumentSOP> InstrumentSOP { get; set; }
        public virtual DbSet<SOPTrainee> SopTrainees { get; set; }

        

    }
}
