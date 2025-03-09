using MediOra.Core.Models.ViewModels.Patients;
using MediOra.Core.Models.ViewModels.Specialities;

namespace MediOra.Core.Contracts.Patients
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientViewModel>> GetAllPatientsAsync();
        Task<PatientViewModel> GetPatientByIdAsync(int id);
        Task DeletePatientAsync(int id);
        Task<bool> ExistsPatientAsync(int id);
        Task<PatientViewModel> DetailsPatientAsync(int patientId);
        //Task AddPatientAsync(PatientCreateViewModel model);
        Task<PatientEditViewModel> EditPatientGetAsync(int patientId);
        Task<int> EditPatientPostAsync(PatientEditViewModel editPatientForm);
        //Task<IEnumerable<PatientViewModel>> GetFilteredPatientsAsync(string searchTerm, int? specialtyId);
    }
}
