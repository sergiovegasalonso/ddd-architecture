using DDDArchitecture.Domain.SeedWork;

namespace DDDArchitecture.Domain.TodoAggregate;

public class TodoItemCompletedEvent : DomainEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}