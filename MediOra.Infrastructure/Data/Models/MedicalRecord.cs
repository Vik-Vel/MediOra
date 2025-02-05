using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static MediOra.Infrastructure.Constants.DataConstants;

namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents a medical record for a patient, containing diagnosis history.
    /// </summary>
    [Comment("Table storing medical records for patients.")]
    public class MedicalRecord
    {
        /// <summary>
        /// Gets or sets the unique identifier for the medical record.
        /// </summary>
        [Key]
        [Comment("Identifier of the medical record.")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the patient associated with this medical record.
        /// </summary>
        [Required]
        [Comment("Identifier of the patient.")]
        public int PatientId { get; set; }

        /// <summary>
        /// Navigation property for the patient.
        /// </summary>
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; } = null!;

        /// <summary>
        /// Gets or sets the medical condition or diagnosis of the patient.
        /// </summary>
        [Required]
        [MaxLength(MedicalRecordConditionMaxLength)]
        [Comment("Medical condition or diagnosis of the patient.")]
        public required string Condition { get; set; }

        /// <summary>
        /// Gets or sets the date when the diagnosis was made.
        /// </summary>
        [Required]
        [Comment("Date when the diagnosis was recorded.")]
        public DateTime DiagnosisDate { get; set; }

        /// <summary>
        /// Gets or sets additional notes about the patient's condition.
        /// </summary>
        [MaxLength(MedicalRecordNotesMaxLength)]
        [Comment("Additional notes about the patient's condition.")]
        public string Notes { get; set; } = string.Empty;
    }
}
