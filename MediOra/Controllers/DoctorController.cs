using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Contracts.Specialties;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MediOra.Controllers
{
    public class DoctorController : BaseController
    {
        private readonly IDoctorService doctorService;
        //private readonly ISpecialtyService specialtyService;

        public DoctorController(IDoctorService _doctorService/*, ISpecialtyService _specialtyService*/)
        {
            doctorService = _doctorService;
           // specialtyService = _specialtyService;

        }
        public async Task<IActionResult> All(string searchTerm, int? specialtyId, string city)
        {
            var doctors = await doctorService.GetAllAsync();

            return View(doctors);
        }
    }
}
