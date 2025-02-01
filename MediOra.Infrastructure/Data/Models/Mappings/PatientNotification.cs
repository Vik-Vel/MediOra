using Microsoft.EntityFrameworkCore;

namespace MediOra.Infrastructure.Data.Models.Mappings
{
    /// <summary>
    /// Represents the relationship between patients and notifications.
    /// This class maps notifications to the patients who received them.
    /// </summary>
    [Comment("Mapping table for patients and notifications.")]
    public class PatientNotification
    {
        /// <summary>
        /// Gets or sets the identifier of the patient.
        /// </summary>
        [Comment("Identifier of the patient.")]
        public int PatientId { get; set; }

        /// <summary>
        /// Navigation property for the patient.
        /// </summary>
        public Patient Patient { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the notification.
        /// </summary>
        [Comment("Identifier of the notification.")]
        public int NotificationId { get; set; }

        /// <summary>
        /// Navigation property for the notification.
        /// </summary>
        public Notification Notification { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date when the notification was sent.
        /// </summary>
        [Comment("Date the notification was sent.")]
        public DateTime SentDate { get; set; }
    }
}
