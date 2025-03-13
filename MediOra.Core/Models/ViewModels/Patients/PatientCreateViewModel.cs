using MediOra.Core.Contracts.Patients;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static MediOra.Core.Constants.MessageConstants;
using static MediOra.Infrastructure.Constants.DataConstants;

namespace MediOra.Core.Models.ViewModels.Patients
{
    public class PatientCreateViewModel : IPatientModel
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PatientFirstNameMaxLength,
           MinimumLength = PatientFirstNameMinLength,
           ErrorMessage = LengthMessage)]
        public string FirstName { get; set; } = null!;

        [DisplayName("Last Name")]
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PatientLastNameMaxLength,
           MinimumLength = PatientLastNameMinLength,
           ErrorMessage = LengthMessage)]
        public string LastName { get; set; } = null!;

        public string FullName => $"{FirstName} {LastName}";

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PatientPhoneNumberMaxLength,
           MinimumLength = PatientPhoneNumberMinLength,
           ErrorMessage = LengthMessage)]
        public string PhoneNumber { get; set; } = null!;

        [DisplayName("Address")]
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PatientAddressMaxLength,
           MinimumLength = PatientAddressMinLength,
           ErrorMessage = LengthMessage)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PatientCityMaxLength,
          MinimumLength = PatientCityMinLength,
          ErrorMessage = LengthMessage)]
        [Comment("Patient's City")]
        public string City { get; set; } = string.Empty;


        [DisplayName("Email")]
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PatientEmailMaxLength,
           MinimumLength = PatientEmailMinLength,
           ErrorMessage = LengthMessage)]
        public string Email { get; set; } = null!;

        [DisplayName("Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Profile Image")]
        public string? ImageUrl { get; set; }

    }
}
