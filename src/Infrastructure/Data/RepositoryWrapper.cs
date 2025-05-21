using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Data
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly IRepository<TodoItem> _todoItemRepository;
        private readonly IRepository<TodoList> _todoListRepository;

        public RepositoryWrapper(IRepository<TodoItem> todoItemRepository, IRepository<TodoList> todoListRepository)
        {
            _todoItemRepository = todoItemRepository;
            _todoListRepository = todoListRepository;
        }

        public IRepository<TodoItem> TodoItem => _todoItemRepository;
        public IRepository<TodoList> TodoList => _todoListRepository;
        // 这里可以继续添加其它仓储属性
    }
}