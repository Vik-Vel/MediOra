using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class ClinicConfiguration : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            // Connection Many-to-Many: Clinic -> Doctor (through DoctorClinic)
            builder.HasMany(c => c.DoctorClinics)                   // One clinic has many DoctorClinic records
                   .WithOne(dc => dc.Clinic)                        // Each DoctorClinic record belongs to one Clinic
                   .HasForeignKey(dc => dc.ClinicId)                // Foreign Key in DoctorClinic table
                   .OnDelete(DeleteBehavior.Restrict);              // Prevent cascade delete


            var data = new SeedData();

            builder.HasData(new Clinic[] {data.Clinic1, data.Clinic2 });
        }
    }
}
