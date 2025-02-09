using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class FeedbackController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
