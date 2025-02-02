using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MediOra.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents the schedule of a doctor for specific days and hours.
    /// </summary>
    [Comment("Represents the schedule of a doctor.")]
    public class Schedule
    {
        /// <summary>
        /// Gets or sets the unique identifier for the schedule.
        /// </summary>
        [Key]
        [Comment("Identifier of the schedule.")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the doctor associated with this schedule.
        /// </summary>
        [Required]
        [Comment("Identifier of the doctor.")]
        public int DoctorId { get; set; }

        /// <summary>
        /// Navigation property for the doctor.
        /// </summary>
        public Doctor Doctor { get; set; } = null!;

        /// <summary>
        /// Gets or sets the day of the week for the schedule.
        /// </summary>
        [Required]
        [Comment("Day of the week for the schedule.")]
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the starting hour of the schedule.
        /// </summary>
        [Required]
        [Comment("Starting hour of the schedule.")]
        public TimeSpan StartHour { get; set; }

        /// <summary>
        /// Gets or sets the ending hour of the schedule.
        /// </summary>
        [Required]
        [Comment("Ending hour of the schedule.")]
        public TimeSpan EndHour { get; set; }
    }
}
