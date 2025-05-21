namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IServiceWrapper
    {
        ITodoItemService TodoItemService { get; }
        // 这里可以继续添加其它服务属性
    }
}