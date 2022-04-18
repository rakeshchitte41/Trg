using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>options):base(options)
        {

        }
        public DbSet<Models.User> users { get; set; }
        public DbSet<Models.Movie> movies { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Movie>().ToTable("movielist");
            modelBuilder.Entity<Models.User>().ToTable("moviedb");
        }


    }
}
