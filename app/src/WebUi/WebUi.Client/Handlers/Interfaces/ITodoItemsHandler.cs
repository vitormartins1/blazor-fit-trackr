using FitTrackr.WebUi.Shared.TodoItems;

namespace FitTrackr.WebUi.Client.Handlers.Interfaces;

public interface ITodoItemsHandler
{
    Task PutTodoItemAsync(int id, UpdateTodoItemRequest request);
    Task<int> PostTodoItemAsync(CreateTodoItemRequest request);
    Task DeleteTodoItemAsync(int id);
}
