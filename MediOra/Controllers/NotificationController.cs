using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class NotificationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
