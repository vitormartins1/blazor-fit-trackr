using FitTrackr.Application.Common.Services.Identity;
using FitTrackr.WebUi.Components.Account;
using FitTrackr.WebUi.Services;
using FitTrackr.WebUi.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FitTrackr.WebUi.DependencyInjection;

public class AuthenticationServices : IServiceInstaller
{
    public void InstallerService(IServiceCollection services, IConfiguration configuration)
    {
        
        services.AddCascadingAuthenticationState();
        services.AddScoped<IdentityUserAccessor>();
        services.AddScoped<IdentityRedirectManager>();
        services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();
        
        services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
        services.AddSingleton<IAuthorizationPolicyProvider, FlexibleAuthorizationPolicyProvider>();

        services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddIdentityCookies();
        
        services.AddHttpContextAccessor();
        services.AddScoped<ICurrentUser, CurrentUser>();
    }
}