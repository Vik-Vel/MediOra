using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            // Connection One-to-One: Feedback -> Appointment
            builder.HasOne(f => f.Appointment)                          // One feedback belongs to one appointment
                   .WithOne(a => a.Feedback)                            // One appointment has one feedback
                   .HasForeignKey<Feedback>(f => f.AppointmentId)       // Foreign Key in `Feedback`
                   .OnDelete(DeleteBehavior.NoAction);                  // Prevent cascade delete

            // Connection Many-to-One: Feedback -> Patient
            builder.HasOne(f => f.Patient)                              // One patient can have many feedbacks
                   .WithMany(p => p.Feedbacks)                          // One feedback belongs to one patient
                   .HasForeignKey(f => f.PatientId)                     // Foreign Key in `Feedback`
                   .OnDelete(DeleteBehavior.Restrict);                  // Prevent cascade delete

            // Connection Many-to-One: Feedback -> Doctor
            builder.HasOne(f => f.Doctor)                                // One doctor can have many feedbacks
                   .WithMany()                                           // One feedback belongs to one doctor
                   .HasForeignKey(f => f.DoctorId)                       // Foreign Key in `Feedback`
                   .OnDelete(DeleteBehavior.Restrict);                   // Prevent cascade delete


            var data = new SeedData();

            builder.HasData(new Feedback[] {data.Feedback1, data.Feedback2 });
        }
    }
}
