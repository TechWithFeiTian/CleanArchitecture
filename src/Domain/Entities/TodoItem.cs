using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Domain.Entities;

public class TodoItem : AuditableEntity
{
    public string? Title { get; set; }

    public string? Note { get; set; }

    public PriorityLevel Priority { get; set; }

    public DateTime? Reminder { get; set; }

    public bool Done { get; set; }

    public int ListId { get; set; }

    public TodoList List { get; set; } = null!;
}