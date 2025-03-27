using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using TodoApp.Domain;
using TodoApp.Infrastructure.Data;

namespace TodoApp.Infrastructure.Data;

public class TodoDbContext : DbContext{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) 
    : base(options) { }
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}