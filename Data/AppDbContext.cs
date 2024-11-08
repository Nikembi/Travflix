using Microsoft.EntityFrameworkCore;
using Travflix.Models;

namespace Travflix.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<AddMovie> Movies { get; set; }
    }
}
