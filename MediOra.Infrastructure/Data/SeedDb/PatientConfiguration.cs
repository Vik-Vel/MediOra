using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            // Connection One-to-Many: Patient -> Appointment
            builder.HasMany(p => p.Appointments)                // A patient can have many appointments
                   .WithOne(a => a.Patient)                     // Each appointment belongs to one patient
                   .HasForeignKey(a => a.PatientId)             // Foreign Key in `Appointment`
                   .OnDelete(DeleteBehavior.Restrict);          // Prevent cascade delete

            // Connection One-to-Many: Patient -> MedicalRecord
            builder.HasMany(p => p.MedicalRecords)              // A patient can have many medical records
                   .WithOne(mr => mr.Patient)                   // Each medical record belongs to one patient
                   .HasForeignKey(mr => mr.PatientId)           // Foreign Key in `MedicalRecord`
                   .OnDelete(DeleteBehavior.Restrict);          // Prevent cascade delete

            // Connection One-to-Many: Patient -> Feedback
            builder.HasMany(p => p.Feedbacks)                   // A patient can give many feedbacks
                   .WithOne(f => f.Patient)                     // Each feedback belongs to one patient
                   .HasForeignKey(f => f.PatientId)             // Foreign Key in `Feedback`
                   .OnDelete(DeleteBehavior.Restrict);          // Prevent cascade delete

            var data = new SeedData();

            builder.HasData(new Patient[] { data.Patient1, data.Patient2, data.Patient3});
        }
    }
}
