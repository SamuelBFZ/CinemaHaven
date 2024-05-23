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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.paymentMethods)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.bills)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Movie>()
                .HasMany(p => p.pays)
                .WithOne(p => p.Movie)
                .HasForeignKey(p => p.MovieId);

            modelBuilder.Entity<PaymentMethod>()
                .HasMany(pm => pm.pays)
                .WithOne(p => p.PaymentMethod)
                .HasForeignKey(p => p.PaymentMethodId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
