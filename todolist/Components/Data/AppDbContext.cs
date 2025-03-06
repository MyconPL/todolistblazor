using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<TodoItem> TodoItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public bool IsCompleted { get; set; }
}
