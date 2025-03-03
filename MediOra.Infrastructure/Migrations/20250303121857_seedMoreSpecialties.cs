using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediOra.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedMoreSpecialties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2025, 3, 4, 12, 18, 56, 506, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2025, 3, 5, 12, 18, 56, 506, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppointmentDate",
                value: new DateTime(2025, 3, 6, 12, 18, 56, 506, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4ef0a6e-6abd-4eab-8c4a-47c271ff859c", "AQAAAAIAAYagAAAAECxghJ26nAm9DShn2z4aTRthMTb/a4FlyVuCEtDAsr/8y9y8gBBMchT0xIO2vLQwJw==", "9ae5d233-8f0b-4ff5-9577-d24464e826de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doctor1-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13d716df-06b0-4f19-8bb1-ccec84515af9", "AQAAAAIAAYagAAAAEG8foeRL48al46GwA7+DtucxI6Se1gRpeZw3C+QlKJjYxf3xxXgLZax9hAlRTgCgWQ==", "65cefb04-f678-4ee2-a8fe-1e52e2344e1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "patient-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90a81056-3cfb-47fe-a0c1-364af2e380b6", "AQAAAAIAAYagAAAAEBfWMOB1plckDjOrBmA+TTHhzePDiN4f1EJ3B4jHnb1wtpSt1WXfPyULY0fVm1LKIA==", "cc36d599-832f-4a23-a78f-4001102b3ee8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 3, 12, 18, 56, 837, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 3, 12, 18, 56, 837, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DiagnosisDate",
                value: new DateTime(2023, 3, 3, 12, 18, 56, 946, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiagnosisDate",
                value: new DateTime(2024, 3, 3, 12, 18, 56, 946, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 3, 3, 12, 18, 57, 56, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 3, 3, 12, 18, 57, 56, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Dermatology" },
                    { 5, "Orthopedics & Traumatology" },
                    { 6, "Ophthalmology" },
                    { 7, "Psychiatry" },
                    { 8, "Obstetrics & Gynecology" },
                    { 9, "Urology" },
                    { 10, "Endocrinology" },
                    { 11, "Gastroenterology" },
                    { 12, "Hematology" },
                    { 13, "Infectious Diseases" },
                    { 14, "Nephrology" },
                    { 15, "Oncology" },
                    { 16, "Pulmonology" },
                    { 17, "Rheumatology" },
                    { 18, "Allergology & Immunology" },
                    { 19, "Anesthesiology & Intensive Care" },
                    { 20, "Dentistry" },
                    { 21, "Physical Therapy & Rehabilitation" },
                    { 22, "Plastic & Reconstructive Surgery" },
                    { 23, "Vascular Surgery" },
                    { 24, "Neurosurgery" },
                    { 25, "Otorhinolaryngology (ENT)" },
                    { 26, "Emergency Medicine" },
                    { 27, "Family Medicine" },
                    { 28, "Sports Medicine" },
                    { 29, "Geriatrics" },
                    { 30, "Nutrition & Dietetics" },
                    { 31, "Radiology & Imaging" },
                    { 32, "Nuclear Medicine" },
                    { 33, "Medical Genetics" },
                    { 34, "Clinical Psychology" },
                    { 35, "General Practice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 25, 20, 16, 51, 424, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 26, 20, 16, 51, 424, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 27, 20, 16, 51, 424, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d67e99-030a-4a41-a791-6897ab803452", "AQAAAAIAAYagAAAAEIVQZBQELyBoMCmVBnNZrE/2hgaoKM5J3QTtNB9wi0T3WBiIpEdnjgavLMsLy3o+Hw==", "41d66e0e-81f8-44d2-be7b-24a951a1a26b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doctor1-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcf5e2c0-31cd-46a0-923a-ea9ba5293251", "AQAAAAIAAYagAAAAELxAJZcK0olbRz8jZ0R9ttwyyLbvcFjSW+mqy0567OTJtMvG4XAcA9bpumZgddws7w==", "49a131de-9a6f-4427-afe3-76d346ea3188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "patient-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5c70cf9-ef3a-4641-9e04-11b84495c43d", "AQAAAAIAAYagAAAAEFmNlmpxM/SInjp3JeKKuaYbutAtEVp/jntq0FZ/BMfTiHAWKAjvz6Sog7NcKC9gBg==", "3548a9e1-1b99-4313-ae78-4d4ffb565e7a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 24, 20, 16, 51, 782, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 24, 20, 16, 51, 782, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DiagnosisDate",
                value: new DateTime(2023, 2, 24, 20, 16, 51, 901, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiagnosisDate",
                value: new DateTime(2024, 2, 24, 20, 16, 51, 901, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 2, 24, 20, 16, 52, 22, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 2, 24, 20, 16, 52, 22, DateTimeKind.Utc).AddTicks(2188));
        }
    }
}
