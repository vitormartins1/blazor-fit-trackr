using FitTrackr.Application.Common.Services.Identity;
using FitTrackr.WebUi.Shared.AccessControl;
using FitTrackr.WebUi.Shared.Authorization;

namespace FitTrackr.Application.AccessControl.Queries;

public sealed record GetAccessControl() : IRequest<AccessControlVm>;

public sealed class GetAccessControlQueryHandler 
    : IRequestHandler<GetAccessControl, AccessControlVm>
{
    private readonly IIdentityService _identityService;

    public GetAccessControlQueryHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<AccessControlVm> Handle(GetAccessControl request, 
        CancellationToken cancellationToken)
    {
        var permissions = PermissionsProvider.GetAll()
            .Where(permission => permission != Permissions.None)
            .ToList();

        var roles = await _identityService.GetRolesAsync(cancellationToken);
        
        var result = new AccessControlVm(roles, permissions);
        
        return result;
    }
}
