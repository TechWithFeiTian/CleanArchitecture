using CleanArchitecture.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.TodoLists.Commands.CreateTodoList;

public class CreateTodoListCommandValidator : AbstractValidator<CreateTodoListCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoListCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Title)
            .NotEmpty().WithMessage("标题不能为空")
            .MaximumLength(200).WithMessage("标题不能超过200个字符")
            .MustAsync(BeUniqueTitle).WithMessage("指定的标题已存在");
    }

    private async Task<bool> BeUniqueTitle(string title, CancellationToken cancellationToken)
    {
        return await _context.TodoLists
            .AllAsync(l => l.Title != title, cancellationToken);
    }
}