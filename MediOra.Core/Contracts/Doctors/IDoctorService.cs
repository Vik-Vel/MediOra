﻿using MediOra.Core.Models.ViewModels.Doctors;
using MediOra.Core.Models.ViewModels.Specialities;
using MediOra.Infrastructure.Data.Models;
using System.Web.Mvc;

namespace MediOra.Core.Contracts.Doctors
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorViewModel>> GetAllAsync();
        Task<DoctorViewModel> GetDoctorByIdAsync(int id);
        Task DeleteDoctorAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<IEnumerable<DoctorViewModel>> GetBySpecialtyAsync(int specialtyId);
        Task<DoctorViewModel> DetailsAsync(int doctorId);
        Task AddDoctorAsync(DoctorCreateViewModel model);
        Task<DoctorEditViewModel> EditDoctorGetAsync(int doctorId);
        Task<int> EditDoctorPostAsync(DoctorEditViewModel editDoctorForm);
        Task<IEnumerable<SpecialtyViewModel>> GetAllSpecialtiesAsync();

    }
}
