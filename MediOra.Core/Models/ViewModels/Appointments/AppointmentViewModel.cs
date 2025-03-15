namespace MediOra.Core.Models.ViewModels.Appointments
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; } 
        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }   
}