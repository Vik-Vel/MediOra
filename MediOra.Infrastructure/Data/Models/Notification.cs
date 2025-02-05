using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static MediOra.Infrastructure.Constants.DataConstants;

namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents a notification sent to a user for upcoming appointments or events.
    /// </summary>
    [Comment("Table storing notifications for users about upcoming events or reminders.")]
    public class Notification
    {
        /// <summary>
        /// Gets or sets the unique identifier for the notification.
        /// </summary>
        [Key]
        [Comment("Identifier of the notification.")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who receives the notification.
        /// </summary>
        [Required]
        [Comment("Identifier of the user receiving the notification.")]
        public int UserId { get; set; }

        /// <summary>
        /// Navigation property for the user.
        /// </summary>
        public IdentityUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the message content of the notification.
        /// </summary>
        [Required]
        [MaxLength(200)]
        [Comment("Message content of the notification.")]
        public required string Message { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the notification.
        /// </summary>
        [Required]
        [Comment("Date and time when the notification was sent.")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether the notification has been read.
        /// </summary>
        [Required]
        [Comment("Indicates whether the notification has been read.")]
        public bool IsRead { get; set; } = false;
    }
}
