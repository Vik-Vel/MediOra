namespace MediOra.Infrastructure.Constants
{
    public class DataConstants
    {
        //Doctor
        public const int DoctorFirstNameMinLength = 2;
        public const int DoctorFirstNameMaxLength = 30;

        public const int DoctorLastNameMinLength = 2;
        public const int DoctorLastNameMaxLength = 50;

        public const int DoctorPhoneNumberMinLength = 5;
        public const int DoctorPhoneNumberMaxLength = 20;

        public const int DoctorEmailMinLength = 5;
        public const int DoctorEmailMaxLength = 50;

        public const int DoctorAddressMinLength = 10;
        public const int DoctorAddressMaxLength = 100;

        public const int DoctorCityMinLength = 3;
        public const int DoctorCityMaxLength = 50;

        public const int DoctorImageUrlMinLength = 10;
        public const int DoctorImageUrlMaxLength = 300;

        public const int DoctorDescriptionMinLength = 10;
        public const int DoctorDescriptionMaxLength = 2000;

        //Patient
        public const int PatientFirstNameMinLength = 2;
        public const int PatientFirstNameMaxLength = 30;

        public const int PatientLastNameMinLength = 2;
        public const int PatientLastNameMaxLength = 50;

        public const int PatientPhoneNumberMinLength = 5;
        public const int PatientPhoneNumberMaxLength = 20;

        public const int PatientEmailMinLength = 5;
        public const int PatientEmailMaxLength = 50;

        public const int PatientAddressMinLength = 10;
        public const int PatientAddressMaxLength = 100;

        public const int PatientCityMinLength = 3;
        public const int PatientCityMaxLength = 50;

        public const int PatientImageUrlMinLength = 10;
        public const int PatientImageUrlMaxLength = 300;


        //Appointment
        public const int AppointmentStatusMinLength = 2;
        public const int AppointmentStatusMaxLength = 20;

        public const int AppointmentNotesMinLength = 5;
        public const int AppointmentNotesMaxLength = 2000;

        // Specialty
        public const int SpecialtyNameMinLength = 2;
        public const int SpecialtyNameMaxLength = 50;


        //Feedback
        public const int FeedbackCommentsMinLength = 5;
        public const int FeedbackCommentsMaxLength = 1500;

        public const int FeedbackRatingMinRange = 1;
        public const int FeedbackRatingMaxRange = 5;

        //Clinic
        public const int ClinicNameMinLength = 3;
        public const int ClinicNameMaxLength = 50;

        public const int ClinicPhoneNumberMinLength = 5;
        public const int ClinicPhoneNumberMaxLength = 25;

        public const int ClinicAddressMinLength = 10;
        public const int ClinicAddressMaxLength = 100;

        public const int ClinicWorkingHoursMinLength = 1;
        public const int ClinicWorkingHoursMaxLength = 6;

        public const int ClinicImageUrlMinLength = 10;
        public const int ClinicImageUrlMaxLength = 300;

        public const int ClinicDescriptionMinLength = 10;
        public const int ClinicDescriptionMaxLength = 2000;

        //MedicalRecord
        public const int MedicalRecordConditionMinLength = 5;
        public const int MedicalRecordConditionMaxLength = 1000;

        public const int MedicalRecordNotesMinLength = 10;
        public const int MedicalRecordNotesMaxLength = 1000;


    }
}
