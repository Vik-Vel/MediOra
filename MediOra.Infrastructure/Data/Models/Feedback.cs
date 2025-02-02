using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static MediOra.Infrastructure.Constants.DataConstants;

namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents patient feedback for a medical appointment.
    /// </summary>
    [Comment("Table storing feedback from patients about appointments.")]
    public class Feedback
    {
        /// <summary>
        /// Gets or sets the unique identifier for the feedback.
        /// </summary>
        [Key]
        [Comment("Identifier of the feedback.")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the related appointment.
        /// </summary>
        [Required]
        [Comment("Identifier of the associated appointment.")]
        public int AppointmentId { get; set; }

        /// <summary>
        /// Navigation property for the related appointment.
        /// </summary>
        public Appointment Appointment { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the patient providing the feedback.
        /// </summary>
        [Required]
        [Comment("Identifier of the patient providing the feedback.")]
        public int PatientId { get; set; }

        /// <summary>
        /// Navigation property for the patient.
        /// </summary>
        public Patient Patient { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the doctor receiving the feedback.
        /// </summary>
        [Required]
        [Comment("Identifier of the doctor who received the feedback.")]
        public int DoctorId { get; set; }

        /// <summary>
        /// Navigation property for the doctor.
        /// </summary>
        public Doctor Doctor { get; set; } = null!;

        /// <summary>
        /// Gets or sets the comments provided by the patient.
        /// </summary>
        [MaxLength(FeedbackCommentsMaxLength)]
        [Comment("Comments provided by the patient.")]
        public string Comments { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the rating given by the patient (1-5).
        /// </summary>
        [Required]
        [Range(FeedbackRatingMinRange, FeedbackRatingMaxRange)]
        [Comment("Rating provided by the patient MinRange-MaxRange).")]
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the feedback was created.
        /// </summary>
        [Required]
        [Comment("Date and time when the feedback was created.")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Indicates whether the feedback is anonymous.
        /// </summary>
        [Comment("Indicates whether the feedback is anonymous.")]
        public bool IsAnonymous { get; set; } = false;
    }
}
