using MediOra.Core.Models.ViewModels.Appointments;

namespace MediOra.Core.Contracts.Appointments
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentViewModel>> GetAllAsync();
        Task<IEnumerable<AppointmentViewModel>> GetFilteredAsync(DateTime? startDate, DateTime? endDate, int? doctorId, int? patientId);
        Task<AppointmentViewModel> GetByIdAsync(int id);
        Task CreateAsync(AppointmentCreateViewModel model);
        Task UpdateAsync(AppointmentViewModel model);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<Dictionary<string, int>> GetAppointmentStatisticsAsync();
        Task<IEnumerable<AppointmentViewModel>> GetUpcomingAppointmentsAsync(int count);
        Task<IEnumerable<AppointmentViewModel>> GetAppointmentsByDoctorAsync(int doctorId);
        Task<IEnumerable<AppointmentViewModel>> GetAppointmentsByPatientAsync(int patientId);
        Task<bool> IsTimeSlotAvailableAsync(int doctorId, DateTime scheduledTime, int duration, int? excludeAppointmentId = null);
        Task CancelAppointmentAsync(int id, string reason);
        Task CompleteAppointmentAsync(int id, string notes);
    }
}
