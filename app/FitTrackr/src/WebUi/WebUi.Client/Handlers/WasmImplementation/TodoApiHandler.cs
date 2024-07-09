using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Shared.TodoLists;

namespace FitTrackr.WebUi.Client.Handlers.WasmImplementation;

internal class TodoApiHandler:ITodoListHandler
{
    private ITodoListsClient _todoListsClient;

    public TodoApiHandler(ITodoListsClient todoListsClient)
    {
        _todoListsClient = todoListsClient;
    }

    public Task<TodosVm> GetTodoListsAsync()
    {
        return _todoListsClient.GetTodoListsAsync();
    }

    public Task PutTodoListAsync(int id, UpdateTodoListRequest request)
    {
        return _todoListsClient.PutTodoListAsync(id, request);
    }

    public Task DeleteTodoListAsync(int id)
    {
        return _todoListsClient.DeleteTodoListAsync(id);
    }

    public Task<int> PostTodoListAsync(CreateTodoListRequest request)
    {
        return _todoListsClient.PostTodoListAsync(request);
    }
}
