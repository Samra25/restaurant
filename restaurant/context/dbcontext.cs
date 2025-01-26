using Microsoft.EntityFrameworkCore;
using restaurant.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace restaurant.context
{
    public class dbcontext : IdentityDbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Restaurant - Menu (One-to-Many)
            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Menus)
                .WithOne(m => m.Restaurant)
                .HasForeignKey(m => m.RestaurantId);


            // Menu - MenuItem (One-to-Many)
            modelBuilder.Entity<Menu>()
                .HasMany(m => m.MenuItems)
                .WithOne(mi => mi.Menu)
                .HasForeignKey(mi => mi.MenuId);

            // Restaurant - Reservation (One-to-Many)
            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Reservations)
                .WithOne(res => res.Restaurant)
                .HasForeignKey(res => res.RestaurantId);

            // Order - OrderItem (One-to-Many)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            // MenuItem - OrderItem (One-to-Many)
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.MenuItem)
                .WithMany()
                .HasForeignKey(oi => oi.MenuItemId);
        }


    }
}
