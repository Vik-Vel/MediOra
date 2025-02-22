using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MediOra.Infrastructure.Constants.DataConstants;


namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents a patient with their personal information.
    /// </summary>
    [Comment("Patient's information")]
    public class Patient
    {
        /// <summary>
        /// Gets or sets the unique identifier for the Patient.
        /// </summary>
        [Key]
        [Comment("Patient's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Patient's first name.
        /// </summary>
        [Required]
        [MaxLength(PatientFirstNameMaxLength)]
        [Comment("Patient's First Name")]
        public required string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Patient's last name.
        /// </summary>
        [Required]
        [MaxLength(PatientLastNameMaxLength)]
        [Comment("Patient's Last Name")]
        public required string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Patient's phone number.
        /// </summary>
        [Required]
        [MaxLength(PatientPhoneNumberMaxLength)]
        [Comment("Patient's Phone number")]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the Patient's address.
        /// </summary>
        [Required]
        [MaxLength(PatientAddressMaxLength)]
        [Comment("Patient's Address")]
        public required string Address { get; set; }

        /// <summary>
        /// Gets or sets the Patient's email address.
        /// </summary>
        [Required]
        [MaxLength(PatientEmailMaxLength)]
        [Comment("Patient's Email")]
        public required string Email { get; set; }

        /// <summary>
        /// Gets or sets the Patient's date of birth.
        /// </summary>
        [Required]
        [Comment("Patient's Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the URL or path to the patient's profile image.
        /// </summary>
        [MaxLength(PatientImageUrlMaxLength)]
        [Comment("Patient's Profile Image URL")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the list of appointments assigned to the Patient.
        /// </summary>
        [Comment("Patient's Appointments")]
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        /// <summary>
        /// Navigation property for the patient's medical records.
        /// </summary>
        [Comment("Medical records associated with the patient.")]
        public List<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

        /// <summary>
        /// Navigation property for the feedbacks provided by the patient.
        /// </summary>
        [Comment("Feedbacks given by the patient.")]
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
