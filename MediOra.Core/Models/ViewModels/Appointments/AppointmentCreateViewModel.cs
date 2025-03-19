using MediOra.Core.Contracts.Appointments;

namespace MediOra.Core.Models.ViewModels.Appointments
{
    public class AppointmentCreateViewModel : IAppointmentModel
    {
        public int PatientId { get ; set ; }
        public int DoctorId { get; set; }
        public DateTime ScheduledTime { get; set; }
        public int Duration { get; set; }
        public string Status { get ; set ; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}