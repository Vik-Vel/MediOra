using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            // Connection One-to-Many: Doctor -> Specialty
            builder.HasOne(d => d.Specialty)                         // A doctor (Doctor) has one specialty (Specialty)
                   .WithMany(s => s.Doctors)                         // A specialty can have many doctors (Doctors)
                   .HasForeignKey(d => d.SpecialtyId)                // Foreign Key in `Doctor` that points to `Specialty`
                   .OnDelete(DeleteBehavior.Restrict);               // If the specialty is deleted, do not delete the doctors


            // Connection Many-to-Many: Doctor -> Clinic (through DoctorClinic)
            builder.HasMany(d => d.DoctorClinics)                   // A doctor can work in many clinics
                   .WithOne(dc => dc.Doctor)                        // In `DoctorClinic` there is a Foreign Key to `Doctor`
                   .HasForeignKey(dc => dc.DoctorId)                // In `DoctorClinic` there is a `DoctorId` that points to `Doctors(Id)`
                   .OnDelete(DeleteBehavior.Restrict);              // We do not delete the records in `DoctorClinic` if we delete a doctor


            // Connection One-to-Many: Doctor -> Schedule
            builder.HasMany(d => d.Schedules)                       // A doctor has many work schedules (Schedules)
                   .WithOne(s => s.Doctor)                          // In `Schedule` there is a Foreign Key to `Doctor`
                   .HasForeignKey(s => s.DoctorId)                  // Foreign Key in `Schedule`, which points to `Doctors(Id)`
                   .OnDelete(DeleteBehavior.Restrict);              // If a doctor is deleted, the schedules will not be deleted


            // Connection One-to-Many: Doctor -> Appointment
            builder.HasMany(d => d.Appointments)                    // One doctor has many appointments
                   .WithOne(a => a.Doctor)                          // One appointment belongs to one doctor
                   .HasForeignKey(a => a.DoctorId)                  // Foreign Key in Appointment table
                   .OnDelete(DeleteBehavior.Restrict);              // Prevent cascade delete

            var data = new SeedData();

            builder.HasData(new Doctor[] { data.Doctor1,data.Doctor2, data.Doctor3});
        }
    }
}
