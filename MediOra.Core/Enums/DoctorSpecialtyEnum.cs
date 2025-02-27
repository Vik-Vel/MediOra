using System.ComponentModel.DataAnnotations;

namespace MediOra.Core.Enums
{
    public enum DoctorSpecialtyEnum
    {
        [Display(Name = "General Practice")]
        GeneralPractice = 1,

        [Display(Name = "Cardiology")]
        Cardiology = 2,

        [Display(Name = "Dermatology")]
        Dermatology = 3,

        [Display(Name = "Neurology")]
        Neurology = 4,

        [Display(Name = "Pediatrics")]
        Pediatrics = 5,

        [Display(Name = "Orthopedics & Traumatology")]
        Orthopedics = 6,

        [Display(Name = "Ophthalmology")]
        Ophthalmology = 7,

        [Display(Name = "Psychiatry")]
        Psychiatry = 8,

        [Display(Name = "Obstetrics & Gynecology")]
        Gynecology = 9,

        [Display(Name = "Urology")]
        Urology = 10,

        [Display(Name = "Endocrinology")]
        Endocrinology = 11,

        [Display(Name = "Gastroenterology")]
        Gastroenterology = 12,

        [Display(Name = "Hematology")]
        Hematology = 13,

        [Display(Name = "Infectious Diseases")]
        InfectiousDiseases = 14,

        [Display(Name = "Nephrology")]
        Nephrology = 15,

        [Display(Name = "Oncology")]
        Oncology = 16,

        [Display(Name = "Pulmonology")]
        Pulmonology = 17,

        [Display(Name = "Rheumatology")]
        Rheumatology = 18,

        [Display(Name = "Allergology & Immunology")]
        Allergology = 19,

        [Display(Name = "Anesthesiology & Intensive Care")]
        Anesthesiology = 20,

        [Display(Name = "Dentistry")]
        Dentistry = 21,

        [Display(Name = "Physical Therapy & Rehabilitation")]
        PhysicalTherapy = 22,

        [Display(Name = "Plastic & Reconstructive Surgery")]
        PlasticSurgery = 23,

        [Display(Name = "Vascular Surgery")]
        VascularSurgery = 24,

        [Display(Name = "Neurosurgery")]
        Neurosurgery = 25,

        [Display(Name = "Otorhinolaryngology (ENT)")]
        ENT = 26,

        [Display(Name = "Emergency Medicine")]
        EmergencyMedicine = 27,

        [Display(Name = "Family Medicine")]
        FamilyMedicine = 28,

        [Display(Name = "Sports Medicine")]
        SportsMedicine = 29,

        [Display(Name = "Geriatrics")]
        Geriatrics = 30,

        [Display(Name = "Nutrition & Dietetics")]
        Nutrition = 31,

        [Display(Name = "Radiology & Imaging")]
        Radiology = 32,

        [Display(Name = "Nuclear Medicine")]
        NuclearMedicine = 33,

        [Display(Name = "Medical Genetics")]
        MedicalGenetics = 34,

        [Display(Name = "Clinical Psychology")]
        ClinicalPsychology = 35
    }
}