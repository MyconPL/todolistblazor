using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace todolist.Components.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(
                "server=localhost;database=todolist;user=root;password=password",
                new MySqlServerVersion(new Version(8, 0, 23))
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
