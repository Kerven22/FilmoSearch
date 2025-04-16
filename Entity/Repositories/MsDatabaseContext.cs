using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity.Repositories
{
    public class MsDatabaseContext : DbContext
    {
        public MsDatabaseContext(DbContextOptions<MsDatabaseContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Film> Films { get; set; }
    }
}
