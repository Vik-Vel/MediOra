using Microsoft.EntityFrameworkCore;

namespace MediOra.Infrastructure.Data.Models.Mappings
{
    /// <summary>
    /// Represents the relationship between doctors and feedback.
    /// This class maps feedback entries to the doctors they are related to.
    /// </summary>
    [Comment("Mapping table for doctors and feedback.")]
    public class DoctorFeedback
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
        /// Gets or sets the identifier of the feedback.
        /// </summary>
        [Comment("Identifier of the feedback.")]
        public int FeedbackId { get; set; }

        /// <summary>
        /// Navigation property for the feedback.
        /// </summary>
        public Feedback Feedback { get; set; } = null!;
    }
}
