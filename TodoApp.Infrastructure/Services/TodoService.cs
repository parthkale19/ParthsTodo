using Microsoft.EntityFrameworkCore;
using TodoApp.Application.Interfaces;
using TodoApp.Domain.Entities;
using TodoApp.Infrastructure.Data;

namespace TodoApp.Infrastructure.Services;

public class TodoService : ITodoService {
    private readonly TodoDbContext _dbContext;

    public TodoService(TodoDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public Task AddAsync(TodoItem item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<TodoItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TodoItem?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TodoItem item)
    {
        throw new NotImplementedException();
    }
}