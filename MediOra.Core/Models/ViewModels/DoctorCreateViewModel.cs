using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using static MediOra.Core.Constants.MessageConstants;
using static MediOra.Infrastructure.Constants.DataConstants;

public class DoctorCreateViewModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(DoctorFirstNameMaxLength,
       MinimumLength = DoctorFirstNameMinLength,
       ErrorMessage = LengthMessage)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(DoctorLastNameMaxLength,
       MinimumLength = DoctorLastNameMinLength,
       ErrorMessage = LengthMessage)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;
    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(DoctorPhoneNumberMaxLength,
       MinimumLength = DoctorPhoneNumberMinLength,
       ErrorMessage = LengthMessage)]
    [Display(Name = "Phone Number")]
    [Phone]
    public string PhoneNumber { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(DoctorAddressMaxLength,
       MinimumLength = DoctorAddressMinLength,
       ErrorMessage = LengthMessage)]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(DoctorCityMaxLength,
       MinimumLength = DoctorCityMinLength,
       ErrorMessage = LengthMessage)]
    public string City { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [EmailAddress]
    [StringLength(DoctorEmailMaxLength,
       MinimumLength = DoctorEmailMinLength,
       ErrorMessage = LengthMessage)]
    public string Email { get; set; } = null!;

    [EmailAddress]
    [StringLength(DoctorDescriptionMaxLength,
MinimumLength = DoctorDescriptionMinLength,
ErrorMessage = LengthMessage)]
    public string Description { get; set; } = null!;

    [Display(Name = "Profile Image")]
    public string? ImageUrl { get; set; }

    [Required(ErrorMessage = RequiredMessage)]
    [Display(Name = "Specialty")]
    public int SpecialtyId { get; set; }
    public IEnumerable<SelectListItem> Specialties { get; set; } = new List<SelectListItem>();

}