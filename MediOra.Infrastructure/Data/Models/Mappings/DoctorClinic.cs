using Microsoft.EntityFrameworkCore;

namespace MediOra.Infrastructure.Data.Models.Mappings
{
    /// <summary>
    /// Represents the relationship between doctors and clinics.
    /// This class maps doctors to the clinics where they work.
    /// </summary>
    [Comment("Mapping table for doctors and clinics.")]
    public class DoctorClinic
    {
        /// <summary>
        /// Gets or sets the identifier of the doctor.
        /// </summary>
        [Comment("Identifier of the doctor.")]
        public int DoctorId { get; set; }

        /// <summary>
        /// Navigation property for the doctor.
        /// </summary>
        public Doctor Doctor { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the clinic.
        /// </summary>
        [Comment("Identifier of the clinic.")]
        public int ClinicId { get; set; }

        /// <summary>
        /// Navigation property for the clinic.
        /// </summary>
        public Clinic Clinic { get; set; } = null!;
    }
}
