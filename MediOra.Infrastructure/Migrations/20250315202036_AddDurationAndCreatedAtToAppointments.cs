using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediOra.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDurationAndCreatedAtToAppointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "Appointments");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date and time when the appointment was created");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Duration in minutes");

            migrationBuilder.AddColumn<DateTime>(
                name: "ScheduledTime",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Appointment's Date and Time");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Duration", "ScheduledTime" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 20, 34, 939, DateTimeKind.Utc).AddTicks(8493), 30, new DateTime(2025, 3, 16, 20, 20, 34, 939, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Duration", "ScheduledTime" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 20, 34, 939, DateTimeKind.Utc).AddTicks(8508), 30, new DateTime(2025, 3, 17, 20, 20, 34, 939, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Duration", "ScheduledTime" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 20, 34, 939, DateTimeKind.Utc).AddTicks(8510), 30, new DateTime(2025, 3, 18, 20, 20, 34, 939, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35cc3480-b777-4108-a186-8a4048170f7f", "AQAAAAIAAYagAAAAEKjOFjQ4vqTWWkdxNJcawUbE8cv19AmUrbLFUVp70SX5GaCtHAvoTiBudlo9cPddJw==", "a3787af2-4c2e-463a-8fb8-3f329977eb6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doctor1-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3ecba6d-e981-415d-8fc3-5c2b9c45efff", "AQAAAAIAAYagAAAAEJgbx1j1dr/WNP0gyFZl+zhNrz+riwoBtg/6E2QNj51go8eNwi0lx2rRBhCCXbQRWw==", "8a18441d-6139-46bc-8dbc-58eef04601aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "patient-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "098866eb-fdd8-436b-8621-5f52070d3028", "AQAAAAIAAYagAAAAENuPfyHgx94KO5tnwaF6KUhCG30zfg/+Q0BKaQI8fGtiOKYuPS/V22/aJea8Nz2uMA==", "3a25f1df-7d61-4630-a6ad-722f0fe39048" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 20, 35, 265, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 20, 35, 265, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DiagnosisDate",
                value: new DateTime(2023, 3, 15, 20, 20, 35, 372, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiagnosisDate",
                value: new DateTime(2024, 3, 15, 20, 20, 35, 372, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 3, 15, 20, 20, 35, 479, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 3, 15, 20, 20, 35, 479, DateTimeKind.Utc).AddTicks(9065));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ScheduledTime",
                table: "Appointments");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Appointment's Date");

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
        }
    }
}
