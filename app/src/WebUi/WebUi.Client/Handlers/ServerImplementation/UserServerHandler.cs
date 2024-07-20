using MediatR;
using FitTrackr.Application.Users.Commands;
using FitTrackr.Application.Users.Queries;
using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Shared.AccessControl;

namespace FitTrackr.WebUi.Client.Handlers.ServerImplementation;

internal class UserServerHandler : IUserHandler
{
    private readonly IMediator _mediator;

    public UserServerHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task<UserDetailsVm> GetUserAsync(string userId)
    {
        return _mediator.Send(new GetUserQuery(userId));
    }

    public Task PutUserAsync(string userId, UserDto user)
    {
        return _mediator.Send(new UpdateUserCommand(user));
    }
}
