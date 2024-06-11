using CinemaHaven.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaHaven.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Bill> Bills { get; set; }

    }
}
