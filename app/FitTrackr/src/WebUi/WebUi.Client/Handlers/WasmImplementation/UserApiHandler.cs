using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Shared.AccessControl;

namespace FitTrackr.WebUi.Client.Handlers.WasmImplementation;

internal class UserApiHandler : IUserHandler
{
    private readonly IUsersClient _usersClient;

    public UserApiHandler(IUsersClient usersClient)
    {
        _usersClient = usersClient;
    }

    public Task<UserDetailsVm> GetUserAsync(string userId)
    {
        return _usersClient.GetUserAsync(userId);
    }

    public Task PutUserAsync(string userId, UserDto user)
    {
        return _usersClient.PutUserAsync(userId, user);
    }
}
