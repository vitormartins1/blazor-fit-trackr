using FitTrackr.WebUi.Shared.Common;

namespace FitTrackr.WebUi.Shared.TodoLists;

public class TodosVm
{
    public List<LookupDto> PriorityLevels { get; set; } = new();

    public List<TodoListDto> Lists { get; set; } = new();
}
