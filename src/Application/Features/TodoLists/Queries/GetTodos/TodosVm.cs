using CleanArchitecture.Application.Common.Models;

namespace CleanArchitecture.Application.Features.TodoLists.Queries.GetTodos;

public class TodosVm
{
    public IList<TodoListDto> Lists { get; set; } = new List<TodoListDto>();

    public IList<LookupDto> PriorityLevels { get; set; } = new List<LookupDto>();
}