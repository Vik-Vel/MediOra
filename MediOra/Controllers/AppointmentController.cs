using MediOra.Core.Contracts.Appointments;
using MediOra.Core.Models.ViewModels.Appointments;
using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentService appointmentService;

        public AppointmentController(IAppointmentService _appointmentService)
        {
            appointmentService = _appointmentService;
        }

        [HttpGet]
        public async Task<IActionResult> AllAppointments(DateTime? startDate, DateTime? endDate, int? doctorId, int? patientId)
        {
           
        }
    }
}
