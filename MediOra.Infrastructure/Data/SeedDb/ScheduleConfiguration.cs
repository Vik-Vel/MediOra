using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            // DoctorId - Foreign Key
            builder.HasOne(s => s.Doctor)                   // One schedule belongs to one doctor
                   .WithMany(d => d.Schedules)              // One doctor can have many schedules
                   .HasForeignKey(s => s.DoctorId)          // Foreign Key in Schedule
                   .OnDelete(DeleteBehavior.Restrict);      // Prevent cascade delete

            var data = new SeedData();

            builder.HasData(new Schedule[] {data.Schedule1, data.Schedule2 });
        }
    }
}
