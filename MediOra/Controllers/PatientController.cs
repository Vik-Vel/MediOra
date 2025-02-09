using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class PatientController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
