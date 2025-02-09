using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
      
    }
}
