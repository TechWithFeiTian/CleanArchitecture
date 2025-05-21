using CleanArchitecture.Application.Features.TodoLists.Commands.CreateTodoList;
using CleanArchitecture.Application.Features.TodoLists.Queries.GetTodos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TodoListsController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<TodosVm>> Get()
    {
        return await Mediator.Send(new GetTodosQuery());
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateTodoListCommand command)
    {
        return await Mediator.Send(command);
    }
}