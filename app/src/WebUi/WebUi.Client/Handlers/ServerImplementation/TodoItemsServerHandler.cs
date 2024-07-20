using MediatR;
using FitTrackr.Application.TodoItems.Commands;
using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Shared.TodoItems;

namespace FitTrackr.WebUi.Client.Handlers.ServerImplementation;

internal class TodoItemsServerHandler :ITodoItemsHandler
{
    private readonly IMediator _mediator;

    public TodoItemsServerHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task PutTodoItemAsync(int id, UpdateTodoItemRequest request)
    {
        return _mediator.Send(new UpdateTodoItemCommand(request));
    }

    public Task<int> PostTodoItemAsync(CreateTodoItemRequest request)
    {
        return _mediator.Send(new CreateTodoItemCommand(request));
    }

    public Task DeleteTodoItemAsync(int id)
    {
        return _mediator.Send(new DeleteTodoItemCommand(id));
    }
}
