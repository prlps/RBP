using Microsoft.EntityFrameworkCore;
using AutoRent.Data.Models;

namespace AutoRent.Data
{
    public class AutoRentContext : DbContext
    {
        public AutoRentContext(DbContextOptions<AutoRentContext> options) : base(options) { }

        public DbSet<Car> Cars => Set<Car>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Rental> Rentals => Set<Rental>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.CarId);
                entity.Property(e => e.Make).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Type).IsRequired().HasMaxLength(50);
                entity.Property(e => e.RentalPricePerDay).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ClientId);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.HasKey(e => e.RentalId);

                entity.HasOne(r => r.Car)
                      .WithMany()
                      .HasForeignKey(r => r.CarId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(r => r.Client)
                      .WithMany()
                      .HasForeignKey(r => r.ClientId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.Property(r => r.PricePerDay).HasColumnType("decimal(10,2)");
                entity.Property(r => r.TotalPrice).HasColumnType("decimal(12,2)");
            });

            // seed небольших демонстрационных данных (опционально)
            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, Make = "Toyota Corolla", Type = "Sedan", PurchasePrice = 15000m, RentalPricePerDay = 30m, IsAvailable = true },
                new Car { CarId = 2, Make = "Volkswagen Tiguan", Type = "SUV", PurchasePrice = 25000m, RentalPricePerDay = 55m, IsAvailable = true }
            );

            modelBuilder.Entity<Client>().HasData(
                new Client { ClientId = 1, LastName = "Иванов", FirstName = "Иван", Address = "ул. Пушкина, д.1", Phone = "+359881000001" },
                new Client { ClientId = 2, LastName = "Петров", FirstName = "Пётр", Address = "ул. Лермонтова, д.2", Phone = "+359881000002" }
            );
        }
    }
}
