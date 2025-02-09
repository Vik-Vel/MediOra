using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class DoctorController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
