using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class TodoList : AuditableEntity
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
}