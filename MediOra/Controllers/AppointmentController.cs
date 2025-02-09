using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class AppointmentController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
