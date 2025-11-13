using AutoRent.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoRent.Data
{
    public class AutoRentDbContext : DbContext
    {
        public AutoRentDbContext(DbContextOptions<AutoRentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
