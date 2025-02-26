using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Contracts.Specialties;
using MediOra.Core.Models.ViewModels;
using MediOra.Core.Services;
using MediOra.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

        public async Task <IActionResult> ManageAllDoctors()
        {
            var doctors = await doctorService.GetAllAsync();

            return View(doctors);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task <IActionResult> AddDoctor()
        {
            var model = new DoctorCreateViewModel
            {
                Specialties = await doctorService.GetSpecialties()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task <IActionResult> AddDoctor(DoctorCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Specialties = await doctorService.GetSpecialties();
                return View(model);
            }

            await doctorService.AddDoctor(model);
            return RedirectToAction(nameof(ManageAllDoctors));
        }


    }
}
