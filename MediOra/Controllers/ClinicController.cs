using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class ClinicController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
