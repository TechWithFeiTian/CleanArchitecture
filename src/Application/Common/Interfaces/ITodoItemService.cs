using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface ITodoItemService
    {
        Task<Result<TodoItem>> GetByIdAsync(int id);
        Task<Result<IEnumerable<TodoItem>>> GetAllAsync();
        Task<Result> CreateAsync(TodoItem item);
        Task<Result> UpdateAsync(TodoItem item);
        Task<Result> DeleteAsync(int id);
    }
}