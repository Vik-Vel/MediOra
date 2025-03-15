using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static MediOra.Infrastructure.Constants.DataConstants;

/// <summary>
/// Represents an appointment between a doctor and a patient.
/// </summary>
[Comment("Appointment's information")]
public class Appointment
{
    /// <summary>
    /// Gets or sets the unique identifier for the appointment.
    /// </summary>
    [Key]
    [Comment("Appointment's Identifier")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the scheduled date and time of the appointment.
    /// </summary>
    [Required]
    [Comment("Appointment's Date and Time")]
    public DateTime ScheduledTime { get; set; }

    /// <summary>
    /// Gets or sets the duration of the appointment in minutes.
    /// </summary>
    [Required]
    [Comment("Duration in minutes")]
    public int Duration { get; set; } = 30;

    /// <summary>
    /// Gets or sets the status of the appointment (e.g., Scheduled, Completed, Cancelled).
    /// </summary>
    [Required]
    [MaxLength(AppointmentStatusMaxLength)]
    [Comment("Appointment's Status")]
    public string Status { get; set; } = "Scheduled";

    /// <summary>
    /// Gets or sets any additional notes related to the appointment.
    /// </summary>
    [MaxLength(AppointmentNotesMaxLength)]
    [Comment("Appointment's Notes")]
    public string Notes { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the identifier of the doctor assigned to this appointment.
    /// </summary>
    [Required]
    [Comment("Doctor's Identifier")]
    public int DoctorId { get; set; }

    /// <summary>
    /// Navigation property for the doctor assigned to this appointment.
    /// </summary>
    [ForeignKey(nameof(DoctorId))]
    public Doctor Doctor { get; set; } = null!;

    /// <summary>
    /// Gets or sets the identifier of the patient assigned to this appointment.
    /// </summary>
    [Required]
    [Comment("Patient's Identifier")]
    public int PatientId { get; set; }

    /// <summary>
    /// Navigation property for the patient assigned to this appointment.
    /// </summary>
    [ForeignKey(nameof(PatientId))]
    public Patient Patient { get; set; } = null!;

    /// <summary>
    /// Navigation property for the feedback associated with this appointment.
    /// </summary>
    [Comment("Feedback related to this appointment.")]
    public Feedback? Feedback { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the appointment was created in the system.
    /// </summary>
    [Required]
    [Comment("Date and time when the appointment was created")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}