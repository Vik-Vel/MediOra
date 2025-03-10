using MediOra.Core.Contracts.Patients;
using MediOra.Core.Models.ViewModels.Patients;
using MediOra.Infrastructure.Data.Common;
using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MediOra.Core.Services
{
    public class PatientService : IPatientService
    {
        private readonly IRepository repository;

        public PatientService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task DeletePatientAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PatientViewModel> DetailsPatientAsync(int patientId)
        {
            Patient? currentPatient = await repository.GetByIdAsync<Patient>(patientId);

            if (currentPatient == null)
            {
                throw new InvalidOperationException($"Patient with ID {patientId} not found.");
            }

            var currentPatientDetails = new PatientViewModel()
            {
                Id = currentPatient.Id,
                FirstName = currentPatient.FirstName,
                LastName = currentPatient.LastName,
                PhoneNumber = currentPatient.PhoneNumber,
                Address = currentPatient.Address,
                City = currentPatient.City,
                Email = currentPatient.Email,
                ImageUrl = currentPatient.ImageUrl,
                DateOfBirth = currentPatient.DateOfBirth,
            };

            return currentPatientDetails;
        }

        public async Task<PatientEditViewModel> EditPatientGetAsync(int patientId)
        {
            var patient = await repository.GetByIdAsync<Patient>(patientId);

            if(patient == null)
            {
                throw new InvalidOperationException($"Patient with ID {patientId} not found.");
            }

            var currentPatient = new PatientEditViewModel
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                PhoneNumber = patient.PhoneNumber,
                Address = patient.Address,
                City = patient.City,
                Email = patient.Email,
                ImageUrl = patient.ImageUrl,
                DateOfBirth = patient.DateOfBirth,
            };

            return currentPatient;
        }

        public async Task<int> EditPatientPostAsync(PatientEditViewModel editPatientForm)
        {
            var patient = await repository.GetByIdAsync<Patient>(editPatientForm.Id);

            if (patient == null)
            {
                throw new InvalidOperationException($"Patient with ID {patient.Id} not found.");
            }

            patient.FirstName = editPatientForm.FirstName;
            patient.LastName = editPatientForm.LastName;
            patient.PhoneNumber = editPatientForm.PhoneNumber;
            patient.Address = editPatientForm.Address;
            patient.City = editPatientForm.City;
            patient.Email = editPatientForm.Email;
            patient.ImageUrl = editPatientForm.ImageUrl;
            patient.ImageUrl = editPatientForm.ImageUrl;

            await repository.SaveChangesAsync();
            return patient.Id;
        }

        public async Task<bool> ExistsPatientAsync(int id)
        {
            return await repository.AllReadOnly<Patient>()
                .AnyAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<PatientViewModel>> GetAllPatientsAsync()
        {
            return await repository.AllReadOnly<Patient>()
                .Select(p=> new PatientViewModel
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    PhoneNumber = p.PhoneNumber,
                    City = p.City,
                    Email = p.Email,
                    Address = p.Address,
                    ImageUrl = p.ImageUrl,
                    DateOfBirth = p.DateOfBirth,
                })
                .ToListAsync();
        }

        public Task<PatientViewModel> GetPatientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
