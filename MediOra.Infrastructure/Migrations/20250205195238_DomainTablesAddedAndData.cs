using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediOra.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DomainTablesAddedAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the clinic.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the clinic."),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Phone number of the clinic."),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Address of the clinic."),
                    WorkingHours = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false, comment: "Working hours of the clinic.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                },
                comment: "Table storing information about medical clinics.");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the notification.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Identifier of the user receiving the notification."),
                    Message = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Message content of the notification."),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the notification was sent."),
                    IsRead = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates whether the notification has been read.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Table storing notifications for users about upcoming events or reminders.");

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the specialty.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the medical specialty.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                },
                comment: "Represents a medical specialty.");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Doctor's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Doctor's First Name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor's Last Name"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Doctor's Phone number"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Doctor's Address"),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor's City"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor's Email"),
                    SpecialtyId = table.Column<int>(type: "int", nullable: false, comment: "Doctor's Specialty Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Doctor's information");

            migrationBuilder.CreateTable(
                name: "DoctorClinic",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the doctor."),
                    ClinicId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the clinic.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorClinic", x => new { x.DoctorId, x.ClinicId });
                    table.ForeignKey(
                        name: "FK_DoctorClinic_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorClinic_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Mapping table for doctors and clinics.");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Patient's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Patient's First Name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Patient's Last Name"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Patient's Phone number"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Patient's Address"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Patient's Email"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Patient's Date Of Birth"),
                    DoctorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                },
                comment: "Patient's information");

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the schedule.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the doctor."),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false, comment: "Day of the week for the schedule."),
                    StartHour = table.Column<TimeSpan>(type: "time", nullable: false, comment: "Starting hour of the schedule."),
                    EndHour = table.Column<TimeSpan>(type: "time", nullable: false, comment: "Ending hour of the schedule.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Represents the schedule of a doctor.");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Appointment's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Appointment's Date"),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Appointment's Status"),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false, comment: "Appointment's Notes"),
                    DoctorId = table.Column<int>(type: "int", nullable: false, comment: "Doctor's Identifier"),
                    PatientId = table.Column<int>(type: "int", nullable: false, comment: "Patient's Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Appointment's information");

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the medical record.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the patient."),
                    Condition = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Medical condition or diagnosis of the patient."),
                    DiagnosisDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date when the diagnosis was recorded."),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Additional notes about the patient's condition.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Table storing medical records for patients.");

            migrationBuilder.CreateTable(
                name: "PatientNotification",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the patient."),
                    NotificationId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the notification."),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date the notification was sent.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientNotification", x => new { x.PatientId, x.NotificationId });
                    table.ForeignKey(
                        name: "FK_PatientNotification_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientNotification_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for patients and notifications.");

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the feedback.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the associated appointment."),
                    PatientId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the patient providing the feedback."),
                    DoctorId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the doctor who received the feedback."),
                    Comments = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "Comments provided by the patient."),
                    Rating = table.Column<int>(type: "int", nullable: false, comment: "Rating provided by the patient MinRange-MaxRange)."),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the feedback was created."),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates whether the feedback is anonymous.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feedbacks_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Table storing feedback from patients about appointments.");

            migrationBuilder.CreateTable(
                name: "DoctorFeedback",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the doctor."),
                    FeedbackId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the feedback.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorFeedback", x => new { x.DoctorId, x.FeedbackId });
                    table.ForeignKey(
                        name: "FK_DoctorFeedback_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorFeedback_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for doctors and feedback.");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin-user-id", 0, "f07945ed-4aa9-4e29-97f1-f96843b3abdf", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEByKOPleZZFcrAyz33QcpYV5moh+5DAjI0x4fiE6No9q9PS4BhrJj9SOqypayInHxw==", null, false, "bc26acc8-3d37-4096-ae82-8996d82e95ce", false, "admin@mail.com" },
                    { "doctor1-user-id", 0, "3e782001-7bb5-4c6c-ad9d-2c0fa27d2a78", "doctor1@mail.com", false, false, null, "DOCTOR1@MAIL.COM", "DOCTOR1@MAIL.COM", "AQAAAAIAAYagAAAAEAunyjqs3k0VwG4DF6XN8mZpfJpBiO8c1VsYniXC8YrMmNjSZ76219fNMYQHA1HZvg==", null, false, "a2288c8e-c707-4e4d-b15d-a54d341af9d6", false, "doctor1@mail.com" },
                    { "patient-user-id", 0, "91b4f703-f2f7-4da3-8c56-2b7b58c59864", "patient@mail.com", false, false, null, "PATIENT@MAIL.COM", "PATIENT@MAIL.COM", "AQAAAAIAAYagAAAAEFaZzH++QRWRLbRveHhe37V923RgkTn1LqEYImDvtLlAWKaGo93js7pRwjS2EQ0qGw==", null, false, "31b18e4e-704c-4636-b236-a3dd7c3b31fa", false, "patient@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Address", "Name", "PhoneNumber", "WorkingHours" },
                values: new object[,]
                {
                    { 1, "111 Downtown St", "Downtown Clinic", "999-999-9999", "9 - 19" },
                    { 2, "222 Uptown Ave", "Uptown Clinic", "888-888-8888", "8 - 18" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DateOfBirth", "DoctorId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "321 Pine St", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "alicejohnson@mail.com", "Alice", "Johnson", "111-111-1111" },
                    { 2, "654 Maple St", new DateTime(1985, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bobwilliams@mail.com", "Bob", "Williams", "222-222-2222" },
                    { 3, "987 Cedar St", new DateTime(2000, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charliedavis@mail.com", "Charlie", "Davis", "333-333-3333" }
                });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Neurology" },
                    { 3, "Pediatrics" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "City", "Email", "FirstName", "LastName", "PhoneNumber", "SpecialtyId" },
                values: new object[,]
                {
                    { 1, "123 Main St", "New York", "johndoe@mail.com", "John", "Doe", "123-456-7890", 1 },
                    { 2, "456 Elm St", "Los Angeles", "janesmith@mail.com", "Jane", "Smith", "987-654-3210", 2 },
                    { 3, "789 Oak St", "Chicago", "emmabrown@mail.com", "Emma", "Brown", "555-555-5555", 3 }
                });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "Id", "Condition", "DiagnosisDate", "Notes", "PatientId" },
                values: new object[,]
                {
                    { 1, "Hypertension", new DateTime(2023, 2, 5, 19, 52, 37, 386, DateTimeKind.Utc).AddTicks(5348), "Monitor blood pressure regularly.", 1 },
                    { 2, "Migraine", new DateTime(2024, 2, 5, 19, 52, 37, 386, DateTimeKind.Utc).AddTicks(5360), "Prescribed medication for migraines.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "DateTime", "IsRead", "Message", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 5, 19, 52, 37, 502, DateTimeKind.Utc).AddTicks(1972), false, "Your upcoming appointment is tomorrow.", "patient-user-id" },
                    { 2, new DateTime(2025, 2, 5, 19, 52, 37, 502, DateTimeKind.Utc).AddTicks(1976), false, "System maintenance scheduled.", "admin-user-id" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 6, 19, 52, 36, 922, DateTimeKind.Utc).AddTicks(1607), 1, "Regular checkup", 1, "Scheduled" },
                    { 2, new DateTime(2025, 2, 7, 19, 52, 36, 922, DateTimeKind.Utc).AddTicks(1615), 2, "Neurology consultation", 2, "Scheduled" },
                    { 3, new DateTime(2025, 2, 8, 19, 52, 36, 922, DateTimeKind.Utc).AddTicks(1617), 3, "Pediatrics follow-up", 3, "Scheduled" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "DayOfWeek", "DoctorId", "EndHour", "StartHour" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 2, 2, 2, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "AppointmentId", "Comments", "CreatedAt", "DoctorId", "IsAnonymous", "PatientId", "Rating" },
                values: new object[,]
                {
                    { 1, 1, "Great service!", new DateTime(2025, 2, 5, 19, 52, 37, 271, DateTimeKind.Utc).AddTicks(5551), 1, false, 1, 5 },
                    { 2, 2, "Very professional.", new DateTime(2025, 2, 5, 19, 52, 37, 271, DateTimeKind.Utc).AddTicks(5553), 2, false, 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClinic_ClinicId",
                table: "DoctorClinic",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorFeedback_FeedbackId",
                table: "DoctorFeedback",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecialtyId",
                table: "Doctors",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_AppointmentId",
                table: "Feedbacks",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_DoctorId",
                table: "Feedbacks",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_PatientId",
                table: "Feedbacks",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientNotification_NotificationId",
                table: "PatientNotification",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorClinic");

            migrationBuilder.DropTable(
                name: "DoctorFeedback");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "PatientNotification");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doctor1-user-id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "patient-user-id");
        }
    }
}
