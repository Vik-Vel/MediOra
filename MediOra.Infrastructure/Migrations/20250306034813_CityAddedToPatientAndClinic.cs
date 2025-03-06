using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediOra.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CityAddedToPatientAndClinic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Patient's City");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Clinics",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Clinic's City");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2025, 3, 7, 3, 48, 11, 797, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2025, 3, 8, 3, 48, 11, 797, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppointmentDate",
                value: new DateTime(2025, 3, 9, 3, 48, 11, 797, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38cb2d4a-f06b-4d55-b0b5-c7394610ad63", "AQAAAAIAAYagAAAAEDfMBt1CFg/21STJI/JRWGZ7wawRLKdI4BhqfLTgo/VnLtvoUgetPWFN5HzzCOM2SA==", "e10532d7-5897-424d-985d-e160ca862857" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doctor1-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aa651c0-06e6-4a62-b967-20cf0b096e43", "AQAAAAIAAYagAAAAEE1JV5pzcdhZn1KoGx9hYvNBap69OEzX9EweiqejFrzi6JjppmZEPEZJ0NBxrlyPhw==", "5d0e796e-6dd4-4e14-a17d-4ae27b963623" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "patient-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2d995e2-9065-4a4e-b306-61868ca17d3c", "AQAAAAIAAYagAAAAEHZ4Pj+P4qvOB76Y4BKwVmFwyVsPxno805gdR91res0/FyiWuP60/SEY8dKofDVSig==", "ae93efa9-6306-4c52-9809-ada2e0ee7966" });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                column: "City",
                value: "");

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                column: "City",
                value: "");

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 3, 48, 12, 129, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 3, 48, 12, 129, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DiagnosisDate",
                value: new DateTime(2023, 3, 6, 3, 48, 12, 239, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiagnosisDate",
                value: new DateTime(2024, 3, 6, 3, 48, 12, 239, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 3, 6, 3, 48, 12, 347, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 3, 6, 3, 48, 12, 347, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "City",
                value: "");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "City",
                value: "");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "City",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Clinics");

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
        }
    }
}
