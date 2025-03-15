namespace MediOra.Core.Models.ViewModels.Appointments
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public DateTime ScheduledTime { get; set; }
        public int Duration { get; set; } 
        public string Status { get; set; } // Scheduled, Completed, Cancelled, etc.
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
