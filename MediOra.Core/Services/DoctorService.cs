using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Enums;
using MediOra.Core.Models.ViewModels.Doctors;
using MediOra.Core.Models.ViewModels.Specialities;
using MediOra.Infrastructure.Data.Common;
using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace MediOra.Core.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IRepository repository;

        public DoctorService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddDoctorAsync(DoctorCreateViewModel model)
        {

            //create the doctor
            var doctor = new Doctor
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                SpecialtyId = model.SpecialtyId,
                City = model.City,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                ImageUrl = model.ImageUrl,
                Description = model.Description
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

        //For Get Method
        public async Task<DoctorEditViewModel> EditDoctorGetAsync(int doctorId)
        {
            var doctor = await repository.GetByIdAsync<Doctor>(doctorId);

            var specialties = await GetAllSpecialtiesAsync(); // ✅ Използваме новия метод

            var currentDoctor = new DoctorEditViewModel
            {
                Id = doctorId,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                PhoneNumber = doctor.PhoneNumber,
                Address = doctor.Address,
                City = doctor.City,
                Email = doctor.Email,
                ImageUrl = doctor.ImageUrl,
                Description = doctor.Description,
                SpecialtyId = doctor.SpecialtyId,
                Specialties = specialties
            };

            return currentDoctor;
        }




        public async Task<int> EditDoctorPostAsync(DoctorEditViewModel editDoctorForm)
        {
            var currentDoctor = await repository.GetByIdAsync<Doctor>(editDoctorForm.Id);

            currentDoctor.FirstName = editDoctorForm.FirstName;
            currentDoctor.LastName = editDoctorForm.LastName;
            currentDoctor.PhoneNumber = editDoctorForm.PhoneNumber;
            currentDoctor.Address = editDoctorForm.Address;
            currentDoctor.City = editDoctorForm.City;
            currentDoctor.Email = editDoctorForm.Email;
            currentDoctor.ImageUrl = editDoctorForm.ImageUrl;
            currentDoctor.Description = editDoctorForm.Description;
            currentDoctor.SpecialtyId = editDoctorForm.SpecialtyId; 

            await repository.SaveChangesAsync();
            return currentDoctor.Id;
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


        public async Task<DoctorViewModel> GetDoctorByIdAsync(int id)
        {
            var currentDoctor = await repository.GetByIdWithIncludesAsync<Doctor>(id, d => d.Specialty);

            var doct = new DoctorViewModel
            {
                Id = id,
                FirstName = currentDoctor.FirstName,
                LastName = currentDoctor.LastName,
                PhoneNumber = currentDoctor.PhoneNumber,
                Address = currentDoctor.Address,
                City = currentDoctor.City,
                Email = currentDoctor.Email,
                ImageUrl = currentDoctor.ImageUrl,
                SpecialtyId = currentDoctor.SpecialtyId,
                SpecialtyName = currentDoctor.Specialty.Name

            };


            return doct;
        }

        public Task<IEnumerable<DoctorViewModel>> GetBySpecialtyAsync(int specialtyId)
        {
            throw new NotImplementedException();
        }

           public async Task<IEnumerable<SpecialtyViewModel>> GetAllSpecialtiesAsync()
        {
            var specialties = await repository.AllReadOnly<Specialty>().ToListAsync();

            return specialties.Select(s => new SpecialtyViewModel
            {
                Id = s.Id,
                Name = s.Name
            }).ToList();
        }

    }
}
