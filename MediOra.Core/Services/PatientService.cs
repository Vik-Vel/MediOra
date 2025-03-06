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

        public Task<PatientViewModel> DetailsAsync(int PatientId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
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
