using DDDArchitecture.Domain.SeedWork;

namespace DDDArchitecture.Domain.TodoAggregate;

public class TodoItemCreatedEvent : DomainEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}