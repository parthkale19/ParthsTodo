using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces;

public interface ITodoService {
    Task<List<TodoItem>> GetAllAsync();
    Task<TodoItem?> GetByIdAsync(int id);
    Task AddAsync(TodoItem item);
    Task UpdateAsync(TodoItem item);
    Task DeleteAsync(int id);
}