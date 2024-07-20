using Microsoft.AspNetCore.Identity;
using FitTrackr.WebUi.Shared.Authorization;

namespace FitTrackr.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
