using MediOra.Core.Models.ViewModels.Patients;
using MediOra.Core.Models.ViewModels.Specialities;

namespace MediOra.Core.Contracts.Patients
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientViewModel>> GetAllPatientsAsync();
        Task<PatientViewModel> GetPatientByIdAsync(int id);
        Task DeletePatientAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<PatientViewModel> DetailsAsync(int PatientId);
        //Task AddPatientAsync(PatientCreateViewModel model);
        //Task<PatientEditViewModel> EditPatientGetAsync(int PatientId);
        //Task<int> EditPatientPostAsync(PatientEditViewModel editPatientForm);
        //Task<IEnumerable<PatientViewModel>> GetFilteredPatientsAsync(string searchTerm, int? specialtyId);
    }
}
