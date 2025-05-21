using CleanArchitecture.Application.Features.TodoItems.Commands.CreateTodoItem;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TodoItemsController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateTodoItemCommand command)
    {
        return await Mediator.Send(command);
    }
}