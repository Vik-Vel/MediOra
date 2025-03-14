using MediOra.Core.Models.ViewModels.Appointments;

namespace MediOra.Core.Contracts.Appointments
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentViewModel>> GetAllAsync();
        Task<AppointmentViewModel> GetByIdAsync(int appointmentId);
        Task CreateAsync(AppointmentViewModel model);
        Task UpdateAsync(AppointmentViewModel model);
        Task DeleteAsync(int appointmentId);
        Task<bool> ExistsAsync();
        Task<IEnumerable<AppointmentViewModel>> GetByDoctorAsync(int doctorId);
        Task<IEnumerable<AppointmentViewModel>> GetByPatientAsync(int patientId);
        Task<IEnumerable<AppointmentViewModel>> GetByDateRangeAsync(DateTime start, DateTime end);
        Task<IEnumerable<(string Value, string Text)>> GetAvailableDoctors();
        Task<IEnumerable<(string Value, string Text)>> GetAvailablePatients();
        Task<IEnumerable<(string Value, string Text)>> GetAvailableTimeSlots(int doctorId, DateTime date);
    }
}
