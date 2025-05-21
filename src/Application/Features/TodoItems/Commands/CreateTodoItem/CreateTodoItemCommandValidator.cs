using CleanArchitecture.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.TodoItems.Commands.CreateTodoItem;

public class CreateTodoItemCommandValidator : AbstractValidator<CreateTodoItemCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoItemCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Title)
            .NotEmpty().WithMessage("标题不能为空")
            .MaximumLength(200).WithMessage("标题不能超过200个字符");

        RuleFor(v => v.ListId)
            .NotEmpty().WithMessage("必须指定所属的清单")
            .MustAsync(ListExists).WithMessage("指定的清单不存在");
    }

    private async Task<bool> ListExists(int listId, CancellationToken cancellationToken)
    {
        return await _context.TodoLists.AnyAsync(l => l.Id == listId, cancellationToken);
    }
}