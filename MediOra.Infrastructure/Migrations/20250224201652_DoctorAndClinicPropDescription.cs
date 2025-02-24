using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediOra.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DoctorAndClinicPropDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Doctors",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                comment: "Doctor's Description");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Clinics",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                comment: "Clinic's Description");

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
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Clinics");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 23, 16, 40, 55, 655, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 24, 16, 40, 55, 655, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 25, 16, 40, 55, 655, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "993d7b04-a7e7-4e21-a3ae-949298920f38", "AQAAAAIAAYagAAAAEEZ3C8F2ip+AmtuzweDde+MTXSEF2JdzVAY4ankHLc5RCwV1LnVs2JX8mFtRjZlwog==", "59f21e10-7920-4366-a529-97d5067003a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doctor1-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "273deffb-965f-4450-af7e-0ee3a1aeccf4", "AQAAAAIAAYagAAAAENaFnZfIAMyWzgOdnl20ya+8TyLhO1/DSA+I1+duuNBSoG6uXeHGp2BzEpp4m0IKkA==", "267edc09-c1dc-49c3-a90e-49ce0dcd2c3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "patient-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ac7c1fe-1bb8-4b65-9cd4-bc21edc7ed65", "AQAAAAIAAYagAAAAEF2Sm8SVFmI/DmReAI1KPf0HzDoKhES1pUoXNIaCPKQEi1f6tfOge6NoD0vivXygMw==", "0f276c96-79c7-420a-a9ae-318f658c1968" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 22, 16, 40, 56, 3, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 22, 16, 40, 56, 3, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DiagnosisDate",
                value: new DateTime(2023, 2, 22, 16, 40, 56, 119, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiagnosisDate",
                value: new DateTime(2024, 2, 22, 16, 40, 56, 119, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 2, 22, 16, 40, 56, 236, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 2, 22, 16, 40, 56, 236, DateTimeKind.Utc).AddTicks(1639));
        }
    }
}
