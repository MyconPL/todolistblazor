using Microsoft.EntityFrameworkCore;

namespace todolist.Components.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=todolistdb;user=root;password=mypassword",
                    new MySqlServerVersion(new Version(8, 0, 23)));
            }
        }
    }
}
