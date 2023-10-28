using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Domain.Settings;
using FlickerApp.Infrastructure.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FlickerApp.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            //services.AddTransient<IEmailService, EmailService>();
        }
    }
}
