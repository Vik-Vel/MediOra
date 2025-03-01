namespace MediOra.Core.Contracts.Doctors
{
    /// <summary>
    /// We use IDoctorModel to define a common structure for doctor models that ensures consistency and reduces code duplication across different ViewModels and services.
    /// </summary>
    public interface IDoctorModel
    {
            string FirstName { get; set; }
            string LastName { get; set; }
            string PhoneNumber { get; set; }
            string Address { get; set; }
            string City { get; set; }
            string Email { get; set; }
            string? ImageUrl { get; set; }
            string? Description { get; set; }
            int SpecialtyId { get; set; }

    }
}
