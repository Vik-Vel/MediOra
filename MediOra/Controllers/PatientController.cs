using MediOra.Core.Contracts.Patients;
using MediOra.Core.Services;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> AllPatients()
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
    }
}
