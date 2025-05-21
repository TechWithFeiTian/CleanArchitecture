using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly IRepository<TodoItem> _repository;

        public TodoItemService(IRepository<TodoItem> repository)
        {
            _repository = repository;
        }

        public async Task<Result<TodoItem>> GetByIdAsync(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            if (item == null)
                return Result<TodoItem>.Failure(new[] { "未找到指定的Todo项。" });
            return Result<TodoItem>.Success(item);
        }

        public async Task<Result<IEnumerable<TodoItem>>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return Result<IEnumerable<TodoItem>>.Success(items);
        }

        public async Task<Result> CreateAsync(TodoItem item)
        {
            await _repository.AddAsync(item);
            return Result.Success();
        }

        public async Task<Result> UpdateAsync(TodoItem item)
        {
            await _repository.UpdateAsync(item);
            return Result.Success();
        }

        public async Task<Result> DeleteAsync(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            if (item == null)
                return Result.Failure(new[] { "未找到指定的Todo项。" });
            await _repository.DeleteAsync(item);
            return Result.Success();
        }
    }
}