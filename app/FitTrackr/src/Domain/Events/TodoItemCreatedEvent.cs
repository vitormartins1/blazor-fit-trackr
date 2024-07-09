using FitTrackr.Domain.Common;
using FitTrackr.Domain.Entities;

namespace FitTrackr.Domain.Events;

public sealed class TodoItemCreatedEvent : BaseEvent
{
    public TodoItem Item { get; }

    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }
}
