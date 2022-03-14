using DDDArchitecture.Domain.SeedWork;

namespace DDDArchitecture.Domain.TodoAggregate;

public class TodoItemDeletedEvent : DomainEvent
{
    public TodoItemDeletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}