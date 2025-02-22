using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Models.ViewModels;
using MediOra.Infrastructure.Data.Common;
using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MediOra.Core.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IRepository repository;

        public DoctorService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task<int> CreateAsync(DoctorViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DoctorViewModel>> GetAllAsync()
        {
            return await repository.AllReadOnly<Doctor>()
                .Select(d => new DoctorViewModel
                {
                    Id = d.Id,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    PhoneNumber = d.PhoneNumber,
                    Address = d.Address,
                    City = d.City,
                    Email = d.Email,
                    SpecialtyId = d.SpecialtyId,
                    SpecialtyName = d.Specialty.Name,
                    ImageUrl = d.ImageUrl,
                })
                .ToListAsync();
        }


        public Task<DoctorViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorViewModel>> GetBySpecialtyAsync(int specialtyId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DoctorViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
