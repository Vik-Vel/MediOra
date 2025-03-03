using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {

            // Connection One-to-Many: Specialty -> Doctor
            builder.HasMany(s => s.Doctors)                     // One specialty can have many doctors
                       .WithOne(d => d.Specialty)               // Each doctor belongs to one specialty
                       .HasForeignKey(d => d.SpecialtyId)       // Foreign Key in Doctor
                       .OnDelete(DeleteBehavior.Restrict);      // Prevent cascade delete

            var data = new SeedData();
            builder.HasData(new Specialty[]
            {
                 data.Cardiology,
                 data.Neurology,
                 data.Pediatrics,
                 data.Dermatology,
                 data.Orthopedics,
                 data.Ophthalmology,
                 data.Psychiatry,
                 data.Gynecology,
                 data.Urology,
                 data.Endocrinology,
                 data.Gastroenterology,
                 data.Hematology,
                 data.InfectiousDiseases,
                 data.Nephrology,
                 data.Oncology,
                 data.Pulmonology,
                 data.Rheumatology,
                 data.Allergology,
                 data.Anesthesiology,
                 data.Dentistry,
                 data.PhysicalTherapy,
                 data.PlasticSurgery,
                 data.VascularSurgery,
                 data.Neurosurgery,
                 data.ENT,
                 data.EmergencyMedicine,
                 data.FamilyMedicine,
                 data.SportsMedicine,
                 data.Geriatrics,
                 data.Nutrition,
                 data.Radiology,
                 data.NuclearMedicine,
                 data.MedicalGenetics,
                 data.ClinicalPsychology,
                 data.GeneralPractice
            });


        }
    }
}
