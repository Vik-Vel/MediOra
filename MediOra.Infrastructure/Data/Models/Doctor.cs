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
    }
}
