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
        public async Task<IActionResult> AllDoctors(string searchTerm, int? specialtyId)
        {
            var doctors = await doctorService.GetFilteredDoctorsAsync(searchTerm, specialtyId);

            var specialties = await doctorService.GetAllSpecialtiesAsync(); // Взимаме специалностите за dropdown

            ViewBag.Specialties = specialties; // Изпращаме специалностите към View-то

            return View(doctors);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> DetailsDoctor(int doctorId)
        {
            if (!await doctorService.ExistsAsync(doctorId))
            {
                return BadRequest();
            }

            var doctor = await doctorService.DetailsDoctorAsync(doctorId);

            return View(doctor);
        }

        [HttpGet]
        public async Task<IActionResult> ManageAllDoctors()
        {
            var doctors = await doctorService.GetAllDoctorsAsync();

            return View(doctors);
        }

        [HttpGet]
        public async Task<IActionResult> AddDoctor()
        {
            var model = new DoctorCreateViewModel
            {
                Specialties = await doctorService.GetAllSpecialtiesAsync() // Takes all specialties
            };

            return View(model);
        }

        [HttpPost]
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
        public async Task<IActionResult> EditDoctor(int doctorId)
        {
            var doctorEditForm = await doctorService.EditDoctorGetAsync(doctorId);

            if (doctorEditForm == null)
            {
                return NotFound();
            }

            return View(doctorEditForm);
        }

        [HttpPost]
        public async Task<IActionResult> EditDoctor(DoctorEditViewModel doctorEditForm)
        {
            if (doctorEditForm == null)
            {
                return NotFound();

            }

            if (!ModelState.IsValid)
            {
                return View(doctorEditForm);
            }

            var id = doctorEditForm.Id;
            await doctorService.EditDoctorPostAsync(doctorEditForm);
            return RedirectToAction(nameof(ManageAllDoctors), new { id });

        }

        [HttpGet]
        public async Task<IActionResult> DeleteDoctor(int doctorId)
        {
            var doctor = await doctorService.GetDoctorByIdAsync(doctorId);

            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDeleteDoctor(int doctorId)
        {

            if (!await doctorService.ExistsAsync(doctorId))
            {
                return BadRequest();
            }

            await doctorService.DeleteDoctorAsync(doctorId);

            TempData["SuccessMessage"] = "The doctor was successfully deleted.";
            return RedirectToAction(nameof(ManageAllDoctors));
        }
    }
}
