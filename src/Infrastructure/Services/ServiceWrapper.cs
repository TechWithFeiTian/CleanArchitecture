using CleanArchitecture.Application.Common.Interfaces;

namespace CleanArchitecture.Infrastructure.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly ITodoItemService _todoItemService;

        public ServiceWrapper(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public ITodoItemService TodoItemService => _todoItemService;
        // 这里可以继续添加其它服务属性
    }
}