using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Models.ViewModels.Doctors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class DoctorController : BaseController
    {
        private readonly IDoctorService doctorService;

        public DoctorController(IDoctorService _doctorService)
        {
            doctorService = _doctorService;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllDoctors()
        {
            var doctors = await doctorService.GetAllAsync();

            return View(doctors);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> DetailsDoctor(int id)
        {
            if (!await doctorService.ExistsAsync(id))
            {
                return BadRequest();
            }

            var doctor = await doctorService.DetailsAsync(id);

            return View(doctor);
        }

        public async Task<IActionResult> ManageAllDoctors()
        {
            var doctors = await doctorService.GetAllAsync();

            return View(doctors);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddDoctor()
        {
            var model = new DoctorCreateViewModel();

            return View(model);
        }

        [HttpPost]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddDoctor(DoctorCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await doctorService.AddDoctorAsync(model);
            return RedirectToAction(nameof(ManageAllDoctors));
        }

        [HttpGet]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> EditDoctor(int id)
        {
            var doctor = await doctorService.GetDoctorByIdAsync(id);

            if (doctor == null)
            {
                return BadRequest();
            }


            var doctorEditForm = await doctorService.EditDoctorGetAsync(id);
            return View(doctorEditForm);
        }

        [HttpPost]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> EditDoctor(DoctorEditViewModel doctorEditForm)
        {
            if (doctorEditForm == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(doctorEditForm);
            }

            var id = doctorEditForm.Id;
            await doctorService.EditDoctorPostAsync(doctorEditForm);
            return RedirectToAction(nameof(ManageAllDoctors), new { id });
        }
    }
}
