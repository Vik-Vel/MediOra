using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            // Connection One-to-Many: Appointment -> Doctor
            builder.HasOne(a => a.Doctor) // Each appointment is assigned to one doctor
                   .WithMany(d => d.Appointments) // One doctor can have many appointments
                   .HasForeignKey(a => a.DoctorId) // Foreign Key in `Appointment`
                   .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete


            // Connection One-to-Many: Appointment -> Patient
            builder.HasOne(a => a.Patient) // Each appointment is assigned to one patient
                   .WithMany(p => p.Appointments) // One patient can have many appointments
                   .HasForeignKey(a => a.PatientId) // Foreign Key in `Appointment`
                   .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            var data = new SeedData();

            builder.HasData(new Appointment[] { });
        }
    }
}
