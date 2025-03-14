using MediOra.Core.Contracts.Appointments;
using MediOra.Core.Models.ViewModels.Appointments;

namespace MediOra.Core.Services
{
    public class AppointmentService : IAppointmentService
    {
        public Task CreateAsync(AppointmentViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppointmentViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<(string Value, string Text)>> GetAvailableDoctors()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<(string Value, string Text)>> GetAvailablePatients()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<(string Value, string Text)>> GetAvailableTimeSlots(int doctorId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppointmentViewModel>> GetByDateRangeAsync(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppointmentViewModel>> GetByDoctorAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<AppointmentViewModel> GetByIdAsync(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppointmentViewModel>> GetByPatientAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AppointmentViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
