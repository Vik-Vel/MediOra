using MediOra.Infrastructure.Data.Models;
using MediOra.Infrastructure.Data.Models.Mappings;
using Microsoft.AspNetCore.Identity;

namespace MediOra.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        // Identity Users
        public IdentityUser AdminUser { get; set; }
        public IdentityUser PatientUser { get; set; }
        public IdentityUser DoctorUser { get; set; }

        // Specialties
        public Specialty Cardiology { get; set; }
        public Specialty Neurology { get; set; }
        public Specialty Pediatrics { get; set; }

        // Doctors
        public Doctor Doctor1 { get; set; }
        public Doctor Doctor2 { get; set; }
        public Doctor Doctor3 { get; set; }

        // Patients
        public Patient Patient1 { get; set; }
        public Patient Patient2 { get; set; }
        public Patient Patient3 { get; set; }

        // Clinics
        public Clinic Clinic1 { get; set; }
        public Clinic Clinic2 { get; set; }

        // Appointments
        public Appointment Appointment1 { get; set; }
        public Appointment Appointment2 { get; set; }
        public Appointment Appointment3 { get; set; }

        // Feedbacks
        public Feedback Feedback1 { get; set; }
        public Feedback Feedback2 { get; set; }

        // Medical Records
        public MedicalRecord MedicalRecord1 { get; set; }
        public MedicalRecord MedicalRecord2 { get; set; }

        // Notifications
        public Notification Notification1 { get; set; }
        public Notification Notification2 { get; set; }

        // Schedules
        public Schedule Schedule1 { get; set; }
        public Schedule Schedule2 { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedSpecialties();
            SeedDoctors();
            SeedPatients();
            SeedClinics();
            SeedAppointments();
            SeedFeedbacks();
            SeedMedicalRecords();
            SeedNotifications();
            SeedSchedules();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AdminUser = new IdentityUser
            {
                Id = "admin-user-id",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM"
            };
            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin123");

            PatientUser = new IdentityUser
            {
                Id = "patient-user-id",
                UserName = "patient@mail.com",
                NormalizedUserName = "PATIENT@MAIL.COM",
                Email = "patient@mail.com",
                NormalizedEmail = "PATIENT@MAIL.COM"
            };
            PatientUser.PasswordHash = hasher.HashPassword(PatientUser, "patient123");

            DoctorUser = new IdentityUser
            {
                Id = "doctor1-user-id",
                UserName = "doctor1@mail.com",
                NormalizedUserName = "DOCTOR1@MAIL.COM",
                Email = "doctor1@mail.com",
                NormalizedEmail = "DOCTOR1@MAIL.COM"
            };
            DoctorUser.PasswordHash = hasher.HashPassword(DoctorUser, "doctor123");
        }

        private void SeedSpecialties()
        {
            Cardiology = new Specialty { Id = 1, Name = "Cardiology" };
            Neurology = new Specialty { Id = 2, Name = "Neurology" };
            Pediatrics = new Specialty { Id = 3, Name = "Pediatrics" };
        }

        private void SeedDoctors()
        {
            Doctor1 = new Doctor
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123-456-7890",
                Address = "123 Main St",
                City = "New York",
                Email = "johndoe@mail.com",
                SpecialtyId = Cardiology.Id
            };

            Doctor2 = new Doctor
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                PhoneNumber = "987-654-3210",
                Address = "456 Elm St",
                City = "Los Angeles",
                Email = "janesmith@mail.com",
                SpecialtyId = Neurology.Id
            };

            Doctor3 = new Doctor
            {
                Id = 3,
                FirstName = "Emma",
                LastName = "Brown",
                PhoneNumber = "555-555-5555",
                Address = "789 Oak St",
                City = "Chicago",
                Email = "emmabrown@mail.com",
                SpecialtyId = Pediatrics.Id
            };
        }

        private void SeedPatients()
        {
            Patient1 = new Patient
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Johnson",
                PhoneNumber = "111-111-1111",
                Address = "321 Pine St",
                Email = "alicejohnson@mail.com",
                DateOfBirth = new DateTime(1990, 5, 15)
            };

            Patient2 = new Patient
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Williams",
                PhoneNumber = "222-222-2222",
                Address = "654 Maple St",
                Email = "bobwilliams@mail.com",
                DateOfBirth = new DateTime(1985, 7, 10)
            };

            Patient3 = new Patient
            {
                Id = 3,
                FirstName = "Charlie",
                LastName = "Davis",
                PhoneNumber = "333-333-3333",
                Address = "987 Cedar St",
                Email = "charliedavis@mail.com",
                DateOfBirth = new DateTime(2000, 12, 25)
            };
        }

        private void SeedClinics()
        {
            Clinic1 = new Clinic
            {
                Id = 1,
                Name = "Downtown Clinic",
                Address = "111 Downtown St",
                PhoneNumber = "999-999-9999",
                WorkingHours = "9 - 19"
            };

            Clinic2 = new Clinic
            {
                Id = 2,
                Name = "Uptown Clinic",
                Address = "222 Uptown Ave",
                PhoneNumber = "888-888-8888",
                WorkingHours = "8 - 18"
            };
        }

        private void SeedAppointments()
        {
            Appointment1 = new Appointment
            {
                Id = 1,
                AppointmentDate = DateTime.UtcNow.AddDays(1),
                DoctorId = Doctor1.Id,
                PatientId = Patient1.Id,
                Status = "Scheduled",
                Notes = "Regular checkup"
            };

            Appointment2 = new Appointment
            {
                Id = 2,
                AppointmentDate = DateTime.UtcNow.AddDays(2),
                DoctorId = Doctor2.Id,
                PatientId = Patient2.Id,
                Status = "Scheduled",
                Notes = "Neurology consultation"
            };

            Appointment3 = new Appointment
            {
                Id = 3,
                AppointmentDate = DateTime.UtcNow.AddDays(3),
                DoctorId = Doctor3.Id,
                PatientId = Patient3.Id,
                Status = "Scheduled",
                Notes = "Pediatrics follow-up"
            };
        }

        private void SeedFeedbacks()
        {
            Feedback1 = new Feedback
            {
                Id = 1,
                AppointmentId = Appointment1.Id,
                PatientId = Patient1.Id,
                DoctorId= Doctor1.Id,
                Comments = "Great service!",
                Rating = 5,
                CreatedAt = DateTime.UtcNow
            };

            Feedback2 = new Feedback
            {
                Id = 2,
                AppointmentId = Appointment2.Id,
                PatientId = Patient2.Id,
                DoctorId = Doctor2.Id,
                Comments = "Very professional.",
                Rating = 4,
                CreatedAt = DateTime.UtcNow
            };
        }

        private void SeedMedicalRecords()
        {
            MedicalRecord1 = new MedicalRecord
            {
                Id = 1,
                PatientId = Patient1.Id,
                Condition = "Hypertension",
                DiagnosisDate = DateTime.UtcNow.AddYears(-2),
                Notes = "Monitor blood pressure regularly."
            };

            MedicalRecord2 = new MedicalRecord
            {
                Id = 2,
                PatientId = Patient2.Id,
                Condition = "Migraine",
                DiagnosisDate = DateTime.UtcNow.AddYears(-1),
                Notes = "Prescribed medication for migraines."
            };
        }

        private void SeedNotifications()
        {
            Notification1 = new Notification
            {
                Id = 1,
                UserId = PatientUser.Id,
                Message = "Your upcoming appointment is tomorrow.",
                DateTime = DateTime.UtcNow,
                IsRead = false
            };

            Notification2 = new Notification
            {
                Id = 2,
                UserId = AdminUser.Id,
                Message = "System maintenance scheduled.",
                DateTime = DateTime.UtcNow,
                IsRead = false
            };
        }

        private void SeedSchedules()
        {
            Schedule1 = new Schedule
            {
                Id = 1,
                DoctorId = Doctor1.Id,
                DayOfWeek = DayOfWeek.Monday,
                StartHour = new TimeSpan(9, 0, 0),
                EndHour = new TimeSpan(17, 0, 0)
            };

            Schedule2 = new Schedule
            {
                Id = 2,
                DoctorId = Doctor2.Id,
                DayOfWeek = DayOfWeek.Tuesday,
                StartHour = new TimeSpan(10, 0, 0),
                EndHour = new TimeSpan(18, 0, 0)
            };
        }
    }
}
