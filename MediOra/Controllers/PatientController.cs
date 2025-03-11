using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Contracts.Patients;
using MediOra.Core.Models.ViewModels.Doctors;
using MediOra.Core.Models.ViewModels.Patients;
using MediOra.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediOra.Controllers
{
    public class PatientController : BaseController
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService _patientService)
        {
            patientService = _patientService;
        }

        [HttpGet]
        public async Task<IActionResult> ManageAllPatients()
        {
            var patients = await patientService.GetAllPatientsAsync();

            return View(patients);
        }


        [HttpGet]
        public async Task<IActionResult> DetailsPatient(int patientId)
        {
            if (!await patientService.ExistsPatientAsync(patientId))
            {
                return BadRequest();
            }

            var patient = await patientService.DetailsPatientAsync(patientId);

            return View(patient);
        }

        [HttpGet]
        public async Task<IActionResult> EditPatient(int patientId)
        {
            var patientEditForm = await patientService.EditPatientGetAsync(patientId);

            if (patientEditForm == null)
            {
                return NotFound();
            }

            return View(patientEditForm);
        }

        [HttpPost]
        public async Task<IActionResult> EditPatient(PatientEditViewModel patientEditForm)
        {
            if (patientEditForm == null)
            {
                return NotFound();

            }

            if (!ModelState.IsValid)
            {
                return View(patientEditForm);
            }

            var id = patientEditForm.Id;
            await patientService.EditPatientPostAsync(patientEditForm);
            return RedirectToAction(nameof(ManageAllPatients), new { id });

        }

        [HttpGet]
        public async Task<IActionResult> DeletePatient(int patientId)
        {
            var patient = await patientService.GetPatientByIdAsync(patientId);

            if (patient != null)
            {
                return NotFound();
            }

            return View(patient);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDeleteDoctor(int patientId)
        {

            if (!await patientService.ExistsPatientAsync(patientId))
            {
                return BadRequest();
            }

            await patientService.DeletePatientAsync(patientId);

            TempData["SuccessMessage"] = "The patient was successfully deleted.";
            return RedirectToAction(nameof(ManageAllPatients));
        }

    }
}
