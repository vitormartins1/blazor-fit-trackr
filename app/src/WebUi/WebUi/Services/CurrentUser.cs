using FitTrackr.Application.Common.Services.Identity;
using System.Security.Claims;

namespace FitTrackr.WebUi.Services;

public class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? UserId => _httpContextAccessor.HttpContext?
        .User?
        .FindFirstValue(ClaimTypes.NameIdentifier);
}
