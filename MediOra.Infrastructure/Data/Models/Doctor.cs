using MediOra.Infrastructure.Data.Models.Mappings;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MediOra.Infrastructure.Constants.DataConstants;

namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents a doctor with their personal and professional information.
    /// </summary>
    [Comment("Doctor's information")]
    public class Doctor
    {
        /// <summary>
        /// Gets or sets the unique identifier for the doctor.
        /// </summary>
        [Key]
        [Comment("Doctor's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the doctor's first name.
        /// </summary>
        [Required]
        [MaxLength(DoctorFirstNameMaxLength)]
        [Comment("Doctor's First Name")]
        public required string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the doctor's last name.
        /// </summary>
        [Required]
        [MaxLength(DoctorLastNameMaxLength)]
        [Comment("Doctor's Last Name")]
        public required string LastName { get; set; }

        /// <summary>
        /// Gets or sets the doctor's phone number.
        /// </summary>
        [Required]
        [MaxLength(DoctorPhoneNumberMaxLength)]
        [Comment("Doctor's Phone number")]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the doctor's address.
        /// </summary>
        [Required]
        [MaxLength(DoctorAddressMaxLength)]
        [Comment("Doctor's Address")]
        public required string Address { get; set; }

        /// <summary>
        /// Gets or sets the city where the doctor practices.
        /// </summary>
        [Required]
        [MaxLength(DoctorCityMaxLength)]
        [Comment("Doctor's City")]
        public required string City { get; set; }

        /// <summary>
        /// Gets or sets the doctor's email address.
        /// </summary>
        [Required]
        [MaxLength(DoctorEmailMaxLength)]
        [Comment("Doctor's Email")]
        public required string Email { get; set; }

        /// <summary>
        /// Gets or sets the URL or path to the doctor's profile image.
        /// </summary>
        [MaxLength(DoctorImageUrlMaxLength)]
        [Comment("Doctor's Profile Image URL")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the doctor's description.
        /// </summary>
        [MaxLength(DoctorDescriptionMaxLength)]
        [Comment("Doctor's Description")]
        public string? Description {get; set; }

        /// <summary>
        /// Gets or sets the identifier for the doctor's specialty.
        /// </summary>
        [Required]
        [Comment("Doctor's Specialty Identifier")]
        public int SpecialtyId { get; set; }

        /// <summary>
        /// Gets or sets the specialty of the doctor.
        /// </summary>
        [ForeignKey(nameof(SpecialtyId))]
        public Specialty Specialty { get; set; } = null!;


        /// <summary>
        /// Gets or sets the list of patients associated with the doctor.
        /// </summary>
        [Comment("Doctor's Patients")]
        public List<Patient> Patients { get; set; } = new List<Patient>();


        /// <summary>
        /// Gets or sets the collection of clinics where the doctor works.
        /// This represents a many-to-many relationship between doctors and clinics.
        /// </summary>
        [Comment("Clinics associated with the doctor.")]
        public List<DoctorClinic> DoctorClinics { get; set; } = new List<DoctorClinic>();

        /// <summary>
        /// Navigation property for the schedules of the doctor.
        /// </summary>
        [Comment("Schedules assigned to the doctor.")]
        public List<Schedule> Schedules { get; set; } = new List<Schedule>();

        /// <summary>
        /// Gets or sets the list of appointments associated with the doctor.
        /// </summary>
        [Comment("Appointments assigned to the doctor.")]
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
