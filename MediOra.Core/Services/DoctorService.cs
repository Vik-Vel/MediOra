using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Contracts.Specialties;
using MediOra.Core.Models.ViewModels;
using MediOra.Infrastructure.Data.Common;
using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace MediOra.Core.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IRepository repository;
        private readonly ISpecialtyService specialtyService;

        public DoctorService(IRepository _repository, ISpecialtyService _specialtyService)
        {
            repository = _repository;
            specialtyService = _specialtyService;
        }

        public async Task AddDoctor(DoctorCreateViewModel model)
        {
            //create the doctor
            var doctor = new Doctor
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                SpecialtyId = (int)model.SpecialtyId,
                City = model.City,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                ImageUrl = model.ImageUrl
            };

            await repository.AddAsync(doctor);
            await repository.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<DoctorViewModel> DetailsAsync(int doctorId)
        {
            Doctor? currentDoctor = await repository
                                          .All<Doctor>()
                                          .Include(d => d.Specialty) //  Зарежда Specialty заедно с Doctor
                                          .FirstOrDefaultAsync(d => d.Id == doctorId);

            // Doctor? currentDoctor = await repository.GetByIdAsync<Doctor>(doctorId);

            var currentDoctorDetails = new DoctorViewModel()
            {
                Id = currentDoctor.Id,
                FirstName = currentDoctor.FirstName,
                LastName = currentDoctor.LastName,
                PhoneNumber = currentDoctor.PhoneNumber,
                Address = currentDoctor.Address,
                City = currentDoctor.City,
                Email = currentDoctor.Email,
                ImageUrl = currentDoctor.ImageUrl,
                SpecialtyId = currentDoctor.SpecialtyId,
                SpecialtyName = currentDoctor.Specialty.Name,
                Description = currentDoctor.Description
            };

            return currentDoctorDetails;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnly<Doctor>()
                .AnyAsync(a => a.Id == id);
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

        public async Task<IEnumerable<SelectListItem>> GetSpecialties()
        {
            var specialties = await repository.AllReadOnly<Specialty>().ToListAsync();

            return specialties.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();
        }

        public Task UpdateAsync(DoctorViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
