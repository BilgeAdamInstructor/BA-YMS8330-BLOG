using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.User>().HasData(new Models.User()
            {
                Id = 1,
                Age = 1,
                Username = "Test1234"
            });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Models.User> Users { get; set; }
    }
}
