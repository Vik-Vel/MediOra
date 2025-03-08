namespace MediOra.Core.Contracts.Patients
{
    public interface IPatientModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Email { get; set; }
        DateTime DateOfBirth { get; set; }
        string? ImageUrl { get; set; }
    }
}
