using FitTrackr.Domain.Common;
using FitTrackr.Domain.Entities;

namespace FitTrackr.Domain.Events;

public sealed class TodoItemCompletedEvent : BaseEvent
{
    public TodoItem Item { get; }

    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }
}
