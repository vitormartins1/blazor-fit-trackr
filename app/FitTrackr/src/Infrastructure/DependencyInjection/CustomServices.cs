using FitTrackr.Application.Common.Services.DateTime;
using FitTrackr.Application.Common.Services.Identity;
using FitTrackr.Infrastructure.DateTime;
using FitTrackr.Infrastructure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FitTrackr.Infrastructure.DependencyInjection;

public sealed class CustomServices : IServiceInstaller
{
    public void InstallerService(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
    }
}