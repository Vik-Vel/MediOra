using MediOra.Core.Models.ViewModels.Home;
using MediOra.Data;
using MediOra.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MediOra.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var totalDoctors = _context.Doctors.Count(); // Вместо repository
            var totalPatients = _context.Patients.Count();
            var totalAppointments = _context.Appointments.Count();
            var totalFeedbacks = _context.Feedbacks.Count();
            var totalClinics = _context.Clinics.Count();

            var model = new HomePageViewModel
            {
                TotalDoctors = totalDoctors,
                TotalPatients = totalPatients,
                TotalAppointments = totalAppointments,
                TotalFeedbacks = totalFeedbacks,
                TotalClinics = totalClinics
            };

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
