using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static MediOra.Infrastructure.Constants.DataConstants;

namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents a medical specialty that doctors can be associated with.
    /// </summary>
    [Comment("Represents a medical specialty.")]
    public class Specialty
    {
        /// <summary>
        /// Gets or sets the unique identifier for the specialty.
        /// </summary>
        [Key]
        [Comment("Identifier of the specialty.")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the specialty (e.g., Cardiology, Neurology).
        /// </summary>
        [Required]
        [MaxLength(SpecialtyNameMaxLength)]
        [Comment("Name of the medical specialty.")]
        public required string Name { get; set; }

        /// <summary>
        /// Navigation property for the list of doctors that belong to this specialty.
        /// </summary>
        [Comment("Doctors associated with this specialty.")]
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
