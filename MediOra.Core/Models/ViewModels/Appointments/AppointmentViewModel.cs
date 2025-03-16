using MediOra.Core.Contracts.Appointments;

namespace MediOra.Core.Models.ViewModels.Appointments
{
    public class AppointmentViewModel : IAppointmentModel
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } = string.Empty;
        public DateTime ScheduledTime { get; set; }
        public int Duration { get; set; }
        public string Status { get; set; } = string.Empty; // Scheduled, Completed, Cancelled, etc.
        public string Notes { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
