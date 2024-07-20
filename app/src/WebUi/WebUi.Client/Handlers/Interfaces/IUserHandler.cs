using FitTrackr.WebUi.Shared.AccessControl;

namespace FitTrackr.WebUi.Client.Handlers.Interfaces;

public interface IUserHandler
{
    Task<UserDetailsVm> GetUserAsync(string userId);
    Task PutUserAsync(string userId, UserDto user);
}
