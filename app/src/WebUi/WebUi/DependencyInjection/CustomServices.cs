using FitTrackr.Infrastructure.Identity;
using FitTrackr.WebUi.Client;
using FitTrackr.WebUi.Components.Account;
using Microsoft.AspNetCore.Identity;

namespace FitTrackr.WebUi.DependencyInjection;

public class CustomServices : IServiceInstaller
{
    public void InstallerService(IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();


        services.AddApplicationServerServices();
    }
}