using MediOra.Infrastructure.Data.Models.Mappings;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MediOra.Infrastructure.Constants.DataConstants;

namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents a medical clinic where doctors work.
    /// </summary>
    [Comment("Table storing information about medical clinics.")]
    public class Clinic
    {
        /// <summary>
        /// Gets or sets the unique identifier for the clinic.
        /// </summary>
        [Key]
        [Comment("Identifier of the clinic.")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the clinic.
        /// </summary>
        [Required]
        [MaxLength(ClinicNameMaxLength)]
        [Comment("Name of the clinic.")]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the clinic.
        /// </summary>
        [Required]
        [MaxLength(ClinicPhoneNumberMaxLength)]
        [Comment("Phone number of the clinic.")]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the address of the clinic.
        /// </summary>
        [Required]
        [MaxLength(ClinicAddressMaxLength)]
        [Comment("Address of the clinic.")]
        public required string Address { get; set; }

        /// <summary>
        /// Gets or sets the working hours of the clinic.
        /// </summary>
        [Required]
        [MaxLength(ClinicWorkingHoursMaxLength)]
        [Comment("Working hours of the clinic.")]
        public required string WorkingHours { get; set; }

        /// <summary>
        /// Gets or sets the collection of doctors working in the clinic.
        /// This represents a many-to-many relationship between doctors and clinics.
        /// </summary>
        [Comment("Doctors associated with the clinic.")]
        public List<DoctorClinic> DoctorClinics { get; set; } = new List<DoctorClinic>();
    }
}
