using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OLLIMS_API.Models
{
    public partial class LIMSDbContext : DbContext
    {
        public LIMSDbContext()
        {
        }

        public LIMSDbContext(DbContextOptions<LIMSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessLevels> AccessLevels { get; set; }
        public virtual DbSet<Instruments> Instruments { get; set; }
        public virtual DbSet<Laboratories> Laboratories { get; set; }
        public virtual DbSet<MeasurementValues> MeasurementValues { get; set; }
        public virtual DbSet<Measurements> Measurements { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Sop> Sop { get; set; }
        public virtual DbSet<SopTrainees> SopTrainees { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevels>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Instruments>(entity =>
            {
                entity.HasOne(d => d.Laboratory)
                    .WithMany(p => p.Instruments)
                    .HasForeignKey(d => d.LaboratoryId)
                    .HasConstraintName("FK__instrumen__labor__4CA06362");

                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.Instruments)
                    .HasForeignKey(d => d.MeasurementId)
                    .HasConstraintName("FK__instrumen__measu__5535A963");

            });

            modelBuilder.Entity<MeasurementValues>(entity =>
            {
                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.MeasurementValues)
                    .HasForeignKey(d => d.MeasurementId)
                    .HasConstraintName("FK__measureme__measu__5629CD9C");
            });

            modelBuilder.Entity<SopTrainees>(entity =>
            {
                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SopTrainees)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__SOP_train__perso__5165187F");

                entity.HasOne(d => d.Sop)
                    .WithMany(p => p.SopTrainees)
                    .HasForeignKey(d => d.Sopid)
                    .HasConstraintName("FK__SOP_train__SOPId__5070F446");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
