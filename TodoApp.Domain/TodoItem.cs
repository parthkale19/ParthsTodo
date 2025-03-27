using TodoApp.Domain.Entities;
namespace TodoApp.Domain;
public class TodoItem
{   
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Category { get; set; }
    public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
