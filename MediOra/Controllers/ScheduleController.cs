using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class ScheduleController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
