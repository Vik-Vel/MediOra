namespace MediOra.Core.Contracts.Appointments
{
    /// <summary>
    /// We use IAppointmentModel to define a common structure for appointment models that ensures 
    /// consistency and reduces code duplication across different ViewModels and services.
    /// </summary>
    public interface IAppointmentModel
    {
        int PatientId { get; set; }
        int DoctorId { get; set; }
        DateTime ScheduledTime { get; set; }
        int Duration { get; set; }
        string Status { get; set; }
        string Notes { get; set; }
    }
}