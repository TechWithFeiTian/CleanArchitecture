using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IRepositoryWrapper
    {
        IRepository<TodoItem> TodoItem { get; }
        IRepository<TodoList> TodoList { get; }
        // 这里可以继续添加其它仓储属性
    }
}