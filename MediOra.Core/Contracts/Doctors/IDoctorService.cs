using MediOra.Core.Models.ViewModels;
using System.Web.Mvc;

namespace MediOra.Core.Contracts.Doctors
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorViewModel>> GetAllAsync();
        Task<DoctorViewModel> GetByIdAsync(int id);
        Task UpdateAsync(DoctorViewModel model);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<IEnumerable<DoctorViewModel>> GetBySpecialtyAsync(int specialtyId);
        Task<DoctorViewModel> DetailsAsync(int articleId);

        Task<IEnumerable<SelectListItem>> GetSpecialties();
        Task AddDoctor(DoctorCreateViewModel model);
    }
}
