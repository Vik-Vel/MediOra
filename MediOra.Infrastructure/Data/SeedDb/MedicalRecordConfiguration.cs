using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            // PatientId - Foreign Key
            builder.HasOne(mr => mr.Patient)                    // One medical record belongs to one patient
                   .WithMany(p => p.MedicalRecords)             // One patient can have many medical records
                   .HasForeignKey(mr => mr.PatientId)           // Foreign Key in MedicalRecord
                   .OnDelete(DeleteBehavior.Restrict);          // Prevent cascade delete


            var data = new SeedData();

            builder.HasData(new MedicalRecord[] {data.MedicalRecord1, data.MedicalRecord2});

        }
    }
}
