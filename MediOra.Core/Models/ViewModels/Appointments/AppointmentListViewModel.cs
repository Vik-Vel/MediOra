using MediOra.Core.Contracts.Appointments;

namespace MediOra.Core.Models.ViewModels.Appointments
{
    public class AppointmentListViewModel : IAppointmentModel
    {
        public int PatientId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DoctorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ScheduledTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<AppointmentViewModel> Appointments { get; set; } = Enumerable.Empty<AppointmentViewModel>();
    }
}
