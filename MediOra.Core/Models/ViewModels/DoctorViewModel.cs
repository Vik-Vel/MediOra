using System.ComponentModel.DataAnnotations;
using static MediOra.Core.Constants.MessageConstants;
using static MediOra.Infrastructure.Constants.DataConstants;
namespace MediOra.Core.Models.ViewModels
{
    public class DoctorViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(DoctorFirstNameMaxLength,
           MinimumLength = DoctorFirstNameMinLength,
           ErrorMessage = LengthMessage)]
        [Display(Name = "First Name")]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(DoctorLastNameMaxLength,
           MinimumLength = DoctorLastNameMinLength,
           ErrorMessage = LengthMessage)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(DoctorPhoneNumberMaxLength,
           MinimumLength = DoctorPhoneNumberMinLength,
           ErrorMessage = LengthMessage)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(DoctorAddressMaxLength,
           MinimumLength = DoctorAddressMinLength,
           ErrorMessage = LengthMessage)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(DoctorCityMaxLength,
           MinimumLength = DoctorCityMinLength,
           ErrorMessage = LengthMessage)]
        public string City { get; set; } = null!;

        [Required]
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

        [Required]
        [Display(Name = "Specialty")]
        public int SpecialtyId { get; set; }

        public string SpecialtyName { get; set; } = null!;
    }
}
