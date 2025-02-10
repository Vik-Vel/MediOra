using MediOra.Core.Contracts.Appointments;
using MediOra.Core.Contracts.Clinics;
using MediOra.Core.Contracts.Doctors;
using MediOra.Core.Contracts.Feedbacks;
using MediOra.Core.Contracts.Notifications;
using MediOra.Core.Contracts.Patients;
using MediOra.Core.Contracts.Schedules;
using MediOra.Core.Services;
using MediOra.Data;
using MediOra.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection //When extend service collection is good to be in this namespace
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IClinicService, ClinicService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IScheduleService, ScheduleService>();

            return services;
        }
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
           services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
            return services;
        }
    }
}
