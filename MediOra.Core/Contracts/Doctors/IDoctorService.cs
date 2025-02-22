using MediOra.Core.Models.ViewModels;

namespace MediOra.Core.Contracts.Doctors
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorViewModel>> GetAllAsync();
        Task<DoctorViewModel> GetByIdAsync(int id);
        Task<int> CreateAsync(DoctorViewModel model);
        Task UpdateAsync(DoctorViewModel model);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<IEnumerable<DoctorViewModel>> GetBySpecialtyAsync(int specialtyId);
    }
}
