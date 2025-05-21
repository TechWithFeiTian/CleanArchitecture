using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.TodoLists.Queries.GetTodos;

public class TodoListDto : IMapFrom<TodoList>
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public IList<TodoItemDto> Items { get; set; } = new List<TodoItemDto>();
}