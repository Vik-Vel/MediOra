using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediOra.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImageUrlAddedAndUppdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Patients",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                comment: "Patient's Profile Image URL");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Doctors",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                comment: "Doctor's Profile Image URL");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Clinics",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                comment: "Clinic's Profile Image URL");

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
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/Clinics/Clinics_DowntownClinic.jpg");

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/Clinics/Clinics_UptownClinic.jpg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/Doctors/Doctor_JohnDoe.jpg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/doctors/Doctor_JaneSmith.jpg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/doctors/Doctor_EmmaBrown.jpg");

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

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/Patients/Patient_AliceJohnson.jpg");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/Patients/Patient_BobWilliams.jpg");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/Patients/Patient_CharlieDavis.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Clinics");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 6, 19, 52, 36, 922, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 7, 19, 52, 36, 922, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppointmentDate",
                value: new DateTime(2025, 2, 8, 19, 52, 36, 922, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f07945ed-4aa9-4e29-97f1-f96843b3abdf", "AQAAAAIAAYagAAAAEByKOPleZZFcrAyz33QcpYV5moh+5DAjI0x4fiE6No9q9PS4BhrJj9SOqypayInHxw==", "bc26acc8-3d37-4096-ae82-8996d82e95ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doctor1-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e782001-7bb5-4c6c-ad9d-2c0fa27d2a78", "AQAAAAIAAYagAAAAEAunyjqs3k0VwG4DF6XN8mZpfJpBiO8c1VsYniXC8YrMmNjSZ76219fNMYQHA1HZvg==", "a2288c8e-c707-4e4d-b15d-a54d341af9d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "patient-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91b4f703-f2f7-4da3-8c56-2b7b58c59864", "AQAAAAIAAYagAAAAEFaZzH++QRWRLbRveHhe37V923RgkTn1LqEYImDvtLlAWKaGo93js7pRwjS2EQ0qGw==", "31b18e4e-704c-4636-b236-a3dd7c3b31fa" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 19, 52, 37, 271, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 19, 52, 37, 271, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DiagnosisDate",
                value: new DateTime(2023, 2, 5, 19, 52, 37, 386, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiagnosisDate",
                value: new DateTime(2024, 2, 5, 19, 52, 37, 386, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 2, 5, 19, 52, 37, 502, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 2, 5, 19, 52, 37, 502, DateTimeKind.Utc).AddTicks(1976));
        }
    }
}
