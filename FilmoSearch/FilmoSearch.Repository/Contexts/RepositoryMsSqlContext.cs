using FilmoSearch.Entities.Models;
using FilmoSearch.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FilmoSearch.Repository.Contexts
{
    public class RepositoryMsSqlContext:DbContext
    {
        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Film>? Films { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<User>? Users { get; set; }

        public RepositoryMsSqlContext(DbContextOptions<RepositoryMsSqlContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
