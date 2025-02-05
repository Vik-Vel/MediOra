using MediOra.Infrastructure.Data.Models;
using MediOra.Infrastructure.Data.Models.Mappings;
using MediOra.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MediOra.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DoctorClinic>()
              .HasKey(dc => new { dc.DoctorId, dc.ClinicId });

            builder.Entity<DoctorFeedback>()
             .HasKey(df => new { df.DoctorId, df.FeedbackId });

            builder.Entity<PatientNotification>()
                .HasKey(pf => new {pf.PatientId, pf.NotificationId});


            //Configuration (Data Seeding)
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new AppointmentConfiguration());
            builder.ApplyConfiguration(new ClinicConfiguration());
            builder.ApplyConfiguration(new DoctorConfiguration());
            builder.ApplyConfiguration(new FeedbackConfiguration());
            builder.ApplyConfiguration(new MedicalRecordConfiguration());
            builder.ApplyConfiguration(new NotificationConfiguration());
            builder.ApplyConfiguration(new PatientConfiguration());
            builder.ApplyConfiguration(new ScheduleConfiguration());
            builder.ApplyConfiguration(new SpecialtyConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Appointment> Appointments { get; set; } = null!;

        public DbSet<Clinic> Clinics { get; set; } = null!;
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Feedback> Feedbacks { get; set; } = null!;
        public DbSet<MedicalRecord> MedicalRecords { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Schedule> Schedules { get; set; } = null!;
        public DbSet<Specialty> Specialties { get; set; } = null!;
    }
}
